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
    public partial class Tipo_Empresa : UserControl,Funciones
    {
        CADINDataSetTableAdapters.Tipo_EmpresaTableAdapter teta;
        BindingSource bds;
        CADINDataSet.Tipo_EmpresaDataTable tedt;

        public Tipo_Empresa()
        {
            InitializeComponent();
            teta = new CADINDataSetTableAdapters.Tipo_EmpresaTableAdapter();
            bds = new BindingSource();
            tedt = teta.GetData();
            bds.DataSource = tedt;

            
                dgvTipoEmpresa.DataSource = bds;
                txtNombre.DataBindings.Add("Text", bds, "nombre");
                txtDescripcion.DataBindings.Add("Text", bds, "descripcion");
            
        }

        private void Tipo_Empresa_Load(object sender, EventArgs e)
        {

        }

        private void lectura() {
            txtNombre.ReadOnly = true;   
            txtDescripcion.ReadOnly = true;
            dgvTipoEmpresa.Enabled = true;
            dgvTipoEmpresa.Focus();
            superValidator1.ClearFailedValidations();
        }

        private void edicion() {
            txtNombre.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
            dgvTipoEmpresa.Enabled = false;
        }

        public void Nuevo()
        {
            bds.AddNew();
            bds.MoveLast();
            Editar();
        }

        public void Imprimir()
        {
            MessageBox.Show("En construccion");
        }

        public bool Guardar()
        {
            superValidator1.Validate();
            if (superValidator1.Validate())
            {
                bds.EndEdit();
                teta.Update(tedt.Rows[bds.IndexOf(bds.Current)]);
                MessageBox.Show("Guardado");
                lectura();
                return true;
            }
            else
            {
                MessageBox.Show("Revise los campos requeridos");
                return false;
            }
        }

        public void Cancelar()
        {
            bds.CancelEdit();
            lectura();
        }

        public void Editar()
        {
            edicion();
        }


        public void Borrar()
        {
            try
            {
                bds.RemoveCurrent();
                teta.Update(tedt);
                lectura();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se permite eliminar registros que se están utilizando.");
            }
            
        }

        public void IrPrimero()
        {
            bds.MoveFirst();
        }

        public void Anterior()
        {
            bds.MovePrevious();
        }

        public void Siguiente()
        {
            bds.MoveNext();
        }

        public void IrFinal()
        {
            bds.MoveLast();
        }

        public bool vacio()
        {
            if (bds.Count == 0)
            {
                return true;
            }
            return false;
        }

        public void Buscar()
        {
        }

        public void Filtrar()
        {
            FormularioFiltroBusqueda.showFormularioFiltroBusqueda(bds);
        }


        public void Reportes()
        {
            FormularioReportes.showReport(bds, "TipoEmpresa");
        }

        public void RealizarPago()
        {
            throw new NotImplementedException();
        }
    }
}
