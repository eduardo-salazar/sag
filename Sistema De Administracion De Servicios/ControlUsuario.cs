using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class ControlUsuario : UserControl,Funciones
    {
        UsuariosDataSetTableAdapters.UsuarioTableAdapter udta = null;
        UsuariosDataSet.UsuarioDataTable udt=null;
        BindingSource bs=null;
        Boolean n = false;

        public ControlUsuario()
        {
            InitializeComponent();
            
            
            udta = new UsuariosDataSetTableAdapters.UsuarioTableAdapter();
            bs = new BindingSource();
            bs.DataError += new BindingManagerDataErrorEventHandler(handleDate);
            udt = udta.GetData();
            bs.DataSource = udt;
            dgvUsuarios.DataSource = bs;
            txtCodUsuario.DataBindings.Add("Text", bs, "cod_usua");
            txtNombre.DataBindings.Add("Text", bs, "nombre");
            txtEmail.DataBindings.Add("Text", bs, "email");
            txtTelefono.DataBindings.Add("Text", bs, "telf");
            txtFechInic.DataBindings.Add("Text", bs, "fech_inic"); 
            txtFechSali.DataBindings.Add("Text", bs, "fech_sali");
            txtUser.DataBindings.Add("Text", bs, "usuario");
            txtPassword.DataBindings.Add("Text", bs, "password");
            chkActivo.DataBindings.Add("Checked", bs, "activo");
            chkAdmin.DataBindings.Add("Checked", bs, "admin");
            dgvUsuarios.Columns["password"].Visible = false;
            dgvUsuarios.Columns["email"].Visible = false;
            dgvUsuarios.Columns["telf"].Visible = false;
            dgvUsuarios.Columns["fech_inic"].Visible = false;
            dgvUsuarios.Columns["fech_sali"].Visible = false;
            dgvUsuarios.Columns["imagen"].Visible = false;
            dgvUsuarios.Columns["cod_usua"].HeaderText = "Código";
            dgvUsuarios.Columns["nombre"].HeaderText = "Nombre";
            dgvUsuarios.Columns["admin"].HeaderText = "Administrador";
            dgvUsuarios.Columns["usuario"].HeaderText = "Usuario";
            dgvUsuarios.Columns["activo"].HeaderText = "Activo";
        }

        private void reloadData() {
            udt = udta.GetData();
            bs.DataSource = udt;
        }

        private void lectura() {
            txtNombre.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtUser.ReadOnly = true;
            btnResetPassword.Enabled = false;
            txtFechInic.Enabled = false;
            txtFechSali.Enabled = false;
            chkActivo.Enabled = false;
            chkAdmin.Enabled = false;
            dgvUsuarios.Enabled = true;
            dgvUsuarios.Focus();
            btnMarcarSalida.Enabled = false;

            txtNombre.FocusHighlightEnabled = false;
            txtEmail.FocusHighlightEnabled = false;
            txtTelefono.FocusHighlightEnabled = false;
            txtUser.FocusHighlightEnabled = false;

            valUsuario.ClearFailedValidations();
        }

        private void edicion() {
            txtNombre.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtUser.ReadOnly = false;
            btnResetPassword.Enabled = true;
            txtFechInic.Enabled = false;
            txtFechSali.Enabled = false;
            chkActivo.Enabled = true;
            chkAdmin.Enabled = true;
            dgvUsuarios.Enabled=false;
            btnMarcarSalida.Enabled = true;
            
            txtNombre.FocusHighlightEnabled=true;
            txtEmail.FocusHighlightEnabled = true;
            txtTelefono.FocusHighlightEnabled = true;
            txtUser.FocusHighlightEnabled = true;
            if (n)
            {
                txtFechInic.Text = DateTime.Now.ToShortDateString();
                txtFechSali.Text = "NULL";
                btnResetPassword.Enabled = false;
            }
        }

        private void resetPassword(Control c)
        {
            c.Text= EncryptPassphraseAlgorithm.EncryptSHA1("1234");
        }

        public bool Guardar() {
            Boolean guardado = false;
            if (valUsuario.Validate()) {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = udta.Connection;
                try
                {
                    cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@nombre"].Value = txtNombre.Text;
                    cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@email"].Value = txtEmail.Text;
                    cmd.Parameters.Add(new SqlParameter("@telf", SqlDbType.NChar, 20));
                    cmd.Parameters["@telf"].Value = txtTelefono.Text;
                    cmd.Parameters.Add(new SqlParameter("@admin", SqlDbType.Bit));
                    cmd.Parameters["@admin"].Value = chkAdmin.Checked;

                    cmd.Parameters.Add(new SqlParameter("@fech_inic", SqlDbType.DateTime));
                    if (txtFechInic.Text.Equals("  /  /"))
                        cmd.Parameters["@fech_inic"].Value = DBNull.Value;
                    else
                        cmd.Parameters["@fech_inic"].Value = txtFechInic.Text;

                    cmd.Parameters.Add(new SqlParameter("@fech_sali", SqlDbType.DateTime));
                    if (txtFechSali.Text.Equals("  /  /"))
                        cmd.Parameters["@fech_sali"].Value = DBNull.Value;
                    else
                        cmd.Parameters["@fech_sali"].Value = txtFechSali.Text;

                    cmd.Parameters.Add(new SqlParameter("@usuario", SqlDbType.NChar, 30));
                    cmd.Parameters["@usuario"].Value = txtUser.Text;
                    cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.NChar, 28));
                    cmd.Parameters["@password"].Value = txtPassword.Text;
                    cmd.Parameters.Add(new SqlParameter("@activo", SqlDbType.Bit, 50));
                    cmd.Parameters["@activo"].Value = chkActivo.Checked;

                    if (!n) {
                        String sql = "UPDATE Usuario SET nombre=@nombre, email=@email, telf=@telf, admin=@admin, "
                            + "fech_inic=@fech_inic, fech_sali=@fech_sali, usuario=@usuario, password=@password, "
                            +"activo=@activo WHERE cod_usua=@cod_usua";
                        cmd.CommandText = sql;
                        cmd.Parameters.Add(new SqlParameter("@cod_usua",SqlDbType.Int));
                        cmd.Parameters["@cod_usua"].Value=txtCodUsuario.Text;
                    }
                    else
                    {
                        String sqlQuery = "INSERT INTO Usuario (nombre, email, telf, admin, fech_inic, "
                        + "fech_sali, usuario, password, activo) VALUES (@nombre, @email, @telf,@admin, "
                        + "@fech_inic, @fech_sali, @usuario, @password, @activo)";
                        cmd.CommandText = sqlQuery;
                    }
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    bs.EndEdit();
                    udt = udta.GetData();
                    MessageBox.Show("Guardado");
                    udt = udta.GetData();
                    reloadData();
                    lectura();
                    guardado = true;
                }
                catch (Exception ex) {
                    guardado = false;
                }
                finally {
                    cmd.Connection.Close();
                    cmd.Connection = null;
                    cmd = null;
                    n = false;
                }
            }
            return guardado;
        }

