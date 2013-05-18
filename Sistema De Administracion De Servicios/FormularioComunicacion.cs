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
    public partial class FormularioComunicacion : Form
    {
        public FormularioComunicacion(Usuario usuario)
        {
            InitializeComponent();
            controlMensaje1.setUser(usuario);
            controlMensajes1.setUsuario(usuario);
        }

        private void FormularioComunicacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.styleManager1.ManagerColorTint = System.Drawing.SystemColors.GradientInactiveCaption;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.SystemColors.GradientInactiveCaption, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(142)))), ((int)(((byte)(0))))));
        }

        private void superTabItemNuevo_Click(object sender, EventArgs e)
        {
            this.controlMensaje1.clear();
        }

        private void superTabItemEnviados_Click(object sender, EventArgs e)
        {
            this.controlMensajes1.Reload();
        }
    }
}
