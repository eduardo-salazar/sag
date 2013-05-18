namespace Sistema_De_Administracion_De_Servicios
{
    partial class FormularioComunicacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioComunicacion));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.superTabControl = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.controlMensaje1 = new Sistema_De_Administracion_De_Servicios.ControlMensaje();
            this.superTabItemNuevo = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.controlMensajes1 = new Sistema_De_Administracion_De_Servicios.ControlMensajes();
            this.superTabItemEnviados = new DevComponents.DotNetBar.SuperTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl)).BeginInit();
            this.superTabControl.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.SystemColors.GradientInactiveCaption;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.SystemColors.GradientInactiveCaption, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(142)))), ((int)(((byte)(0))))));
            // 
            // superTabControl
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl.ControlBox.MenuBox.Name = "";
            this.superTabControl.ControlBox.Name = "";
            this.superTabControl.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl.ControlBox.MenuBox,
            this.superTabControl.ControlBox.CloseBox});
            this.superTabControl.Controls.Add(this.superTabControlPanel1);
            this.superTabControl.Controls.Add(this.superTabControlPanel2);
            this.superTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl.Location = new System.Drawing.Point(0, 0);
            this.superTabControl.Name = "superTabControl";
            this.superTabControl.ReorderTabsEnabled = true;
            this.superTabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl.SelectedTabIndex = 0;
            this.superTabControl.Size = new System.Drawing.Size(754, 412);
            this.superTabControl.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl.TabIndex = 1;
            this.superTabControl.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItemNuevo,
            this.superTabItemEnviados});
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.controlMensaje1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 46);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(754, 366);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItemNuevo;
            // 
            // controlMensaje1
            // 
            this.controlMensaje1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.controlMensaje1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMensaje1.Location = new System.Drawing.Point(0, 0);
            this.controlMensaje1.Name = "controlMensaje1";
            this.controlMensaje1.Size = new System.Drawing.Size(754, 366);
            this.controlMensaje1.TabIndex = 0;
            // 
            // superTabItemNuevo
            // 
            this.superTabItemNuevo.AttachedControl = this.superTabControlPanel1;
            this.superTabItemNuevo.GlobalItem = false;
            this.superTabItemNuevo.Image = ((System.Drawing.Image)(resources.GetObject("superTabItemNuevo.Image")));
            this.superTabItemNuevo.Name = "superTabItemNuevo";
            this.superTabItemNuevo.Text = "Nuevo";
            this.superTabItemNuevo.Click += new System.EventHandler(this.superTabItemNuevo_Click);
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.controlMensajes1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(754, 412);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItemEnviados;
            // 
            // controlMensajes1
            // 
            this.controlMensajes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMensajes1.Location = new System.Drawing.Point(0, 0);
            this.controlMensajes1.MinimumSize = new System.Drawing.Size(752, 340);
            this.controlMensajes1.Name = "controlMensajes1";
            this.controlMensajes1.Size = new System.Drawing.Size(754, 412);
            this.controlMensajes1.TabIndex = 0;
            // 
            // superTabItemEnviados
            // 
            this.superTabItemEnviados.AttachedControl = this.superTabControlPanel2;
            this.superTabItemEnviados.GlobalItem = false;
            this.superTabItemEnviados.Image = ((System.Drawing.Image)(resources.GetObject("superTabItemEnviados.Image")));
            this.superTabItemEnviados.Name = "superTabItemEnviados";
            this.superTabItemEnviados.Text = "Enviados";
            this.superTabItemEnviados.Click += new System.EventHandler(this.superTabItemEnviados_Click);
            // 
            // FormularioComunicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(754, 412);
            this.Controls.Add(this.superTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(770, 450);
            this.Name = "FormularioComunicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioComunicacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioComunicacion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl)).EndInit();
            this.superTabControl.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.SuperTabControl superTabControl;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private ControlMensajes controlMensajes1;
        private DevComponents.DotNetBar.SuperTabItem superTabItemEnviados;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private ControlMensaje controlMensaje1;
        private DevComponents.DotNetBar.SuperTabItem superTabItemNuevo;

    }
}