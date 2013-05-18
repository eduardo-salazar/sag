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
    public partial class RealizarPago : Form
    {
        ReportesDataSetTableAdapters.ReciboTableAdapter reciboTa;
        ReportesDataSet.ReciboDataTable reciboDt;
        CADINDataSetTableAdapters.Pago_MembresiaTableAdapter tableAdapaterPagos;
        CADINDataSetTableAdapters.ReciboTableAdapter tableAdapterRecibos;
        CADINDataSet.Pago_MembresiaDataTable dataTable;
        double montoPago=0;
        double montoPendiente = 0;
        int codigo = 0;
        //Variable temporal 
        int contPago=0;//sirve para simular el pagado de una membresia para que cambie a la suguiente tupla cuando se agrega un pago de mem...
        public RealizarPago(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            tableAdapaterPagos=new CADINDataSetTableAdapters.Pago_MembresiaTableAdapter();
            tableAdapterRecibos = new CADINDataSetTableAdapters.ReciboTableAdapter();
            dataTable = tableAdapaterPagos.GetDataByEmpresa(codigo);
            this.fechaPago.Value = DateTime.Today;
            this.lbDinamico.Visible = false;
            this.txtDinamico.Visible = false;
            this.btnBuscarCaso.Visible = false;
            this.comboMoneda.SelectedIndex = 0;
            calcularSaldoPendiente();
            this.btnAgregarPago.Click+=new EventHandler(btnAgregarPago_Click);
            //Eventos Radios
            this.radioMembresia.MouseClick+=new MouseEventHandler(radioMembresia_MouseClick);
            this.radioCaso.MouseClick+=new MouseEventHandler(radioCaso_MouseClick);
            this.radioOtro.MouseClick+=new MouseEventHandler(radioOtro_MouseClick);

            //Evento para que se actualice el total del datagrid cuando editan un monto en el datagrid
            this.dataGridDescripcionPago.CellEndEdit+=new DataGridViewCellEventHandler(dataGridDescripcionPago_CellEndEdit);

            //Evento para que autocomplete la descripcion cuando editan el monto a pagar
            this.txtMonto.Validated+=new EventHandler(txtMonto_TextChanged);

            //Evento cuando eliminen alguna fila del datagrid
            this.dataGridDescripcionPago.UserDeletingRow+=new DataGridViewRowCancelEventHandler(dataGridDescripcionPago_UserDeletingRow);
            this.dataGridDescripcionPago.UserDeletedRow+=new DataGridViewRowEventHandler(dataGridDescripcionPago_UserDeletedRow);
        }
        private double calcularSaldoPendiente() 
        {
            foreach (DataRow row in dataTable)
            {
                if (row.ItemArray.GetValue(6).Equals(false))
                {
                    montoPendiente += Convert.ToDouble(row.ItemArray.GetValue(4).ToString());
                }
            }
            return montoPendiente;
        }
        private bool esUltima(int rowIndex)
        {
            while (rowIndex!=(this.dataGridDescripcionPago.Rows.Count-1))
            {
                if (Convert.ToInt32(this.dataGridDescripcionPago.Rows[rowIndex + 1].Cells[2].Value) != 1)
                {
                    rowIndex++;
                }
                else
                {
                    break;
                }
            }
            if (rowIndex == (this.dataGridDescripcionPago.Rows.Count - 1))
            {
                return true;
            }
            return false;
        }
        void dataGridDescripcionPago_UserDeletedRow(Object sender, DataGridViewRowEventArgs e)
        {
            if (this.dataGridDescripcionPago.Rows.Count == 1)
            {
                this.dataGridDescripcionPago.Rows.RemoveAt(0);
            }
            else
            {
                actualizarTotal();
            }

        }
        void dataGridDescripcionPago_UserDeletingRow(Object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!esUltima(e.Row.Index))
            {
                MessageBox.Show("Existe otro pago de Membresia posterior", "Error", MessageBoxButtons.OK);
                e.Cancel = true;
            }
            else
            {
                contPago--;
                llenarPagoNuevaMembresia(contPago);
            }
        }
        void radioOtro_MouseClick(object sender, EventArgs e)
        {
            this.lbDinamico.Visible = false;
            this.txtDinamico.Visible = false;
            this.btnBuscarCaso.Visible = false;
            this.txtMonto.Text = "";
            this.txtDescripcion.Text = "";
            this.txtDescripcion.Enabled = true;
        }
        void radioCaso_MouseClick(object sender, EventArgs e)
        {
            this.lbDinamico.Text = "Cod Caso:";
            this.txtDinamico.Text = "";
            this.btnBuscarCaso.Visible = true;
            this.lbDinamico.Visible = true;
            this.txtDinamico.Visible = true;
            this.txtMonto.Text = "";
            this.txtDescripcion.Text = "";
            
            this.txtDescripcion.Text = "Pago por caso ";
            this.txtDinamico.Enabled = false;
        }
        void dataGridDescripcionPago_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                actualizarTotal();
            }
        }
        void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (this.radioMembresia.Checked && this.montoPago != 0)
            {
                if (this.txtMonto.Text!="")
                {
                    if (Convert.ToDouble(this.txtMonto.Text) > montoPago)
                    {
                        if (txtDescripcion.Text.Contains("+ Abono"))
                        {
                            txtDescripcion.Text = txtDescripcion.Text.Replace("+ Abono", "");
                        }
                        if (txtDescripcion.Text.Contains("Abono"))
                        {
                            txtDescripcion.Text = txtDescripcion.Text.Replace("Abono", "");
                            txtDescripcion.Text = txtDescripcion.Text.TrimStart();
                        }
                        this.txtDescripcion.Text = txtDescripcion.Text.TrimEnd() + " + Abono ";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtMonto.Text) < montoPago)
                        {
                            if (txtDescripcion.Text.Contains("+ Abono"))
                            {
                                txtDescripcion.Text = txtDescripcion.Text.Replace("+ Abono", "");
                            }
                            if (!txtDescripcion.Text.Contains("Abono"))
                            {
                                txtDescripcion.Text = "Abono " + txtDescripcion.Text;
                            }
                        }
                        else
                        {
                            if (txtDescripcion.Text.Contains("+ Abono"))
                            {
                                txtDescripcion.Text = txtDescripcion.Text.Replace("+ Abono", "");
                            }
                            if (txtDescripcion.Text.Contains("Abono"))
                            {
                                txtDescripcion.Text = txtDescripcion.Text.Replace("Abono","");
                                txtDescripcion.Text = txtDescripcion.Text.TrimStart();
                            }
                        }
                    }
                }
            }
        }
        void btnAgregarPago_Click(object sender, EventArgs e)
        {
            if (this.txtDescripcion.Text!="")
            {
                if (true)
                {
                    if (this.dataGridDescripcionPago.Rows.Count > 0)
                    {
                        this.dataGridDescripcionPago.Rows.RemoveAt(this.dataGridDescripcionPago.Rows.Count - 1);
                    }
                    this.dataGridDescripcionPago.Rows.Add();
                    this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 1].Cells[0].Value = txtDescripcion.Text;
                    this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 1].Cells[1].Value = "$ " + txtMonto.Text;
                    this.dataGridDescripcionPago.Rows.Add();
                    this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 1].Cells[0].Value = "Total";
                    this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 1].Cells[1].Value = "$ " + calcularTotal();

                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.Font = new Font(this.dataGridDescripcionPago.Font, FontStyle.Bold);
                    this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 1].DefaultCellStyle = style;
                    if (radioMembresia.Checked)
                    {
                        this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 2].Cells[2].Value = 1;
                        llenarPagoNuevaMembresia(++contPago);

                        
                        this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 2].Cells["peri_pago"].Value = txtDinamico.Text;
                        montoPendiente = montoPendiente - Convert.ToDouble(txtMonto.Text);
                        this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 2].Cells["monto_pend"].Value = montoPendiente;
                        
                        //obtener el numero de pago
                        int contador = 0;
                        foreach (DataRow row in dataTable)
                        {
                            if (row.ItemArray.GetValue(6).Equals(false))
                            {
                                if (contador == contPago-1)
                                {
                                    this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 2].Cells["num_pago"].Value=row.ItemArray.GetValue(0);
                                    this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 2].Cells["monto_Pago"].Value = row.ItemArray.GetValue(4);
                                    break;
                                }
                                else
                                {
                                    contador++;
                                }
                            }
                        }
                        
                    }
                    else
                    {
                        if (radioCaso.Checked)
                        {
                            this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 2].Cells[2].Value = 2;
                            if (txtDinamico.Text != "")
                                this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 2].Cells["cod_caso"].Value = txtDinamico.Text;
                            else
                                MessageBox.Show("Debe de seleccionar el caso el cual se pagará","Error",MessageBoxButtons.OK);
                        }
                        else
                        {
                            this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 2].Cells[2].Value = 3;
                        }
                    }
                    this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 2].Cells["fecha"].Value = fechaPago.Value.ToString("dd/MM/yyyy");
                    this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 2].Cells["observaciones"].Value = txtObservacion.Text;
                }
            }
        }
        private double calcularTotal()
        {
            double total=0;
            DataGridViewRow row;
            for (int i = 0; i < this.dataGridDescripcionPago.Rows.Count-1; i++)
            {
                row = this.dataGridDescripcionPago.Rows[i];
                total += (row.Cells[1].Value.Equals("")) ? 0 : Convert.ToDouble(row.Cells[1].Value.ToString().Substring(1));
            }
            return total;
        }
        private void actualizarTotal()
        {
            this.dataGridDescripcionPago.Rows[this.dataGridDescripcionPago.Rows.Count - 1].Cells[1].Value = calcularTotal();
        }
        private void llenarPagoNuevaMembresia(int veces)
        {
            int contador = 0;
            foreach (DataRow row in dataTable)
            {
                if (row.ItemArray.GetValue(6).Equals(false))
                {
                    if (contador == contPago)
                    {
                        this.btnBuscarCaso.Visible = false;
                        this.txtDinamico.Text = row.ItemArray.GetValue(2).ToString();
                        this.montoPago = Convert.ToDouble(row.ItemArray.GetValue(4).ToString());
                        this.txtMonto.Text = montoPago.ToString();
                        this.comboMoneda.SelectedIndex = 0;
                        DateTime fecha = Convert.ToDateTime(row.ItemArray.GetValue(5));
                        this.txtDescripcion.Text = "Membresia " + fecha.ToString("MMMM") +" "+ this.txtDinamico.Text;
                        break;
                    }
                    else
                    {
                        contador++;
                    }
                }
            }

            if (this.txtDinamico.Text != "")
            {
                this.lbDinamico.Visible = true;
                this.lbDinamico.Text = "Período: ";
                this.txtDinamico.Visible = true;
            }
            else
            {
                MessageBox.Show("No hay ningun pago Relacionado a Membresia", "Advertencia", MessageBoxButtons.OK);
            }


        }

        void radioMembresia_MouseClick(object sender, EventArgs e)
        {
            llenarPagoNuevaMembresia(contPago);
            this.txtDescripcion.Enabled = false;
            this.txtDinamico.Enabled = false;
        }
        int num_recibo = 0;
        private bool insertarMembresia(DataGridViewRow row)
        { 
            string descripcion=row.Cells[0].Value.ToString();
            double monto=Convert.ToDouble(row.Cells[1].Value.ToString().Substring(1));
            DateTime fecha=Convert.ToDateTime(row.Cells["fecha"].Value);
            int periodoPago=Convert.ToInt32(row.Cells["peri_pago"].Value);
            string personaPagar=txtNombreCliente.Text;
            string personaRecibe=txtRecibidoPor.Text;
            double montopendiente=montoPendiente;
            string observaciones=row.Cells["observaciones"].Value.ToString();
            
            string consulta;
            SqlCommand comand;

            try
            {
                tableAdapterRecibos.Insert(codigo, descripcion, true, false, null, false, monto, "C", fecha, periodoPago, personaPagar, personaRecibe, montoPendiente, observaciones);
                consulta = "select MAX(num_recib) from Recibo";
                SqlDataAdapter da = new SqlDataAdapter(consulta, tableAdapterRecibos.Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                DataTable table = new DataTable();
                da.Fill(table);
                num_recibo = Convert.ToInt32(table.Rows[0].ItemArray.GetValue(0));
                //Marcar como pagado 

                consulta = "Update Pago_Membresia set pagado=1,num_recib=" + num_recibo + " where num_pago=" + row.Cells["num_pago"].Value + ";";
                comand = new SqlCommand(consulta, tableAdapaterPagos.Connection);
                comand.Connection.Open();
                comand.ExecuteNonQuery();
                comand.Connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            if (monto > Convert.ToDouble(row.Cells["monto_Pago"].Value))
            {
                consulta = "Update Pago_Membresia set monto="+monto+" where num_pago=" + row.Cells["num_pago"].Value + ";";
                comand = new SqlCommand(consulta, tableAdapaterPagos.Connection);
                comand.Connection.Open();
                comand.ExecuteNonQuery();
                comand.Connection.Close();

                int contador = 0;
                foreach (DataRow row3 in dataTable)
                {
                    if (row3.ItemArray.GetValue(6).Equals(false))
                    {
                        if (contador == contPago)
                        {
                            monto = monto - Convert.ToDouble(row.Cells["monto_Pago"].Value);
                            consulta = "Update Pago_Membresia set monto=" + monto + " where num_pago=" + row3.ItemArray.GetValue(0)+ ";";
                            comand = new SqlCommand(consulta, tableAdapaterPagos.Connection);
                            comand.Connection.Open();
                            comand.ExecuteNonQuery();
                            comand.Connection.Close();
                            break;
                        }
                        else
                        {
                            contador++;
                        }
                    }
                }
            }

            return true;
        }
        private void insertarCaso(DataGridViewRow row)
        {

            string descripcion = row.Cells[0].Value.ToString();
            int cod_caso = Convert.ToInt32(row.Cells["cod_caso"].Value);
            double monto = Convert.ToDouble(row.Cells[1].Value.ToString().Substring(1));
            DateTime fecha = Convert.ToDateTime(row.Cells["fecha"].Value);
            string personaPagar = txtNombreCliente.Text;
            string personaRecibe = txtRecibidoPor.Text;
            double montopendiente = 0;
            string observaciones = row.Cells["observaciones"].Value.ToString();

            tableAdapterRecibos.Insert(codigo,descripcion,false,true,cod_caso,false,monto,"C",
                        fecha,0,personaPagar,personaRecibe,montopendiente,observaciones);
            //---------------------------------------------------------------------------
            //Este codigo es necesario para que se asigne el num_factura el num_recb corespondiente
            string consulta = "select MAX(num_recib) from Recibo";
            SqlDataAdapter da = new SqlDataAdapter(consulta, tableAdapterRecibos.Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataTable table = new DataTable();
            da.Fill(table);
            num_recibo = Convert.ToInt32(table.Rows[0].ItemArray.GetValue(0));
            //-----------------------------------------------------------------------------
            string consulta2 = "Update Recibo set peri_pago='NULL'where num_recib=" + num_recibo + ";";
            SqlCommand comand = new SqlCommand(consulta2, tableAdapterRecibos.Connection);
            comand.Connection.Open();
            comand.ExecuteNonQuery();
            comand.Connection.Close();

            tableAdapaterPagos.Insert(codigo,0,0,monto,fecha,true,num_recibo,observaciones,2);
            //---------------------------------------------------------------------------
            //Este codigo es necesario para que se asigne el num_factura el num_recb corespondiente
            consulta = "select MAX(num_pago) from Pago_Membresia";
            da = new SqlDataAdapter(consulta, tableAdapaterPagos.Connection);
            builder = new SqlCommandBuilder(da);
            table = new DataTable();
            da.Fill(table);
            int num_pago = Convert.ToInt32(table.Rows[0].ItemArray.GetValue(0));
            //-----------------------------------------------------------------------------
            consulta2 = "Update Pago_Membresia set peri_pago='NULL',num_cuota='NULL' where num_recib=" + num_pago + ";";
            comand = new SqlCommand(consulta2, tableAdapterRecibos.Connection);
            comand.Connection.Open();
            comand.ExecuteNonQuery();
            comand.Connection.Close();

        }
        private void insertarOtro(DataGridViewRow row)
        {
            string descripcion = row.Cells[0].Value.ToString();
            double monto = Convert.ToDouble(row.Cells[1].Value.ToString().Substring(1));
            DateTime fecha = Convert.ToDateTime(row.Cells["fecha"].Value);
            string personaPagar = txtNombreCliente.Text;
            string personaRecibe = txtRecibidoPor.Text;
            double montopendiente = 0;
            string observaciones = row.Cells["observaciones"].Value.ToString();
            SqlCommand comand=null;
            try
            {
                tableAdapterRecibos.Insert(codigo, descripcion, false, false, null, true, monto, "C",
                       fecha, 0, personaPagar, personaRecibe, montopendiente, observaciones);
                //---------------------------------------------------------------------------
                //Este codigo es necesario para que se asigne el num_factura el num_recb corespondiente
                string consulta = "select MAX(num_recib) from Recibo";
                SqlDataAdapter da = new SqlDataAdapter(consulta, tableAdapterRecibos.Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                DataTable table = new DataTable();
                da.Fill(table);
                num_recibo = Convert.ToInt32(table.Rows[0].ItemArray.GetValue(0));
                //-----------------------------------------------------------------------------
                string consulta2 = "Update Recibo set peri_pago=NULL where num_recib=" + num_recibo + ";";
                comand = new SqlCommand(consulta2, tableAdapterRecibos.Connection);
                comand.Connection.Open();
                comand.ExecuteNonQuery();
                comand.Connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ". No se ingreso el Recibo");
            }
            finally
            {
                //comand.Connection.Close();
            }
            try
            {
                tableAdapaterPagos.Insert(codigo, 0, 0, monto, fecha, true, num_recibo, observaciones, 3);
                //---------------------------------------------------------------------------
                //Este codigo es necesario para que se asigne el num_factura el num_recb corespondiente
                string consulta3 = "select MAX(num_pago) from Pago_Membresia";
                SqlDataAdapter da1 = new SqlDataAdapter(consulta3, tableAdapaterPagos.Connection);
                SqlCommandBuilder builder1 = new SqlCommandBuilder(da1);
                DataTable table1 = new DataTable();
                da1.Fill(table1);
                int num_pago = Convert.ToInt32(table1.Rows[0].ItemArray.GetValue(0));
                //-----------------------------------------------------------------------------
                string consulta4 = "Update Pago_Membresia set perid_pago=NULL,num_cuota=NULL where num_recib=" + num_pago + ";";
                comand = new SqlCommand(consulta4, tableAdapterRecibos.Connection);
                comand.Connection.Open();
                comand.ExecuteNonQuery();
                comand.Connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ". No se ingreso el Pago");
            }
            finally
            {
                comand.Connection.Close();
            }
           
        }
        string num_factura="R764";
        private void btnCrearRecibo_Click(object sender, EventArgs e)
        {
            int i = 0;//variable para que se asigne el codigo del primer recibo
            bool estado = true;
            foreach (DataGridViewRow row in this.dataGridDescripcionPago.Rows)
            {
                if (Convert.ToInt32(row.Cells[2].Value) == 1)
                {
                    insertarMembresia(row);
                }
                else
                {
                    if (Convert.ToInt32(row.Cells[2].Value) == 2)
                    {
                        insertarCaso(row);
                    }
                    else
                    {

                        if (Convert.ToInt32(row.Cells[2].Value)==3)
                        {
                            insertarOtro(row); 
                        }
                    }
                }
                if (i == 0)
                {
                    if (num_recibo.ToString().Length < 4)
                    {
                        for (int j = 0; j < 4 - num_recibo.ToString().Length; j++)
                        {
                            num_factura += "0";
                        }
                        num_factura += num_recibo;
                    }
                    else 
                    {
                        int num_recibo2 = Convert.ToInt32(num_recibo.ToString().Substring(num_recibo.ToString().Length-4,num_recibo.ToString().Length-1));
                        num_factura += num_recibo2;
                    }
                    i++;
                }

                SqlCommand comand=null;
                try
                {
                    string consulta = "Update Recibo set num_factura='" + num_factura + "'where num_recib=" + num_recibo + ";";
                    comand = new SqlCommand(consulta, tableAdapterRecibos.Connection);
                    comand.Connection.Open();
                    comand.ExecuteNonQuery();
                    comand.Connection.Close();

                }
                catch (Exception ex)
                {
                    estado = false;
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    comand.Connection.Close();
                }
            }
            if (estado)
            {

                try
                {
                    reciboTa = new ReportesDataSetTableAdapters.ReciboTableAdapter();
                    BindingSource binding = new BindingSource();
                    reciboDt = new ReportesDataSet.ReciboDataTable();
                    reciboDt = reciboTa.GetDataBy(codigo, num_factura);
                    binding.DataSource = reciboDt;
                    FormularioReportes.showReport(binding, "Recibos");
                    this.Close();
                }
                catch (Exception)
                {
                    
                    throw;
                }
                
            }
            
        }
        Casos_View f;
        private void btnBuscarCaso_Click(object sender, EventArgs e)
        {
            f = new Casos_View(codigo);
            f.dataGridViewX1.CellDoubleClick+=new DataGridViewCellEventHandler(dataGridViewX1_CellDoubleClick);
            f.ShowDialog();

        }
        void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtDinamico.Text = f.getCodigo(e.RowIndex).ToString();
            f.Dispose();
        }
    }
}
