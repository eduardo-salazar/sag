namespace Sistema_De_Administracion_De_Servicios
{
    partial class FormBusqueda
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarSiguiente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboColumns = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMatch = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.MaskedTextBox();
            this.txtEncontrados = new System.Windows.Forms.TextBox();
            this.etiEncontrados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // btnBuscarSiguiente
            // 
            this.btnBuscarSiguiente.Location = new System.Drawing.Point(316, 18);
            this.btnBuscarSiguiente.Name = "btnBuscarSiguiente";
            this.btnBuscarSiguiente.Size = new System.Drawing.Size(108, 23);
            this.btnBuscarSiguiente.TabIndex = 5;
            this.btnBuscarSiguiente.Text = "Encontrar Siguiente";
            this.btnBuscarSiguiente.UseVisualStyleBackColor = true;
            this.btnBuscarSiguiente.Click += new System.EventHandler(this.btnBuscarSiguiente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar en:";
            // 
            // cboColumns
            // 
            this.cboColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumns.FormattingEnabled = true;
            this.cboColumns.Location = new System.Drawing.Point(96, 79);
            this.cboColumns.Margin = new System.Windows.Forms.Padding(10);
            this.cboColumns.Name = "cboColumns";
            this.cboColumns.Size = new System.Drawing.Size(158, 21);
            this.cboColumns.TabIndex = 2;
            this.cboColumns.SelectedIndexChanged += new System.EventHandler(this.cboColumns_SelectedIndexChanged);
            this.cboColumns.TextChanged += new System.EventHandler(this.cboColumns_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Coincidir:";
            // 
            // cboMatch
            // 
            this.cboMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatch.FormattingEnabled = true;
            this.cboMatch.Items.AddRange(new object[] {
            "Cualquier Parte del Campo",
            "Campo Completo",
            "Inicio del Campo"});
            this.cboMatch.Location = new System.Drawing.Point(96, 120);
            this.cboMatch.Margin = new System.Windows.Forms.Padding(10);
            this.cboMatch.Name = "cboMatch";
            this.cboMatch.Size = new System.Drawing.Size(158, 21);
            this.cboMatch.TabIndex = 3;
            this.cboMatch.SelectedIndexChanged += new System.EventHandler(this.cboMatch_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(96, 20);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PromptChar = ' ';
            this.txtBuscar.Size = new System.Drawing.Size(207, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            // 
            // txtEncontrados
            // 
            this.txtEncontrados.Location = new System.Drawing.Point(377, 120);
            this.txtEncontrados.Name = "txtEncontrados";
            this.txtEncontrados.ReadOnly = true;
            this.txtEncontrados.Size = new System.Drawing.Size(39, 20);
            this.txtEncontrados.TabIndex = 9;
            this.txtEncontrados.Visible = false;
            // 
            // etiEncontrados
            // 
            this.etiEncontrados.AutoSize = true;
            this.etiEncontrados.Location = new System.Drawing.Point(301, 123);
            this.etiEncontrados.Name = "etiEncontrados";
            this.etiEncontrados.Size = new System.Drawing.Size(70, 13);
            this.etiEncontrados.TabIndex = 10;
            this.etiEncontrados.Text = "Encontrados:";
            this.etiEncontrados.Visible = false;
            // 
            // FormBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 160);
            this.Controls.Add(this.etiEncontrados);
            this.Controls.Add(this.txtEncontrados);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboColumns);
            this.Controls.Add(this.btnBuscarSiguiente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBusqueda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bucar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormBusqueda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarSiguiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMatch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox txtBuscar;
        private System.Windows.Forms.TextBox txtEncontrados;
        private System.Windows.Forms.Label etiEncontrados;

    }
}