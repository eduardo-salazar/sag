using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class Sectores : UserControl, Funciones
    {
        bool guardado;
        CADINDataSetTableAdapters.SectoresTableAdapter sta;
        CADINDataSet.SectoresDataTable sdt;
        BindingSource bds;

        public Sectores()
        {
            InitializeComponent();

            sta = new CADINDataSetTableAdapters.SectoresTableAdapter();
            sdt = new CADINDataSet.SectoresDataTable();
            bds = new BindingSource();
            sdt = sta.GetData();
            bds.DataSource = sdt;

           
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

        private void Sectores_Load(object sender, EventArgs e)
        {

        }
        
        public bool Guardar()
        {
            superValidator1.Validate();
            if (superValidator1.Validate())
            {
                bds.EndEdit();
                sta.Update(sdt.Rows[bds.IndexOf(bds.Current)]);
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
                sta.Update(sdt);
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
            FormularioReportes.showReport(bds, "Sector");
        }
        
        public void RealizarPago()
        {
            throw new NotImplementedException();
        }
    }
}
