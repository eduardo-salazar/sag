using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class ControlMensaje : UserControl
    {
        System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows;
        BindingSource contactoEmpresaBindingSource;
        Usuario usuario;
        List<Object[]> targetContact;
        String recipients;

        public ControlMensaje()
        {
            InitializeComponent();
            contactoEmpresaBindingSource = new BindingSource();
            contactoEmpresaBindingSource.DataSource = new EmpresaDataSetTableAdapters.ContactoEmpresaTableAdapter().GetData();
        }

        public void setContenido(String asunto, String para, String toCc, String toCco, String mensaje) {
            txtAsunto.Text = asunto;
            txtPara.Text = para;
            txtCc.Text = toCc;
            txtCco.Text = toCco;
            txtMensaje.Text = mensaje;
        }

        public void clear() {
            txtAsunto.Clear();
            txtCc.Clear();
            txtCco.Clear();
            txtMensaje.Clear();
            txtPara.Clear();
        }

        public void setUser(Usuario usuario) {
            this.usuario = usuario;
        }

        private void showFormularioSeleccionDestinatarios(object sender, EventArgs e) {
            FormularioSeleccionDestinatarios formularioSeleccionDestinatarios = new FormularioSeleccionDestinatarios(contactoEmpresaBindingSource, txtPara.Text, txtCc.Text, txtCco.Text);
            formularioSeleccionDestinatarios.setTarget(((DevComponents.DotNetBar.ButtonX)sender).Text.Replace(".",""));
            DialogResult result = formularioSeleccionDestinatarios.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txtPara.Text = formularioSeleccionDestinatarios.Para;
                this.txtCc.Text = formularioSeleccionDestinatarios.Cc;
                this.txtCco.Text = formularioSeleccionDestinatarios.Cco;
                this.selectedRows = formularioSeleccionDestinatarios.selectedRows;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            OutlookEmailSender2 outlookEmailSender=new OutlookEmailSender2();
            outlookEmailSender.setSubject(txtAsunto.Text);
            if(txtPara.Text.Trim().Length!=0)
                outlookEmailSender.addRecipients(txtPara.Text,Microsoft.Office.Interop.Outlook.OlMailRecipientType.olTo);
            if(txtCc.Text.Trim().Length!=0)
                outlookEmailSender.addRecipients(txtCc.Text,Microsoft.Office.Interop.Outlook.OlMailRecipientType.olCC);
            if(txtCco.Text.Trim().Length!=0)
                outlookEmailSender.addRecipients(txtCco.Text,Microsoft.Office.Interop.Outlook.OlMailRecipientType.olBCC);
            if (txtMensaje.Text.Trim().Length != 0)
                outlookEmailSender.setMessage(txtMensaje.Text);
            outlookEmailSender.sendThroughOutlook(true);
            recipients = outlookEmailSender.Recipients;
            txtAsunto.Text = outlookEmailSender.subject;
            txtMensaje.Text = outlookEmailSender.message;
            //NotifyIcon sasTrayIcon = new NotifyIcon();
            //sasTrayIcon.Visible = true;
            if(outlookEmailSender.Sent){
                //sasTrayIcon.ShowBalloonTip(1000,"Sistema de Administración de Servicios","El mensaje:\""+txtAsunto.Text+"\" se ha enviado",ToolTipIcon.Info);
                asignTargetContacts();
                CADINDataSetTableAdapters.MensajeTableAdapter mensajeTableAdapter = new CADINDataSetTableAdapters.MensajeTableAdapter();
                String s = outlookEmailSender.Sender;
                int codMensaje = (int)mensajeTableAdapter.InsertAndReturnKey(DateTime.Now, txtAsunto.Text, outlookEmailSender.message,usuario.Cod_Usua, outlookEmailSender.Sender);
                CADINDataSetTableAdapters.ComunicacionTableAdapter comunicacionTableAdapter = new CADINDataSetTableAdapters.ComunicacionTableAdapter();
                foreach (object[] contact in targetContact)
                {
                    comunicacionTableAdapter.Insert(Convert.ToInt32(contact[0].ToString()), codMensaje, contact[1].ToString());
                }
                MessageBox.Show("El mensaje:\"" + txtAsunto.Text + "\" se ha enviado");
            }else{
                //sasTrayIcon.ShowBalloonTip(1000,"Sistema de Administración de Servicios","No se pudo enviar el mensaje:\""+txtAsunto.Text+"\"",ToolTipIcon.Error);
                MessageBox.Show("No se pudo enviar el mensaje:\"" + txtAsunto.Text + "\"");
            }
            //clear();
        }

        private void asignTargetContacts() {
            EmpresaDataSet.ContactoEmpresaDataTable contactoEmpresa = (EmpresaDataSet.ContactoEmpresaDataTable)contactoEmpresaBindingSource.DataSource;
            targetContact = new List<Object[]>();
            List<String> emailCollection = new List<string>();
            emailCollection.AddRange(recipients.Replace(" ", "").Split(';'));
            foreach (String email in emailCollection)
            {
                int index = contactoEmpresaBindingSource.Find("Correo Electrónico", email);
                if (index != -1)
                {
                    int cod_empr = Convert.ToInt32(contactoEmpresa[index].COD_EMPRESA.ToString());
                    int j = -1;
                    for (int i = 0; i < targetContact.Count && j == -1; i++)
                    {
                        Object[] obj = targetContact.ElementAt(i);
                        if ((int)obj[0] == cod_empr)
                        {
                            j = i;
                            obj[1] = obj[1] + "; " + email;
                        }
                    }
                    if (j == -1)
                    {
                        Object[] o = new Object[2];
                        o[0] = Convert.ToInt32(contactoEmpresa[index].COD_EMPRESA.ToString());
                        o[1] = email;
                        targetContact.Add(o);
                    }
                }
            }
        }
    }
}
