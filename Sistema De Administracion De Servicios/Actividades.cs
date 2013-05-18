using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class Actividades : Form
    {
        CADINDataSetTableAdapters.CasoTableAdapter cta;
        CADINDataSetTableAdapters.ActividadesTableAdapter ata;
        CADINDataSetTableAdapters.Solicitud_ApoyoTableAdapter sata;
        CADINDataSetTableAdapters.Tipo_ActividadTableAdapter tata;
        CADINDataSet.ActividadesDataTable adt;
        CADINDataSet.Solicitud_ApoyoDataTable sadt;
        CADINDataSet.Tipo_ActividadDataTable tadt;
        BindingSource s2, s3, s4;
        int cod_Usua;
        int ca, cc, cfa, c_caso;

        public Actividades(bool modo2, System.Data.DataRow s, int cod_Usuario, int cod_caso)
        {
            
            InitializeComponent();

            cta = new CADINDataSetTableAdapters.CasoTableAdapter();
            ata = new CADINDataSetTableAdapters.ActividadesTableAdapter();
            sata = new CADINDataSetTableAdapters.Solicitud_ApoyoTableAdapter();
            tata = new CADINDataSetTableAdapters.Tipo_ActividadTableAdapter();

            s2 = new BindingSource();
            s3 = new BindingSource();
            s4 = new BindingSource();

            adt = ata.GetData();
            sadt = sata.GetData();
            tadt = tata.GetData();

            s2.DataSource = adt;
            //s2.DataSource = s;
            s3.DataSource = sadt;
            s4.DataSource = tadt;

            cbTipSolic.DataSource = s3;
            cbTipSolic.DisplayMember = "nombre";
            cbTipSolic.ValueMember = "cod_soli";

            cbTipoAct.DataSource = s4;
            cbTipoAct.DisplayMember = "nombre";
            cbTipoAct.ValueMember = "cod_tact";

            cfa = cod_Usuario;
            c_caso = cod_caso;

            if ((modo2 == false) && (Convert.ToInt32(s["cod_actv"].ToString()) == -1))
                modo2 = true;
            else
            {
                if (modo2 == true)
                {
                    limpiarControles();
                }
                else
                {
                    btnAgregarAct.Visible = false;
                    btnCambiosAct.Visible = true;

                    ca = Convert.ToInt32(s["cod_actv"].ToString());
                    cc = Convert.ToInt32(s["cod_caso"].ToString());
                    
                    
                    ipFechProg.Value = Convert.ToDateTime(s["fech_prog"].ToString());
                    //ipFechProg.DataBindings.Add("Value", s2, "fech_prog");
                    chkbRealizado.Checked = Convert.ToBoolean(s["realizado"].ToString());
                    //chkbRealizado.DataBinding.Add("Checked", s2, "realizado");
                    chkbActCerrada.Checked = Convert.ToBoolean(s["acti_cerrada"].ToString());
                    //chkbActCerrada.DataBindings.Add("Checked", s2, "acti_cerrada");
                    string fecha = s["fech_cierre"].ToString();
                    if (fecha == "")
                    {
                        ipFechCierre.IsEmpty = true;
                    }
                    else
                    {
                        ipFechCierre.Value = Convert.ToDateTime(fecha);
                    }
                    //ipFechCierre.DataBindings.Add("Value", s2, "fech_cierre");
                    txRef.Text = s["referencia"].ToString();
                    //txRef.DataBindings.Add("Text", s2, "referencia");
                    txObservacionesA.Text = s["observaciones"].ToString();
                    //txObservacionesA.DataBindings.Add("Text", s2, "observaciones");
                    cbTipoAct.SelectedValue = Convert.ToInt32(s["cod_tact"].ToString());
                    //cbTipoAct.DataBindings.Add("SelectedValue", s2, "cod_tact");
                    cbTipSolic.SelectedValue = Convert.ToInt32(s["cod_soli"].ToString());
                    //cbTipSolic.DataBindings.Add("SelectedValue", s2, "cod_soli");
                }
            }
        }

       /* public Actividades(bool modo2, BindingSource s)
        {
            InitializeComponent();

            cta = new CADINDataSetTableAdapters.CasoTableAdapter();
            ata = new CADINDataSetTableAdapters.ActividadesTableAdapter();
            sata = new CADINDataSetTableAdapters.Solicitud_ApoyoTableAdapter();
            tata = new CADINDataSetTableAdapters.Tipo_ActividadTableAdapter();

            s2 = new BindingSource();
            s3 = new BindingSource();
            s4 = new BindingSource();

            //adt = ata.GetData();
            sadt = sata.GetData();
            tadt = tata.GetData();

            //s2.DataSource = adt;
            s2 = s;
            s3.DataSource = sadt;
            s4.DataSource = tadt;
            
            cbTipSolic.DataSource = s3;
            cbTipSolic.DisplayMember = "nombre";
            cbTipSolic.ValueMember = "cod_soli";

            cbTipoAct.DataSource = s4;
            cbTipoAct.DisplayMember = "nombre";
            cbTipoAct.ValueMember = "cod_tact";
            DataTable dt=(DataTable)s.DataSource;
            ipFechProg.Text = dt.Rows[s.IndexOf(s.Current)]["fech_prog"].ToString();
            ipFechProg.DataBindings.Add("Value", s2, "fech_prog");
            chkbRealizado.DataBindings.Add("Checked", s2, "realizado");
            chkbActCerrada.DataBindings.Add("Checked", s2, "acti_cerrada");
            ipFechCierre.DataBindings.Add("Value", s2, "fech_cierre");
            txRef.DataBindings.Add("Text", s2, "referencia");
            txObservacionesA.DataBindings.Add("Text", s2, "observaciones");
            cbTipoAct.DataBindings.Add("SelectedValue", s2, "cod_tact");
            cbTipSolic.DataBindings.Add("SelectedValue", s2, "cod_soli");

            if (modo2 == true)
            {
                limpiarControles();
            }
            else
            {
                btnAgregarAct.Visible = false;
                btnCambiosAct.Visible = true;
                btnInicio.Enabled = true;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
                btnFinal.Enabled = true;
            }
        } */

        private void limpiarControles()
        {
            cbTipSolic.Text = "";
            cbTipoAct.Text = "";
            ipFechProg.IsEmpty = true;
            chkbRealizado.Checked = false;
            chkbActCerrada.Checked = false;
            ipFechCierre.IsEmpty = true;
            txRef.Clear();
            txObservacionesA.Clear();
        }



        private void Actividades_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarAct_Click(object sender, EventArgs e)
        {
            if (superValidator1.Validate())
            {
                                
                DateTime d = Convert.ToDateTime("01/01/0001");
                if (ipFechCierre.Value == d)
                    ata.Insert(c_caso, Convert.ToInt32(cbTipSolic.SelectedValue),
                        Convert.ToInt32(cbTipoAct.SelectedValue), cfa, txRef.Text, ipFechProg.Value,
                        chkbRealizado.Checked, chkbActCerrada.Checked, null, txObservacionesA.Text);
                else
                    ata.Insert(c_caso, Convert.ToInt32(cbTipSolic.SelectedValue),
                        Convert.ToInt32(cbTipoAct.SelectedValue), cfa, txRef.Text, ipFechProg.Value,
                        chkbRealizado.Checked, chkbActCerrada.Checked, ipFechCierre.Value, txObservacionesA.Text);

                MessageBox.Show("Actividad Guardada");


                this.Close();
            }
            else
                MessageBox.Show("Revisar Campos Requeridos");
            
        }

        
        private void btnCambiosAct_Click(object sender, EventArgs e)
        {
            DateTime d = Convert.ToDateTime("01/01/0001");
            if (ipFechCierre.Value == d)
            {
                ata.UpdateQuery2((int)cbTipSolic.SelectedValue, (int)cbTipoAct.SelectedValue, txRef.Text, ipFechProg.Value,
                    chkbRealizado.Checked, chkbActCerrada.Checked, txObservacionesA.Text,ca, cc);
            }
            else
            {
                ata.UpdateQuery1((int)cbTipSolic.SelectedValue, (int)cbTipoAct.SelectedValue, txRef.Text, ipFechProg.Value,
                   chkbRealizado.Checked, chkbActCerrada.Checked, ipFechCierre.Value, txObservacionesA.Text, ca, cc);
            }

            
            
           MessageBox.Show("Cambios Realizados");
           this.Close();
        }

        private void Actividades_FormClosed(object sender, FormClosedEventArgs e)
        {

        } 

        public void setUser(int cod_Usua) {
            this.cod_Usua = cod_Usua;
        }
    }
}
