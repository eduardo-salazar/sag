namespace Sistema_De_Administracion_De_Servicios
{
    partial class Tipo_Tarifa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tipo_Tarifa));
            this.dgvTipoTarifas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMontoAnual = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Campo requerido.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Campo requerido.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cADINDataSet = new Sistema_De_Administracion_De_Servicios.CADINDataSet();
            this.tipo_TarifaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_TarifaTableAdapter = new Sistema_De_Administracion_De_Servicios.CADINDataSetTableAdapters.Tipo_TarifaTableAdapter();
            this.tableAdapterManager = new Sistema_De_Administracion_De_Servicios.CADINDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TarifaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoTarifas
            // 
            this.dgvTipoTarifas.AllowUserToAddRows = false;
            this.dgvTipoTarifas.AllowUserToDeleteRows = false;
            this.dgvTipoTarifas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoTarifas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoTarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipoTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoTarifas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTipoTarifas.EnableHeadersVisualStyles = false;
            this.dgvTipoTarifas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTipoTarifas.Location = new System.Drawing.Point(35, 189);
            this.dgvTipoTarifas.MultiSelect = false;
            this.dgvTipoTarifas.Name = "dgvTipoTarifas";
            this.dgvTipoTarifas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoTarifas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTipoTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoTarifas.Size = new System.Drawing.Size(470, 150);
            this.dgvTipoTarifas.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(35, 111);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "Descripcion :";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(116, 110);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(271, 64);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNombre.Border.Class = "TextBoxBorder";
            this.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(116, 58);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 2;
            this.superValidator1.SetValidator1(this.txtNombre, this.requiredFieldValidator1);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(35, 55);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Nombre :";
            // 
            // txtMontoAnual
            // 
            this.txtMontoAnual.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMontoAnual.Border.Class = "TextBoxBorder";
            this.txtMontoAnual.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMontoAnual.ForeColor = System.Drawing.Color.Black;
            this.txtMontoAnual.Location = new System.Drawing.Point(116, 84);
            this.txtMontoAnual.MaxLength = 5;
            this.txtMontoAnual.Name = "txtMontoAnual";
            this.txtMontoAnual.ReadOnly = true;
            this.txtMontoAnual.Size = new System.Drawing.Size(79, 20);
            this.txtMontoAnual.TabIndex = 3;
            this.superValidator1.SetValidator1(this.txtMontoAnual, this.requiredFieldValidator2);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(35, 81);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelX3.TabIndex = 15;
            this.labelX3.Text = "Monto Anual :";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Campo requerido.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Campo requerido.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(183, 17);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(175, 23);
            this.labelX4.TabIndex = 16;
            this.labelX4.Text = "TIPOS DE TARIFAS";
            // 
            // cADINDataSet
            // 
            this.cADINDataSet.DataSetName = "CADINDataSet";
            this.cADINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipo_TarifaBindingSource
            // 
            this.tipo_TarifaBindingSource.DataMember = "Tipo_Tarifa";
            this.tipo_TarifaBindingSource.DataSource = this.cADINDataSet;
            // 
            // tipo_TarifaTableAdapter
            // 
            this.tipo_TarifaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CasoTableAdapter = null;
            this.tableAdapterManager.ComunicacionTableAdapter = null;
            this.tableAdapterManager.Contacto_EmpresaTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.Empresa_AgrupacionTableAdapter = null;
            this.tableAdapterManager.EmpresaTableAdapter = null;
            this.tableAdapterManager.MensajeTableAdapter = null;
            this.tableAdapterManager.Pago_MembresiaTableAdapter = null;
            this.tableAdapterManager.ReciboTableAdapter = null;
            this.tableAdapterManager.SectoresTableAdapter = null;
            this.tableAdapterManager.Solicitud_ApoyoTableAdapter = null;
            this.tableAdapterManager.Tipo_ActividadTableAdapter = null;
            this.tableAdapterManager.Tipo_EmpresaTableAdapter = null;
            this.tableAdapterManager.Tipo_MembresiaTableAdapter = null;
            this.tableAdapterManager.Tipo_TarifaTableAdapter = this.tipo_TarifaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Sistema_De_Administracion_De_Servicios.CADINDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // Tipo_Tarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtMontoAnual);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.dgvTipoTarifas);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelX1);
            this.Name = "Tipo_Tarifa";
            this.Size = new System.Drawing.Size(557, 684);
            this.Load += new System.EventHandler(this.Tipo_Tarifa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TarifaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTipoTarifas;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMontoAnual;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.BindingSource tipo_TarifaBindingSource;
        private CADINDataSet cADINDataSet;
        private CADINDataSetTableAdapters.Tipo_TarifaTableAdapter tipo_TarifaTableAdapter;
        private CADINDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
