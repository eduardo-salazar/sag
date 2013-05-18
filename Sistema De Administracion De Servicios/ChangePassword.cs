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
    public partial class ChangePassword : Form
    {
        String old;
        public String newPass;
        public Boolean c = false;
        public Boolean match = false;

        public ChangePassword(String pass)
        {
            InitializeComponent();
            old = pass;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (old.Equals(EncryptPassphraseAlgorithm.EncryptSHA1(txtOldPass.Text.Trim())))
            {
                match = true;
                newPass =EncryptPassphraseAlgorithm.EncryptSHA1(txtNewPass.Text.Trim());
                MessageBox.Show("Contraseña Cambiada");
                this.Dispose();
            }
            else {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
    }
}
