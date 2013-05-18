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
    public partial class Caso : UserControl, Funciones
    {

        CADINDataSetTableAdapters.CasoTableAdapter cta;
        CADINDataSetTableAdapters.ActividadesTableAdapter ata;
        CADINDataSetTableAdapters.EmpresaTableAdapter eta;
        CADINDataSetTableAdapters.Actividades2TableAdapter ata2;
        CADINDataSet.CasoDataTable cdt;
        CADINDataSet.ActividadesDataTable adt;
        CADINDataSet.Actividades2DataTable adt2;
        BindingSource s1, s2;
        bool modo = false;
        public Usuario u;

        public Caso(Usuario u)
        {
            InitializeComponent();

            this.u = u;
            cta = new CADINDataSetTableAdapters.CasoTableAdapter();
            ata = new CADINDataSetTableAdapters.ActividadesTableAdapter();
            ata2 = new CADINDataSetTableAdapters.Actividades2TableAdapter();
            eta = new CADINDataSetTableAdapters.EmpresaTableAdapter();

            s1 = new BindingSource();
            s2 = new BindingSource();

            cdt = cta.GetData();
            adt = ata.GetData();
            

            s1.DataSource = cdt;
            s2.DataSource = adt;
            if (s1.Position != -1)
            {
                txcod_Caso.DataBindings.Add("Text", s1, "cod_caso");
                txCod_empr.DataBindings.Add("Text", s1, "cod_empr");
                txNomb_solic.DataBindings.Add("Text", s1, "pers_solic");
                txCargo.DataBindings.Add("Text", s1, "carg_pers_solic");
                ipFech_soli.DataBindings.Add("Text", s1, "fech_solic");
                txDesc_prob.DataBindings.Add("Text", s1, "desc_soli");

                txDesc_solu.DataBindings.Add("Text", s1, "desc_solu");
                if (s1.Position != -1)
                    sliderNiv_solu.DataBindings.Add("Value", s1, "nive_solu");
                if (s1.Position != -1)
                    ckbCaso_cerr.DataBindings.Add("Checked", s1, "caso_cerrado");

                txObservaciones.DataBindings.Add("Text", s1, "observaciones");
                txCod_resp.DataBindings.Add("Text", s1, "cod_func_asig");
                txResp_Caso.DataBindings.Add("Text", s1, "nomb_func_asig");
                ipFech_solu.DataBindings.Add("Text", s1, "fech_solf");
                dataGridViewX1.DataSource = s2;

                if (u.Admin) {
                    chkbAdm.Visible = true;
                    if (s1.Position != -1)
                     chkbAdm.DataBindings.Add("Checked", s1, "caso_cerrado");
                }
                s1.MoveFirst();
                cargarNE1();
                llenarActividades();
                Cancelar();
            }
            else { 
                MessageBox.Show("No hay registros guardados");  
                Nuevo(); 
                }
        }

        private void llenarActividades()
        {
            if (s1.Position != -1)
            {
                this.dataGridViewX1.Columns.Clear();
                /* string c = "Select t1.cod_actv, t1.cod_caso, t2.nombre, t3.nombre, t1.cod_func_asig, t1.referencia ," +
                "t1.fech_prog, t1.realizado, t1.acti_cerrada, t1.fech_cierre, t1.observaciones  from Actividades t1" +
                "inner join Tipo_Actividad t2 on t1.cod_tact=t2.cod_tact inner join Solicitud_Apoyo t3 on t1.cod_soli=t3.cod_soli" +
                " where cod_caso=" + cdt.Rows[s1.Position].ItemArray.GetValue(0).ToString() + ";"; */

                adt2 = ata2.GetData((int)cdt.Rows[s1.Position].ItemArray.GetValue(0));

                //int cod_caso = Convert.ToInt32(txcod_Caso.Text);
                //adt2 = ata2.GetData((cod_caso));

                this.dataGridViewX1.DataSource = adt2;
                this.dataGridViewX1.Columns["cod_actv"].Visible = false;
                this.dataGridViewX1.Columns["cod_caso"].Visible = false;
                this.dataGridViewX1.Columns["nombre"].HeaderText = "Tipo de Solicitud";
                this.dataGridViewX1.Columns["Expr1"].HeaderText = "Tipo de Actividad";
                this.dataGridViewX1.Columns["cod_func_asig"].HeaderText = "Funcionario Asignado";
                this.dataGridViewX1.Columns["referencia"].HeaderText = "Referencia";
                this.dataGridViewX1.Columns["fech_prog"].HeaderText = "Fecha Programada";
                this.dataGridViewX1.Columns["realizado"].HeaderText = "Realizado";
                this.dataGridViewX1.Columns["acti_cerrada"].HeaderText = "Actividad Cerrada";
                this.dataGridViewX1.Columns["fech_cierre"].HeaderText = "Fecha de Cierre";
                this.dataGridViewX1.Columns["observaciones"].HeaderText = "Observaciones";

            }
        }

        public void Nuevo()
        {
            this.dataGridViewX1.DataSource = null;
            this.dataGridViewX1.Columns.Add("cod_activ", "codigo de actividad");
            this.dataGridViewX1.Columns.Add("cod_caso", "codigo de caso");
            this.dataGridViewX1.Columns.Add("cod_soli", "codigo de solicitud");
            this.dataGridViewX1.Columns.Add("cod_tact", "tipo de actividad");
            this.dataGridViewX1.Columns.Add("cod_func_asig", "funcionario asignado");
            this.dataGridViewX1.Columns[0].Visible = false;
            this.dataGridViewX1.Columns[1].Visible = false;
            this.dataGridViewX1.Columns.Add("referencia", "Referencia");
            this.dataGridViewX1.Columns.Add("fech_prog", "Fecha Programada");
            this.dataGridViewX1.Columns.Add("realizado", "Realizado");
            this.dataGridViewX1.Columns.Add("acti_cerrada", "Actividad Cerrada");
            this.dataGridViewX1.Columns.Add("fech_cierre", "Fecha de Cierre");
            this.dataGridViewX1.Columns.Add("observacion", "Observaciones");
            ipFech_soli.Focus();

            Editar();
            limpiarControles();
            txCod_resp.Text = " " + u.Cod_Usua;
            txResp_Caso.Text = " " + u.Nombre;
            modo = false;
        }

        private void limpiarControles()
        {
            txcod_Caso.Clear();
            txCod_empr.Clear();
            txNomb_solic.Clear();
            txCargo.Clear();
            ipFech_soli.IsEmpty = true;
            txDesc_prob.Clear();
            txDesc_solu.Clear();
            sliderNiv_solu.Step.Equals(0);
            ckbCaso_cerr.Checked = false;
            txObservaciones.Clear(); ;
            txCod_resp.Clear();
            txResp_Caso.Clear();
            ipFech_solu.IsEmpty = true;
            chkbAdm.Checked = false;
            dataGridViewX1.ReadOnly = false;
            dataGridViewX1.AllowUserToAddRows = true;
            dataGridViewX1.AllowUserToDeleteRows = true;
            txNE.Clear();
        }

        public void Imprimir()
        {
            MessageBox.Show("En construccion");
        }

        public bool Guardar()
        {
            if (superValidator1.Validate())
            {
                if (modo)
                {
                    //cta.Update(cdt.Rows[s1.IndexOf(s1.Current)]);
                    ActualizarC();

                    this.dataGridViewX1.ReadOnly = true;
                }
                else
                {

                    //s1.AddNew();
                    //s1.MoveLast();

                    GuardarC();
                }
                cdt = cta.GetData();
                s1.DataSource = cdt;
                MessageBox.Show("Guardado");
                Cancelar();
                return true;
            }
            else
                MessageBox.Show("Revise los campos requeridos");
            return false;
        }

        public void Cancelar()
        {
            s1.CancelEdit();
            dataGridViewX1.CancelEdit();
            //llenarActividades();
            dataGridViewX1.Refresh();
            txCod_empr.ReadOnly = true;
            txNomb_solic.ReadOnly = true;
            txCargo.ReadOnly = true;
            ipFech_soli.Enabled = false;
            txDesc_prob.ReadOnly = true;
            txDesc_solu.ReadOnly = true;
            sliderNiv_solu.Enabled = false;
            ckbCaso_cerr.Enabled = false;
            txObservaciones.ReadOnly = true;
            ipFech_solu.Enabled = false;
            chkbAdm.Enabled = false;
            superValidator1.ClearFailedValidations();
            dataGridViewX1.ReadOnly = true;
            dataGridViewX1.AllowUserToAddRows = false;
            dataGridViewX1.AllowUserToDeleteRows = false;
            btnEliminarAct.Enabled = false;
            buttonX1.Enabled = false;
            dataGridViewX1.Enabled = false;
            txNE.ReadOnly = true;

            llenarActividades();
        }


        public void Editar()
        {
            txCod_empr.ReadOnly = false;
            txNomb_solic.ReadOnly = false;
            txCargo.ReadOnly = false;
            ipFech_soli.Enabled = true;
            txDesc_prob.ReadOnly = false;
            txDesc_solu.ReadOnly = false;
            sliderNiv_solu.Enabled = true;
            ckbCaso_cerr.Enabled = true;
            txObservaciones.ReadOnly = false;
            ipFech_solu.Enabled = true;
            chkbAdm.Enabled = true;
            dataGridViewX1.ReadOnly = false;
            dataGridViewX1.AllowUserToAddRows = true;
            dataGridViewX1.AllowUserToDeleteRows = true;
            btnEliminarAct.Enabled = true;
            buttonX1.Enabled = true;
            dataGridViewX1.Enabled = true;
            txNE.ReadOnly = false;
            modo = true;
        }

        public void Borrar()
        {
            this.modo = false;

            string consulta = "delete from Actividades where cod_caso=" + cdt.Rows[s1.Position].ItemArray.GetValue(0);
            SqlCommand command = new SqlCommand(consulta, ata.Connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            s1.RemoveCurrent();
            cta.Update(cdt);
        }

        public void IrPrimero()
        {
            s1.MoveFirst();
            llenarActividades();
            cargarNE1();
        }

        public void Anterior()
        {
            s1.MovePrevious();
            llenarActividades();
            cargarNE1();
        }

        public void Siguiente()
        {
            s1.MoveNext();
            llenarActividades();
            cargarNE1();
        }

        public void IrFinal()
        {
            s1.MoveLast();
            llenarActividades();
            cargarNE1();
        }

        public bool vacio()
        {
            if (cdt.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }

        public void Reportes()
        {
            FormularioReportes.showReport(s1, "Casos");
        }

        public void RealizarPago()
        {
            MessageBox.Show("Construyendo");
        }

        public void Filtrar()
        {
            FormularioFiltroBusqueda.showFormularioFiltroBusqueda(s1);

        }

        public void setUser(Usuario u)
        {
            this.u = u;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            //Eliminar actividades de caso
            if (!dataGridViewX1.CurrentRow.IsNewRow)
            {
                
                string consulta = "delete from Actividades where cod_actv =" + dataGridViewX1.CurrentRow.Cells[0].Value;
                SqlCommand command;
                try
                {
                    command = new SqlCommand(consulta, ata.Connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
                catch (NullReferenceException e1)
                {
                    MessageBox.Show("No hay Actividades");
                }

                dataGridViewX1.Rows.RemoveAt(dataGridViewX1.CurrentRow.Index);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (superValidator1.Validate())
            {
                if (modo)
                {
                    // cta.Update(cdt.Rows[s1.IndexOf(s1.Current)]);

                    ActualizarC();

                    this.dataGridViewX1.ReadOnly = true;

                }
                else
                {
                    //s1.AddNew();

                    GuardarC();

                    cdt = cta.GetData();
                    s1.DataSource = cdt;
                    s1.MoveLast();

                    modo = true;
                }
                
                int index = s2.IndexOf(s2.Current);
                System.Data.DataRow row;
                if (adt.Rows.Count > 0)
                {
                    row = adt.Rows[index];
                }
                else
                {
                    row = adt.NewRow();
                }

                int cod_responsable = Convert.ToInt32(txCod_resp.Text);
                int cod_caso = Convert.ToInt32(txcod_Caso.Text);

                Actividades act = new Actividades(true, row, cod_responsable, cod_caso);
                act.setUser(u.Cod_Usua);
                act.ShowDialog();
                llenarActividades();

            }
            else
                MessageBox.Show("Revise los campos requeridos");
            
        }

        private void Caso_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (superValidator1.Validate())
            {
                if (modo)
                {
                    // cta.Update(cdt.Rows[s1.IndexOf(s1.Current)]);

                    ActualizarC();

                    this.dataGridViewX1.ReadOnly = true;

                }
                else
                {
                    //s1.AddNew();

                    GuardarC();

                    cdt = cta.GetData();
                    s1.DataSource = cdt;
                    s1.MoveLast();

                    modo = true;
                }
                //MessageBox.Show(e.RowIndex+"");
                //int index = s2.IndexOf(s2.Current);
                int index = e.RowIndex;
                Actividades act;
                //MessageBox.Show(dataGridViewX1[0, index].Value.ToString());

                int cod_responsable = Convert.ToInt32(txCod_resp.Text);
                int cod_caso = Convert.ToInt32(txcod_Caso.Text);

                if ((dataGridViewX1[0, index].Value == null) || (dataGridViewX1[0, index].Value.ToString() == "") || (dataGridViewX1[0, index].Value.Equals(-1)))
                {
                    System.Data.DataRow row = adt.NewRow();
                    act = new Actividades(true, row, cod_responsable, cod_caso);
                }
                else
                {
                    //MessageBox.Show(dataGridViewX1[0, index].Value.ToString());
                    //System.Data.DataRow row = adt.Rows[index];
                    DataRow row= adt.FindBycod_actv((int)dataGridViewX1.Rows[index].Cells["cod_actv"].Value);
                    act = new Actividades(false, row, cod_responsable, cod_caso);
                }
                act.ShowDialog();
                llenarActividades();
            }
            else
                MessageBox.Show("Revise los campos requeridos");

            

        }

        private void Caso_Load_1(object sender, EventArgs e)
        {
            llenarActividades();
        }

        public void ActualizarC()
        {
            SqlCommand comand;
            String consulta1 = "Update Caso set "
                         + "pers_solic='" + txNomb_solic.Text + "'"
                         + ",carg_pers_solic='" + txCargo.Text + "'"
                         + " where cod_caso=" + txcod_Caso.Text + ";";

            String consulta2 = "Update Caso set "
                         + "fech_solic='" + ipFech_soli.Value.ToString("dd-MM-yyyy") + "'"
                         + ",desc_soli='" + txDesc_prob.Text + "'"
                         + " where cod_caso=" + txcod_Caso.Text + ";";

            String consulta3 = "Update Caso set "
                         + "desc_solu='" + txDesc_solu.Text + "'"
                         + " where cod_caso=" + txcod_Caso.Text + ";";

            String consulta4;

            DateTime d = Convert.ToDateTime("01/01/0001");
            if (ipFech_solu.Value == d)
            {
                consulta4 = "Update Caso set "
                             + "nive_solu='" + sliderNiv_solu.Value + "'"
                             + ",caso_cerrado='" + ckbCaso_cerr.Checked + "'"
                             + ",cod_func_asig='" + txCod_resp.Text + "'"
                             + ",nomb_func_asig='" + txResp_Caso.Text + "'"
                    //+ ",fech_solf='" + ipFech_solu.Value.ToShortDateString() + "'"
                    //+ ",check_adm='" + chkbAdm.Checked + "'"
                             + " where cod_caso=" + txcod_Caso.Text + ";";
            }
            else
            {
                consulta4 = "Update Caso set "
                             + "nive_solu='" + sliderNiv_solu.Value + "'"
                             + ",caso_cerrado='" + ckbCaso_cerr.Checked + "'"
                             + ",cod_func_asig='" + txCod_resp.Text + "'"
                             + ",nomb_func_asig='" + txResp_Caso.Text + "'"
                             + ",fech_solf='" + ipFech_solu.Value.ToShortDateString() + "'"
                             + " where cod_caso=" + txcod_Caso.Text + ";";
            }

            String consulta5 = "Update Caso set "
                         + "observaciones='" + txObservaciones.Text + "'"
                         + " where cod_caso=" + txcod_Caso.Text + ";";

            comand = new SqlCommand(consulta1, cta.Connection);
            comand.Connection.Open();
            comand.ExecuteNonQuery();

            comand = new SqlCommand(consulta2, cta.Connection);
            comand.ExecuteNonQuery();

            comand = new SqlCommand(consulta3, cta.Connection);
            comand.ExecuteNonQuery();

            comand = new SqlCommand(consulta4, cta.Connection);
            comand.ExecuteNonQuery();

            comand = new SqlCommand(consulta5, cta.Connection);
            comand.ExecuteNonQuery();

            comand.Connection.Close();
        }

        public void GuardarC()
        {

            DateTime d = Convert.ToDateTime("01/01/0001");
            if (ipFech_solu.Value == d)
                cta.Insert(Convert.ToInt32(txCod_empr.Text), txNomb_solic.Text, txCargo.Text,
                    ipFech_soli.Value, txDesc_prob.Text, txDesc_solu.Text, sliderNiv_solu.Value,
                    ckbCaso_cerr.Checked, txObservaciones.Text, Convert.ToInt32(txCod_resp.Text),
                    txResp_Caso.Text, null, chkbAdm.Checked);
            else
                cta.Insert(Convert.ToInt32(txCod_empr.Text), txNomb_solic.Text, txCargo.Text,
                ipFech_soli.Value, txDesc_prob.Text, txDesc_solu.Text, sliderNiv_solu.Value,
                ckbCaso_cerr.Checked, txObservaciones.Text, Convert.ToInt32(txCod_resp.Text),
                txResp_Caso.Text, ipFech_solu.Value, chkbAdm.Checked);
        }

       /* private void txCod_empr_CursorChanged(object sender, EventArgs e)
        {
            string c = "Select nomb_empr from Empresa where cod_empr=" + txCod_empr.Text + ";";
            SqlDataAdapter da = new SqlDataAdapter(c, eta.Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataTable table = new DataTable();
            da.Fill(table);

            try
            {
                System.Data.DataRow row = table.Rows[0];
                txNE.Text = row.ItemArray.GetValue(0).ToString();
            }
            catch (IndexOutOfRangeException e2)
            {
                MessageBox.Show("Codigo no existe, favor confirmelo");
                txCod_empr.Clear();
                txNE.Clear();
                txCod_empr.Focus();
            }
        } */

        private void dataGridViewX1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!((dataGridViewX1[0, 0].Value == null) || (dataGridViewX1[0, 0].Value.ToString() == "") || (dataGridViewX1[0, 0].Value.Equals(-1)) ))
            {
                bool j;
                try
                {
                    j = (bool)dataGridViewX1.Rows[e.RowIndex].Cells["acti_cerrada"].Value;
                }
                catch (NullReferenceException e5)
                {
                    j = false;
                }
                catch (InvalidCastException e6)
                {
                    j = false;
                }

                if (j == false)
                {
                    e.CellStyle.BackColor = Color.IndianRed;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Green;
                }
            }
        }

        Empresas_View f;
        private void btBuscarEmpresa_Click(object sender, EventArgs e)
        {
            f = new Empresas_View(txNE.Text);
            f.dataGridViewEmpresas.CellDoubleClick += new DataGridViewCellEventHandler(dataGridViewEmpresas_CellDoubleClick);
            f.ShowDialog();
        }

        private void dataGridViewEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txCod_empr.Text = f.getCodigo(e.RowIndex).ToString();
            cargarNE2();
            f.Dispose();
        }

        public void cargarNE2() {
            string c = "Select nomb_empr from Empresa where cod_empr=" + txCod_empr.Text + ";";
            SqlDataAdapter da = new SqlDataAdapter(c, eta.Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataTable table = new DataTable();
            da.Fill(table);
            if (!table.Rows.Count.Equals(0))
            {
                System.Data.DataRow row = table.Rows[0];
                txNE.Text = row.ItemArray.GetValue(0).ToString();
            }
        }
        
        public void cargarNE1()
        {
            string c = "Select nomb_empr from Empresa where cod_empr=" + cdt.Rows[s1.Position].ItemArray.GetValue(1).ToString() + ";";
            SqlDataAdapter da = new SqlDataAdapter(c, eta.Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataTable table = new DataTable();
            da.Fill(table);
            if (!table.Rows.Count.Equals(0))
            {
                System.Data.DataRow row = table.Rows[0];
                txNE.Text = row.ItemArray.GetValue(0).ToString();
            }
        }
    }
}
