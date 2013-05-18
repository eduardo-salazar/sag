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
    public partial class FormularioFiltroBusqueda : Form
    {
        private ControlFiltroBusqueda controlFiltroBusqueda1;
        BindingSource bsSource;

        public FormularioFiltroBusqueda(BindingSource bsSource)
        {
            InitializeComponent();
            this.bsSource = bsSource;
            this.controlFiltroBusqueda1.bindingSource = this.bsSource;
        }

        public static void Show(BindingSource bsSource) {
            FormularioFiltroBusqueda formularioFiltroBusqueda = new FormularioFiltroBusqueda(bsSource);
            formularioFiltroBusqueda.Show();
        }

        public static void showFormularioFiltroBusqueda(BindingSource bsSource)
        {
            FormularioFiltroBusqueda formularioFiltroBusqueda = new FormularioFiltroBusqueda(bsSource);
            formularioFiltroBusqueda.ShowDialog();
        }

        private void InitializeComponent()
        {
            this.controlFiltroBusqueda1 = new Sistema_De_Administracion_De_Servicios.ControlFiltroBusqueda();
            this.SuspendLayout();
            // 
            // controlFiltroBusqueda1
            // 
            this.controlFiltroBusqueda1.AutoSize = true;
            this.controlFiltroBusqueda1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlFiltroBusqueda1.BackColor = System.Drawing.Color.White;
            this.controlFiltroBusqueda1.bindingSource = null;
            this.controlFiltroBusqueda1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlFiltroBusqueda1.Location = new System.Drawing.Point(0, 0);
            this.controlFiltroBusqueda1.Margin = new System.Windows.Forms.Padding(0);
            this.controlFiltroBusqueda1.MaximumSize = new System.Drawing.Size(543, 410);
            this.controlFiltroBusqueda1.MinimumSize = new System.Drawing.Size(537, 230);
            this.controlFiltroBusqueda1.Name = "controlFiltroBusqueda1";
            this.controlFiltroBusqueda1.Padding = new System.Windows.Forms.Padding(10);
            this.controlFiltroBusqueda1.Size = new System.Drawing.Size(543, 262);
            this.controlFiltroBusqueda1.TabIndex = 0;
            // 
            // FormularioFiltroBusqueda
            // 
            this.ClientSize = new System.Drawing.Size(544, 262);
            this.Controls.Add(this.controlFiltroBusqueda1);
            this.Name = "FormularioFiltroBusqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
