using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class FormularioSeleccionDestinatarios : Form
    {
        public String Para;
        public String Cc;
        public String Cco;
        public System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows;
        private TextBox targetTextBox;
        private BindingSource empresaBindingSource;

        public FormularioSeleccionDestinatarios(BindingSource contactoEmpresaBindingSource, String Para, String Cc, String Cco)
        {
            InitializeComponent();
            this.empresaBindingSource = contactoEmpresaBindingSource;
            this.Para = Para;
            this.Cc = Cc;
            this.Cco = Cco;
            this.targetTextBox = txtPara;
            //BindingSource bindingSource = new BindingSource();
            //bindingSource.DataSource=new EmpresaDataSetTableAdapters.ContactoEmpresaTableAdapter().GetData();
            //dataGridViewContactos.DataSource = bindingSource;
        }

        public void setTarget(String TargetName){
            if (TargetName.Equals("Cc"))
            {
                btnCc.Checked = true;
            }
            else if (TargetName.Equals("Cco"))
            {
                btnCco.Checked = true;
            }
            else
            {
                btnPara.Checked = true;
            }
        }

        private void FormularioSeleccionDestinatarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empresaDataSet.ContactoEmpresa' Puede moverla o quitarla según sea necesario.
            //this.contactoEmpresaTableAdapter.Fill(this.empresaDataSet.ContactoEmpresa);
            dataGridViewContactos.DataSource = empresaBindingSource;
            this.txtPara.Text = Para;
            this.txtCc.Text = Cc;
            this.txtCco.Text = Cco;
            optPrincipal.Checked = true;
        }

        private void addContacts() {
            selectedRows = dataGridViewContactos.SelectedRows;
            foreach (System.Windows.Forms.DataGridViewRow d in selectedRows)
            {
                String contacto = d.Cells["correoElectrónicoDataGridViewTextBoxColumn"].Value.ToString();
                if (contacto.Trim().Length != 0)
                {
                    if(btnPara.Checked)
                        addContact(txtPara,contacto);
                    if (btnCc.Checked)
                        addContact(txtCc, contacto);
                    if (btnCco.Checked)
                        addContact(txtCco, contacto);
                }
            }   
        }

        private void addContact(TextBox targetTextBox, String contactEmail) {
            if (targetTextBox.Text.Trim().Length != 0)
                targetTextBox.Text += ";";
            targetTextBox.Text += " " + contactEmail;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Para = txtPara.Text;
            this.Cc = txtCc.Text;
            this.Cco = txtCco.Text;
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridViewContactos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewContactos.Rows[e.RowIndex].Cells["correoElectrónicoDataGridViewTextBoxColumn"].Value.ToString().Length == 0)
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.SelectionForeColor = Color.Red;
                e.CellStyle.SelectionBackColor = Color.FromArgb(219, 229, 241);
            }
        }

        private void dataGridViewContactos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addContacts();
        }

        private void radioButtonMostrarContactos_CheckedChanged(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonItem itemButton = (DevComponents.DotNetBar.ButtonItem)sender;
            if (itemButton.Checked)
            {
                if (itemButton.Equals(optPrincipal))
                    ((BindingSource)dataGridViewContactos.DataSource).Filter = "COD_CONTACTO=cont_principal";
                else if (itemButton.Equals(optSuplente1))
                    ((BindingSource)dataGridViewContactos.DataSource).Filter = "COD_CONTACTO=primS";
                else if (itemButton.Equals(optSuplente2))
                    ((BindingSource)dataGridViewContactos.DataSource).Filter = "COD_CONTACTO=seguS";
                else if (itemButton.Equals(optSuplente3))
                    ((BindingSource)dataGridViewContactos.DataSource).Filter = "COD_CONTACTO=tercS";

            //    RadioButton radioButton = (RadioButton)sender;
            //if (radioButton.Checked)
            //{
            //    if (radioButton.Equals(optPrincipal))
            //        ((BindingSource)dataGridViewContactos.DataSource).Filter = "COD_CONTACTO=cont_principal";
            //    else if (radioButton.Equals(optSuplente1))
            //        ((BindingSource)dataGridViewContactos.DataSource).Filter = "COD_CONTACTO=primS";
            //    else if (radioButton.Equals(optSuplente2))
            //        ((BindingSource)dataGridViewContactos.DataSource).Filter = "COD_CONTACTO=seguS";
            //    else if (radioButton.Equals(optSuplente3))
            //        ((BindingSource)dataGridViewContactos.DataSource).Filter = "COD_CONTACTO=tercS";
            }
        }

        private List<String> getEmailCollection() {
            List<String> emailCollection = new List<String>();
            if(txtPara.Text.Length!=0)
                emailCollection.AddRange(txtPara.Text.Replace(" ","").Split(';'));
            if(txtCc.Text.Length!=0)
                emailCollection.AddRange(txtCc.Text.Split(';'));
            if (txtCco.Text.Length != 0)
                emailCollection.AddRange(txtCco.Text.Split(';'));
            return emailCollection;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            addContacts();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FormularioFiltroBusqueda.showFormularioFiltroBusqueda(empresaBindingSource);
        }

        //private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (Char)Keys.Back)
        //    {
        //        TextBox t = (TextBox)sender;
        //        String text = t.Text;
        //        if (text.Length != 0)
        //        {
        //            String subString;
        //            int index = 0;
        //            if (text.Contains(";"))
        //            {
        //                subString = text.Substring(text.LastIndexOf(";") + 1).Replace(" ", "");
        //                index = text.LastIndexOf(";");
        //            }
        //            else
        //            {
        //                subString = text.Replace(" ", "");
        //            }
        //            if (ExpressionValidator.ExpressionValidator.isEmail(subString))
        //            {
        //                t.Text = text.Remove(index);
        //                e.Handled = true;
        //            }
        //            t.Select(t.Text.Length, 0);
        //        }
        //    }
        //}
    }
}
