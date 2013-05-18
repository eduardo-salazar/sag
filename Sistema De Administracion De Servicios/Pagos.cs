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
    public partial class Pagos : Form
    {
        DataTable PagoMemDT=new DataTable();
        private int codEmpresa=-1;
        DateTimePicker dtpFechaPago;
        
        public Pagos(string cuota,int codEmpresa)
        {
            this.codEmpresa=codEmpresa;
            InitializeComponent();
            this.lbTotalPago.Text = cuota;
            PagoMemDT = pago_MembresiaTableAdapter.GetDataByEmpresa(codEmpresa);
            //vistaPagos();
            PagoMemDT.Columns["perid_pago"].ColumnName = "Período de Pago";
            PagoMemDT.Columns["num_cuota"].ColumnName = "Número de Cuota";
            PagoMemDT.Columns["monto"].ColumnName = "Monto";
            PagoMemDT.Columns["fech_pago"].ColumnName = "Fecha de Pago";
            PagoMemDT.Columns["pagado"].ColumnName = "Estado";
            PagoMemDT.Columns["num_recib"].ColumnName = "Número de Recibo";
            PagoMemDT.Columns["observaciones"].ColumnName = "Observaciones";
            PagoMemDT.Columns["tipo"].ColumnName = "Tipo";
            this.dgPagosEmpresa.DataSource = PagoMemDT;
            this.domainNumCuotas.SelectedItem=5;
            dtpFechaPago = new DateTimePicker();
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Visible = false;
            dtpFechaPago.Width = this.dgPagosEmpresa.Columns[5].Width-5;
            this.dgPagosEmpresa.Controls.Add(dtpFechaPago);
            this.dtpFechaPago.ValueChanged += dtpFechaPago_ValueChanged;
            this.dgPagosEmpresa.CellBeginEdit += this.dgPagosEmpresa_CellBeginEdit;
            this.dgPagosEmpresa.CellEndEdit += this.dgPagosEmpresa_CellEndEdit;

        }
        void vistaPagos()
        {
            for (int i = 0; i < PagoMemDT.Rows.Count; i++)
            {
                if (PagoMemDT.Rows[i].ItemArray.GetValue(6).ToString().Equals("true"))
                {
                    PagoMemDT.Rows[i].ItemArray.SetValue("Pagado", 6);
                }
                else
                {
                    PagoMemDT.Rows[i].ItemArray.SetValue("Pendiente",6);
                }
            }
        }
        public Pagos(string cuota)
        {
            InitializeComponent();
            this.lbTotalPago.Text = cuota;
            this.domainNumCuotas.SelectedItem = 11;
            this.dgPagosEmpresa.DataBindings.Clear();
            this.dgPagosEmpresa.AllowUserToAddRows = false;
            dtpFechaPago = new DateTimePicker();
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Visible = false;
            dtpFechaPago.Width = 95;
            this.dgPagosEmpresa.Controls.Add(dtpFechaPago);
            this.dtpFechaPago.ValueChanged += dtpFechaPago_ValueChanged;
            this.dgPagosEmpresa.CellBeginEdit += this.dgPagosEmpresa_CellBeginEdit;
            this.dgPagosEmpresa.CellEndEdit += this.dgPagosEmpresa_CellEndEdit;

        }
        
        public void modoVisual() 
        {
            this.btnGenerarPagos.Enabled = false;
            this.btnBorrarPago.Enabled = false;
            this.domainNumCuotas.Enabled = false;
            this.cbFrequenciaPagos.Enabled = false;
            this.dgPagosEmpresa.ReadOnly = true;
        }
        public void modoEdicion()
        {
            this.btnGenerarPagos.Enabled = true;
            this.btnBorrarPago.Enabled = true;
            this.domainNumCuotas.Enabled = true;
            this.cbFrequenciaPagos.Enabled = true;
            this.dgPagosEmpresa.ReadOnly = false;
            this.dgPagosEmpresa.AllowUserToAddRows = true;
        }
        private void Pagos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cADINDataSet.Pago_Membresia' table. You can move, or remove it, as needed.
            //if (codEmpresa!=-1)
            //    this.pago_MembresiaTableAdapter.FillByEmpresa(this.cADINDataSet.Pago_Membresia, codEmpresa);
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void domainNumCuotas_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dgPagosEmpresa_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (this.dgPagosEmpresa.Focused && this.dgPagosEmpresa.CurrentCell.ColumnIndex == 5)
            {
                dtpFechaPago.Location = this.dgPagosEmpresa.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                dtpFechaPago.Visible = true;
                DateTime a;
                if (this.dgPagosEmpresa.CurrentCell.Value != DBNull.Value)
                {
                    a = Convert.ToDateTime(this.dgPagosEmpresa.CurrentCell.Value);
                    dtpFechaPago.Value = a;
                }
                else
                {
                    dtpFechaPago.Value = Convert.ToDateTime("01-Jan-01 12:00:00 AM");
                }
                
            }
            else
            {
                dtpFechaPago.Visible = false;
            }
        }

        private void dgPagosEmpresa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgPagosEmpresa.Focused && this.dgPagosEmpresa.CurrentCell.ColumnIndex == 5)
            {
                this.dgPagosEmpresa.CurrentCell.Value = dtpFechaPago.Value.ToString("dd/MMM/yyyy");
            }
        }

        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            this.dgPagosEmpresa.CurrentCell.Value = dtpFechaPago.Value.ToString("dd/MMM/yyyy");
        }
        
        private void dgPagosEmpresa_DataSourceChanged(object sender, EventArgs e)
        {
            this.dgPagosEmpresa.Columns[0].Visible = false;
            this.dgPagosEmpresa.Columns[1].Visible = false;
            this.dgPagosEmpresa.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgPagosEmpresa.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgPagosEmpresa.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgPagosEmpresa.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgPagosEmpresa.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgPagosEmpresa.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            this.dgPagosEmpresa.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            

        }

       

        

        

       


       
    }
}
