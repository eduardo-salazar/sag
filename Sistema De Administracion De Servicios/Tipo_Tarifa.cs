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
    public partial class Tipo_Tarifa : UserControl,Funciones
    {
        CADINDataSetTableAdapters.Tipo_TarifaTableAdapter ttta;
        BindingSource bds;
        CADINDataSet.Tipo_TarifaDataTable ttdt;

        public Tipo_Tarifa()
        {
            InitializeComponent();
            ttta = new CADINDataSetTableAdapters.Tipo_TarifaTableAdapter();
            bds = new BindingSource();
            ttdt = ttta.GetData();
            bds.DataSource = ttdt;

           
                dgvTipoTarifas.DataSource = bds;
                txtNombre.DataBindings.Add("Text", bds, "nombre");
                txtMontoAnual.DataBindings.Add("Text", bds, "mont_anua");
                txtDescripcion.DataBindings.Add("Text", bds, "descripcion");
            
        }

        private void edicion() {
            txtNombre.ReadOnly = false;
            txtMontoAnual.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
            dgvTipoTarifas.Enabled = false;
            txtNombre.FocusHighlightEnabled = true;
            txtMontoAnual.FocusHighlightEnabled = true;
            txtDescripcion.FocusHighlightEnabled = true;
        }

        private void lectura() {
            txtNombre.ReadOnly = true;
            txtMontoAnual.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            dgvTipoTarifas.Enabled = true;
            dgvTipoTarifas.Focus();
            superValidator1.ClearFailedValidations();

            txtNombre.FocusHighlightEnabled = false;
            txtMontoAnual.FocusHighlightEnabled = false;
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
            if (superValidator1.Validate())
            {
                bds.EndEdit();
                ttta.Update(ttdt.Rows[bds.IndexOf(bds.Current)]);
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
                ttta.Update(ttdt);
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
            if (bds.Count==0)
            {
                return true;
            }
            return false;
        }

        public void Buscar()
        {
            FormularioFiltroBusqueda formularioFiltro = new FormularioFiltroBusqueda(bds);
            formularioFiltro.Show();
        }

        public void Filtrar()
        {
            FormularioFiltroBusqueda.showFormularioFiltroBusqueda(bds);
        }


        public void Reportes()
        {
            FormularioReportes.showReport(bds, "TipoTarifa");
        }

        public void RealizarPago()
        {
            throw new NotImplementedException();
        }

        private void Tipo_Tarifa_Load(object sender, EventArgs e)
        {

        }
    }
}
