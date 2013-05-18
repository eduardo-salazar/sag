using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class FormUsuario : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cADINDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.cADINDataSet.Usuario);
            

        }
    }
}