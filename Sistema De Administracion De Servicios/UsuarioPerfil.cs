using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class UsuarioPerfil : UserControl,Funciones
    {
        CADINDataSetTableAdapters.UsuarioTableAdapter uta;
        DataRow ur;
        BindingSource bs;
        Usuario usuario;

        public UsuarioPerfil(Usuario u)
        {
            InitializeComponent();
            usuario = u;
            bs=new BindingSource();
            uta = new CADINDataSetTableAdapters.UsuarioTableAdapter();
            ur = uta.GetData().FindBycod_usua(u.Cod_Usua);
            bs.DataSource = ur;
            txtCodUsuario.DataBindings.Add("Text", bs, "cod_usua");
            txtNombre.DataBindings.Add("Text", bs, "nombre");
            txtUser.DataBindings.Add("Text", bs, "usuario");
            txtEmail.DataBindings.Add("Text", bs, "email");
            txtTelefono.DataBindings.Add("Text", bs, "telf");
        }

        private void lectura() {
            txtNombre.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtUser.ReadOnly = true;
            btnGuardar.Enabled = false;
        }

        private void edicion() {
            txtNombre.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtUser.ReadOnly = false;
            btnGuardar.Enabled = true;
        }

        private void txtNombre_DoubleClick(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            btnGuardar.Enabled = true;
        }

        private void txtEmail_DoubleClick(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = false;
            btnGuardar.Enabled = true;
        }

        private void txtTelefono_DoubleClick(object sender, EventArgs e)
        {
            txtTelefono.ReadOnly = false;
            btnGuardar.Enabled = true;
        }

        private void txtUser_DoubleClick(object sender, EventArgs e)
        {
            txtUser.ReadOnly = false;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (valUsuario.Validate())
            {
                bs.EndEdit();
                uta.Update(ur);
                MessageBox.Show("Los cambios se guardaron correctamente");
                lectura();
            }
        }

        public void Nuevo()
        {
            MessageBox.Show("La función no se implementa en este formulario");
        }

        public void Imprimir()
        {
            MessageBox.Show("La función no se implementa en este formulario");
        }

        public bool Guardar()
        {
            Boolean saved = false;
            if (valUsuario.Validate())
            {
                bs.EndEdit();
                uta.Update(ur);
                MessageBox.Show("Los cambios se guardaron correctamente");
                saved = true;
            }
            return saved;
        }

        public void Cancelar()
        {
            bs.CancelEdit();
            lectura();
        }

        public void Editar()
        {
            edicion();
        }

        public void Borrar()
        {
            MessageBox.Show("La función no se implementa en este formulario");
        }

        public void IrPrimero()
        {
            MessageBox.Show("La función no se implementa en este formulario");
        }

        public void Anterior()
        {
            MessageBox.Show("La función no se implementa en este formulario");
        }

        public void Siguiente()
        {
            MessageBox.Show("La función no se implementa en este formulario");
        }

        public void IrFinal()
        {
            MessageBox.Show("La función no se implementa en este formulario");
        }

        public bool vacio()
        {
            return false;
        }

        public void Reportes()
        {
            MessageBox.Show("La función no se implementa en este formulario");
        }

        public void RealizarPago()
        {
            MessageBox.Show("La función no se implementa en este formulario");
        }

        public void Filtrar()
        {
            MessageBox.Show("La función no se implementa en este formulario");
        }

        private void linkCambiarPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword cp = new ChangePassword(ur["password"].ToString().Trim());
            cp.ShowDialog();
            if (cp.match)
            {
                ur["password"] = cp.newPass;
                btnGuardar.Enabled = true;
            }
            else
                MessageBox.Show("No se efectuó ningun cambio"); 
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled=true;
        }

        private void UsuarioPerfil_Load(object sender, EventArgs e)
        {
            txtNombre.TextChanged += new EventHandler(TextBox_TextChanged);
            txtUser.TextChanged += new EventHandler(TextBox_TextChanged);
            txtEmail.TextChanged += new EventHandler(TextBox_TextChanged);
            txtTelefono.TextChanged += new EventHandler(TextBox_TextChanged);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            //DialogResult result=openFileDialog.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    buttonPicture.Image = Image.FromFile(openFileDialog.FileName);
            //    btnGuardar.Enabled = true;
            //}
        }
    }
}
