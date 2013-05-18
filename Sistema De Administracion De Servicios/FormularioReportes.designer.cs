namespace Sistema_De_Administracion_De_Servicios
{
    partial class FormularioReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioReportes));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.itemPanelVersionReporte = new DevComponents.DotNetBar.ItemPanel();
            this.txtSelectedVersionReporte = new System.Windows.Forms.TextBox();
            this.expandablePanelVersionReporte = new DevComponents.DotNetBar.ExpandablePanel();
            this.expandablePanelVersionReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reportViewer1.Location = new System.Drawing.Point(95, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(838, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // itemPanelVersionReporte
            // 
            this.itemPanelVersionReporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.itemPanelVersionReporte.AutoScroll = true;
            this.itemPanelVersionReporte.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.itemPanelVersionReporte.BackgroundStyle.Class = "ItemPanel";
            this.itemPanelVersionReporte.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanelVersionReporte.ContainerControlProcessDialogKey = true;
            this.itemPanelVersionReporte.FitButtonsToContainerWidth = true;
            this.itemPanelVersionReporte.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.itemPanelVersionReporte.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanelVersionReporte.Location = new System.Drawing.Point(0, 64);
            this.itemPanelVersionReporte.Name = "itemPanelVersionReporte";
            this.itemPanelVersionReporte.Size = new System.Drawing.Size(200, 422);
            this.itemPanelVersionReporte.TabIndex = 2;
            this.itemPanelVersionReporte.SelectedIndexChanged += new System.EventHandler(this.itemPanel1_SelectedIndexChanged);
            this.itemPanelVersionReporte.ItemClick += new System.EventHandler(this.itemPanel1_ItemClick);
            // 
            // txtSelectedVersionReporte
            // 
            this.txtSelectedVersionReporte.Location = new System.Drawing.Point(0, 38);
            this.txtSelectedVersionReporte.Name = "txtSelectedVersionReporte";
            this.txtSelectedVersionReporte.ReadOnly = true;
            this.txtSelectedVersionReporte.Size = new System.Drawing.Size(200, 20);
            this.txtSelectedVersionReporte.TabIndex = 3;
            // 
            // expandablePanelVersionReporte
            // 
            this.expandablePanelVersionReporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.expandablePanelVersionReporte.AutoSize = true;
            this.expandablePanelVersionReporte.CanvasColor = System.Drawing.Color.Transparent;
            this.expandablePanelVersionReporte.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanelVersionReporte.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanelVersionReporte.Controls.Add(this.txtSelectedVersionReporte);
            this.expandablePanelVersionReporte.Controls.Add(this.itemPanelVersionReporte);
            this.expandablePanelVersionReporte.Location = new System.Drawing.Point(0, 0);
            this.expandablePanelVersionReporte.Name = "expandablePanelVersionReporte";
            this.expandablePanelVersionReporte.Size = new System.Drawing.Size(203, 486);
            this.expandablePanelVersionReporte.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanelVersionReporte.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanelVersionReporte.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanelVersionReporte.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanelVersionReporte.Style.GradientAngle = 90;
            this.expandablePanelVersionReporte.TabIndex = 4;
            this.expandablePanelVersionReporte.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanelVersionReporte.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanelVersionReporte.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanelVersionReporte.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanelVersionReporte.TitleStyle.ForeColor.Color = System.Drawing.Color.Navy;
            this.expandablePanelVersionReporte.TitleStyle.GradientAngle = 90;
            this.expandablePanelVersionReporte.TitleText = "Versión de Reporte";
            // 
            // FormularioReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 486);
            this.Controls.Add(this.expandablePanelVersionReporte);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioReportes_FormClosing);
            this.expandablePanelVersionReporte.ResumeLayout(false);
            this.expandablePanelVersionReporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevComponents.DotNetBar.ItemPanel itemPanelVersionReporte;
        private System.Windows.Forms.TextBox txtSelectedVersionReporte;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanelVersionReporte;
        
    }
}