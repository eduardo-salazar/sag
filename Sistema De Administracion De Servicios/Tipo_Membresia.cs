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
    public partial class Tipo_Membresia : UserControl,Funciones
    {
        CADINDataSetTableAdapters.Tipo_MembresiaTableAdapter tmta;
        BindingSource bds;
        CADINDataSet.Tipo_MembresiaDataTable tmdt;

        public Tipo_Membresia()
        {
            InitializeComponent();
            tmta = new CADINDataSetTableAdapters.Tipo_MembresiaTableAdapter();
            bds = new BindingSource();
            tmdt = new CADINDataSet.Tipo_MembresiaDataTable();
            tmdt = tmta.GetData();
            bds.DataSource = tmdt;

            
                dataGridViewX1.DataSource = bds;
                textBoxX1.DataBindings.Add("Text", bds, "nombre");
                textBoxX2.DataBindings.Add("Text", bds, "descripcion");
           
        }

        private void Tipo_Membresia_Load(object sender, EventArgs e)
        {

        }

        private void edicion()
        {
            textBoxX1.ReadOnly = false;
            textBoxX2.ReadOnly = false;            
            dataGridViewX1.Enabled = false;

            textBoxX1.FocusHighlightEnabled = true;
            textBoxX2.FocusHighlightEnabled = true;
        }

        private void lectura()
        {
            textBoxX1.ReadOnly = true;
            textBoxX2.ReadOnly = true;
            dataGridViewX1.Enabled = true;
            dataGridViewX1.Focus();
            textBoxX1.FocusHighlightEnabled = false;
            textBoxX2.FocusHighlightEnabled = false;

            superValidator1.ClearFailedValidations();
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
                tmta.Update(tmdt.Rows[bds.IndexOf(bds.Current)]);
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
                tmta.Update(tmdt);
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
            FormularioReportes.showReport(bds, "TipoMembresia");    
        }

        public void RealizarPago()
        {
            throw new NotImplementedException();
        }
    }
}
