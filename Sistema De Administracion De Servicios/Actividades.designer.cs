namespace Sistema_De_Administracion_De_Servicios
{
    partial class Actividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actividades));
            this.labelX27 = new DevComponents.DotNetBar.LabelX();
            this.cbTipSolic = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ipFechCierre = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkbActCerrada = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkbRealizado = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txObservacionesA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ipFechProg = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txRef = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.labelX25 = new DevComponents.DotNetBar.LabelX();
            this.labelX24 = new DevComponents.DotNetBar.LabelX();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.labelX21 = new DevComponents.DotNetBar.LabelX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.cbTipoAct = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnAgregarAct = new DevComponents.DotNetBar.ButtonX();
            this.btnCambiosAct = new DevComponents.DotNetBar.ButtonX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Campo Requerido");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.ipFechCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipFechProg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX27
            // 
            // 
            // 
            // 
            this.labelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX27.Location = new System.Drawing.Point(6, 14);
            this.labelX27.Name = "labelX27";
            this.labelX27.Size = new System.Drawing.Size(95, 23);
            this.labelX27.TabIndex = 62;
            this.labelX27.Text = "Tipo de Solicitud :";
            // 
            // cbTipSolic
            // 
            this.cbTipSolic.DisplayMember = "Text";
            this.cbTipSolic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipSolic.FormattingEnabled = true;
            this.cbTipSolic.ItemHeight = 14;
            this.cbTipSolic.Location = new System.Drawing.Point(116, 12);
            this.cbTipSolic.Name = "cbTipSolic";
            this.cbTipSolic.Size = new System.Drawing.Size(173, 20);
            this.cbTipSolic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTipSolic.TabIndex = 61;
            // 
            // ipFechCierre
            // 
            // 
            // 
            // 
            this.ipFechCierre.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ipFechCierre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipFechCierre.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.ipFechCierre.ButtonDropDown.Visible = true;
            this.ipFechCierre.IsPopupCalendarOpen = false;
            this.ipFechCierre.Location = new System.Drawing.Point(116, 139);
            // 
            // 
            // 
            this.ipFechCierre.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ipFechCierre.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipFechCierre.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.ipFechCierre.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.ipFechCierre.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.ipFechCierre.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.ipFechCierre.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ipFechCierre.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ipFechCierre.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.ipFechCierre.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.ipFechCierre.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipFechCierre.MonthCalendar.DisplayMonth = new System.DateTime(2012, 6, 1, 0, 0, 0, 0);
            this.ipFechCierre.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.ipFechCierre.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ipFechCierre.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.ipFechCierre.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.ipFechCierre.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ipFechCierre.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipFechCierre.MonthCalendar.TodayButtonVisible = true;
            this.ipFechCierre.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.ipFechCierre.Name = "ipFechCierre";
            this.ipFechCierre.Size = new System.Drawing.Size(173, 20);
            this.ipFechCierre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ipFechCierre.TabIndex = 60;
            // 
            // chkbActCerrada
            // 
            // 
            // 
            // 
            this.chkbActCerrada.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkbActCerrada.Location = new System.Drawing.Point(245, 107);
            this.chkbActCerrada.Name = "chkbActCerrada";
            this.chkbActCerrada.Size = new System.Drawing.Size(32, 23);
            this.chkbActCerrada.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkbActCerrada.TabIndex = 59;
            // 
            // chkbRealizado
            // 
            // 
            // 
            // 
            this.chkbRealizado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkbRealizado.Location = new System.Drawing.Point(74, 107);
            this.chkbRealizado.Name = "chkbRealizado";
            this.chkbRealizado.Size = new System.Drawing.Size(18, 23);
            this.chkbRealizado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkbRealizado.TabIndex = 58;
            // 
            // txObservacionesA
            // 
            this.txObservacionesA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txObservacionesA.Border.Class = "TextBoxBorder";
            this.txObservacionesA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txObservacionesA.ForeColor = System.Drawing.Color.Black;
            this.txObservacionesA.Location = new System.Drawing.Point(318, 99);
            this.txObservacionesA.Multiline = true;
            this.txObservacionesA.Name = "txObservacionesA";
            this.txObservacionesA.Size = new System.Drawing.Size(354, 52);
            this.txObservacionesA.TabIndex = 57;
            // 
            // ipFechProg
            // 
            // 
            // 
            // 
            this.ipFechProg.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ipFechProg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipFechProg.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.ipFechProg.ButtonDropDown.Visible = true;
            this.ipFechProg.IsPopupCalendarOpen = false;
            this.ipFechProg.Location = new System.Drawing.Point(116, 64);
            // 
            // 
            // 
            this.ipFechProg.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ipFechProg.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipFechProg.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.ipFechProg.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.ipFechProg.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.ipFechProg.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.ipFechProg.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ipFechProg.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ipFechProg.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.ipFechProg.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.ipFechProg.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipFechProg.MonthCalendar.DisplayMonth = new System.DateTime(2012, 6, 1, 0, 0, 0, 0);
            this.ipFechProg.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.ipFechProg.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ipFechProg.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.ipFechProg.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.ipFechProg.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ipFechProg.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipFechProg.MonthCalendar.TodayButtonVisible = true;
            this.ipFechProg.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.ipFechProg.Name = "ipFechProg";
            this.ipFechProg.Size = new System.Drawing.Size(173, 20);
            this.ipFechProg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ipFechProg.TabIndex = 51;
            this.superValidator1.SetValidator1(this.ipFechProg, this.requiredFieldValidator1);
            // 
            // txRef
            // 
            this.txRef.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txRef.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txRef.ForeColor = System.Drawing.Color.Black;
            this.txRef.Location = new System.Drawing.Point(318, 30);
            this.txRef.Multiline = true;
            this.txRef.Name = "txRef";
            this.txRef.Size = new System.Drawing.Size(354, 45);
            this.txRef.TabIndex = 56;
            // 
            // labelX26
            // 
            // 
            // 
            // 
            this.labelX26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX26.Location = new System.Drawing.Point(318, 81);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(93, 23);
            this.labelX26.TabIndex = 55;
            this.labelX26.Text = "Observaciones :";
            // 
            // labelX25
            // 
            // 
            // 
            // 
            this.labelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX25.Location = new System.Drawing.Point(6, 136);
            this.labelX25.Name = "labelX25";
            this.labelX25.Size = new System.Drawing.Size(93, 23);
            this.labelX25.TabIndex = 54;
            this.labelX25.Text = "Fecha de Cierre :";
            // 
            // labelX24
            // 
            // 
            // 
            // 
            this.labelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX24.Location = new System.Drawing.Point(144, 107);
            this.labelX24.Name = "labelX24";
            this.labelX24.Size = new System.Drawing.Size(95, 23);
            this.labelX24.TabIndex = 53;
            this.labelX24.Text = "Actividad Cerrada :";
            // 
            // labelX23
            // 
            // 
            // 
            // 
            this.labelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX23.Location = new System.Drawing.Point(6, 107);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(75, 23);
            this.labelX23.TabIndex = 52;
            this.labelX23.Text = "Realizado :";
            // 
            // labelX22
            // 
            // 
            // 
            // 
            this.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX22.Location = new System.Drawing.Point(6, 64);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(111, 23);
            this.labelX22.TabIndex = 50;
            this.labelX22.Text = "Fecha Programada :";
            // 
            // labelX21
            // 
            // 
            // 
            // 
            this.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX21.Location = new System.Drawing.Point(318, 9);
            this.labelX21.Name = "labelX21";
            this.labelX21.Size = new System.Drawing.Size(75, 23);
            this.labelX21.TabIndex = 49;
            this.labelX21.Text = "Referencia :";
            // 
            // labelX20
            // 
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Location = new System.Drawing.Point(6, 35);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(95, 23);
            this.labelX20.TabIndex = 48;
            this.labelX20.Text = "Tipo de Actividad :";
            // 
            // cbTipoAct
            // 
            this.cbTipoAct.DisplayMember = "Text";
            this.cbTipoAct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoAct.FormattingEnabled = true;
            this.cbTipoAct.ItemHeight = 14;
            this.cbTipoAct.Location = new System.Drawing.Point(116, 38);
            this.cbTipoAct.Name = "cbTipoAct";
            this.cbTipoAct.Size = new System.Drawing.Size(173, 20);
            this.cbTipoAct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTipoAct.TabIndex = 47;
            // 
            // btnAgregarAct
            // 
            this.btnAgregarAct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarAct.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregarAct.Location = new System.Drawing.Point(588, 176);
            this.btnAgregarAct.Name = "btnAgregarAct";
            this.btnAgregarAct.Size = new System.Drawing.Size(107, 23);
            this.btnAgregarAct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregarAct.TabIndex = 63;
            this.btnAgregarAct.Text = "Agregar Actividad";
            this.btnAgregarAct.Click += new System.EventHandler(this.btnAgregarAct_Click);
            // 
            // btnCambiosAct
            // 
            this.btnCambiosAct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCambiosAct.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCambiosAct.Location = new System.Drawing.Point(481, 176);
            this.btnCambiosAct.Name = "btnCambiosAct";
            this.btnCambiosAct.Size = new System.Drawing.Size(101, 23);
            this.btnCambiosAct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCambiosAct.TabIndex = 64;
            this.btnCambiosAct.Text = "Guardar Cambios";
            this.btnCambiosAct.Visible = false;
            this.btnCambiosAct.Click += new System.EventHandler(this.btnCambiosAct_Click);
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Campo Requerido";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 214);
            this.Controls.Add(this.btnCambiosAct);
            this.Controls.Add(this.btnAgregarAct);
            this.Controls.Add(this.labelX27);
            this.Controls.Add(this.cbTipSolic);
            this.Controls.Add(this.ipFechCierre);
            this.Controls.Add(this.chkbActCerrada);
            this.Controls.Add(this.chkbRealizado);
            this.Controls.Add(this.txObservacionesA);
            this.Controls.Add(this.ipFechProg);
            this.Controls.Add(this.txRef);
            this.Controls.Add(this.labelX26);
            this.Controls.Add(this.labelX25);
            this.Controls.Add(this.labelX24);
            this.Controls.Add(this.labelX23);
            this.Controls.Add(this.labelX22);
            this.Controls.Add(this.labelX21);
            this.Controls.Add(this.labelX20);
            this.Controls.Add(this.cbTipoAct);
            this.Name = "Actividades";
            this.Text = "Actividades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Actividades_FormClosed);
            this.Load += new System.EventHandler(this.Actividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ipFechCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipFechProg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX27;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTipSolic;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput ipFechCierre;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkbActCerrada;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkbRealizado;
        private DevComponents.DotNetBar.Controls.TextBoxX txObservacionesA;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput ipFechProg;
        private DevComponents.DotNetBar.Controls.TextBoxX txRef;
        private DevComponents.DotNetBar.LabelX labelX26;
        private DevComponents.DotNetBar.LabelX labelX25;
        private DevComponents.DotNetBar.LabelX labelX24;
        private DevComponents.DotNetBar.LabelX labelX23;
        private DevComponents.DotNetBar.LabelX labelX22;
        private DevComponents.DotNetBar.LabelX labelX21;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTipoAct;
        private DevComponents.DotNetBar.ButtonX btnAgregarAct;
        private DevComponents.DotNetBar.ButtonX btnCambiosAct;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
    }
}