namespace Sistema_De_Administracion_De_Servicios
{
    partial class ControlFiltroBusqueda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboValor = new System.Windows.Forms.ComboBox();
            this.etiEncontrados = new System.Windows.Forms.Label();
            this.dgvFiltro = new System.Windows.Forms.DataGridView();
            this.operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expresion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarSiguiente = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cboClausula = new System.Windows.Forms.ComboBox();
            this.dtpValor = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboModo = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.txtEncontrados = new System.Windows.Forms.TextBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboValor
            // 
            this.cboValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValor.FormattingEnabled = true;
            this.cboValor.Location = new System.Drawing.Point(282, 20);
            this.cboValor.Margin = new System.Windows.Forms.Padding(10);
            this.cboValor.Name = "cboValor";
            this.cboValor.Size = new System.Drawing.Size(171, 21);
            this.cboValor.TabIndex = 37;
            this.cboValor.Visible = false;
            // 
            // etiEncontrados
            // 
            this.etiEncontrados.AutoSize = true;
            this.etiEncontrados.Location = new System.Drawing.Point(409, 53);
            this.etiEncontrados.Name = "etiEncontrados";
            this.etiEncontrados.Size = new System.Drawing.Size(70, 13);
            this.etiEncontrados.TabIndex = 36;
            this.etiEncontrados.Text = "Encontrados:";
            this.etiEncontrados.Visible = false;
            // 
            // dgvFiltro
            // 
            this.dgvFiltro.AllowUserToAddRows = false;
            this.dgvFiltro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operador,
            this.campo,
            this.expresion,
            this.valor});
            this.dgvFiltro.Location = new System.Drawing.Point(20, 77);
            this.dgvFiltro.Name = "dgvFiltro";
            this.dgvFiltro.RowHeadersVisible = false;
            this.dgvFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltro.Size = new System.Drawing.Size(504, 86);
            this.dgvFiltro.TabIndex = 35;
            this.dgvFiltro.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvFiltro_RowsRemoved);
            // 
            // operador
            // 
            this.operador.HeaderText = "";
            this.operador.Name = "operador";
            // 
            // campo
            // 
            this.campo.HeaderText = "Campo";
            this.campo.Name = "campo";
            // 
            // expresion
            // 
            this.expresion.HeaderText = "Expresion";
            this.expresion.Name = "expresion";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // btnBuscarSiguiente
            // 
            this.btnBuscarSiguiente.Location = new System.Drawing.Point(129, 48);
            this.btnBuscarSiguiente.Name = "btnBuscarSiguiente";
            this.btnBuscarSiguiente.Size = new System.Drawing.Size(103, 23);
            this.btnBuscarSiguiente.TabIndex = 34;
            this.btnBuscarSiguiente.Text = "Encontrar Siguiente";
            this.btnBuscarSiguiente.UseVisualStyleBackColor = true;
            this.btnBuscarSiguiente.Click += new System.EventHandler(this.btnBuscarSiguiente_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(20, 48);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(103, 23);
            this.btnFiltrar.TabIndex = 33;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cboClausula
            // 
            this.cboClausula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClausula.Enabled = false;
            this.cboClausula.FormattingEnabled = true;
            this.cboClausula.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cboClausula.Location = new System.Drawing.Point(20, 20);
            this.cboClausula.Margin = new System.Windows.Forms.Padding(10);
            this.cboClausula.Name = "cboClausula";
            this.cboClausula.Size = new System.Drawing.Size(47, 21);
            this.cboClausula.TabIndex = 32;
            // 
            // dtpValor
            // 
            this.dtpValor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValor.Location = new System.Drawing.Point(282, 21);
            this.dtpValor.Name = "dtpValor";
            this.dtpValor.Size = new System.Drawing.Size(171, 20);
            this.dtpValor.TabIndex = 31;
            this.dtpValor.Visible = false;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(282, 21);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(171, 20);
            this.txtValor.TabIndex = 30;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(20, 169);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.ReadOnly = true;
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFiltro.Size = new System.Drawing.Size(504, 22);
            this.txtFiltro.TabIndex = 29;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(459, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(65, 23);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboModo
            // 
            this.cboModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModo.FormattingEnabled = true;
            this.cboModo.Items.AddRange(new object[] {
            "=",
            "<>",
            "<",
            ">"});
            this.cboModo.Location = new System.Drawing.Point(237, 20);
            this.cboModo.Margin = new System.Windows.Forms.Padding(10);
            this.cboModo.Name = "cboModo";
            this.cboModo.Size = new System.Drawing.Size(36, 21);
            this.cboModo.TabIndex = 27;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Items.AddRange(new object[] {
            "cod_empr",
            "nombre",
            "departamento"});
            this.cboCampo.Location = new System.Drawing.Point(80, 20);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(146, 21);
            this.cboCampo.TabIndex = 26;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // txtEncontrados
            // 
            this.txtEncontrados.Location = new System.Drawing.Point(485, 50);
            this.txtEncontrados.Name = "txtEncontrados";
            this.txtEncontrados.ReadOnly = true;
            this.txtEncontrados.Size = new System.Drawing.Size(39, 20);
            this.txtEncontrados.TabIndex = 39;
            this.txtEncontrados.Visible = false;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AllowUserToResizeRows = false;
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewX1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 20);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.PaintEnhancedSelection = false;
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(504, 0);
            this.dataGridViewX1.TabIndex = 1;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.AutoSize = true;
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.expandablePanel1.Controls.Add(this.dataGridViewX1);
            this.expandablePanel1.ExpandButtonAlignment = DevComponents.DotNetBar.eTitleButtonAlignment.Left;
            this.expandablePanel1.Expanded = false;
            this.expandablePanel1.ExpandedBounds = new System.Drawing.Rectangle(20, 197, 504, 200);
            this.expandablePanel1.ExpandOnTitleClick = true;
            this.expandablePanel1.Location = new System.Drawing.Point(20, 197);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(504, 20);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.expandablePanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.Etched;
            this.expandablePanel1.Style.BorderColor.Color = System.Drawing.Color.Black;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 38;
            this.expandablePanel1.TitleHeight = 20;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.Etched;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.expandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Resultado";
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(237, 48);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(103, 23);
            this.btnLimpiarFiltro.TabIndex = 40;
            this.btnLimpiarFiltro.Text = "Limpiar Filtro";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // ControlFiltroBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.txtEncontrados);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.cboValor);
            this.Controls.Add(this.etiEncontrados);
            this.Controls.Add(this.dgvFiltro);
            this.Controls.Add(this.btnBuscarSiguiente);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cboClausula);
            this.Controls.Add(this.dtpValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboModo);
            this.Controls.Add(this.cboCampo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(543, 410);
            this.MinimumSize = new System.Drawing.Size(537, 230);
            this.Name = "ControlFiltroBusqueda";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(537, 230);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboValor;
        private System.Windows.Forms.Label etiEncontrados;
        private System.Windows.Forms.DataGridView dgvFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn operador;
        private System.Windows.Forms.DataGridViewTextBoxColumn campo;
        private System.Windows.Forms.DataGridViewTextBoxColumn expresion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.Button btnBuscarSiguiente;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cboClausula;
        private System.Windows.Forms.DateTimePicker dtpValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboModo;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.TextBox txtEncontrados;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private System.Windows.Forms.Button btnLimpiarFiltro;

    }
}
