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
    public partial class Solicitud_Apoyo : UserControl,Funciones
    {
        CADINDataSetTableAdapters.Solicitud_ApoyoTableAdapter sata=null;
        BindingSource bds=null;
        CADINDataSet.Solicitud_ApoyoDataTable sadt=null;

        public Solicitud_Apoyo()
        {
            InitializeComponent();
            sata = new CADINDataSetTableAdapters.Solicitud_ApoyoTableAdapter();
            bds = new BindingSource();
            sadt = sata.GetData();
            bds.DataSource = sadt;

            
                dataGridViewX1.DataSource = bds;
                textBoxX1.DataBindings.Add("Text", bds, "nombre");
                textBoxX2.DataBindings.Add("Text", bds, "descripcion");
           
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

        public bool Guardar()
        {
            bds.EndEdit();
            superValidator1.Validate();
            if (superValidator1.Validate())
            {
                sata.Update(sadt.Rows[bds.IndexOf(bds.Current)]);
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
                sata.Update(sadt);
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

        private void Solicitud_Apoyo_Load(object sender, EventArgs e)
        {

        }

        public void Nuevo()
        {
            textBoxX1.Focus();
            bds.AddNew();
            bds.MoveLast();
            
            Editar();
        }

        public void Imprimir()
        {
            MessageBox.Show("En construccion...");
        }

        private void labelX3_Click(object sender, EventArgs e)
        {

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
            FormularioReportes.showReport(bds, "SolicitudApoyo");
        }

        public void RealizarPago()
        {
            throw new NotImplementedException();
        }
    }
}