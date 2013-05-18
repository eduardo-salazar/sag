using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class Login : Form
    {
        Entorno entorno = null;
        Usuario usuario = null;
        delegate void threadCallBack();
        Thread thread=null;

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //thread = new Thread(login);
            //thread.Start();
            loginWithoutThreading();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.SelectAll();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                e.Handled = true;
                //thread = new Thread(login);
                //thread.Start();
                loginWithoutThreading();
            }
        }        

        void login()
        {
            handleProgressBar();
            handleControlsEnabled();
            try
            {
                UsuariosDataSetTableAdapters.UsuarioTableAdapter uta = new UsuariosDataSetTableAdapters.UsuarioTableAdapter();
                UsuariosDataSet.UsuarioDataTable udt = uta.GetDataByUsuario(txtUser.Text.Trim(), EncryptPassphraseAlgorithm.EncryptSHA1(txtPassword.Text.Trim()));
                if (udt.Rows.Count!=0)
                {
                    UsuariosDataSet.UsuarioRow ur = (UsuariosDataSet.UsuarioRow)udt.Rows[0];
                    if ((Boolean)ur["activo"])
                    {
                        usuario = new Usuario((int)ur["cod_usua"], ur["nombre"].ToString(), (Boolean)ur["activo"]);
                        usuario.Admin = (Boolean)ur["admin"];
                        usuario.User = ur["usuario"].ToString();
                        entorno = new Entorno(usuario);
                        handleProgressBar();
                        ocultarLogin();
                        Application.Run(entorno);
                    }
                    else
                    {
                        handleProgressBar();
                        handleControlsEnabled();
                        MessageBox.Show("El usuario no se encuentra activo. Contacte con un usuario administrador");
                        selectTxtUser();
                    }
                }
                else
                {
                    handleProgressBar();
                    handleControlsEnabled();
                    MessageBox.Show("El usuario o la contraseña proporcionados son incorrectos");
                    selectTxtUser();
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                handleProgressBar();
                handleControlsEnabled();
                MessageBox.Show("No se pudo establecer la conexión con el servidor, verifique la configuración de conexión");
                selectTxtUser();
            }
        }

        void ocultarLogin()
        {
            if (this.InvokeRequired)
            {
                threadCallBack c = new threadCallBack(ocultarLogin);
                this.Invoke(c);
            }
            else
            {
                this.Hide();
            }
        }

        void selectTxtUser()
        {
            if (this.txtUser.InvokeRequired)
            {
                threadCallBack c = new threadCallBack(selectTxtUser);
                this.Invoke(c);
            }
            else
            {
                this.txtUser.Focus();
                this.txtUser.SelectAll();
            }
        }

        void handleProgressBar()
        {
            if (this.cpbConectando.InvokeRequired)
            {
                threadCallBack c = new threadCallBack(handleProgressBar);
                this.Invoke(c);
            }
            else
            {
                cpbConectando.IsRunning = !cpbConectando.IsRunning;
            }
        }

        void handleControlsEnabled()
        {
            if (this.txtUser.InvokeRequired)
            {
                threadCallBack c = new threadCallBack(handleControlsEnabled);
                this.Invoke(c);
            }
            else
            {
                this.txtUser.Enabled = !this.txtUser.Enabled;
                if (this.txtPassword.InvokeRequired)
                {
                    threadCallBack c = new threadCallBack(handleControlsEnabled);
                    this.Invoke(c);
                }
                else
                {
                    this.txtPassword.Enabled = !this.txtPassword.Enabled;
                    if (this.btnIngresar.InvokeRequired)
                    {
                        threadCallBack c = new threadCallBack(handleControlsEnabled);
                        this.Invoke(c);
                    }
                    else
                    {
                        this.btnIngresar.Enabled = !this.btnIngresar.Enabled;
                        if (this.btnCancelar.InvokeRequired)
                        {
                            threadCallBack c = new threadCallBack(handleControlsEnabled);
                            this.Invoke(c);
                        }
                        else
                        {
                            this.btnCancelar.Enabled = !this.btnCancelar.Enabled;
                        }
                    }
                }
            }
        }

        private void loginWithoutThreading()
        {
            if (valLogin.Validate())
            {
                try
                {
                    String user = txtUser.Text;
                    String pass = EncryptPassphraseAlgorithm.EncryptSHA1(txtPassword.Text);
                    CADINDataSet.UsuarioDataTable udt = new CADINDataSetTableAdapters.UsuarioTableAdapter().GetDataByUser(txtUser.Text.Trim(),EncryptPassphraseAlgorithm.EncryptSHA1(txtPassword.Text.Trim()));
                    if (udt.Rows.Count != 0)
                    {
                        CADINDataSet.UsuarioRow row = (CADINDataSet.UsuarioRow)udt.Rows[0];
                        if (row.activo)
                        {
                            Usuario usuario = new Usuario(row.cod_usua, row.nombre, row.activo);
                            usuario.Email = row.email;
                            usuario.Telefono = row.telf;
                            usuario.Admin = row.admin;
                            usuario.User = row.usuario;
                            Entorno en = new Entorno(usuario);
                            this.Hide();
                            en.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no activo");
                            this.txtUser.Focus();
                            this.txtUser.SelectAll();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario o la contraseña proporcionado son incorrectos");
                        this.txtUser.Focus();
                        this.txtUser.SelectAll();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo establecer la conexion. Por favor revise la configuración");
                }
            }
        }
    }
}
