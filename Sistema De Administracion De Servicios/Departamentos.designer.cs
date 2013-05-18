namespace Sistema_De_Administracion_De_Servicios
{
    partial class Departamentos
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX7 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(23, 26);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(121, 23);
            this.labelX9.TabIndex = 18;
            this.labelX9.Text = "Nombre Departamento :";
            // 
            // textBoxX7
            // 
            this.textBoxX7.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX7.Border.Class = "TextBoxBorder";
            this.textBoxX7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX7.ForeColor = System.Drawing.Color.Black;
            this.textBoxX7.Location = new System.Drawing.Point(150, 29);
            this.textBoxX7.Name = "textBoxX7";
            this.textBoxX7.Size = new System.Drawing.Size(200, 20);
            this.textBoxX7.TabIndex = 19;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(206, 55);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(125, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 20;
            this.buttonX1.Text = "Agregar Departamento";
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.textBoxX7);
            this.Controls.Add(this.labelX9);
            this.Name = "Departamentos";
            this.Size = new System.Drawing.Size(391, 103);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX7;
        private DevComponents.DotNetBar.ButtonX buttonX1;

    }
}
