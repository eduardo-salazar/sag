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
    public partial class TipoActividad : UserControl, Funciones
    {
        CADINDataSetTableAdapters.Tipo_ActividadTableAdapter tata;
        BindingSource bds;
        CADINDataSet.Tipo_ActividadDataTable tadt;

        public TipoActividad()
        {
            InitializeComponent();
            tata = new CADINDataSetTableAdapters.Tipo_ActividadTableAdapter();
            bds = new BindingSource();
            tadt = tata.GetData();
            bds.DataSource = tadt;

            
                dgvTipoActividades.DataSource = bds;
                txtNombre.DataBindings.Add("Text", bds, "nombre");
                txtDescripcion.DataBindings.Add("Text", bds, "descripcion");
            
        }

        private void TipoActividad_Load(object sender, EventArgs e)
        {

        }

        private void edicion() {
            txtNombre.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
            dgvTipoActividades.Enabled = false;

            txtNombre.FocusHighlightEnabled = true;
            txtDescripcion.FocusHighlightEnabled = true;
        }

        private void lectura() {
            txtNombre.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            dgvTipoActividades.Enabled = true;
            dgvTipoActividades.Focus();

            txtNombre.FocusHighlightEnabled = false;
            txtDescripcion.FocusHighlightEnabled = false;
        }

        public void Nuevo()
        {
            bds.AddNew();
            bds.MoveLast();
            Editar();
        }

        public void Imprimir()
        {
            MessageBox.Show("En construccion...");
        }

        public bool Guardar()
        {
            superValidator1.Validate();
            if (superValidator1.Validate())
            {
                bds.EndEdit();
                tata.Update(tadt.Rows[bds.IndexOf(bds.Current)]);
                MessageBox.Show("Guardado");
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
            MessageBox.Show("Salir del Modo de Edicion");
            bds.CancelEdit();
            txtNombre.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            
        }

        public void Editar()
        {
            MessageBox.Show("Entrar a Modo de Edicion");
            txtNombre.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
        }

        public void Borrar()
        {
            try
            {
                bds.RemoveCurrent();
                tata.Update(tadt);
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
                return true;
            else
                return false;
        }

        public void Reportes()
        {
            FormularioReportes.showReport(bds, "TipoActividad");    
        }

        public void Filtrar()
        {
            FormularioFiltroBusqueda.showFormularioFiltroBusqueda(bds);
        }


        public void RealizarPago()
        {
            throw new NotImplementedException();
        }
    }
}
