using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class FormBusqueda : Form
    {
        DataTable dtSource;
        BindingSource bsSource;
        DataRow[] foundRows;
        Boolean found = false;
        int i=-1;
        object[] valueMembers;
        ComboBox.ObjectCollection displayMembers;


        public FormBusqueda(DataTable dtSource ,BindingSource bsSource)
        {
            InitializeComponent();
            displayMembers = cboColumns.Items;
            this.dtSource = dtSource;
            this.bsSource = bsSource;
        }

        public Boolean setMembers(object[] displayMembers, object[] valueMembers) {
            Boolean success = false;
            if (displayMembers.Length == valueMembers.Length) {
                cboColumns.Items.Clear();
                foreach (object item in displayMembers)
                {
                    this.displayMembers.Add(item);
                }
                this.valueMembers = valueMembers;
                cboColumns.SelectedIndex = 0;
                cboMatch.SelectedIndex = 1;
            }
            return success;
        }

        private void cboColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset();
            String dataType=dtSource.Columns[valueMembers[cboColumns.SelectedIndex].ToString()].DataType.ToString();
            if (dataType.Equals("System.DateTime"))
            {
                cboMatch.SelectedIndex = 1;
                cboMatch.Enabled = false;
                txtBuscar.Mask = "00/00/0000";
            }
            else if (dataType.Equals("System.String"))
            {
                cboMatch.SelectedIndex = 0;
                cboMatch.Enabled = true;
                txtBuscar.Mask = "";
            }else if(dataType.Equals("System.Int32"))
            {
                cboMatch.SelectedIndex = 1;
                cboMatch.Enabled = false;
                txtBuscar.Mask = "999999";
            }
            if (cboMatch.Enabled)
            {
                cboMatch.Focus();
            }
            else
                txtBuscar.Focus();
        }

        private void btnBuscarSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!found)
                {
                    String sql = valueMembers[cboColumns.SelectedIndex].ToString();
                    //if ("System.String".Equals(dtSource.Columns[valueMembers[cboColumns.SelectedIndex].ToString()].DataType.ToString()))
                    //{
                    if (cboMatch.SelectedIndex != 1)
                    {
                        sql += " LIKE '";
                    }
                    else
                        sql += " = '";
                    if (cboMatch.SelectedIndex == 0)
                        sql += "%";
                    sql += txtBuscar.Text;
                    if (cboMatch.SelectedIndex != 1)
                        sql += "%";
                    sql += "'";
                    //}
                    //else
                    //    sql += " = " + txtBuscar.Text;
                    foundRows = dtSource.Select(sql);
                    if (foundRows.Length != 0)
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    if (i == foundRows.Length - 1)
                    {
                        i = -1;
                        MessageBox.Show("No se encontraron mas registros");
                    }
                    else
                    {
                        i++;
                        bsSource.Position = bsSource.Find(dtSource.PrimaryKey[0].ToString(), foundRows[i][0]);
                        etiEncontrados.Visible = true;
                        txtEncontrados.Visible = true;
                        txtEncontrados.Text = "" + foundRows.Length;
                    }
                    //MessageBox.Show(foundRows[i][0].ToString());
                }
                else
                {
                    MessageBox.Show("No se encontro el registro");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            //MessageBox.Show(dtSource.Columns[valueMembers[cboColumns.SelectedIndex].ToString()].DataType.ToString());
            //int index = bsSource.Find(valueMembers[cboColumns.SelectedIndex].ToString(), txtBuscar.Text);
            //if (index != -1)
            //{
            //    bsSource.Position = index;
            //}
            //bsSource.Filter=valueMembers[cboColumns.SelectedIndex]+" LIKE '%"+txtBuscar.Text+"%'";
        }

        private void reset()
        {
            found = false;
            i = -1;
            foundRows = null;
            txtEncontrados.Text = "";
            txtEncontrados.Visible = false;
            etiEncontrados.Visible = false;
            if (txtBuscar.Text.Length != 0)
                btnBuscarSiguiente.Enabled = true;
            else
                btnBuscarSiguiente.Enabled = false;
        }

        

        private void cboColumns_TextChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void cboMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset();
            txtBuscar.Focus();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.SelectAll();
        }

        private void FormBusqueda_Load(object sender, EventArgs e)
        {

        }
    }
}
