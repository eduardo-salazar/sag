namespace Sistema_De_Administracion_De_Servicios
{
    partial class FormularioSeleccionDestinatarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioSeleccionDestinatarios));
            this.dataGridViewContactos = new System.Windows.Forms.DataGridView();
            this.icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombreContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectrónicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnetEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaDataSet = new Sistema_De_Administracion_De_Servicios.EmpresaDataSet();
            this.txtCco = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPara = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.CheckBox();
            this.btnCc = new System.Windows.Forms.CheckBox();
            this.btnCco = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.sliderItem1 = new DevComponents.DotNetBar.SliderItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.optPrincipal = new DevComponents.DotNetBar.ButtonItem();
            this.optSuplente1 = new DevComponents.DotNetBar.ButtonItem();
            this.optSuplente2 = new DevComponents.DotNetBar.ButtonItem();
            this.optSuplente3 = new DevComponents.DotNetBar.ButtonItem();
            this.btnFiltrar = new DevComponents.DotNetBar.ButtonItem();
            this.controlContainerItem7 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem3 = new DevComponents.DotNetBar.ControlContainerItem();
            this.contactoEmpresaTableAdapter = new Sistema_De_Administracion_De_Servicios.EmpresaDataSetTableAdapters.ContactoEmpresaTableAdapter();
            this.ico = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombreContactoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoContactoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectrónicoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContactos
            // 
            this.dataGridViewContactos.AllowUserToAddRows = false;
            this.dataGridViewContactos.AllowUserToDeleteRows = false;
            this.dataGridViewContactos.AllowUserToResizeRows = false;
            this.dataGridViewContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContactos.AutoGenerateColumns = false;
            this.dataGridViewContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContactos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewContactos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewContactos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewContactos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewContactos.ColumnHeadersHeight = 20;
            this.dataGridViewContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.icon,
            this.nombreContactoDataGridViewTextBoxColumn,
            this.cargoContactoDataGridViewTextBoxColumn,
            this.correoElectrónicoDataGridViewTextBoxColumn,
            this.carnetEmpresaDataGridViewTextBoxColumn,
            this.nombreEmpresaDataGridViewTextBoxColumn});
            this.dataGridViewContactos.DataSource = this.contactoEmpresaBindingSource;
            this.dataGridViewContactos.EnableHeadersVisualStyles = false;
            this.dataGridViewContactos.GridColor = System.Drawing.Color.White;
            this.dataGridViewContactos.Location = new System.Drawing.Point(12, 67);
            this.dataGridViewContactos.Name = "dataGridViewContactos";
            this.dataGridViewContactos.ReadOnly = true;
            this.dataGridViewContactos.RowHeadersVisible = false;
            this.dataGridViewContactos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContactos.Size = new System.Drawing.Size(604, 137);
            this.dataGridViewContactos.TabIndex = 1;
            this.dataGridViewContactos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContactos_CellDoubleClick);
            this.dataGridViewContactos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewContactos_CellFormatting);
            // 
            // icon
            // 
            this.icon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.icon.HeaderText = "";
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Name = "icon";
            this.icon.ReadOnly = true;
            this.icon.Width = 20;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            this.nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "Nombre Contacto";
            this.nombreContactoDataGridViewTextBoxColumn.HeaderText = "Nombre Contacto";
            this.nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            this.nombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoContactoDataGridViewTextBoxColumn
            // 
            this.cargoContactoDataGridViewTextBoxColumn.DataPropertyName = "Cargo Contacto";
            this.cargoContactoDataGridViewTextBoxColumn.HeaderText = "Cargo Contacto";
            this.cargoContactoDataGridViewTextBoxColumn.Name = "cargoContactoDataGridViewTextBoxColumn";
            this.cargoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoElectrónicoDataGridViewTextBoxColumn
            // 
            this.correoElectrónicoDataGridViewTextBoxColumn.DataPropertyName = "Correo Electrónico";
            this.correoElectrónicoDataGridViewTextBoxColumn.HeaderText = "Correo Electrónico";
            this.correoElectrónicoDataGridViewTextBoxColumn.Name = "correoElectrónicoDataGridViewTextBoxColumn";
            this.correoElectrónicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carnetEmpresaDataGridViewTextBoxColumn
            // 
            this.carnetEmpresaDataGridViewTextBoxColumn.DataPropertyName = "Carnet Empresa";
            this.carnetEmpresaDataGridViewTextBoxColumn.HeaderText = "Carnet Empresa";
            this.carnetEmpresaDataGridViewTextBoxColumn.Name = "carnetEmpresaDataGridViewTextBoxColumn";
            this.carnetEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEmpresaDataGridViewTextBoxColumn
            // 
            this.nombreEmpresaDataGridViewTextBoxColumn.DataPropertyName = "Nombre Empresa";
            this.nombreEmpresaDataGridViewTextBoxColumn.HeaderText = "Nombre Empresa";
            this.nombreEmpresaDataGridViewTextBoxColumn.Name = "nombreEmpresaDataGridViewTextBoxColumn";
            this.nombreEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactoEmpresaBindingSource
            // 
            this.contactoEmpresaBindingSource.DataMember = "ContactoEmpresa";
            this.contactoEmpresaBindingSource.DataSource = this.empresaDataSet;
            // 
            // empresaDataSet
            // 
            this.empresaDataSet.DataSetName = "EmpresaDataSet";
            this.empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCco
            // 
            this.txtCco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCco.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCco.Border.Class = "TextBoxBorder";
            this.txtCco.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCco.Location = new System.Drawing.Point(78, 348);
            this.txtCco.MaximumSize = new System.Drawing.Size(0, 60);
            this.txtCco.MinimumSize = new System.Drawing.Size(537, 20);
            this.txtCco.Multiline = true;
            this.txtCco.Name = "txtCco";
            this.txtCco.Size = new System.Drawing.Size(537, 40);
            this.txtCco.TabIndex = 13;
            // 
            // txtCc
            // 
            this.txtCc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCc.Border.Class = "TextBoxBorder";
            this.txtCc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCc.Location = new System.Drawing.Point(79, 302);
            this.txtCc.MaximumSize = new System.Drawing.Size(0, 60);
            this.txtCc.MinimumSize = new System.Drawing.Size(537, 20);
            this.txtCc.Multiline = true;
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(537, 40);
            this.txtCc.TabIndex = 12;
            // 
            // txtPara
            // 
            this.txtPara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPara.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPara.Border.Class = "TextBoxBorder";
            this.txtPara.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPara.Location = new System.Drawing.Point(79, 256);
            this.txtPara.MaximumSize = new System.Drawing.Size(0, 60);
            this.txtPara.MinimumSize = new System.Drawing.Size(537, 20);
            this.txtPara.Multiline = true;
            this.txtPara.Name = "txtPara";
            this.txtPara.PreventEnterBeep = true;
            this.txtPara.Size = new System.Drawing.Size(537, 40);
            this.txtPara.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(460, 403);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(541, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPara
            // 
            this.btnPara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPara.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPara.Location = new System.Drawing.Point(13, 256);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(60, 40);
            this.btnPara.TabIndex = 25;
            this.btnPara.Text = "Para";
            this.btnPara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPara.UseVisualStyleBackColor = true;
            // 
            // btnCc
            // 
            this.btnCc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCc.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnCc.Location = new System.Drawing.Point(13, 302);
            this.btnCc.Name = "btnCc";
            this.btnCc.Size = new System.Drawing.Size(60, 40);
            this.btnCc.TabIndex = 26;
            this.btnCc.Text = "Cc";
            this.btnCc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCc.UseVisualStyleBackColor = true;
            // 
            // btnCco
            // 
            this.btnCco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCco.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnCco.Location = new System.Drawing.Point(12, 349);
            this.btnCco.Name = "btnCco";
            this.btnCco.Size = new System.Drawing.Size(60, 40);
            this.btnCco.TabIndex = 27;
            this.btnCco.Text = "Cco";
            this.btnCco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCco.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Location = new System.Drawing.Point(185, 210);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(259, 40);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.ribbonBar1.Location = new System.Drawing.Point(65, 84);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(75, 78);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "ribbonBar1";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "buttonItem1";
            // 
            // sliderItem1
            // 
            this.sliderItem1.Name = "sliderItem1";
            this.sliderItem1.Text = "sliderItem1";
            this.sliderItem1.Value = 0;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.controlContainerItem1});
            this.ribbonBar2.Location = new System.Drawing.Point(39, 79);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(136, 96);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 33;
            this.ribbonBar2.Text = "ribbonBar2";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = global::Sistema_De_Administracion_De_Servicios.Properties.Resources.find48;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 14;
            this.buttonItem2.Text = "buttonItem2";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = true;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem2});
            this.ribbonBar3.Location = new System.Drawing.Point(78, 32);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(75, 23);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 33;
            this.ribbonBar3.Text = "ribbonBar3";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = true;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "bar1 (bar1)";
            this.bar1.AccessibleName = "bar1";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem2,
            this.optPrincipal,
            this.optSuplente1,
            this.optSuplente2,
            this.optSuplente3,
            this.btnFiltrar});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(628, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 32;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.PaddingLeft = 20;
            this.labelItem2.PaddingRight = 20;
            this.labelItem2.Text = "Mostrar Contactos";
            // 
            // optPrincipal
            // 
            this.optPrincipal.AutoCheckOnClick = true;
            this.optPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("optPrincipal.Image")));
            this.optPrincipal.Name = "optPrincipal";
            this.optPrincipal.OptionGroup = "groupContactos";
            this.optPrincipal.Tooltip = "Contacto Principal";
            this.optPrincipal.CheckedChanged += new System.EventHandler(this.radioButtonMostrarContactos_CheckedChanged);
            // 
            // optSuplente1
            // 
            this.optSuplente1.AutoCheckOnClick = true;
            this.optSuplente1.Image = ((System.Drawing.Image)(resources.GetObject("optSuplente1.Image")));
            this.optSuplente1.Name = "optSuplente1";
            this.optSuplente1.OptionGroup = "groupContactos";
            this.optSuplente1.Tooltip = "Suplente 1";
            this.optSuplente1.CheckedChanged += new System.EventHandler(this.radioButtonMostrarContactos_CheckedChanged);
            // 
            // optSuplente2
            // 
            this.optSuplente2.AutoCheckOnClick = true;
            this.optSuplente2.Image = ((System.Drawing.Image)(resources.GetObject("optSuplente2.Image")));
            this.optSuplente2.Name = "optSuplente2";
            this.optSuplente2.OptionGroup = "groupContactos";
            this.optSuplente2.Tooltip = "Suplente 2";
            this.optSuplente2.CheckedChanged += new System.EventHandler(this.radioButtonMostrarContactos_CheckedChanged);
            // 
            // optSuplente3
            // 
            this.optSuplente3.AutoCheckOnClick = true;
            this.optSuplente3.Image = ((System.Drawing.Image)(resources.GetObject("optSuplente3.Image")));
            this.optSuplente3.Name = "optSuplente3";
            this.optSuplente3.OptionGroup = "groupContactos";
            this.optSuplente3.Tooltip = "Suplente 3";
            this.optSuplente3.CheckedChanged += new System.EventHandler(this.radioButtonMostrarContactos_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BeginGroup = true;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Tooltip = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // controlContainerItem7
            // 
            this.controlContainerItem7.AllowItemResize = false;
            this.controlContainerItem7.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem7.Name = "controlContainerItem7";
            // 
            // controlContainerItem3
            // 
            this.controlContainerItem3.AllowItemResize = false;
            this.controlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem3.Name = "controlContainerItem3";
            // 
            // contactoEmpresaTableAdapter
            // 
            this.contactoEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // ico
            // 
            this.ico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ico.FillWeight = 60.9137F;
            this.ico.HeaderText = "";
            this.ico.Image = ((System.Drawing.Image)(resources.GetObject("ico.Image")));
            this.ico.MinimumWidth = 20;
            this.ico.Name = "ico";
            this.ico.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ico.Width = 20;
            // 
            // nombreContactoDataGridViewTextBoxColumn1
            // 
            this.nombreContactoDataGridViewTextBoxColumn1.DataPropertyName = "Nombre Contacto";
            this.nombreContactoDataGridViewTextBoxColumn1.FillWeight = 107.8173F;
            this.nombreContactoDataGridViewTextBoxColumn1.HeaderText = "Nombre Contacto";
            this.nombreContactoDataGridViewTextBoxColumn1.Name = "nombreContactoDataGridViewTextBoxColumn1";
            this.nombreContactoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombreContactoDataGridViewTextBoxColumn1.Width = 116;
            // 
            // cargoContactoDataGridViewTextBoxColumn1
            // 
            this.cargoContactoDataGridViewTextBoxColumn1.DataPropertyName = "Cargo Contacto";
            this.cargoContactoDataGridViewTextBoxColumn1.FillWeight = 107.8173F;
            this.cargoContactoDataGridViewTextBoxColumn1.HeaderText = "Cargo Contacto";
            this.cargoContactoDataGridViewTextBoxColumn1.Name = "cargoContactoDataGridViewTextBoxColumn1";
            this.cargoContactoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cargoContactoDataGridViewTextBoxColumn1.Width = 117;
            // 
            // correoElectrónicoDataGridViewTextBoxColumn1
            // 
            this.correoElectrónicoDataGridViewTextBoxColumn1.DataPropertyName = "Correo Electrónico";
            this.correoElectrónicoDataGridViewTextBoxColumn1.FillWeight = 107.8173F;
            this.correoElectrónicoDataGridViewTextBoxColumn1.HeaderText = "Correo Electrónico";
            this.correoElectrónicoDataGridViewTextBoxColumn1.Name = "correoElectrónicoDataGridViewTextBoxColumn1";
            this.correoElectrónicoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.correoElectrónicoDataGridViewTextBoxColumn1.Width = 116;
            // 
            // FormularioSeleccionDestinatarios
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(628, 438);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCco);
            this.Controls.Add(this.btnCc);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCco);
            this.Controls.Add(this.txtCc);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.dataGridViewContactos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormularioSeleccionDestinatarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioSeleccionDestinatarios";
            this.Load += new System.EventHandler(this.FormularioSeleccionDestinatarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EmpresaDataSet empresaDataSet;
        private System.Windows.Forms.BindingSource contactoEmpresaBindingSource;
        private EmpresaDataSetTableAdapters.ContactoEmpresaTableAdapter contactoEmpresaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewContactos;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCco;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCc;
        public DevComponents.DotNetBar.Controls.TextBoxX txtPara;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox btnPara;
        private System.Windows.Forms.CheckBox btnCc;
        private System.Windows.Forms.CheckBox btnCco;
        private System.Windows.Forms.Button btnAgregar;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.SliderItem sliderItem1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ButtonItem btnFiltrar;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem7;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;
        private DevComponents.DotNetBar.ButtonItem optPrincipal;
        private DevComponents.DotNetBar.ButtonItem optSuplente1;
        private DevComponents.DotNetBar.ButtonItem optSuplente2;
        private DevComponents.DotNetBar.ButtonItem optSuplente3;
        private System.Windows.Forms.DataGridViewImageColumn ico;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoContactoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectrónicoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectrónicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnetEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpresaDataGridViewTextBoxColumn;
    }
}