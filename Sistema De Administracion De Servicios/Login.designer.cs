namespace Sistema_De_Administracion_De_Servicios
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.paneLogin = new System.Windows.Forms.Panel();
            this.cpbConectando = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.valLogin = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.valPasswordReq = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Debe ingresar una contraseña");
            this.valPasswordLength = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.valUsuarioReq = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Debe Ingresar un Usuario");
            this.valUsuarioLenght = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.valError = new System.Windows.Forms.ErrorProvider(this.components);
            this.valHighlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.paneLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valError)).BeginInit();
            this.SuspendLayout();
            // 
            // paneLogin
            // 
            this.paneLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paneLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.paneLogin.Controls.Add(this.cpbConectando);
            this.paneLogin.Controls.Add(this.pictureBox1);
            this.paneLogin.Controls.Add(this.btnCancelar);
            this.paneLogin.Controls.Add(this.btnIngresar);
            this.paneLogin.Controls.Add(this.labelX3);
            this.paneLogin.Controls.Add(this.txtPassword);
            this.paneLogin.Controls.Add(this.labelX2);
            this.paneLogin.Controls.Add(this.txtUser);
            this.paneLogin.Controls.Add(this.labelX1);
            this.paneLogin.Location = new System.Drawing.Point(12, 12);
            this.paneLogin.Name = "paneLogin";
            this.paneLogin.Size = new System.Drawing.Size(500, 360);
            this.paneLogin.TabIndex = 0;
            // 
            // cpbConectando
            // 
            this.cpbConectando.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cpbConectando.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cpbConectando.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cpbConectando.Location = new System.Drawing.Point(221, 308);
            this.cpbConectando.Name = "cpbConectando";
            this.cpbConectando.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbConectando.Size = new System.Drawing.Size(74, 40);
            this.cpbConectando.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.cpbConectando.TabIndex = 16;
            this.cpbConectando.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Sistema_De_Administracion_De_Servicios.Properties.Resources.User_blue_icon;
            this.pictureBox1.Location = new System.Drawing.Point(40, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 110);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(272, 266);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(156, 266);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(90, 35);
            this.btnIngresar.TabIndex = 13;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.labelX3.Location = new System.Drawing.Point(153, 62);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(264, 57);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "Iniciar Sesión";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusHighlightEnabled = true;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(207, 203);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 29);
            this.txtPassword.TabIndex = 9;
            this.valLogin.SetValidator1(this.txtPassword, this.valPasswordReq);
            this.valLogin.SetValidator2(this.txtPassword, this.valPasswordLength);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.labelX2.Location = new System.Drawing.Point(94, 204);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUser.Border.Class = "TextBoxBorder";
            this.txtUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUser.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.txtUser.FocusHighlightEnabled = true;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(207, 154);
            this.txtUser.Margin = new System.Windows.Forms.Padding(10);
            this.txtUser.MaxLength = 15;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 29);
            this.txtUser.TabIndex = 7;
            this.valLogin.SetValidator1(this.txtUser, this.valUsuarioReq);
            this.valLogin.SetValidator2(this.txtUser, this.valUsuarioLenght);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.labelX1.Location = new System.Drawing.Point(94, 155);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Usuario:";
            // 
            // valLogin
            // 
            this.valLogin.ContainerControl = this;
            this.valLogin.ErrorProvider = this.valError;
            this.valLogin.Highlighter = this.valHighlighter;
            // 
            // valPasswordReq
            // 
            this.valPasswordReq.ErrorMessage = "Debe ingresar una contraseña";
            this.valPasswordReq.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // valPasswordLength
            // 
            this.valPasswordLength.ErrorMessage = "Contraseña demasiado corta";
            this.valPasswordLength.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.valPasswordLength.ValidationExpression = "\\S{3,3}";
            // 
            // valUsuarioReq
            // 
            this.valUsuarioReq.ErrorMessage = "Debe Ingresar un Usuario";
            this.valUsuarioReq.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // valUsuarioLenght
            // 
            this.valUsuarioLenght.ErrorMessage = "Nombre de usuario demasiado corto";
            this.valUsuarioLenght.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.valUsuarioLenght.ValidationExpression = "\\S{3,3}";
            // 
            // valError
            // 
            this.valError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.valError.ContainerControl = this;
            this.valError.Icon = ((System.Drawing.Icon)(resources.GetObject("valError.Icon")));
            // 
            // valHighlighter
            // 
            this.valHighlighter.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Sistema_De_Administracion_De_Servicios.Properties.Resources.form_background;
            this.ClientSize = new System.Drawing.Size(524, 384);
            this.Controls.Add(this.paneLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.paneLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneLogin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUser;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Validator.SuperValidator valLogin;
        private System.Windows.Forms.ErrorProvider valError;
        private DevComponents.DotNetBar.Validator.Highlighter valHighlighter;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator valUsuarioReq;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator valUsuarioLenght;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator valPasswordReq;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator valPasswordLength;
        private DevComponents.DotNetBar.Controls.CircularProgress cpbConectando;



    }
}