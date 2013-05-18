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
    public partial class ControlMensajes : UserControl
    {
        Usuario usuario;
        BindingSource bindingSource;

        public ControlMensajes()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            //bindingSource.DataSource = new CADINDataSetTableAdapters.ComunicacionMensajeTableAdapter().GetData();
            bindingSource.DataSource = new CADINDataSet.ComunicacionMensajeDataTable();
            dataGridView1.DataSource = bindingSource;
            txtAsunto.DataBindings.Add("Text", bindingSource, "asunto");
            txtFecha.DataBindings.Add("Text", bindingSource, "fech_envio");
            txtPara.DataBindings.Add("Text", bindingSource, "email");
            txtMensaje.DataBindings.Add("Text", bindingSource, "mensaje");
            txtDe.DataBindings.Add("Text",bindingSource,"origen");
            txtEmpresa.DataBindings.Add("Text",bindingSource,"nomb_empr");
        }

        public ControlMensajes(Usuario usuario) {
            InitializeComponent();
            this.usuario = usuario;
            bindingSource = new BindingSource();
            Reload();
            dataGridView1.DataSource = bindingSource;
            txtAsunto.DataBindings.Add("Text", bindingSource, "asunto");
            txtFecha.DataBindings.Add("Text", bindingSource, "fech_envio");
            txtPara.DataBindings.Add("Text", bindingSource, "email");
            txtMensaje.DataBindings.Add("Text", bindingSource, "mensaje");
        }

        public void setUsuario(Usuario u) {
            this.usuario = u;
            Reload();
        }

        public void Reload() {
            if (usuario.Admin)
            {
                bindingSource.DataSource = new CADINDataSetTableAdapters.ComunicacionMensajeTableAdapter().GetData();
            }
            else
            {
                bindingSource.DataSource = new CADINDataSetTableAdapters.ComunicacionMensajeTableAdapter().GetDataByCodUsua(usuario.Cod_Usua);
            }
        }
    }
}
