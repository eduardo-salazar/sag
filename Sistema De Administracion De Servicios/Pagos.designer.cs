namespace Sistema_De_Administracion_De_Servicios
{
    partial class Pagos
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
            this.cbFrequenciaPagos = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbSemana = new DevComponents.Editors.ComboItem();
            this.cbMes = new DevComponents.Editors.ComboItem();
            this.cbAno = new DevComponents.Editors.ComboItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cADINDataSet = new Sistema_De_Administracion_De_Servicios.CADINDataSet();
            this.pago_MembresiaTableAdapter = new Sistema_De_Administracion_De_Servicios.CADINDataSetTableAdapters.Pago_MembresiaTableAdapter();
            this.dgPagosEmpresa = new System.Windows.Forms.DataGridView();
            this.pagoMembresiaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.domainNumCuotas = new System.Windows.Forms.DomainUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrarPago = new DevComponents.DotNetBar.ButtonX();
            this.btnGenerarPagos = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbTotalPago = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.cADINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagosEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoMembresiaBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFrequenciaPagos
            // 
            this.cbFrequenciaPagos.DisplayMember = "Text";
            this.cbFrequenciaPagos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFrequenciaPagos.FormattingEnabled = true;
            this.cbFrequenciaPagos.ItemHeight = 14;
            this.cbFrequenciaPagos.Items.AddRange(new object[] {
            this.cbSemana,
            this.cbMes,
            this.cbAno});
            this.cbFrequenciaPagos.Location = new System.Drawing.Point(276, 49);
            this.cbFrequenciaPagos.Name = "cbFrequenciaPagos";
            this.cbFrequenciaPagos.Size = new System.Drawing.Size(121, 20);
            this.cbFrequenciaPagos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFrequenciaPagos.TabIndex = 3;
            // 
            // cbSemana
            // 
            this.cbSemana.Text = "Semanal";
            // 
            // cbMes
            // 
            this.cbMes.Text = "Mes";
            // 
            // cbAno
            // 
            this.cbAno.Text = "Año";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(19, 47);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(107, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Cantidad de Cuotas:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(212, 47);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(69, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Frequencia:";
            // 
            // cADINDataSet
            // 
            this.cADINDataSet.DataSetName = "CADINDataSet";
            this.cADINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pago_MembresiaTableAdapter
            // 
            this.pago_MembresiaTableAdapter.ClearBeforeFill = true;
            // 
            // dgPagosEmpresa
            // 
            this.dgPagosEmpresa.AllowUserToAddRows = false;
            this.dgPagosEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPagosEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagosEmpresa.Location = new System.Drawing.Point(12, 157);
            this.dgPagosEmpresa.Name = "dgPagosEmpresa";
            this.dgPagosEmpresa.Size = new System.Drawing.Size(706, 186);
            this.dgPagosEmpresa.TabIndex = 6;
            this.dgPagosEmpresa.DataSourceChanged += new System.EventHandler(this.dgPagosEmpresa_DataSourceChanged);
            this.dgPagosEmpresa.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgPagosEmpresa_CellBeginEdit);
            this.dgPagosEmpresa.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPagosEmpresa_CellEndEdit);
            // 
            // pagoMembresiaBindingSource2
            // 
            this.pagoMembresiaBindingSource2.DataMember = "Pago_Membresia";
            this.pagoMembresiaBindingSource2.DataSource = this.cADINDataSet;
            // 
            // domainNumCuotas
            // 
            this.domainNumCuotas.Items.Add("12");
            this.domainNumCuotas.Items.Add("11");
            this.domainNumCuotas.Items.Add("10");
            this.domainNumCuotas.Items.Add("9");
            this.domainNumCuotas.Items.Add("8");
            this.domainNumCuotas.Items.Add("7");
            this.domainNumCuotas.Items.Add("6");
            this.domainNumCuotas.Items.Add("5");
            this.domainNumCuotas.Items.Add("4");
            this.domainNumCuotas.Items.Add("3");
            this.domainNumCuotas.Items.Add("2");
            this.domainNumCuotas.Items.Add("1");
            this.domainNumCuotas.Location = new System.Drawing.Point(124, 49);
            this.domainNumCuotas.Name = "domainNumCuotas";
            this.domainNumCuotas.Size = new System.Drawing.Size(58, 20);
            this.domainNumCuotas.TabIndex = 7;
            this.domainNumCuotas.SelectedItemChanged += new System.EventHandler(this.domainNumCuotas_SelectedItemChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Sistema_De_Administracion_De_Servicios.Properties.Resources.form_background2;
            this.groupBox1.Controls.Add(this.btnBorrarPago);
            this.groupBox1.Controls.Add(this.btnGenerarPagos);
            this.groupBox1.Controls.Add(this.cbFrequenciaPagos);
            this.groupBox1.Controls.Add(this.domainNumCuotas);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 114);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generación de Pagos";
            // 
            // btnBorrarPago
            // 
            this.btnBorrarPago.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBorrarPago.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBorrarPago.Location = new System.Drawing.Point(423, 63);
            this.btnBorrarPago.Name = "btnBorrarPago";
            this.btnBorrarPago.Size = new System.Drawing.Size(106, 23);
            this.btnBorrarPago.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBorrarPago.TabIndex = 9;
            this.btnBorrarPago.Text = "Borrar Pago(s)";
            // 
            // btnGenerarPagos
            // 
            this.btnGenerarPagos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenerarPagos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGenerarPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPagos.Location = new System.Drawing.Point(423, 23);
            this.btnGenerarPagos.Name = "btnGenerarPagos";
            this.btnGenerarPagos.Size = new System.Drawing.Size(106, 23);
            this.btnGenerarPagos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGenerarPagos.TabIndex = 8;
            this.btnGenerarPagos.Text = "Generar Pagos";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Location = new System.Drawing.Point(584, 28);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(134, 31);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackgroundImage = global::Sistema_De_Administracion_De_Servicios.Properties.Resources.form_background;
            this.panelEx1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 10;
            this.panelEx1.Text = "Total a pagar Por Tarifa";
            this.panelEx1.Click += new System.EventHandler(this.panelEx1_Click);
            // 
            // lbTotalPago
            // 
            this.lbTotalPago.CanvasColor = System.Drawing.SystemColors.Control;
            this.lbTotalPago.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lbTotalPago.Location = new System.Drawing.Point(584, 51);
            this.lbTotalPago.Name = "lbTotalPago";
            this.lbTotalPago.Size = new System.Drawing.Size(134, 91);
            this.lbTotalPago.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.lbTotalPago.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbTotalPago.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbTotalPago.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.lbTotalPago.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.lbTotalPago.Style.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPago.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.lbTotalPago.Style.GradientAngle = 90;
            this.lbTotalPago.TabIndex = 11;
            this.lbTotalPago.Text = "Aqui va el Monto a Pagar";
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_De_Administracion_De_Servicios.Properties.Resources.form_background2;
            this.ClientSize = new System.Drawing.Size(734, 383);
            this.Controls.Add(this.lbTotalPago);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgPagosEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Pagos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cADINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagosEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoMembresiaBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private CADINDataSet cADINDataSet;
        private CADINDataSetTableAdapters.Pago_MembresiaTableAdapter pago_MembresiaTableAdapter;
        private System.Windows.Forms.BindingSource pagoMembresiaBindingSource2;
        private DevComponents.Editors.ComboItem cbSemana;
        private DevComponents.Editors.ComboItem cbMes;
        private DevComponents.Editors.ComboItem cbAno;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcuotaDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgPagosEmpresa;
        public DevComponents.DotNetBar.ButtonX btnGenerarPagos;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cbFrequenciaPagos;
        public System.Windows.Forms.DomainUpDown domainNumCuotas;
        public DevComponents.DotNetBar.PanelEx lbTotalPago;
        public DevComponents.DotNetBar.ButtonX btnBorrarPago;
    }
}