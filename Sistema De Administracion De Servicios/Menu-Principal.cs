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
    public partial class Menu_Principal : DevComponents.DotNetBar.Controls.SlidePanel
    {
        Usuario usuario = null;
        public Menu_Principal(Usuario a)
        {
            InitializeComponent();
            usuario = a;
            labelNombre.Text = "Bienvenido "+ a.Nombre;
            if (a.Admin) {
                btnAdministrador.Visible = true;
            }
        }
       
       protected override void OnResize(EventArgs e)
        {
           // Center the panel
           //usuarioGadget.Location=new Point((this.Width - usuarioGadget.Width)/2,20);
           //itemPanel1.Location = new Point((this.Width - itemPanel1.Width) / 2 + 16, ((this.Height - tabUsuario.Height - 16) - itemPanel1.Height) / 2 );
           itemPanel1.Location = new Point((this.Width - itemPanel1.Width) / 2 + 16, (this.Height - itemPanel1.Height)/2);
           usuarioResumen.Location = new Point(this.itemPanel1.Location.X,50);
          
           base.OnResize(e);
        }
      
        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void appViewTile_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirServicio_Click(object sender, EventArgs e)
        {
            this.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            this.IsOpen = false;
        }


        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void infoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void usuarioResumen_Click(object sender, EventArgs e)
        {

        }

        void irEntorno() {
            this.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            this.IsOpen = false;
        }
        private void btnAgregarEmpresa_Click(object sender, EventArgs e)
        {
            this.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            this.IsOpen = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listCatSolicitudApoyo_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatSectores_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatEmpresa_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatCasos_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatTipoMembresia_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatTipoEmpresa_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatTarifas_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void metroTileItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion");
        }

       
        private void imagenUsuario_DoubleClick(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listTipoActividad_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listAdmPantallaGerencial_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listAgrupaciones_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void listCatComunicacion_Click(object sender, EventArgs e)
        {
            irEntorno();
        }

        private void btnComunicacion_Click(object sender, EventArgs e)
        {

        }
    }
}
