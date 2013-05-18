using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class Empresa : UserControl,Funciones
    {
        CADINDataSetTableAdapters.EmpresaTableAdapter ta1;
        CADINDataSet.EmpresaDataTable dt1;
        CADINDataSetTableAdapters.Empresa_AgrupacionTableAdapter emprAgrupTableA;
        CADINDataSet.Empresa_AgrupacionDataTable emprAgrupDataT;
        CADINDataSetTableAdapters.DepartamentosTableAdapter ta2;
        CADINDataSet.DepartamentosDataTable dt2;
        CADINDataSetTableAdapters.SectoresTableAdapter ta3;
        CADINDataSet.SectoresDataTable dt3;
        CADINDataSetTableAdapters.Tipo_MembresiaTableAdapter ta4;
        CADINDataSet.Tipo_MembresiaDataTable dt4;
        CADINDataSetTableAdapters.Tipo_TarifaTableAdapter ta5;
        CADINDataSet.Tipo_TarifaDataTable dt5;
        CADINDataSetTableAdapters.Tipo_EmpresaTableAdapter ta6;
        CADINDataSet.Tipo_EmpresaDataTable dt6;
        CADINDataSetTableAdapters.Contacto_EmpresaTableAdapter ta7;
        CADINDataSet.Contacto_EmpresaDataTable dt7;
        CADINDataSetTableAdapters.Pago_MembresiaTableAdapter taPagoMembresia;
       

        BindingSource s1, s2, s3, s4, s5, s6,s7,s8;
        bool modo = false;

        Pagos pagos;
        public DataGridView gridPagos = new DataGridView();
        public Empresa(bool modo)
        {
            InitializeComponent();
           

            if (modo)
            {
                modo = true;
                EnlazarControlesBasicos();
            }
            else
            {
                modo = false;
                EnlazarControlesBasicos();
                EnlazarControlesFichaCompleta();
            }

            

        }
        private void EnlazarControlesBasicos()
        {
            emprAgrupTableA = new CADINDataSetTableAdapters.Empresa_AgrupacionTableAdapter();
            ta2 = new CADINDataSetTableAdapters.DepartamentosTableAdapter();
            ta3 = new CADINDataSetTableAdapters.SectoresTableAdapter();
            ta4 = new CADINDataSetTableAdapters.Tipo_MembresiaTableAdapter();
            ta5 = new CADINDataSetTableAdapters.Tipo_TarifaTableAdapter();
            ta6 = new CADINDataSetTableAdapters.Tipo_EmpresaTableAdapter();
            taPagoMembresia = new CADINDataSetTableAdapters.Pago_MembresiaTableAdapter();

            s2 = new BindingSource();
            s3 = new BindingSource();
            s4 = new BindingSource();
            s5 = new BindingSource();
            s6 = new BindingSource();
            s8 = new BindingSource();

            dt2 = ta2.GetData();
            dt3 = ta3.GetData();
            dt4 = ta4.GetData();
            dt5 = ta5.GetData();
            dt6 = ta6.GetData();
            emprAgrupDataT = emprAgrupTableA.GetData();

            s2.DataSource = dt2;
            s3.DataSource = dt3;
            s4.DataSource = dt4;
            s5.DataSource = dt5;
            s6.DataSource = dt6;
            s8.DataSource = emprAgrupDataT;

            ta1 = new CADINDataSetTableAdapters.EmpresaTableAdapter();

            ta7 = new CADINDataSetTableAdapters.Contacto_EmpresaTableAdapter();

            s1 = new BindingSource();

            s7 = new BindingSource();

            dt1 = ta1.GetDataByEmpresasActivas();
            dt7 = ta7.GetData();

            s1.DataSource = dt1;
            s7.DataSource = dt7;


            comboBoxEx1.DataSource = s2;
            comboBoxEx1.DisplayMember = "nombre";
            comboBoxEx1.ValueMember = "cod_dept";

            comboBoxEx2.DataSource = s3;
            comboBoxEx2.DisplayMember = "nombre";
            comboBoxEx2.ValueMember = "cod_sect";

            cboAgrupacion.DataSource = s8;
            cboAgrupacion.DisplayMember = "nombre";
            cboAgrupacion.ValueMember="cod_gremio";

            comboBoxEx3.DataSource = s4;
            comboBoxEx3.DisplayMember = "nombre";
            comboBoxEx3.ValueMember = "cod_memb";

            comboBoxEx4.DataSource = s5;
            comboBoxEx4.DisplayMember = "nombre";
            comboBoxEx4.ValueMember = "cod_tari";

            comboBoxEx5.DataSource = s6;
            comboBoxEx5.DisplayMember = "nombre";
            comboBoxEx5.ValueMember = "cod_tipo_empr";

            //Controles de eventos de los combobox de los contactos supleantes
            this.comboBoxEx6.Click += new EventHandler(comboBoxEx6_Click);
            this.comboBoxEx7.Click += new EventHandler(comboBoxEx7_Click);
            this.comboBoxEx8.Click += new EventHandler(comboBoxEx8_Click);
            this.comboBoxEx9.Click += new EventHandler(comboBoxEx9_Click);

            //eventos del datagrid
            this.comboBoxEx4.SelectedIndexChanged += new EventHandler(comboBoxEx4_SelectedIndexChanged);

            
        
        }
        private void EnlazarControlesFichaCompleta()
        {
            
           


            //control del cambio de ficha
            this.s1.PositionChanged += new EventHandler(s1_PositionChanged);

            textBoxX1.DataBindings.Add("Text", s1, "nomb_empr");
            textBoxX2.DataBindings.Add("Text", s1, "nomb_come");
            dateTimeInput1.DataBindings.Add("Text", s1, "fech_const");
            comboBoxEx1.DataBindings.Add("SelectedValue", s1, "cod_dept");
            textBoxX3.DataBindings.Add("Text", s1, "direc");
            textBoxX4.DataBindings.Add("Text", s1, "telef");
            textBoxX5.DataBindings.Add("Text", s1, "fax");
            textBoxX6.DataBindings.Add("Text", s1, "email");
            textBoxX7.DataBindings.Add("Text", s1, "pagi_web");
            txtCodCiiu.DataBindings.Add("Text",s1,"cod_ciiu");

            comboBoxEx2.DataBindings.Add("SelectedValue", s1, "sect_empr");
            cboAgrupacion.DataBindings.Add("SelectedValue",s1,"cod_gremio");
            textBoxX8.DataBindings.Add("Text", s1, "cant_empl");
            textBoxX9.DataBindings.Add("Text", s1, "prom_ventM");
            textBoxX10.DataBindings.Add("Text", s1, "inv_fija");
            textBoxX11.DataBindings.Add("Text", s1, "arti");
            textBoxX12.DataBindings.Add("Text", s1, "mate_prim");

            checkBoxX1.DataBindings.Add("Checked", s1, "afi_cena");
            checkBoxX2.DataBindings.Add("Checked", s1, "soc_cadi");
            dateTimeInput2.DataBindings.Add("Text", s1, "socioIni");
            comboBoxEx3.DataBindings.Add("SelectedValue", s1, "tipo_memb");
            comboBoxEx4.DataBindings.Add("SelectedValue", s1, "tipo_tari");
            comboBoxEx5.DataBindings.Add("SelectedValue", s1, "tipo_empr");
            //textBoxX17.DataBindings.Add("Text", s1, "cuotaAnual");
            checkBoxX3.DataBindings.Add("Checked", s1, "reci_corr");
            dataGridViewX1.DataSource = s7;

            if (s1.Position!=-1)
            {
                llenarContactos();
                llenarComboBox();
                setPrecioMembresia(); 
            }
            textBoxX13.DataBindings.Add("Text", s1, "carnet");
            Cancelar();
        }
        private void llenarContactos()
        {
            this.dataGridViewX1.Columns.Clear();
            if (s1.Position != -1)
            {
                string c = "Select * from Contacto_Empresa where cod_empr=" + dt1.Rows[s1.Position].ItemArray.GetValue(0).ToString() + ";";
                SqlDataAdapter da = new SqlDataAdapter(c, ta1.Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                DataTable table = new DataTable();
                da.Fill(table);
                this.dataGridViewX1.DataSource = table;
                this.dataGridViewX1.Columns["cod_empr"].Visible = false;
                this.dataGridViewX1.Columns["cod_cont"].Visible = false;
                this.dataGridViewX1.Columns["nomb"].HeaderText = "Nombre Contacto";
                this.dataGridViewX1.Columns["carg"].HeaderText = "Cargo";
                this.dataGridViewX1.Columns["telf"].HeaderText = "Telefono";
                this.dataGridViewX1.Columns["email"].HeaderText = "Email";
                this.dataGridViewX1.Columns["observacion"].HeaderText = "Observación";
            }
            else
            {
                MessageBox.Show("No hay registros de empresas","Aviso",MessageBoxButtons.OK);
            }
            
        }
        private string getNombre(int cod)
        {
            string c = "Select nomb from Contacto_Empresa where cod_cont=" +cod.ToString() +";";
            SqlDataAdapter da = new SqlDataAdapter(c, ta7.Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataTable table = new DataTable();
            da.Fill(table);
            return table.Rows[0].ItemArray.GetValue(0).ToString();
        }
        private void llenarComboBox()
        {
            DataTable table = new DataTable();
            if (s1.Position!=-1)
            {
                string c = "Select cont_principal,primS,seguS,tercS from empresa where cod_empr=" + dt1.Rows[s1.Position].ItemArray.GetValue(0).ToString() + ";";
                SqlDataAdapter da = new SqlDataAdapter(c, ta1.Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.Fill(table); 
            }
            //set blank combobox
            this.comboBoxEx6.Text = "";
            this.comboBoxEx7.Text = "";
            this.comboBoxEx8.Text = "";
            this.comboBoxEx9.Text = "";
            if (table.Rows.Count != 0)
            {
                int p1, p2, p3, p4;
                if (table.Rows[0].ItemArray.GetValue(0) != DBNull.Value)
                {
                    p1 = Convert.ToInt16(table.Rows[0].ItemArray.GetValue(0));
                    this.comboBoxEx6.Items.Clear();
                    this.comboBoxEx6.Items.Add(getNombre(p1));
                    this.comboBoxEx6.SelectedIndex = 0;
                }
                if (table.Rows[0].ItemArray.GetValue(1) != DBNull.Value)
                {
                    p2 = Convert.ToInt16(table.Rows[0].ItemArray.GetValue(1));
                    this.comboBoxEx7.Text = getNombre(p2);
                }
                if (table.Rows[0].ItemArray.GetValue(2) != DBNull.Value)
                {
                    p3 = Convert.ToInt16(table.Rows[0].ItemArray.GetValue(2));
                    this.comboBoxEx8.Text = getNombre(p3);
                }
                if (table.Rows[0].ItemArray.GetValue(3) != DBNull.Value)
                {
                    p4 = Convert.ToInt16(table.Rows[0].ItemArray.GetValue(3));
                    this.comboBoxEx9.Text = getNombre(p4);
                }
            }
        }
        private void s1_PositionChanged(Object sender,EventArgs e)
        {
            if (!modo)
            {
                llenarContactos();
                llenarComboBox();
                tabla = new DataTable();
                setPrecioMembresia(); 
            }
        }
        void setCordobas()
        {
            //if (this.textBoxX10.Text != "" && !this.textBoxX10.Text.Contains("C$"))
            //    this.textBoxX10.Text = "C$ " + this.textBoxX10.Text;
            //if (this.textBoxX9.Text != "" && !this.textBoxX9.Text.Contains("C$"))
            //    this.textBoxX9.Text = "C$ " + this.textBoxX9.Text;
        }
        void removeCordobas()
        {
            //if (this.textBoxX9.Text != "" && this.textBoxX9.Text.Contains("C$"))
            //    this.textBoxX9.Text = this.textBoxX9.Text.Substring(2);
            //if (this.textBoxX10.Text != "" && this.textBoxX10.Text.Contains("C$"))
            //    this.textBoxX10.Text = this.textBoxX10.Text.Substring(2);
        }
        private bool actualizarContactos()
        {
            return true;
        }
        int codigo;
        public bool Guardar()
        {
            string mensaje = "";   
            if (superValidator1.Validate())
            {
                
                if (!modo)
                {
                    removeCordobas();
                    s1.EndEdit();
                    ta1.Update(dt1.Rows[s1.IndexOf(s1.Current)]);
                    
                    codigo = Convert.ToInt32(dt1.Rows[s1.Position].ItemArray.GetValue(0));
                    string consulta;
                    SqlCommand comand;
                    this.dataGridViewX1.ReadOnly = true;
                    foreach (DataGridViewRow row in dataGridViewX1.Rows)
                    {
                        if (!row.IsNewRow)
                        {

                            if (row.Cells[0].Value != DBNull.Value)
                            {
                                consulta = "Update Contacto_Empresa set "
                                + "nomb='" + row.Cells[2].Value.ToString().TrimStart().TrimEnd() + "'"
                                + ",carg='" + row.Cells[3].Value.ToString().TrimStart().TrimEnd() + "'"
                                + ",telf='" + row.Cells[4].Value.ToString().Trim() + "'"
                                + ",email='" + row.Cells[5].Value.ToString().TrimStart().TrimEnd() + "'"
                                + ",observacion='" + row.Cells[6].Value.ToString().TrimStart().TrimEnd() + "'"
                                + " where cod_cont=" + row.Cells[1].Value + ";";
                            }
                            else
                            {
                                consulta = "Insert into Contacto_Empresa(cod_empr,nomb,carg,telf,email,observacion) values("
                                    + codigo
                                    + ",'" + row.Cells[2].Value + "'"
                                    + ",'" + row.Cells[3].Value + "'"
                                    + ",'" + row.Cells[4].Value + "'"
                                    + ",'" + row.Cells[5].Value + "'"
                                    + ",'" + row.Cells[6].Value + "'"
                                    + ");";
                            }
                            comand = new SqlCommand(consulta, ta7.Connection);
                            comand.Connection.Open();
                            comand.ExecuteNonQuery();
                            comand.Connection.Close();
                        }
                    }
                    consulta = "Delete from Pago_Membresia where cod_empr=" + codigo;
                    comand = new SqlCommand(consulta, ta7.Connection);
                    comand.Connection.Open();
                    comand.ExecuteNonQuery();
                    comand.Connection.Close();
                    foreach (DataRow row in tabla.Rows)
                    {
                        if (row.ItemArray.GetValue(7).Equals(DBNull.Value))
                        {
                            double monto;
                            if (row.ItemArray.GetValue(4).ToString().Contains("$"))
                                monto = Convert.ToDouble(row.ItemArray.GetValue(4).ToString().Substring(1));
                            else
                                monto = Convert.ToDouble(row.ItemArray.GetValue(4).ToString());
                            taPagoMembresia.Insert(codigo, Convert.ToInt32(row.ItemArray.GetValue(2)),
                            Convert.ToInt32(row.ItemArray.GetValue(3)),
                            monto,
                            Convert.ToDateTime(row.ItemArray.GetValue(5)),
                            Convert.ToBoolean(row.ItemArray.GetValue(6)), null, "",1);
                        }
                        else
                        { 
                        
                            taPagoMembresia.Insert(codigo, Convert.ToInt32(row.ItemArray.GetValue(2)),
                            Convert.ToInt32(row.ItemArray.GetValue(3)),
                            Convert.ToDouble(row.ItemArray.GetValue(4).ToString().Substring(1)),
                            Convert.ToDateTime(row.ItemArray.GetValue(5)),
                            Convert.ToBoolean(row.ItemArray.GetValue(6)), Convert.ToInt32(row.ItemArray.GetValue(7).ToString()), row.ItemArray.GetValue(8).ToString(),Convert.ToInt32(row.ItemArray.GetValue(9).ToString()));
                            
                        }
                    }
                }
                else
                {
                    //Procedimiento para agregar una nueva empresa
                   
                    s1.AddNew();
                    s1.MoveLast();
                    DataRow c1 = dt7.NewRow();
                    int monto1, monto2,cant;
                    if (textBoxX9.Text.Equals(""))
                    {
                        monto1 = 0;
                    }
                    else
                    {
                        monto1=Convert.ToInt32(textBoxX9.Text);
                    }
                    if (textBoxX10.Text.Equals(""))
                    {
                        monto2 = 0;
                    }
                    else
                    {
                        monto2=Convert.ToInt32(textBoxX10.Text);
                    }
                    if (textBoxX8.Text.Equals(""))
                    {
                        cant = 0;
                    }
                    else
                    {
                        cant = Convert.ToInt32(textBoxX10.Text);
                    }
                    ta1.Insert(txtCodCiiu.Text, textBoxX1.Text,                                                          
                        textBoxX2.Text, dateTimeInput1.Value,
                        textBoxX3.Text, Convert.ToInt32(comboBoxEx1.SelectedValue),
                        textBoxX4.Text, textBoxX5.Text, textBoxX6.Text, textBoxX7.Text,
                        Convert.ToInt32(comboBoxEx2.SelectedValue),Convert.ToInt32(this.cboAgrupacion.SelectedValue),null,null,null
                        /*Convert.ToInt32(textBoxX8.Text),Convert.ToInt32(textBoxX9.Text),
                        Convert.ToInt32(textBoxX10.Text)*/,
                        textBoxX11.Text, textBoxX12.Text, cant, monto1, monto2,
                        null, checkBoxX1.Checked, checkBoxX2.Checked,
                        Convert.ToInt32(comboBoxEx3.SelectedValue),
                        Convert.ToInt32(comboBoxEx4.SelectedValue),
                        Convert.ToInt32(comboBoxEx5.SelectedValue),
                        checkBoxX3.Checked, dateTimeInput2.Value,
                        15/*Convert.ToDouble(textBoxX17.Text.Substring(3))*/,null,true);

                    //vincularControlesDesvinculados();
                    string consulta = "Select MAX(cod_empr) from Empresa";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, ta1.Connection);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    codigo = Convert.ToInt32(table.Rows[0].ItemArray.GetValue(0));
                    //obtener el carnet
                    consulta = "Select carnet from Empresa where cod_empr="+codigo+";";
                    da = new SqlDataAdapter(consulta, ta1.Connection);
                    table = new DataTable();
                    da.Fill(table);
                    int carnet = Convert.ToInt32(table.Rows[0].ItemArray.GetValue(0));
                    mensaje += "con número de carné "+carnet;
                    //INSERTAR PAGOS 
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        DataRow row = tabla.Rows[i];
                        taPagoMembresia.Insert(codigo, Convert.ToInt32(row.ItemArray.GetValue(2)),
                            Convert.ToInt32(row.ItemArray.GetValue(3)),
                            Convert.ToDouble(row.ItemArray.GetValue(4).ToString().Substring(1)),
                            Convert.ToDateTime(row.ItemArray.GetValue(5)),
                            false, null, null,1);
                    }
                    //INSERTAR CONTACTOS DE EMPRESA
                    SqlCommand command;
                    foreach (DataGridViewRow row in dataGridViewX1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            consulta = "Insert into Contacto_Empresa(cod_empr,nomb,carg,telf,email,observacion) values("
                                        + codigo
                                        + ",'" + row.Cells[2].Value + "'"
                                        + ",'" + row.Cells[3].Value + "'"
                                        + ",'" + row.Cells[4].Value + "'"
                                        + ",'" + row.Cells[5].Value + "'"
                                        + ",'" + row.Cells[6].Value + "'"
                                        + ");";
                            command = new SqlCommand(consulta, ta7.Connection);
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                            command.Connection.Close();
                        }
                    }
                    
                }
                this.comboBoxEx6.Enabled = false;
                this.comboBoxEx7.Enabled = false;
                this.comboBoxEx8.Enabled = false;
                //Agregar los contactos principales
                string consulta2;
                SqlDataAdapter dataAdapter;
                SqlCommandBuilder builder;
                DataTable dataTable;
                SqlCommand command2;
                
                //PROPIETARIO
                consulta2 = "Select cod_cont from Contacto_Empresa where cod_empr="
                            +codigo+" and nomb='"+comboBoxEx6.Text+"';";
                dataAdapter = new SqlDataAdapter(consulta2, ta7.Connection);
                builder = new SqlCommandBuilder(dataAdapter);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (comboBoxEx6.Text != "")
                {
                    consulta2 = "update Empresa set cont_principal=" + dataTable.Rows[0].ItemArray.GetValue(0)
                                + " where cod_empr=" + codigo + ";";
                }
                else
                {
                    consulta2 = "update Empresa set cont_principal=NULL" + " where cod_empr=" + codigo + ";";                        
                }
                command2 = new SqlCommand(consulta2, ta1.Connection);
                command2.Connection.Open();
                command2.ExecuteNonQuery();
                command2.Connection.Close();
                
                
                //PRIMER SUPLENTE
                consulta2 = "Select cod_cont from Contacto_Empresa where cod_empr="
                            + codigo + " and nomb='" + comboBoxEx7.Text + "';";
                dataAdapter = new SqlDataAdapter(consulta2, ta7.Connection);
                builder = new SqlCommandBuilder(dataAdapter);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (comboBoxEx7.Text != "")
                {
                    consulta2 = "update Empresa set primS=" + dataTable.Rows[0].ItemArray.GetValue(0)
                                + " where cod_empr=" + codigo + ";";
                }
                else
                {
                    consulta2 = "update Empresa set primS=NULL" + " where cod_empr=" + codigo + ";";
                }
                command2 = new SqlCommand(consulta2, ta1.Connection);
                command2.Connection.Open();
                command2.ExecuteNonQuery();
                command2.Connection.Close();
                
               
                //SEGUNDO SUPLENTE
                consulta2 = "Select cod_cont from Contacto_Empresa where cod_empr="
                            + codigo + " and nomb='" + comboBoxEx8.Text + "';";
                dataAdapter = new SqlDataAdapter(consulta2, ta7.Connection);
                builder = new SqlCommandBuilder(dataAdapter);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (comboBoxEx8.Text != "")
                {
                    consulta2 = "update Empresa set seguS=" + dataTable.Rows[0].ItemArray.GetValue(0)
                                + " where cod_empr=" + codigo + ";";
                }
                else 
                {
                    consulta2 = "update Empresa set seguS=NULL"+ " where cod_empr=" + codigo + ";";
                }
                command2 = new SqlCommand(consulta2, ta1.Connection);
                command2.Connection.Open();
                command2.ExecuteNonQuery();
                command2.Connection.Close();
                
                
                //TERCER SUPLENTE
                consulta2 = "Select cod_cont from Contacto_Empresa where cod_empr="
                            + codigo + " and nomb='" + comboBoxEx9.Text + "';";
                dataAdapter = new SqlDataAdapter(consulta2, ta7.Connection);
                builder = new SqlCommandBuilder(dataAdapter);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (comboBoxEx9.Text != "")
                {
                    consulta2 = "update Empresa set tercS=" + dataTable.Rows[0].ItemArray.GetValue(0)
                                + " where cod_empr=" + codigo + ";";
                }
                else
                {
                    consulta2 = "update Empresa set tercS=NULL"+ " where cod_empr=" + codigo + ";";
                }
                command2 = new SqlCommand(consulta2, ta1.Connection);
                command2.Connection.Open();
                command2.ExecuteNonQuery();
                command2.Connection.Close();

                dt1 = ta1.GetDataByEmpresasActivas();
                s1.DataSource = dt1;
                Cancelar();
                MessageBox.Show("Guardado "+mensaje);
                
                return true;
            }else
                MessageBox.Show("Verificar Informacion");
            return false;
        }
        public void vincularControlesDesvinculados()
        {
            if (textBoxX8.DataBindings.Count == 0)
            {
                textBoxX8.DataBindings.Add("Text", s1, "cant_empl");
            }
            if (textBoxX9.DataBindings.Count == 0)
            {
                textBoxX9.DataBindings.Add("Text", s1, "prom_ventM");
            }
            if (textBoxX10.DataBindings.Count == 0)
            {
                textBoxX10.DataBindings.Add("Text", s1, "inv_fija");
            }
        }
        public void Cancelar()
        {
            s1.CancelEdit();
            dataGridViewX1.CancelEdit();
            llenarContactos();
            llenarComboBox();
            setCordobas();
            dataGridViewX1.Refresh();
            comboBoxEx6.Refresh();
            comboBoxEx7.Refresh();
            comboBoxEx8.Refresh();
            comboBoxEx9.Refresh();
            superValidator1.ClearFailedValidations();
            textBoxX1.ReadOnly = true;
            textBoxX2.ReadOnly = true;
            dateTimeInput1.Enabled = false;
            comboBoxEx1.Enabled = false;
            textBoxX3.ReadOnly = true;
            textBoxX4.ReadOnly = true;
            textBoxX5.ReadOnly = true;
            textBoxX6.ReadOnly = true;
            textBoxX7.ReadOnly = true;
            txtCodCiiu.ReadOnly = true;

            comboBoxEx2.Enabled = false;
            textBoxX8.ReadOnly = true;
            textBoxX9.ReadOnly = true;
            textBoxX10.ReadOnly = true;
            textBoxX11.ReadOnly = true;
            textBoxX12.ReadOnly = true;

            checkBoxX1.Enabled = false;
            checkBoxX2.Enabled = false;
            dateTimeInput2.Enabled = false;
            comboBoxEx3.Enabled = false;
            comboBoxEx4.Enabled = false;
            comboBoxEx5.Enabled = false;
            textBoxX17.ReadOnly = true;
            checkBoxX3.Enabled = false;
            dataGridViewX1.ReadOnly = true;
            dataGridViewX1.AllowUserToAddRows = false;
            dataGridViewX1.AllowUserToDeleteRows = false;
         

            comboBoxEx6.Enabled = false;
            comboBoxEx7.Enabled = false;
            comboBoxEx8.Enabled = false;
            comboBoxEx9.Enabled = false;
            btnEliminarContacto.Enabled = false;
            vincularControlesDesvinculados();
            
        }

        public void Editar()
        {

            btnEliminarContacto.Enabled = true;
            textBoxX1.ReadOnly = false;
            textBoxX2.ReadOnly = false;
            dateTimeInput1.Enabled = true;
            comboBoxEx1.Enabled = true;
            textBoxX3.ReadOnly = false;
            textBoxX4.ReadOnly = false;
            textBoxX5.ReadOnly = false;
            textBoxX6.ReadOnly = false;
            textBoxX7.ReadOnly = false;
            txtCodCiiu.ReadOnly = false;

            cboAgrupacion.Enabled = true;
            comboBoxEx2.Enabled = true;
            textBoxX8.ReadOnly = false;
            textBoxX9.ReadOnly = false;
            textBoxX10.ReadOnly = false;
            textBoxX11.ReadOnly = false;
            textBoxX12.ReadOnly = false;

            checkBoxX1.Enabled = true;
            checkBoxX2.Enabled = true;
            dateTimeInput2.Enabled = true;
            comboBoxEx3.Enabled = true;
            comboBoxEx4.Enabled = true;
            comboBoxEx5.Enabled = true;
            textBoxX17.ReadOnly = true;
            checkBoxX3.Enabled = true;
            dataGridViewX1.ReadOnly = false;
            dataGridViewX1.AllowUserToAddRows = true;
            dataGridViewX1.AllowUserToDeleteRows = true;
           
            comboBoxEx6.Enabled = true;
            comboBoxEx7.Enabled = true;
            comboBoxEx8.Enabled = true;
            comboBoxEx9.Enabled = true;
            //modo = true;
        }

        public void Borrar()
        {
            this.modo = false;
            
            //Eliminar contactos de esa empresa
         
            string consulta = "update Empresa set activo='False' where cod_empr=" + dt1.Rows[s1.Position].ItemArray.GetValue(0);
            SqlCommand command = new SqlCommand(consulta,ta1.Connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            //Eliminar Empresa de la base de datos
            s1.RemoveCurrent();
            dt1.AcceptChanges();
            s1_PositionChanged(null, null);
            //ta1.Update(dt1);
        }

        public void IrPrimero()
        {
            s1.MoveFirst();
            cont = 0;
            setCordobas();
        }

        public void Anterior()
        {
            s1.MovePrevious();
            cont = 0;
            setCordobas();
        }

        public void Siguiente()
        {
            s1.MoveNext();
            cont = 0;
            setCordobas();
        }

        public void IrFinal()
        {
            s1.MoveLast();
            cont = 0;
            setCordobas();
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            setCordobas();
        }
        private void validarColumnasDataGrid_Validating(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {

                if (this.dataGridViewX1.CurrentCell.ColumnIndex == this.dataGridViewX1.Columns["telf"].Index)
                {
                    if (this.dataGridViewX1.CurrentCell.Value != null)
                    {
                        if (this.dataGridViewX1.CurrentCell.Value.ToString().Length == 4)
                        {
                            this.dataGridViewX1.CurrentCell.Value += "-";

                        }

                    }
                }
                e.Handled = false;
            }
        }
        public void Nuevo()
        {
            modo = true;
            this.dataGridViewX1.DataSource = null;
            this.dataGridViewX1.Columns.Add("cod_empr","codigo empreas");
            this.dataGridViewX1.Columns.Add("cod_cont", "codigo contactos");
            this.dataGridViewX1.Columns[0].Visible = false;
            this.dataGridViewX1.Columns[1].Visible = false;
            this.dataGridViewX1.Columns.Add("nombre", "Nombre y Apellido");
            this.dataGridViewX1.Columns.Add("cargo", "Cargo");
            this.dataGridViewX1.Columns.Add("telf", "Teléfono");
            this.dataGridViewX1.KeyPress += new KeyPressEventHandler(validarColumnasDataGrid_Validating);
            this.dataGridViewX1.Columns.Add("email", "Email");
            this.dataGridViewX1.Columns.Add("observacion", "Observaciones");
            textBoxX1.Focus();
            
            Editar();
            limpiarControles();
            this.dateTimeInput2.Value = DateTime.Today;
            
        }
        private void limpiarControles()
        {
            //Elimina el binding de los tres texbox 
            if (textBoxX8.DataBindings.Count != 0)
            {
                textBoxX8.DataBindings.RemoveAt(0);
            }
            if (textBoxX9.DataBindings.Count != 0)
            {
                textBoxX9.DataBindings.RemoveAt(0);
            }
            if (textBoxX10.DataBindings.Count != 0)
            {
                textBoxX10.DataBindings.RemoveAt(0);
            }
            textBoxX1.Clear();
            textBoxX2.Clear();
            dateTimeInput1.IsEmpty = true;
            textBoxX3.Clear();
            textBoxX4.Clear();
            textBoxX5.Clear();
            textBoxX6.Clear();
            textBoxX7.Clear();
            txtCodCiiu.Clear();
            cboAgrupacion.Text = "";
            textBoxX11.Clear();
            textBoxX12.Clear();
            textBoxX13.Clear();
            textBoxX13.ReadOnly = true;
            textBoxX9.Clear();
            textBoxX8.Clear();
            textBoxX10.Clear();
            checkBoxX1.Checked = false;
            checkBoxX2.Checked = false;
            dateTimeInput2.IsEmpty = true;
           
            textBoxX17.Clear();
            checkBoxX3.Checked = false;
            dataGridViewX1.ReadOnly = false;
            dataGridViewX1.AllowUserToAddRows = true;
            dataGridViewX1.AllowUserToDeleteRows = true;

            comboBoxEx6.Items.Clear();
            comboBoxEx6.Text = "";
            comboBoxEx7.Items.Clear();
            comboBoxEx7.Text = "";
            comboBoxEx8.Items.Clear();
            comboBoxEx8.Text = "";
            comboBoxEx9.Items.Clear();
            comboBoxEx9.Text = "";
        }
        public void Imprimir()
        {
            throw new NotImplementedException();
        }
        
        public bool vacio()
        {
            if (s1.Position== -1)
            {
                return true;
            }
            return false;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            s7.EndEdit();
            ta7.Update(dt7.Rows[s7.IndexOf(s7.Current)]);
            MessageBox.Show("Contactos Guardados");
        }
        //EVENTOS DE CONTROL DE COMBOBOX
        
        private void comboBoxEx6_Click(Object sender, EventArgs e)
        {
            this.comboBoxEx6.Items.Clear();
            foreach(DataGridViewRow fila in this.dataGridViewX1.Rows)
            {
                if (!fila.IsNewRow)
                    this.comboBoxEx6.Items.Add(fila.Cells[2].Value);
            }
            //this.comboBoxEx6.SelectedIndex = 0;
        }
        private void comboBoxEx7_Click(Object sender, EventArgs e)
        {
            this.comboBoxEx7.Items.Clear();
            this.comboBoxEx7.Items.Add("");
            foreach (DataGridViewRow fila in this.dataGridViewX1.Rows)
            {
                if (!fila.IsNewRow)
                    this.comboBoxEx7.Items.Add(fila.Cells[2].Value);
            }
        }
        private void comboBoxEx8_Click(Object sender, EventArgs e)
        {
            this.comboBoxEx8.Items.Clear();
            this.comboBoxEx8.Items.Add("");
            foreach (DataGridViewRow fila in this.dataGridViewX1.Rows)
            {
                if (!fila.IsNewRow)
                    this.comboBoxEx8.Items.Add(fila.Cells[2].Value);
            }
        }
        private void comboBoxEx9_Click(Object sender, EventArgs e)
        {
            this.comboBoxEx9.Items.Clear();
            this.comboBoxEx9.Items.Add("");
            foreach (DataGridViewRow fila in this.dataGridViewX1.Rows)
            {
                if (!fila.IsNewRow)
                    this.comboBoxEx9.Items.Add(fila.Cells[2].Value);
            }
        }

        private void textBoxX13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            //Eliminar contactos de esa empresa
            if (!dataGridViewX1.CurrentRow.IsNewRow)
            {
                string consulta = "delete from Contacto_Empresa where cod_cont=" + dataGridViewX1.CurrentRow.Cells[1].Value;
                SqlCommand command;
                bool estado = false;//es true si se esta eliminando un contacto de la base de datos
                try
                {
                    command = new SqlCommand(consulta, ta7.Connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    estado = true;
                }
                catch (NullReferenceException e1)
                {
                    estado = false;
                }


                string nombre = dataGridViewX1.CurrentRow.Cells[2].Value.ToString();
                if (comboBoxEx6.Text == nombre)
                {
                    if (estado)
                    {
                        consulta = "update Empresa set propietario=NULL where cod_empr=" + dataGridViewX1.CurrentRow.Cells[0].Value + ";";
                        command = new SqlCommand(consulta, ta1.Connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    }
                    comboBoxEx6.Items.Clear();
                    comboBoxEx6.Text = "";
                    comboBoxEx6.Refresh();
                }
                if (comboBoxEx7.Text == nombre)
                {
                    if (estado)
                    {
                        consulta = "update Empresa set primS=NULL where cod_empr=" + dataGridViewX1.CurrentRow.Cells[0].Value + ";";
                        command = new SqlCommand(consulta, ta1.Connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    }
                    comboBoxEx7.Items.Clear();
                    comboBoxEx7.Text = "";
                    comboBoxEx7.Refresh();
                }
                if (comboBoxEx8.Text == nombre)
                {
                    if (estado)
                    {
                        consulta = "update Empresa set seguS=NULL where cod_empr=" + dataGridViewX1.CurrentRow.Cells[0].Value + ";";
                        command = new SqlCommand(consulta, ta1.Connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    }
                    comboBoxEx8.Items.Clear();
                    comboBoxEx8.Text = "";
                    comboBoxEx8.Refresh();
                }
                if (comboBoxEx9.Text == nombre)
                {
                    if (estado)
                    {
                        consulta = "update Empresa set tercS=NULL where cod_empr=" + dataGridViewX1.CurrentRow.Cells[0].Value + ";";
                        command = new SqlCommand(consulta, ta1.Connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    }
                    comboBoxEx9.Items.Clear();
                    comboBoxEx9.Text = "";
                    comboBoxEx9.Refresh();
                }
                dataGridViewX1.Rows.RemoveAt(dataGridViewX1.CurrentRow.Index); 
            }

        }

        private void comboBoxEx4_Click(object sender, EventArgs e)
        {


        }

        private void comboBoxEx4_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (comboBoxEx4.SelectedIndex!=-1)
            {
                setPrecioMembresia(); 
            }
        }
        void setPrecioMembresia()
        {

            if (comboBoxEx4.SelectedIndex!=-1)
            {
                textBoxX17.Text = string.Format("C$ {0:N}",
                        Convert.ToDouble(dt5.Rows[comboBoxEx4.SelectedIndex].ItemArray.GetValue(2).ToString())); 
            }
        }

        public void Buscar()
        {
            FormBusqueda cub = new FormBusqueda(this.dt1, this.s1);
            object[] items = { "cod_empr", "nomb_empr", "nomb_come"};
            object[] columnNames = { "Código de Empresa", "Nombre de la Empresa", "Nombre Comercial"};
            cub.setMembers(columnNames, items);
            cub.Show();
        }

        public void Filtrar()
        {
            FormularioFiltroBusqueda.showFormularioFiltroBusqueda(s1);
        }
        int cont = 0;
        private void btnGenerarPagos_Click(object sender, EventArgs e)
        {
            if (this.textBoxX17.Text == "")
                MessageBox.Show("No hay una tarifa definida", "Error al cargar Pagos", MessageBoxButtons.OK);
            else
            {
                if (this.textBoxX13.Text == "" )
                    pagos = new Pagos(this.textBoxX17.Text);
                else
                {
                    string codigo = this.textBoxX13.Text.Substring(4).TrimStart('0');
                    pagos = new Pagos(this.textBoxX17.Text, Convert.ToInt32(codigo));
                    if (tabla.Columns.Count==0)
                    {
                        tabla = taPagoMembresia.GetDataByEmpresa(Convert.ToInt32(codigo));
                        this.tabla.Columns[0].ColumnName = "Número de Pago";
                        this.tabla.Columns[1].ColumnName = "Código de Empresa";
                        this.tabla.Columns[2].ColumnName = "Período de Pago";
                        this.tabla.Columns[3].ColumnName = "Número de Cuota";
                        this.tabla.Columns[4].ColumnName = "Monto";
                        this.tabla.Columns[5].ColumnName = "Fecha de Pago";
                        this.tabla.Columns[6].ColumnName = "Estado";
                        this.tabla.Columns[7].ColumnName = "Número de recibo";
                        this.tabla.Columns[8].ColumnName = "Observaciones";
                        this.tabla.Columns[9].ColumnName = "tipo";
                    }
                }
                if (cont == 0)
                {
                    if (tabla.Columns.Count == 0)
                    {
                        iniciarDataTable();
                    }
                    tablaBin.DataSource = tabla;
                    cont++;
                }
                pagos.dgPagosEmpresa.DataSource = tablaBin;

                if (comboBoxEx4.Enabled==true)
                    pagos.modoEdicion();
                else
                    pagos.modoVisual();
                //EVENTOS A CONTROL DEL FORMULARIO PAGOS
                pagos.btnGenerarPagos.Click +=new EventHandler(PagosbtnGenerarPagos_Click);
                pagos.btnBorrarPago.Click +=new EventHandler(btnBorrarPago_Click);
                pagos.dgPagosEmpresa.AllowUserToDeleteRows = false;
                //pagos.dgPagosEmpresa.RowsRemoved +=new DataGridViewRowsRemovedEventHandler(eliminarPagos);
                pagos.ShowDialog();
            }
        }
        /*
         ----------------------------------------------------------------------------------
         * --------------------------------------------------------------------------------
         * ------------------------CONTROL DE FORMULARIO PAGOS-----------------------------
         * --------------------------------------------------------------------------------
         */
        void btnBorrarPago_Click(object sender, EventArgs e)
        {
            int cont = 0;
            if (pagos.dgPagosEmpresa.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection rows = pagos.dgPagosEmpresa.SelectedRows;

                foreach(DataGridViewRow row in rows)
                {
                    if (!row.IsNewRow)
                    {

                        if (row.Cells[6].Value.Equals(false))
                        {

                            tabla.Rows.RemoveAt(row.Index);
                        }
                        else
                        {
                            cont++;
                        }
                    }
                    else
                    {
                        cont--;
                    }
                }

                if (cont > 0)
                {
                    MessageBox.Show("No se lograron borrar " + cont + " registros\nAyuda: Los pagos vinculados a un número de recibo no pueden ser borrados por los gestores", "Advertencia", MessageBoxButtons.OK);

                }
                else if (cont == 0)
                {
                    MessageBox.Show("Registros Borrados exitosamente", "Información", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Registro no corresponde a ningún pago","Error",MessageBoxButtons.OK);
                }
            }
        }
        void PagosbtnGenerarPagos_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(pagos.domainNumCuotas.Text);
            DataRow pago;
            DateTime dateTime = new DateTime();
            dateTime=DateTime.Now;
            string periodo = DateTime.Now.Year.ToString();
            int numPagoTemporal = -2;
            int cuotas = 1;
            double monto = Convert.ToDouble(pagos.lbTotalPago.Text.Substring(2)) / Convert.ToInt32(pagos.domainNumCuotas.Text);
            for (int i = 0; i < rows; i++)
            {
                pago = tabla.NewRow();

                //Campos de cada registor
                if (this.textBoxX13.Text=="")
                {

                    //num_pago
                    pago[0] = "";
                    //cod_empr
                    pago[1] = "";

                }
                else
                {
                    pago[0] = Convert.ToInt32(numPagoTemporal--);
                    pago[1] = Convert.ToInt32(this.textBoxX13.Text);
                }
                //perid_pago
                pago[2] = Convert.ToInt32(periodo);
                //num_cuota
                pago[3] = Convert.ToInt32(cuotas++.ToString());
                //monto
                pago[4] = /*string.Format("C$ {0:N}",*/ Convert.ToDouble(monto.ToString());
                //fech_pago
                pago[5] = Convert.ToDateTime(dateTime.ToString("dd/MM/yyyy"));
                //pagado
                pago[6] = false;
                //num_recib
                //pago[7] = "";
                //observaciones
                //pago[8] = "";
                switch (pagos.cbFrequenciaPagos.SelectedIndex)
                {
                    case 0: dateTime = dateTime.AddDays(7); break;
                    case 1: dateTime = dateTime.AddMonths(1); break;
                    case 2: dateTime = dateTime.AddYears(1); break;
                }
                tabla.Rows.Add(pago);
            }
                
          }


        void eliminarPagos(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int indice = e.RowIndex;
            tabla.Rows[indice].Delete();
            //actualizarPendiente(null,null);
        }
        
        
        DataTable tabla=new DataTable();
        BindingSource tablaBin = new BindingSource();
        public void iniciarDataTable()
        {
            this.tabla.Columns.Add("Número de Pago");
            this.tabla.Columns.Add("Código de Empresa");
            this.tabla.Columns.Add("Período de Pago");
            this.tabla.Columns.Add("Número de Cuota");
            this.tabla.Columns.Add("Monto");
            this.tabla.Columns.Add("Fecha de Pago");
            this.tabla.Columns.Add("Estado");
            this.tabla.Columns.Add("Número de recibo");
            this.tabla.Columns.Add("Observaciones");
            this.tabla.Columns.Add("Tipo");

        }
        
        int conttel=0;
        private void textBoxX4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.textBoxX4.Text.Length > contfax)
            {
                conttel++;
                if (textBoxX4.Text.Length == 4)
                {
                    this.textBoxX4.Text += "-";
                    this.textBoxX4.Select(this.textBoxX4.Text.Length, 0);
                }
            }
            else
            {
                conttel--;
            }
        }
        
        int contfax = 0;
        private void textBoxX5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.textBoxX5.Text.Length > contfax)
            {
                contfax++;
                if (textBoxX5.Text.Length == 4)
                {
                    this.textBoxX5.Text += "-";
                    this.textBoxX5.Select(this.textBoxX5.Text.Length, 0);
                }
            }
            else
            {
                contfax--;
            }
        }

        private void textBoxX8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
            }
        }

        private void textBoxX10_Validating(object sender, CancelEventArgs e)
        {
            //if (!this.textBoxX10.Text.Equals(""))
            //{
            //    string monto=this.textBoxX10.Text;
            //    if (this.textBoxX10.Text.Contains("C$"))
            //    {
            //        monto = this.textBoxX10.Text.Substring(3);
            //        this.textBoxX10.Text = this.textBoxX10.Text.Remove(3); 
            //    }
            //    this.textBoxX10.Text = string.Format("{0:N}", Convert.ToDouble(monto));
            //}
        }


        public void Reportes()
        {
            FormularioReportes.showReport(s1,"Empresas");

        }

        public void RealizarPago()
        {
            if (!this.textBoxX9.ReadOnly)
                MessageBox.Show("Debe de guardar los cambios antes de realizar esta operación", "Error", MessageBoxButtons.OK);
            else
            {
                RealizarPago pago = new RealizarPago(Convert.ToInt32(dt1.Rows[s1.Position].ItemArray.GetValue(0)));
                pago.ShowDialog();
            }
            
            //FormularioReportes.showReport(dt1, "Pagos");
        }

       

        private void textBoxX9_Validating_1(object sender, CancelEventArgs e)
        {
            //if (!this.textBoxX9.Text.Equals(""))
            //{
            //    string monto = this.textBoxX9.Text;
            //    if (this.textBoxX9.Text.Contains("C$"))
            //    {
            //        monto = this.textBoxX9.Text.Substring(3);
            //        this.textBoxX9.Text = this.textBoxX9.Text.Remove(3);
            //    }
            //    this.textBoxX9.Text += string.Format("C$ {0:N}", Convert.ToDouble(monto));
            //}
        }

        
    }
}
