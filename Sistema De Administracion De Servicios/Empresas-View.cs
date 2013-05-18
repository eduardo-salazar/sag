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
    public partial class Empresas_View : Form
    {
        CADINDataSetTableAdapters.EmpresaTableAdapter eta;
        CADINDataSet.EmpresaDataTable edt;
        String nomb_emp;
        
        public Empresas_View(String nomb_empresa)
        {
            InitializeComponent();
            this.nomb_emp = nomb_empresa;
            eta = new CADINDataSetTableAdapters.EmpresaTableAdapter();
            edt = new CADINDataSet.EmpresaDataTable();
            edt = eta.GetDataByNombEmpresa(nomb_empresa);
            this.dataGridViewEmpresas.DataSource = edt;
            this.dataGridViewEmpresas.Columns[1].Visible = false;
        }

        public int getCodigo(int index)
        {
            return Convert.ToInt32(edt.Rows[index].ItemArray.GetValue(0));
        }

        private void Empresas_View_Load(object sender, EventArgs e)
        {

        }

        
    }
}
