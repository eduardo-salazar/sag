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
    public partial class ControlFiltroBusqueda : UserControl
    {
        DataRow[] foundedRows;
        Boolean found;
        int i = -1;

        DataTable dtSource;
        BindingSource bsSource;
        String dataType;
        String initialFilter;

        public ControlFiltroBusqueda()
        {
            InitializeComponent();
        }

        public BindingSource bindingSource {
            get { return this.bsSource; }
            set {
                if (value != null)
                {
                    bsSource = value;
                    //
                    this.dtSource = (DataTable)bsSource.DataSource;
                    List<DataColumn> columns = new List<DataColumn>();
                    foreach (DataColumn column in dtSource.Columns)
                    {
                        if(column.Caption.Length!=0)
                            columns.Add(column);
                    }
                    this.cboCampo.DataSource = columns;
                    this.cboCampo.DisplayMember = "Caption";
                    this.cboCampo.ValueMember = "ColumnName";
                    DataTable bo = new DataTable();
                    bo.Columns.Add("display");
                    bo.Columns.Add("value");
                    bo.Rows.Add("Si", true);
                    bo.Rows.Add("No", false);
                    this.cboValor.DataSource = bo;
                    this.cboValor.DisplayMember = "display";
                    this.cboValor.ValueMember = "value";
                    this.cboModo.SelectedIndex = 0;
                    this.cboCampo.SelectedIndex = 0;
                    txtFiltro.Text = bsSource.Filter;
                    initialFilter = bsSource.Filter;
                    if (txtFiltro.Text.Length != 0)
                    {
                        cboClausula.Enabled = true;
                        cboClausula.SelectedIndex = 0;
                    }
                    this.dataGridViewX1.DataSource = this.bsSource;
                    if (dtSource.PrimaryKey.Length > 1)
                        btnBuscarSiguiente.Enabled = false;
                }
                else
                    bsSource = null;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                String operador;
                //if (dgvFiltro.Rows.Count == 0)
                if (!cboClausula.Enabled)
                {
                    operador = "";
                    //if(dgvFiltro.Rows.Count!=0 || txtFiltro.Text.Trim().Length!=0)
                    //    cboClausula.Enabled = true;
                    cboClausula.SelectedIndex = 0;
                }
                else
                {
                    operador = cboClausula.SelectedItem.ToString();
                }
                String campo = ((DataColumn)cboCampo.SelectedItem).ColumnName;
                String expresion = cboModo.SelectedItem.ToString();
                String valor;
                if (dataType.Equals("System.DateTime"))
                    valor = dtpValor.Value.ToString();
                else if (dataType.Equals("System.Boolean"))
                    valor = ((DataRowView)cboValor.SelectedItem)["value"].ToString();
                else
                {
                    if ((dataType.Equals("System.Int32") || dataType.Equals("System.Double"))&&txtValor.Text.Length==0 ) {
                        return;
                    }
                    valor = txtValor.Text;
                }
                dgvFiltro.Rows.Add(operador, campo, expresion, valor);
                txtFiltro.Text = getFilter();
                resetFoundedControls();
                cboClausula.Enabled = true;
            
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValor.Clear();
            dtpValor.ResetText();
            DataColumn selectedColumn = (DataColumn)this.cboCampo.SelectedItem;
            DataColumn column = dtSource.Columns[selectedColumn.ColumnName];
            dataType = column.DataType.ToString();
            if (dataType.Equals("System.String"))
            {
                txtValor.MaxLength = column.MaxLength;
                dtpValor.Visible = false;
                txtValor.Visible = true;
                cboValor.Visible = false;
            }
            else if (dataType.Equals("System.DateTime"))
            {
                txtValor.MaxLength = 10;
                dtpValor.Visible = true;
                txtValor.Visible = false;
                cboValor.Visible = false;
            }
            else if (dataType.Equals("System.Int32") || dataType.Equals("System.Double"))
            {
                txtValor.MaxLength = 10;
                dtpValor.Visible = false;
                txtValor.Visible = true;
                cboValor.Visible = false;
            }
            else if (dataType.Equals("System.Boolean"))
            {
                dtpValor.Visible = false;
                txtValor.Visible = false;
                cboValor.Visible = true;
            }
        }

        private String getFilter()
        {
            String filter = "";
            if (initialFilter == null)
                initialFilter = "";
            if(initialFilter.Length!=0)
                filter+="(" + initialFilter + ") ";
            for (int i = 0; i < dgvFiltro.Rows.Count; i++)
            {
                if (cboClausula.Enabled)
                    filter += " " + dgvFiltro["operador", i].Value + " ";
                filter += "( [";
                filter += dgvFiltro["campo", i].Value;
                filter += "] " + dgvFiltro["expresion", i].Value;
                filter += " '" + dgvFiltro["valor", i].Value + "'";
                filter += " )";
            }
            return filter;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            if (dataType.Equals("System.Int32"))
            {
                if (!(Char.IsDigit(c) || Char.IsControl(c)))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.bsSource.Filter = getFilter();
            etiEncontrados.Visible = true;
            txtEncontrados.Visible = true;
            txtEncontrados.Text = "" + bsSource.Count;
            txtFiltro.Text = bsSource.Filter;
        }

        private void btnBuscarSiguiente_Click(object sender, EventArgs e)
        {
            if (!found && getFilter().Trim().Length!=0)
            {
                String filter = getFilter();
                foundedRows = dtSource.Select(getFilter());
                if (foundedRows.Length != 0)
                {
                    found = true;
                }
            }
            if (found)
            {
                if (i == foundedRows.Length - 1)
                {
                    i = -1;
                    MessageBox.Show("No se encontraron mas registros");
                }
                else
                {
                    i++;
                    bsSource.Position = bsSource.Find(dtSource.PrimaryKey[0].ToString(), foundedRows[i][0]);
                }
                etiEncontrados.Visible = true;
                txtEncontrados.Visible = true;
                txtEncontrados.Text = "" + foundedRows.Length;
            }
            else
                MessageBox.Show("No se encontró el registro");
        }

        private void resetFoundedControls()
        {
            found = false;
            foundedRows = null;
            txtEncontrados.Text = "";
            txtEncontrados.Visible = false;
            etiEncontrados.Visible = false;
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            cboClausula.Enabled = false;
            txtFiltro.Text = "";
            initialFilter = "";
            resetFoundedControls();
            dgvFiltro.Rows.Clear();
            bsSource.Filter = "";
        }

        private void dgvFiltro_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvFiltro.Rows.Count == 0 && initialFilter.Trim().Length==0)
            {
                cboClausula.Enabled = false;
            }
            txtFiltro.Text=getFilter();
        }
    }
}
