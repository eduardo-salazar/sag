namespace Sistema_De_Administracion_De_Servicios
{
    partial class RealizarPago
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
            this.txtNombreCliente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtMonto = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.radioMembresia = new System.Windows.Forms.RadioButton();
            this.radioCaso = new System.Windows.Forms.RadioButton();
            this.radioOtro = new System.Windows.Forms.RadioButton();
            this.tabControl2 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCaso = new DevComponents.DotNetBar.ButtonX();
            this.txtDinamico = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbDinamico = new DevComponents.DotNetBar.LabelX();
            this.btnAgregarPago = new DevComponents.DotNetBar.ButtonX();
            this.btnCrearRecibo = new DevComponents.DotNetBar.ButtonX();
            this.fechaPago = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRecibidoPor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtObservacion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.dataGridDescripcionPago = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peri_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_pend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_caso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl2)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechaPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDescripcionPago)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtNombreCliente.Border.Class = "TextBoxBorder";
            this.txtNombreCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNombreCliente.Location = new System.Drawing.Point(74, 15);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(361, 20);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(26, 13);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(48, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Cliente:";
            // 
            // txtMonto
            // 
            // 
            // 
            // 
            this.txtMonto.BackgroundStyle.Class = "TextBoxBorder";
            this.txtMonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMonto.ButtonClear.Visible = true;
            this.txtMonto.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMonto.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtMonto.Location = new System.Drawing.Point(74, 191);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(99, 20);
            this.txtMonto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtMonto.TabIndex = 4;
            this.txtMonto.Text = "";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMonto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(21, 188);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(43, 23);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "Importe:";
            // 
            // radioMembresia
            // 
            this.radioMembresia.AutoSize = true;
            this.radioMembresia.BackColor = System.Drawing.Color.Transparent;
            this.radioMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMembresia.Location = new System.Drawing.Point(44, 19);
            this.radioMembresia.Name = "radioMembresia";
            this.radioMembresia.Size = new System.Drawing.Size(88, 19);
            this.radioMembresia.TabIndex = 3;
            this.radioMembresia.TabStop = true;
            this.radioMembresia.Text = "Membresia";
            this.radioMembresia.UseVisualStyleBackColor = false;
            // 
            // radioCaso
            // 
            this.radioCaso.AutoSize = true;
            this.radioCaso.BackColor = System.Drawing.Color.Transparent;
            this.radioCaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCaso.Location = new System.Drawing.Point(148, 19);
            this.radioCaso.Name = "radioCaso";
            this.radioCaso.Size = new System.Drawing.Size(161, 19);
            this.radioCaso.TabIndex = 0;
            this.radioCaso.TabStop = true;
            this.radioCaso.Text = "Pago Por Servicio (Caso)";
            this.radioCaso.UseVisualStyleBackColor = false;
            // 
            // radioOtro
            // 
            this.radioOtro.AutoSize = true;
            this.radioOtro.BackColor = System.Drawing.Color.Transparent;
            this.radioOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOtro.Location = new System.Drawing.Point(323, 19);
            this.radioOtro.Name = "radioOtro";
            this.radioOtro.Size = new System.Drawing.Size(48, 19);
            this.radioOtro.TabIndex = 0;
            this.radioOtro.TabStop = true;
            this.radioOtro.Text = "Otro";
            this.radioOtro.UseVisualStyleBackColor = false;
            // 
            // tabControl2
            // 
            this.tabControl2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabControl2.CanReorderTabs = true;
            this.tabControl2.Controls.Add(this.tabControlPanel1);
            this.tabControl2.ForeColor = System.Drawing.Color.Black;
            this.tabControl2.Location = new System.Drawing.Point(12, 1);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControl2.SelectedTabIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(458, 451);
            this.tabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.SimulatedTheme;
            this.tabControl2.TabIndex = 10;
            this.tabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl2.Tabs.Add(this.tabItem1);
            this.tabControl2.Text = "tabControl2";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.groupBox1);
            this.tabControlPanel1.Controls.Add(this.btnAgregarPago);
            this.tabControlPanel1.Controls.Add(this.btnCrearRecibo);
            this.tabControlPanel1.Controls.Add(this.fechaPago);
            this.tabControlPanel1.Controls.Add(this.labelX7);
            this.tabControlPanel1.Controls.Add(this.labelX5);
            this.tabControlPanel1.Controls.Add(this.txtDescripcion);
            this.tabControlPanel1.Controls.Add(this.txtRecibidoPor);
            this.tabControlPanel1.Controls.Add(this.labelX6);
            this.tabControlPanel1.Controls.Add(this.labelX2);
            this.tabControlPanel1.Controls.Add(this.txtObservacion);
            this.tabControlPanel1.Controls.Add(this.labelX3);
            this.tabControlPanel1.Controls.Add(this.txtNombreCliente);
            this.tabControlPanel1.Controls.Add(this.comboMoneda);
            this.tabControlPanel1.Controls.Add(this.txtMonto);
            this.tabControlPanel1.Controls.Add(this.labelX4);
            this.tabControlPanel1.Controls.Add(this.labelX1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(458, 425);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = -90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBuscarCaso);
            this.groupBox1.Controls.Add(this.txtDinamico);
            this.groupBox1.Controls.Add(this.lbDinamico);
            this.groupBox1.Controls.Add(this.radioMembresia);
            this.groupBox1.Controls.Add(this.radioCaso);
            this.groupBox1.Controls.Add(this.radioOtro);
            this.groupBox1.Location = new System.Drawing.Point(21, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 90);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepto";
            // 
            // btnBuscarCaso
            // 
            this.btnBuscarCaso.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarCaso.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscarCaso.Location = new System.Drawing.Point(278, 55);
            this.btnBuscarCaso.Name = "btnBuscarCaso";
            this.btnBuscarCaso.Size = new System.Drawing.Size(56, 20);
            this.btnBuscarCaso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarCaso.TabIndex = 5;
            this.btnBuscarCaso.Text = "Buscar";
            this.btnBuscarCaso.Click += new System.EventHandler(this.btnBuscarCaso_Click);
            // 
            // txtDinamico
            // 
            this.txtDinamico.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtDinamico.Border.Class = "TextBoxBorder";
            this.txtDinamico.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDinamico.ForeColor = System.Drawing.Color.Black;
            this.txtDinamico.Location = new System.Drawing.Point(172, 55);
            this.txtDinamico.Name = "txtDinamico";
            this.txtDinamico.Size = new System.Drawing.Size(100, 20);
            this.txtDinamico.TabIndex = 4;
            // 
            // lbDinamico
            // 
            // 
            // 
            // 
            this.lbDinamico.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDinamico.Location = new System.Drawing.Point(109, 53);
            this.lbDinamico.Name = "lbDinamico";
            this.lbDinamico.Size = new System.Drawing.Size(56, 23);
            this.lbDinamico.TabIndex = 3;
            this.lbDinamico.Text = "labelX8";
            this.lbDinamico.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarPago.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregarPago.Location = new System.Drawing.Point(180, 389);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(104, 23);
            this.btnAgregarPago.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregarPago.TabIndex = 8;
            this.btnAgregarPago.Text = "Agregar";
            // 
            // btnCrearRecibo
            // 
            this.btnCrearRecibo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCrearRecibo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCrearRecibo.Location = new System.Drawing.Point(290, 389);
            this.btnCrearRecibo.Name = "btnCrearRecibo";
            this.btnCrearRecibo.Size = new System.Drawing.Size(145, 23);
            this.btnCrearRecibo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCrearRecibo.TabIndex = 9;
            this.btnCrearRecibo.Text = "Crear Recibo";
            this.btnCrearRecibo.Click += new System.EventHandler(this.btnCrearRecibo_Click);
            // 
            // fechaPago
            // 
            // 
            // 
            // 
            this.fechaPago.BackgroundStyle.Class = "DateTimeInputBackground";
            this.fechaPago.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fechaPago.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.fechaPago.ButtonDropDown.Visible = true;
            this.fechaPago.IsPopupCalendarOpen = false;
            this.fechaPago.Location = new System.Drawing.Point(331, 56);
            // 
            // 
            // 
            this.fechaPago.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fechaPago.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fechaPago.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.fechaPago.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.fechaPago.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.fechaPago.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.fechaPago.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.fechaPago.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.fechaPago.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.fechaPago.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.fechaPago.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fechaPago.MonthCalendar.DisplayMonth = new System.DateTime(2012, 7, 1, 0, 0, 0, 0);
            this.fechaPago.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.fechaPago.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fechaPago.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.fechaPago.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.fechaPago.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.fechaPago.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fechaPago.MonthCalendar.TodayButtonVisible = true;
            this.fechaPago.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.fechaPago.Name = "fechaPago";
            this.fechaPago.Size = new System.Drawing.Size(104, 20);
            this.fechaPago.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.fechaPago.TabIndex = 13;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(21, 218);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 14;
            this.labelX7.Text = "Descripción: ";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(290, 54);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(48, 23);
            this.labelX5.TabIndex = 15;
            this.labelX5.Text = "Fecha:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(21, 247);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(414, 19);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtRecibidoPor
            // 
            this.txtRecibidoPor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtRecibidoPor.Border.Class = "TextBoxBorder";
            this.txtRecibidoPor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRecibidoPor.ForeColor = System.Drawing.Color.Black;
            this.txtRecibidoPor.Location = new System.Drawing.Point(75, 54);
            this.txtRecibidoPor.Name = "txtRecibidoPor";
            this.txtRecibidoPor.Size = new System.Drawing.Size(173, 20);
            this.txtRecibidoPor.TabIndex = 2;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(21, 272);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 4;
            this.labelX6.Text = "Observacion: ";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(8, 51);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(71, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "Recibido por:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtObservacion.Border.Class = "TextBoxBorder";
            this.txtObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtObservacion.ForeColor = System.Drawing.Color.Black;
            this.txtObservacion.Location = new System.Drawing.Point(21, 301);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(414, 82);
            this.txtObservacion.TabIndex = 7;
            // 
            // comboMoneda
            // 
            this.comboMoneda.DisplayMember = "Text";
            this.comboMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboMoneda.FormattingEnabled = true;
            this.comboMoneda.ItemHeight = 14;
            this.comboMoneda.Items.AddRange(new object[] {
            this.comboItem1});
            this.comboMoneda.Location = new System.Drawing.Point(247, 191);
            this.comboMoneda.Name = "comboMoneda";
            this.comboMoneda.Size = new System.Drawing.Size(192, 20);
            this.comboMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboMoneda.TabIndex = 5;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "NIO-Córdobas Nicaragüenses";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(193, 188);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(43, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "Moneda:";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.BackColor = System.Drawing.Color.White;
            this.tabItem1.BackColor2 = System.Drawing.Color.White;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "--- Pago ---        ";
            // 
            // dataGridDescripcionPago
            // 
            this.dataGridDescripcionPago.AllowUserToAddRows = false;
            this.dataGridDescripcionPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridDescripcionPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDescripcionPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.monto,
            this.control,
            this.fecha,
            this.peri_pago,
            this.monto_pend,
            this.observaciones,
            this.cod_caso,
            this.num_pago,
            this.monto_Pago});
            this.dataGridDescripcionPago.Location = new System.Drawing.Point(10, 37);
            this.dataGridDescripcionPago.MultiSelect = false;
            this.dataGridDescripcionPago.Name = "dataGridDescripcionPago";
            this.dataGridDescripcionPago.Size = new System.Drawing.Size(458, 390);
            this.dataGridDescripcionPago.TabIndex = 11;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descripcion.Width = 300;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // control
            // 
            this.control.HeaderText = "control";
            this.control.Name = "control";
            this.control.Visible = false;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Visible = false;
            // 
            // peri_pago
            // 
            this.peri_pago.HeaderText = "Periodo";
            this.peri_pago.Name = "peri_pago";
            this.peri_pago.Visible = false;
            // 
            // monto_pend
            // 
            this.monto_pend.HeaderText = "montoPendiente";
            this.monto_pend.Name = "monto_pend";
            this.monto_pend.Visible = false;
            // 
            // observaciones
            // 
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.Visible = false;
            // 
            // cod_caso
            // 
            this.cod_caso.HeaderText = "codigocaso";
            this.cod_caso.Name = "cod_caso";
            this.cod_caso.Visible = false;
            // 
            // num_pago
            // 
            this.num_pago.HeaderText = "Column1";
            this.num_pago.Name = "num_pago";
            this.num_pago.Visible = false;
            // 
            // monto_Pago
            // 
            this.monto_Pago.HeaderText = "Column1";
            this.monto_Pago.Name = "monto_Pago";
            this.monto_Pago.Visible = false;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.dataGridDescripcionPago);
            this.expandablePanel1.Location = new System.Drawing.Point(476, 12);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(485, 440);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 13;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Pagos";
            // 
            // RealizarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(933, 457);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.tabControl2);
            this.Name = "RealizarPago";
            this.Text = "RealizarPago";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl2)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechaPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDescripcionPago)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtNombreCliente;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtMonto;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.RadioButton radioOtro;
        private System.Windows.Forms.RadioButton radioCaso;
        private System.Windows.Forms.RadioButton radioMembresia;
        private DevComponents.DotNetBar.TabControl tabControl2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboMoneda;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput fechaPago;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRecibidoPor;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtObservacion;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnAgregarPago;
        private System.Windows.Forms.DataGridView dataGridDescripcionPago;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscarCaso;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDinamico;
        private DevComponents.DotNetBar.LabelX lbDinamico;
        private DevComponents.DotNetBar.ButtonX btnCrearRecibo;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn control;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn peri_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_pend;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_caso;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_Pago;

    }
}