/*        public bool guardar()
        {
            Boolean g=false;
            if (valUsuario.Validate())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = udta.Connection;
                try
                {
                    String cod_usua = txtCodUsuario.Text.Trim();
                    String nombre = "'" + txtNombre.Text.Trim() + "'";
                    String email = "NULL";
                    String telf = "NULL";
                    String admin = "0";
                    String fech_inic = "NULL";
                    String fech_sali = "NULL";
                    String usuario = "'" + txtUser.Text.Trim() + "'";
                    String password = "'" + txtPassword.Text.Trim() + "'";
                    String activo = "0";

                    if (txtEmail.Text.Trim().Length != 0)
                        email = "'" + txtEmail.Text.Trim() + "'";
                    if (txtTelefono.Text.Trim().Length != 0)
                        telf = "'" + txtTelefono.Text.Trim() + "'";
                    if (chkAdmin.Checked)
                        admin = "1";
                    if (!txtFechInic.Text.Equals("  /  /"))
                        fech_inic = "" + txtFechInic.Text.Trim() + "";
                    if (!txtFechSali.Text.Equals("  /  /"))
                        fech_sali = "" + txtFechSali.Text.Trim() + "";
                    if (chkActivo.Checked)
                        activo = "1";
                    if (!n)
                    {
                        String sql = "UPDATE Usuario SET ";
                        sql += "nombre = " + nombre + " , ";
                        sql += "email = " + email + " , ";
                        sql += "telf = " + telf + " , ";
                        sql += "admin = " + admin + " , ";
                        sql += "fech_inic = " + fech_inic + " , ";
                        sql += "fech_sali = " + fech_sali + " , ";
                        sql += "usuario = " + usuario + " , ";
                        sql += "password = " + password + " , ";
                        sql += "activo = " + activo;
                        sql += " WHERE cod_usua = " + cod_usua;
                        cmd.Connection.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        String sql = "INSERT INTO Usuario (nombre, email, telf, admin, fech_inic, fech_sali, usuario, password, activo) VALUES ( ";
                        sql += nombre + " , " + email + " , " + telf + " , " + admin + " , " + fech_inic + " , " + fech_sali + " , " + usuario + " , " + password + " , " + activo + " )";
                        cmd.Connection.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                    bs.EndEdit();
                    udt = udta.GetData();
                    MessageBox.Show("Guardado");
                    udt = udta.GetData();
                    reloadData();
                    lectura();
                    g= true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    g= false;
                }
                finally
                {
                    cmd.Connection.Close();
                    n = false;
                }
            }
            return g;
        }*/

        public void Nuevo()
        {
            n = true;
            bs.AddNew();
            bs.MoveLast();
            edicion();
            resetPassword(txtPassword);
        }

        public void Imprimir() {
            MessageBox.Show("En Construccion");
        }

        public void Cancelar()
        {
            bs.CancelEdit();
            lectura();
            n = false;
        }

        public void Editar()
        {
            edicion();
        }

        public void Borrar()
        {
            DataRowView dr = (DataRowView)bs.Current;
            String cod_usua = dr["cod_usua"].ToString().Trim();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = udta.Connection;
            try
            {
                
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Usuario WHERE cod_usua = " + cod_usua;
                cmd.ExecuteNonQuery();
                reloadData();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Hubo un problema al eliminar el registro");
            }
            finally
            {
                cmd.Connection.Close();
            }

        }

        public void IrPrimero()
        {
            bs.MoveFirst();
        }

        public void Anterior()
        {
            bs.MovePrevious();
        }

        public void Siguiente()
        {
            bs.MoveNext();
        }

        public void IrFinal()
        {
            bs.MoveLast();
        }

        public bool vacio() {
            if (bs.Count == 0)
                return true;
            else
                return false;
        }

        private void handleDate(Object sender, EventArgs e) {
            DataRowView d = (DataRowView)bs.Current;
            DateTime dt;
            bool chk;
            try
            {
                dt = (DateTime)d["fech_inic"];
            }
            catch
            {
                d["fech_inic"] = new DateTime(); 
            } 
            try
            {
                dt = (DateTime)d["fech_sali"];
            }
            catch
            {
                d["fech_sali"] = new DateTime(); 
            }
            try
            {
                chk = (bool)d["admin"];
            }
            catch (Exception ex)
            {
                d["admin"] = false;
            } 
            try
            {
                chk = (bool)d["activo"];
            }
            catch (Exception ex)
            {
                d["activo"] = false;
            }
        }

        private void btnMarcarSalida_Click(object sender, EventArgs e)
        {
            txtFechSali.Text = DateTime.Now.ToShortDateString();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            resetPassword(txtPassword);
            MessageBox.Show("Contraseña reseteada a 1234");
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtUser.SelectAll();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.SelectAll();
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            txtTelefono.SelectAll();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.SelectAll();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show(bs.IndexOf(bs.Current).ToString());
        }

        private void txtFechInic_Enter(object sender, EventArgs e)
        {
            txtFechInic.Select();
        }

        public void Buscar() {
            //FormBusqueda cub = new FormBusqueda(this.udt, bs);
            //object[] items = { "cod_usua", "nombre", "email", "telf", "usuario", "fech_inic"};
            //object[] columnNames = { "Código de Usuario", "Nombre", "Email", "Telefono", "Username", "fech_inic"};
            //cub.setMembers(columnNames, items);
            //cub.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Filtrar()
        {
            //object[] items = { "cod_usua", "nombre", "email", "telf", "admin", "fech_inic", "fech_sali", "usuario", "activo" };
            //FormularioFiltroBusqueda.showFormularioFiltroBusqueda(bs, items);
            FormularioFiltroBusqueda.showFormularioFiltroBusqueda(bs);
        }

        public void Reportes() {
            FormularioReportes.showReport(bs, "Usuario");
        }


        public void RealizarPago()
        {
            throw new NotImplementedException();
        }
    }
}
