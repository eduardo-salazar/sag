namespace Sistema_De_Administracion_De_Servicios
{
    partial class ControlMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlMensajes));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPara = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.RichTextBox();
            this.icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.txtEmpresa);
            this.splitContainer1.Panel2.Controls.Add(this.txtPara);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtFecha);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtDe);
            this.splitContainer1.Panel2.Controls.Add(this.txtAsunto);
            this.splitContainer1.Panel2.Controls.Add(this.txtMensaje);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(752, 340);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.icon,
            this.asunto,
            this.destino,
            this.fecha,
            this.mensaje,
            this.emailDestino,
            this.origen,
            this.codigoUsuario});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(250, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtPara
            // 
            this.txtPara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPara.BackColor = System.Drawing.Color.White;
            this.txtPara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPara.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtPara.Location = new System.Drawing.Point(73, 120);
            this.txtPara.Name = "txtPara";
            this.txtPara.ReadOnly = true;
            this.txtPara.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtPara.Size = new System.Drawing.Size(422, 38);
            this.txtPara.TabIndex = 12;
            this.txtPara.Text = "Email de Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Para:";
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.BackColor = System.Drawing.Color.White;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(73, 96);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(405, 18);
            this.txtFecha.TabIndex = 10;
            this.txtFecha.Text = "Fecha de Envío";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(18, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enviado:";
            // 
            // txtDe
            // 
            this.txtDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDe.BackColor = System.Drawing.Color.White;
            this.txtDe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDe.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtDe.Location = new System.Drawing.Point(21, 72);
            this.txtDe.Name = "txtDe";
            this.txtDe.ReadOnly = true;
            this.txtDe.Size = new System.Drawing.Size(458, 18);
            this.txtDe.TabIndex = 8;
            this.txtDe.Text = "Email de Origen";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsunto.BackColor = System.Drawing.Color.White;
            this.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAsunto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtAsunto.Location = new System.Drawing.Point(21, 46);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.ReadOnly = true;
            this.txtAsunto.Size = new System.Drawing.Size(457, 20);
            this.txtAsunto.TabIndex = 7;
            this.txtAsunto.Text = "Asunto";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensaje.BackColor = System.Drawing.Color.White;
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(21, 171);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(458, 149);
            this.txtMensaje.TabIndex = 6;
            this.txtMensaje.Text = "Mensaje";
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
            // asunto
            // 
            this.asunto.DataPropertyName = "asunto";
            this.asunto.HeaderText = "Asunto";
            this.asunto.Name = "asunto";
            this.asunto.ReadOnly = true;
            this.asunto.ToolTipText = "Asunto";
            // 
            // destino
            // 
            this.destino.DataPropertyName = "nomb_empr";
            this.destino.HeaderText = "Destino";
            this.destino.Name = "destino";
            this.destino.ReadOnly = true;
            this.destino.ToolTipText = "Empresa de Destino";
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fech_envio";
            this.fecha.HeaderText = "Fecha de Envío";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.ToolTipText = "Fecha de Envío";
            // 
            // mensaje
            // 
            this.mensaje.DataPropertyName = "mensaje";
            this.mensaje.HeaderText = "";
            this.mensaje.Name = "mensaje";
            this.mensaje.ReadOnly = true;
            this.mensaje.Visible = false;
            // 
            // emailDestino
            // 
            this.emailDestino.DataPropertyName = "email";
            this.emailDestino.HeaderText = "";
            this.emailDestino.Name = "emailDestino";
            this.emailDestino.ReadOnly = true;
            this.emailDestino.Visible = false;
            // 
            // origen
            // 
            this.origen.DataPropertyName = "origen";
            this.origen.HeaderText = "";
            this.origen.Name = "origen";
            this.origen.ReadOnly = true;
            this.origen.Visible = false;
            // 
            // codigoUsuario
            // 
            this.codigoUsuario.DataPropertyName = "cod_usua";
            this.codigoUsuario.HeaderText = "";
            this.codigoUsuario.Name = "codigoUsuario";
            this.codigoUsuario.ReadOnly = true;
            this.codigoUsuario.Visible = false;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmpresa.BackColor = System.Drawing.Color.White;
            this.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpresa.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtEmpresa.Location = new System.Drawing.Point(19, 20);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(459, 23);
            this.txtEmpresa.TabIndex = 13;
            this.txtEmpresa.Text = "Empresa";
            // 
            // ControlMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(752, 340);
            this.Name = "ControlMensajes";
            this.Size = new System.Drawing.Size(752, 340);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox txtMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.RichTextBox txtPara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUsuario;
        private System.Windows.Forms.TextBox txtEmpresa;
    }
}
