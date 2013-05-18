namespace Sistema_De_Administracion_De_Servicios
{
    partial class FormUsuario
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
            this.txtCodUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.etiCodigoUsuario = new DevComponents.DotNetBar.LabelX();
            this.chkActivo = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.etiUsuario = new DevComponents.DotNetBar.LabelX();
            this.etiFechFin = new DevComponents.DotNetBar.LabelX();
            this.dtFechFin = new System.Windows.Forms.DateTimePicker();
            this.etiFechIni = new DevComponents.DotNetBar.LabelX();
            this.dtFechIni = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.etiTelefono = new DevComponents.DotNetBar.LabelX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.etiEmail = new DevComponents.DotNetBar.LabelX();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.etiNombre = new DevComponents.DotNetBar.LabelX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cADINDataSet = new Sistema_De_Administracion_De_Servicios.CADINDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Sistema_De_Administracion_De_Servicios.CADINDataSetTableAdapters.UsuarioTableAdapter();
            this.codusuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechinicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechsaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkAdmin = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCodUsuario.Border.Class = "TextBoxBorder";
            this.txtCodUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "cod_usua", true));
            this.txtCodUsuario.Enabled = false;
            this.txtCodUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtCodUsuario.Location = new System.Drawing.Point(173, 37);
            this.txtCodUsuario.Margin = new System.Windows.Forms.Padding(10);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtCodUsuario.TabIndex = 37;
            // 
            // etiCodigoUsuario
            // 
            // 
            // 
            // 
            this.etiCodigoUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiCodigoUsuario.Location = new System.Drawing.Point(85, 34);
            this.etiCodigoUsuario.Name = "etiCodigoUsuario";
            this.etiCodigoUsuario.Size = new System.Drawing.Size(75, 23);
            this.etiCodigoUsuario.TabIndex = 36;
            this.etiCodigoUsuario.Text = "Cod_Usuario:";
            // 
            // chkActivo
            // 
            // 
            // 
            // 
            this.chkActivo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkActivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckValue", this.usuarioBindingSource, "activo", true));
            this.chkActivo.Location = new System.Drawing.Point(503, 157);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(100, 23);
            this.chkActivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkActivo.TabIndex = 34;
            this.chkActivo.Text = "Usuario Activo";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "password", true));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(503, 117);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 22);
            this.txtPassword.TabIndex = 33;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(415, 114);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 32;
            this.labelX1.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUser.Border.Class = "TextBoxBorder";
            this.txtUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "usuario", true));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(503, 77);
            this.txtUser.Margin = new System.Windows.Forms.Padding(10);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(165, 22);
            this.txtUser.TabIndex = 31;
            // 
            // etiUsuario
            // 
            // 
            // 
            // 
            this.etiUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiUsuario.Location = new System.Drawing.Point(415, 74);
            this.etiUsuario.Name = "etiUsuario";
            this.etiUsuario.Size = new System.Drawing.Size(75, 23);
            this.etiUsuario.TabIndex = 30;
            this.etiUsuario.Text = "Usuario:";
            // 
            // etiFechFin
            // 
            // 
            // 
            // 
            this.etiFechFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiFechFin.Location = new System.Drawing.Point(85, 237);
            this.etiFechFin.Name = "etiFechFin";
            this.etiFechFin.Size = new System.Drawing.Size(75, 23);
            this.etiFechFin.TabIndex = 29;
            this.etiFechFin.Text = "Fecha Salida:";
            // 
            // dtFechFin
            // 
            this.dtFechFin.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuarioBindingSource, "fech_sali", true));
            this.dtFechFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechFin.Location = new System.Drawing.Point(173, 237);
            this.dtFechFin.Margin = new System.Windows.Forms.Padding(10);
            this.dtFechFin.Name = "dtFechFin";
            this.dtFechFin.Size = new System.Drawing.Size(165, 22);
            this.dtFechFin.TabIndex = 28;
            // 
            // etiFechIni
            // 
            // 
            // 
            // 
            this.etiFechIni.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiFechIni.Location = new System.Drawing.Point(85, 197);
            this.etiFechIni.Name = "etiFechIni";
            this.etiFechIni.Size = new System.Drawing.Size(75, 23);
            this.etiFechIni.TabIndex = 27;
            this.etiFechIni.Text = "Fecha Inicio:";
            // 
            // dtFechIni
            // 
            this.dtFechIni.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuarioBindingSource, "fech_inic", true));
            this.dtFechIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechIni.Location = new System.Drawing.Point(173, 197);
            this.dtFechIni.Margin = new System.Windows.Forms.Padding(10);
            this.dtFechIni.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtFechIni.Name = "dtFechIni";
            this.dtFechIni.Size = new System.Drawing.Size(165, 22);
            this.dtFechIni.TabIndex = 26;
            this.dtFechIni.Value = new System.DateTime(2012, 6, 1, 0, 0, 0, 0);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTelefono.Border.Class = "TextBoxBorder";
            this.txtTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "telf", true));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(173, 157);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(10);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(165, 22);
            this.txtTelefono.TabIndex = 25;
            // 
            // etiTelefono
            // 
            // 
            // 
            // 
            this.etiTelefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiTelefono.Location = new System.Drawing.Point(85, 154);
            this.etiTelefono.Name = "etiTelefono";
            this.etiTelefono.Size = new System.Drawing.Size(75, 23);
            this.etiTelefono.TabIndex = 24;
            this.etiTelefono.Text = "Teléfono:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "email", true));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(173, 117);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(10);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 22);
            this.txtEmail.TabIndex = 23;
            // 
            // etiEmail
            // 
            // 
            // 
            // 
            this.etiEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiEmail.Location = new System.Drawing.Point(85, 114);
            this.etiEmail.Name = "etiEmail";
            this.etiEmail.Size = new System.Drawing.Size(75, 23);
            this.etiEmail.TabIndex = 22;
            this.etiEmail.Text = "Email:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNombre.Border.Class = "TextBoxBorder";
            this.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "nombre", true));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(173, 77);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 22);
            this.txtNombre.TabIndex = 21;
            // 
            // etiNombre
            // 
            // 
            // 
            // 
            this.etiNombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiNombre.Location = new System.Drawing.Point(85, 74);
            this.etiNombre.Name = "etiNombre";
            this.etiNombre.Size = new System.Drawing.Size(75, 23);
            this.etiNombre.TabIndex = 20;
            this.etiNombre.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codusuaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telfDataGridViewTextBoxColumn,
            this.adminDataGridViewCheckBoxColumn,
            this.fechinicDataGridViewTextBoxColumn,
            this.fechsaliDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.usuarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 190);
            this.dataGridView1.TabIndex = 39;
            // 
            // cADINDataSet
            // 
            this.cADINDataSet.DataSetName = "CADINDataSet";
            this.cADINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.cADINDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // codusuaDataGridViewTextBoxColumn
            // 
            this.codusuaDataGridViewTextBoxColumn.DataPropertyName = "cod_usua";
            this.codusuaDataGridViewTextBoxColumn.HeaderText = "cod_usua";
            this.codusuaDataGridViewTextBoxColumn.Name = "codusuaDataGridViewTextBoxColumn";
            this.codusuaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telfDataGridViewTextBoxColumn
            // 
            this.telfDataGridViewTextBoxColumn.DataPropertyName = "telf";
            this.telfDataGridViewTextBoxColumn.HeaderText = "telf";
            this.telfDataGridViewTextBoxColumn.Name = "telfDataGridViewTextBoxColumn";
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            this.adminDataGridViewCheckBoxColumn.DataPropertyName = "admin";
            this.adminDataGridViewCheckBoxColumn.HeaderText = "admin";
            this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            // 
            // fechinicDataGridViewTextBoxColumn
            // 
            this.fechinicDataGridViewTextBoxColumn.DataPropertyName = "fech_inic";
            this.fechinicDataGridViewTextBoxColumn.HeaderText = "fech_inic";
            this.fechinicDataGridViewTextBoxColumn.Name = "fechinicDataGridViewTextBoxColumn";
            // 
            // fechsaliDataGridViewTextBoxColumn
            // 
            this.fechsaliDataGridViewTextBoxColumn.DataPropertyName = "fech_sali";
            this.fechsaliDataGridViewTextBoxColumn.HeaderText = "fech_sali";
            this.fechsaliDataGridViewTextBoxColumn.Name = "fechsaliDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            // 
            // chkAdmin
            // 
            // 
            // 
            // 
            this.chkAdmin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAdmin.DataBindings.Add(new System.Windows.Forms.Binding("CheckValue", this.usuarioBindingSource, "admin", true));
            this.chkAdmin.Location = new System.Drawing.Point(503, 196);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(100, 23);
            this.chkAdmin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAdmin.TabIndex = 40;
            this.chkAdmin.Text = "Administrador";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 396);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.etiCodigoUsuario);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.etiUsuario);
            this.Controls.Add(this.etiFechFin);
            this.Controls.Add(this.dtFechFin);
            this.Controls.Add(this.etiFechIni);
            this.Controls.Add(this.dtFechIni);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.etiTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.etiEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.etiNombre);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormUsuario";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtCodUsuario;
        private DevComponents.DotNetBar.LabelX etiCodigoUsuario;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkActivo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUser;
        private DevComponents.DotNetBar.LabelX etiUsuario;
        private DevComponents.DotNetBar.LabelX etiFechFin;
        private System.Windows.Forms.DateTimePicker dtFechFin;
        private DevComponents.DotNetBar.LabelX etiFechIni;
        private System.Windows.Forms.DateTimePicker dtFechIni;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTelefono;
        private DevComponents.DotNetBar.LabelX etiTelefono;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.LabelX etiEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.DotNetBar.LabelX etiNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CADINDataSet cADINDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private CADINDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codusuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechinicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechsaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkAdmin;


    }
}