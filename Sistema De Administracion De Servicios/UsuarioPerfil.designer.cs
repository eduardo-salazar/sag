namespace Sistema_De_Administracion_De_Servicios
{
    partial class UsuarioPerfil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioPerfil));
            this.etiTelefono = new DevComponents.DotNetBar.LabelX();
            this.etiEmail = new DevComponents.DotNetBar.LabelX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.valUsuario = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.valUsuarioError = new System.Windows.Forms.ErrorProvider(this.components);
            this.valUsuarioHighlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.requiredFieldNombre = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("El nobre de usuario es requerido");
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.validEmailField = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.txtUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.requiredFieldUsuario = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("El nombre de usuario es requerido");
            this.valUsuarioReq = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Debe ingresar un username para el usuario");
            this.valTelfInvalid = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.valEmailInvalid = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.valNombreReq = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Debe ingresar el nombre del usuario");
            this.valPasswordReq = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Debe ingresar un password para el usuario");
            this.buttonPicture = new DevComponents.DotNetBar.ButtonX();
            this.txtTelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCodUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.linkCambiarPassword = new System.Windows.Forms.LinkLabel();
            this.etiUsuario = new DevComponents.DotNetBar.LabelX();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.valUsuarioError)).BeginInit();
            this.SuspendLayout();
            // 
            // etiTelefono
            // 
            // 
            // 
            // 
            this.etiTelefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiTelefono.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.etiTelefono.Location = new System.Drawing.Point(20, 193);
            this.etiTelefono.Name = "etiTelefono";
            this.etiTelefono.Size = new System.Drawing.Size(75, 23);
            this.etiTelefono.TabIndex = 23;
            this.etiTelefono.Text = "Teléfono:";
            // 
            // etiEmail
            // 
            // 
            // 
            // 
            this.etiEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.etiEmail.Location = new System.Drawing.Point(20, 160);
            this.etiEmail.Name = "etiEmail";
            this.etiEmail.Size = new System.Drawing.Size(75, 23);
            this.etiEmail.TabIndex = 21;
            this.etiEmail.Text = "Email:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnGuardar.Location = new System.Drawing.Point(20, 261);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(342, 33);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // valUsuario
            // 
            this.valUsuario.ContainerControl = this;
            this.valUsuario.ErrorProvider = this.valUsuarioError;
            this.valUsuario.Highlighter = this.valUsuarioHighlighter;
            // 
            // valUsuarioError
            // 
            this.valUsuarioError.ContainerControl = this;
            this.valUsuarioError.Icon = ((System.Drawing.Icon)(resources.GetObject("valUsuarioError.Icon")));
            // 
            // valUsuarioHighlighter
            // 
            this.valUsuarioHighlighter.ContainerControl = this;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtNombre.Border.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNombre.Border.Class = "TextBoxBorder";
            this.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNombre.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNombre.Location = new System.Drawing.Point(133, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(10, 3, 3, 0);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 32);
            this.txtNombre.TabIndex = 42;
            this.valUsuario.SetValidator1(this.txtNombre, this.requiredFieldNombre);
            this.txtNombre.WatermarkText = "Nombre";
            // 
            // requiredFieldNombre
            // 
            this.requiredFieldNombre.ErrorMessage = "El nobre de usuario es requerido";
            this.requiredFieldNombre.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(101, 160);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 27);
            this.txtEmail.TabIndex = 44;
            this.valUsuario.SetValidator1(this.txtEmail, this.validEmailField);
            this.txtEmail.WatermarkText = "Email";
            // 
            // validEmailField
            // 
            this.validEmailField.EmptyValueIsValid = true;
            this.validEmailField.ErrorMessage = "El email introducido no es valido";
            this.validEmailField.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.validEmailField.ValidationExpression = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9" +
    "})$";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUser.Border.Class = "TextBoxBorder";
            this.txtUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(101, 126);
            this.txtUser.MaxLength = 30;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(261, 27);
            this.txtUser.TabIndex = 48;
            this.valUsuario.SetValidator1(this.txtUser, this.requiredFieldUsuario);
            this.txtUser.WatermarkText = "Usuario";
            // 
            // requiredFieldUsuario
            // 
            this.requiredFieldUsuario.ErrorMessage = "El nombre de usuario es requerido";
            this.requiredFieldUsuario.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // valUsuarioReq
            // 
            this.valUsuarioReq.ErrorMessage = "Debe ingresar un username para el usuario";
            this.valUsuarioReq.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // valTelfInvalid
            // 
            this.valTelfInvalid.EmptyValueIsValid = true;
            this.valTelfInvalid.ErrorMessage = "Ingrese un teléfono válido";
            this.valTelfInvalid.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.valTelfInvalid.ValidationExpression = "0*[1-9][0-9]*";
            // 
            // valEmailInvalid
            // 
            this.valEmailInvalid.EmptyValueIsValid = true;
            this.valEmailInvalid.ErrorMessage = "Ingrese un email válido";
            this.valEmailInvalid.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.valEmailInvalid.ValidationExpression = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9" +
    "})$";
            // 
            // valNombreReq
            // 
            this.valNombreReq.ErrorMessage = "Debe ingresar el nombre del usuario";
            this.valNombreReq.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // valPasswordReq
            // 
            this.valPasswordReq.ErrorMessage = "Debe ingresar un password para el usuario";
            this.valPasswordReq.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // buttonPicture
            // 
            this.buttonPicture.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonPicture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPicture.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.buttonPicture.Image = global::Sistema_De_Administracion_De_Servicios.Properties.Resources.User_blue_icon;
            this.buttonPicture.ImageFixedSize = new System.Drawing.Size(100, 100);
            this.buttonPicture.Location = new System.Drawing.Point(20, 20);
            this.buttonPicture.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.buttonPicture.Name = "buttonPicture";
            this.buttonPicture.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.buttonPicture.Size = new System.Drawing.Size(100, 100);
            this.buttonPicture.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonPicture.TabIndex = 36;
            this.buttonPicture.Tooltip = "Cambiar Imagen";
            this.buttonPicture.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTelefono.Border.Class = "TextBoxBorder";
            this.txtTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(101, 193);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(261, 27);
            this.txtTelefono.TabIndex = 45;
            this.txtTelefono.WatermarkText = "Teléfono";
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.txtCodUsuario.Border.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCodUsuario.Border.Class = "TextBoxBorder";
            this.txtCodUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodUsuario.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCodUsuario.Location = new System.Drawing.Point(133, 52);
            this.txtCodUsuario.Margin = new System.Windows.Forms.Padding(10, 0, 3, 3);
            this.txtCodUsuario.MaxLength = 10;
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.ReadOnly = true;
            this.txtCodUsuario.Size = new System.Drawing.Size(93, 23);
            this.txtCodUsuario.TabIndex = 46;
            this.txtCodUsuario.WatermarkText = "Código";
            // 
            // linkCambiarPassword
            // 
            this.linkCambiarPassword.ActiveLinkColor = System.Drawing.Color.DarkBlue;
            this.linkCambiarPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCambiarPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCambiarPassword.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkCambiarPassword.Location = new System.Drawing.Point(20, 226);
            this.linkCambiarPassword.Margin = new System.Windows.Forms.Padding(3);
            this.linkCambiarPassword.Name = "linkCambiarPassword";
            this.linkCambiarPassword.Size = new System.Drawing.Size(342, 27);
            this.linkCambiarPassword.TabIndex = 0;
            this.linkCambiarPassword.TabStop = true;
            this.linkCambiarPassword.Text = "Cambiar Contraseña";
            this.linkCambiarPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkCambiarPassword.VisitedLinkColor = System.Drawing.Color.DarkBlue;
            this.linkCambiarPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCambiarPassword_LinkClicked);
            // 
            // etiUsuario
            // 
            // 
            // 
            // 
            this.etiUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.etiUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.etiUsuario.Location = new System.Drawing.Point(20, 126);
            this.etiUsuario.Name = "etiUsuario";
            this.etiUsuario.Size = new System.Drawing.Size(75, 23);
            this.etiUsuario.TabIndex = 47;
            this.etiUsuario.Text = "Usuario:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp|All Files|*.*";
            // 
            // UsuarioPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.etiUsuario);
            this.Controls.Add(this.linkCambiarPassword);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.buttonPicture);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.etiTelefono);
            this.Controls.Add(this.etiEmail);
            this.Name = "UsuarioPerfil";
            this.Size = new System.Drawing.Size(380, 328);
            this.Load += new System.EventHandler(this.UsuarioPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valUsuarioError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX etiTelefono;
        private DevComponents.DotNetBar.LabelX etiEmail;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.Validator.SuperValidator valUsuario;
        private System.Windows.Forms.ErrorProvider valUsuarioError;
        private DevComponents.DotNetBar.Validator.Highlighter valUsuarioHighlighter;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator valNombreReq;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator valEmailInvalid;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator valTelfInvalid;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator valUsuarioReq;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator valPasswordReq;
        private DevComponents.DotNetBar.ButtonX buttonPicture;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTelefono;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodUsuario;
        private System.Windows.Forms.LinkLabel linkCambiarPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUser;
        private DevComponents.DotNetBar.LabelX etiUsuario;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldUsuario;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator validEmailField;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldNombre;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

    }
}
