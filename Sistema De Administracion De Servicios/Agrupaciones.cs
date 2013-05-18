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
    public partial class Agrupaciones : UserControl,Funciones
    {
        CADINDataSetTableAdapters.Empresa_AgrupacionTableAdapter empreAgrupTableA;
        BindingSource emprAgrupBs;
        CADINDataSet.Empresa_AgrupacionDataTable empreAgrupDatat;

        public Agrupaciones()
        {
            InitializeComponent();
            empreAgrupTableA= new CADINDataSetTableAdapters.Empresa_AgrupacionTableAdapter();
            emprAgrupBs = new BindingSource();
            empreAgrupDatat = empreAgrupTableA.GetData();
            emprAgrupBs.DataSource = empreAgrupDatat;
            dgAgrupaciones.DataSource = emprAgrupBs;
            dgAgrupaciones.Columns["cod_gremio"].Visible = false;
            dgAgrupaciones.Columns["nombre"].HeaderText = "Nombre";
            dgAgrupaciones.Columns["descripcion"].HeaderText = "Descripción";
            txtNombre.DataBindings.Add("Text", emprAgrupBs, "nombre");
            txtDescripcion.DataBindings.Add("Text", emprAgrupBs, "descripcion");
        }

        private void edicion()
        {
            txtNombre.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
            dgAgrupaciones.Enabled = false;

            txtNombre.FocusHighlightEnabled = true;
            txtDescripcion.FocusHighlightEnabled = true;
        }

        private void lectura()
        {
            txtNombre.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            dgAgrupaciones.Enabled = true;
            dgAgrupaciones.Focus();
            txtNombre.FocusHighlightEnabled = false;
            txtDescripcion.FocusHighlightEnabled = false;

            superValidator2.ClearFailedValidations();
        }

        public bool Guardar()
        {
            this.emprAgrupBs.EndEdit();
            superValidator2.Validate();
            if (superValidator2.Validate())
            {
                this.empreAgrupTableA.Update(this.empreAgrupDatat.Rows[this.emprAgrupBs.IndexOf(this.emprAgrupBs.Current)]);
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
            emprAgrupBs.CancelEdit();
            lectura();
        }

        public void Editar()
        {
            edicion();
        }
        
        public void Borrar()
        {
            emprAgrupBs.RemoveCurrent();
            this.empreAgrupTableA.Update(this.empreAgrupDatat);
        }

        public void IrPrimero()
        {
            emprAgrupBs.MoveFirst();
        }

        public void Anterior()
        {
            emprAgrupBs.MovePrevious();
        }

        public void Siguiente()
        {
            emprAgrupBs.MoveNext();
        }

        public void IrFinal()
        {
            emprAgrupBs.MoveLast();
        }

        private void Solicitud_Apoyo_Load(object sender, EventArgs e)
        {

        }

        public void Nuevo()
        {
            txtNombre.Focus();
            emprAgrupBs.AddNew();
            emprAgrupBs.MoveLast();
            
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
             if (emprAgrupBs.Count == 0)
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
            FormularioFiltroBusqueda.showFormularioFiltroBusqueda(emprAgrupBs);
        }


        public void Reportes()
        {
            FormularioReportes.showReport(emprAgrupBs, "SolicitudApoyo");
        }

        public void RealizarPago()
        {
            throw new NotImplementedException();
        }
    }
}