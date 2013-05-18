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
    public partial class Casos_View : Form
    {
        CADINDataSetTableAdapters.CasoTableAdapter tableAdapterCaso;
        CADINDataSet.CasoDataTable dataTableCaso;
        public Casos_View(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            tableAdapterCaso = new CADINDataSetTableAdapters.CasoTableAdapter();
            dataTableCaso = new CADINDataSet.CasoDataTable();
            dataTableCaso=tableAdapterCaso.GetDataByEmpresa(codigo);
            this.dataGridViewX1.DataSource = dataTableCaso;
            this.dataGridViewX1.Columns[1].Visible = false;

        }
        int codigo = 0;
        public int getCodigo(int index)
        {
            return Convert.ToInt32(dataTableCaso.Rows[index].ItemArray.GetValue(0));
        }

        private void Casos_View_Load(object sender, EventArgs e)
        {
            
        }

        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioTodos.Checked)
            {
                dataTableCaso = tableAdapterCaso.GetDataByEmpresa(codigo);
                this.dataGridViewX1.DataSource = dataTableCaso;
                this.dataGridViewX1.Columns[1].Visible = false;
            }
        }

        private void radioSinCancelar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioSinCancelar.Checked)
            {
                dataTableCaso = tableAdapterCaso.GetDataByEmpresaSinPagar(codigo);
                this.dataGridViewX1.DataSource = dataTableCaso;
                this.dataGridViewX1.Columns[1].Visible = false;
            }
        }
    }
}
