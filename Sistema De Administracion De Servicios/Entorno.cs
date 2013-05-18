using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using System.Data;
using DevComponents.DotNetBar;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class Entorno : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        Menu_Principal _StartControl = null;
        UserControl panel;
        Usuario usuario = null;

        public Entorno(Usuario a)
        {
            InitializeComponent();

            this.bar1.Style = eDotNetBarStyle.Office2010;
           
            this.bar1.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (this.bar1.Width / 2), this.bar1.Location.Y);
            //Abrir Menu-Principal
            this.SuspendLayout();
            usuario = a;
            _StartControl = new Menu_Principal(a);
            
            this.Controls.Add(_StartControl);
            _StartControl.BringToFront();
            _StartControl.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            
            //Agregar los eventos que controlan los clicks del menu
            _StartControl.btnAbrirServicio.Click += new EventHandler(abrir_servicio_click);
            _StartControl.btnAgregarEmpresa.Click += new EventHandler(agregar_empresa_click);
            _StartControl.btnAdministrador.Click+=new EventHandler(btnAdministrador_Click);
            _StartControl.btnCatalogos.Click+=new EventHandler(btnCatalogos_Click);
            _StartControl.btnReportes.Click+=new EventHandler(btnReportes_Click);
            _StartControl.btnComunicacion.Click+=new EventHandler(btnComunicacion_Click);
            //Controles de eventos de la lista de catalogos
            _StartControl.listCatCasos.Click+=new EventHandler(listCatCasos2_Click);
            _StartControl.listCatEmpresa.Click+=new EventHandler(listCatEmpresa_Click);
            _StartControl.listCatSectores.Click+=new EventHandler(listCatSectores_Click);
            _StartControl.listCatSolicitudApoyo.Click+=new System.EventHandler(listCatSolicitudApoyo_Click);
            _StartControl.listCatTarifas.Click+=new EventHandler(listCatTarifas_Click);
            _StartControl.listCatTipoEmpresa.Click+=new EventHandler(listCatTipoEmpresa_Click);
            _StartControl.listCatTipoMembresia.Click+=new EventHandler(listCatTipoMembresia_Click);
            _StartControl.listTipoActividad.Click += new EventHandler(listTipoActividad_Clik);
            _StartControl.listAgrupaciones.Click+=new EventHandler(listAgrupaciones_Click);

            //Controles de eventos de la lista de Adminstrador
            _StartControl.listAdmControlUsuarios.Click+=new EventHandler(listAdmControlUsuarios_Click);
            _StartControl.listAdmComunicacion.Click+=new EventHandler(listAdmComunicacion_Click);
            _StartControl.listAdmPantallaGerencial.Click+=new EventHandler(listAdmPantallaGerencial_Click);

            //Eventos de los botones de los controles
            this.btnNuevo.Click +=new EventHandler(btnNuevo_Click);
            this.btnGuardar.Click +=new EventHandler(btnGuardar_Click);
            this.btnEditar.Click +=new EventHandler(btnEditar_Click);
            this.btnBorrar.Click+=new EventHandler(btnBorrar_Click);
            this.btnCancelar.Click+=new EventHandler(btnCancelar_Click);

                //navegacion
            this.btnPrimero.Click+=new EventHandler(btnPrimero_Click);
            this.btnAnterior.Click+=new EventHandler(btnAnterior_Click);
            this.btnSiguiente.Click+=new EventHandler(btnSiguiente_Click);
            this.btnUltimo.Click+=new EventHandler(btnUltimo_Click);
            
            this.btnBuscar.Click+=new EventHandler(btnBuscar_Click);
            this.btnReportesControl.Click+=new EventHandler(btnReportesControl_Click);
            this.btnRealizarPago.Click+=new EventHandler(btnRealizarPago_Click);
         

            this._StartControl.imagenUsuario.DoubleClick+=new EventHandler(imagenUsuario_DoubleClick);

            this.ResumeLayout(false);
 
        }

        /*-----------------Estos metodos controlan el desplazamiento de los paneles--------------------------------*/
        protected override void OnLoad(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            base.OnLoad(e);
        }

        private Rectangle GetStartControlBounds()
        {
            int captionHeight = metroShell1.MetroTabStrip.GetCaptionHeight() + 2;
            Thickness borderThickness = this.GetBorderThickness();
            return new Rectangle((int)borderThickness.Left, captionHeight, this.Width - (int)borderThickness.Horizontal, this.Height - captionHeight - 1);
        }
        private void UpdateControlsSizeAndLocation()
        {
            if (_StartControl != null)
            {
                if (!_StartControl.IsOpen)
                    _StartControl.OpenBounds = GetStartControlBounds();
                else
                {
                    _StartControl.Bounds = GetStartControlBounds();
                }
                if (!IsModalPanelDisplayed)
                    _StartControl.BringToFront();
            }
        }
        protected override void OnResize(EventArgs e)
        {
            UpdateControlsSizeAndLocation();
            base.OnResize(e);
        }

        private void Entorno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /*---------FIN METODOS DE CONTROL DE DESPLAZAMIENTO DE PANELES---------------------*/

        /*-------------CONTROL EVENTOS CLICK DE MENU-PRINCIPAL-----------------------------*/

        void imagenUsuario_DoubleClick(Object sender, EventArgs e) {
            limpiarPanel();
            panel = new UsuarioPerfil(usuario);
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoEdicion();
        }
        void abrir_servicio_click(Object sender, EventArgs e)
        {
            
            limpiarPanel();
            panel = new Caso(usuario);
            ajustarTamano(panel);
            ((Caso)panel).setUser(usuario);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            btnNuevo_Click(null, null);
        }

        void agregar_empresa_click(Object sender, EventArgs e)
        {
            limpiarPanel();
            panel = new Empresa(true);
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            btnNuevo_Click(null,null);
            this.btnRealizarPago.Visible = true;           

        }
        void btnAdministrador_Click(Object sender, EventArgs e)
        {
            //Agregar Apertura de paneles segun sea el item
            if (!_StartControl.listaAdministrador.Visible)
            {
                _StartControl.listaCatalogos.Visible = false;
                _StartControl.listaAdministrador.Visible = true; 
            }
            else
                _StartControl.listaAdministrador.Visible = false;

        }
        void btnCatalogos_Click(Object sender, EventArgs e)
        {
            if (!_StartControl.listaCatalogos.Visible)
            {
                _StartControl.listaAdministrador.Visible = false;
                _StartControl.listaCatalogos.Visible = true;
            }
            else
                _StartControl.listaCatalogos.Visible = false;
        }
        void btnReportes_Click(object sender, EventArgs e)
        {
            FormularioReportes.showFormularioReportes("ReporteCompleto");
        }
        void btnComunicacion_Click(object sender, EventArgs e)
        {
            FormularioComunicacion p = new FormularioComunicacion(usuario);
            p.ShowDialog();
        }

        //Lista de Catalogos
        void limpiarControles() 
        {
            this.btnEditar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.btnBorrar.Enabled = false;
            this.btnGuardar.Enabled = false;
            ActivarNavegacion(false);
            this.btnReportesControl.Enabled = false;
            this.btnBuscar.Enabled = false;
            this.btnRealizarPago.Enabled = false;
            this.btnNuevo.Enabled = true;
        }
        void verificarVacio(UserControl panel)
        {
            Funciones f = (Funciones)panel;
            if (f.vacio())
            {
                limpiarControles();
            }
        }
        void listCatCasos2_Click(Object sender,EventArgs e)
        {
            limpiarPanel();
            panel = new Caso(usuario);
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);

        }
        void listCatEmpresa_Click(Object sender,EventArgs e)
        {
            limpiarPanel();
            panel = new Empresa(false);
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            this.btnRealizarPago.Visible = true;   
            modoNavegacion();
            verificarVacio(panel);
        }
        void listCatSectores_Click(Object sender,EventArgs e)
        {
            limpiarPanel();
            panel = new Sectores();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
        void listCatSolicitudApoyo_Click(Object sender,EventArgs e)
        {
            limpiarPanel();
            panel = new Solicitud_Apoyo();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
       
         void listCatTarifas_Click(Object sender,EventArgs e)
        {
            limpiarPanel();
            panel = new Tipo_Tarifa();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
         void listCatTipoEmpresa_Click(Object sender,EventArgs e)
        {
            limpiarPanel();
            panel = new Tipo_Empresa();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
         void listCatTipoMembresia_Click(Object sender,EventArgs e)
        {
            limpiarPanel();
            panel = new Tipo_Membresia();
            ajustarTamano(panel);
            this.Controls.Add(panel);
            seleccionar_tabControles();
            modoNavegacion();
            verificarVacio(panel);
        }
         void listTipoActividad_Clik(object sender, EventArgs e)
         {
             limpiarPanel();
             panel = new TipoActividad();
             ajustarTamano(panel);
             this.Controls.Add(panel);
             seleccionar_tabControles();
             modoNavegacion();
             verificarVacio(panel);
         }
         void listAgrupaciones_Click(object sender, EventArgs e)
         {
             limpiarPanel();
             panel = new Agrupaciones();
             ajustarTamano(panel);
             this.Controls.Add(panel);
             seleccionar_tabControles();
             modoNavegacion();
             verificarVacio(panel);
         }
         
        //Lista Administrador
         void listAdmComunicacion_Click(object sender, EventArgs e)
         {

             FormularioComunicacion p = new FormularioComunicacion(usuario);
             p.Show();
             
         }
         void listAdmPantallaGerencial_Click(object sender, EventArgs e)
         {
             limpiarPanel();
             panel = new PantallaGerencial();
             ajustarTamano(panel);
             this.Controls.Add(panel);
             seleccionar_tabControles();
             modoNavegacion();
             this.btnNuevo.Enabled = false;
         }
         void listAdmControlUsuarios_Click(Object sender, EventArgs e)
         { 
             limpiarPanel();
             panel= new ControlUsuario();
             ajustarTamano(panel);
             this.Controls.Add(panel);
             seleccionar_tabControles();
             modoNavegacion();
         }
        
        /*----------FIN EVENTOS DE CONTROL DE MENU-PRINCIPAL--------------------------------*/


        
        /*-----------CONTROL DE EVENTOS CLICK DE LOS CONTROLES DEL ENTORNO------------------*/
        
        void btnNuevo_Click(Object sender, EventArgs e)
        {
            ActivarNavegacion(false);
            this.btnBuscar.Enabled = false;
            this.btnReportesControl.Enabled = false;

            this.btnEditar.Enabled = false;
            this.btnNuevo.Enabled = false;
            this.btnBorrar.Enabled = false;
            this.btnGuardar.Enabled = true;
            this.btnCancelar.Enabled = true;
            Funciones f = (Funciones)panel;
            f.Nuevo();
        }
        void btnGuardar_Click(Object sender, EventArgs e)
        {
            DialogResult resultado=MessageBox.Show("Desea guardar los cambios?","Confirmar",MessageBoxButtons.YesNo);
            Funciones f;
            bool estado = false ;
            if (resultado == DialogResult.Yes)
            {
                f = (Funciones)panel;
                estado = f.Guardar();
            }
            else
            {
                estado = true;
            }
            if (estado)
            {
                ActivarNavegacion(true);
                this.btnNuevo.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnBorrar.Enabled = true;
                
                this.btnReportesControl.Enabled = true;
                this.btnBuscar.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }
        void btnEditar_Click(Object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.Editar();
            ActivarNavegacion(false);
            this.btnCancelar.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.btnBorrar.Enabled = false;
            this.btnNuevo.Enabled = false;
          

        }
        void btnBorrar_Click(Object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea borrar es registro seleccionado?", "Confirmar", MessageBoxButtons.YesNo);
            Funciones f=(Funciones)panel;
            bool estado = false;
            if (resultado == DialogResult.Yes)
            {
                f.Borrar();
                estado = true;
            }
            else
            {
                estado = false;
            }
            if (estado)
            {
                if (f.vacio())
                {
                    limpiarControles();
                }            
            }
            
            
        }
        void btnCancelar_Click(Object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cancelar los cambios realizados?","Confirmar",MessageBoxButtons.YesNo);
            Funciones f = (Funciones)panel;
            if (resultado == DialogResult.Yes)
            {
                f.Cancelar();
                ActivarNavegacion(true);
                this.btnNuevo.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnBorrar.Enabled = true;
                
                this.btnReportesControl.Enabled = true;
                this.btnBuscar.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                if (f.vacio())
                {
                    limpiarControles();
                }    
            }
            
        }

            //navegacion

         void btnPrimero_Click(Object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.IrPrimero();
        }
        void btnAnterior_Click(Object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.Anterior();
        }
        void btnSiguiente_Click(Object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.Siguiente();
        }
        void btnUltimo_Click(Object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.IrFinal();
        }


        /*--------------FIN EVENTOS DE CONTROLES DEL ENTORNO---------------------------------*/


        /*---------------------METODOS PROPIOS PARA EL ENTRONO------------------------------*/
        

        void seleccionar_tabControles()
        {
            this.metroShell1.SelectedTab = this.tabControles;
        }
        void limpiarPanel()
        {
            if (panel != null)
                this.Controls.Remove(panel);
            this.btnRealizarPago.Visible = false;
        }
        void ajustarTamano(UserControl p)
        {
            panel.Location = new Point((this.Width - panel.Width) / 2, this.metroShell1.Height + 5);
            panel.Size = new Size(panel.Width, this.Height - this.metroShell1.Height - 40);
        }
       
        //Metodos que controlan los controles habilitados y los desabilitados
        void modoNavegacion()
        {

            this.btnNuevo.Enabled = true;
            this.btnGuardar.Enabled = false;
            this.btnBorrar.Enabled = true;
            this.btnEditar.Enabled = true;
            this.btnCancelar.Enabled = false;
            //Navegacion
            this.btnPrimero.Enabled = true;
            this.btnAnterior.Enabled = true;
            this.btnSiguiente.Enabled = true;
            this.btnUltimo.Enabled = true;
            
            this.btnBuscar.Enabled = true;

            this.btnReportesControl.Enabled = true;


        }
        void ActivarNavegacion(bool a)
        {
            this.btnPrimero.Enabled = a;
            this.btnAnterior.Enabled = a;
            this.btnSiguiente.Enabled = a;
            this.btnUltimo.Enabled = a;

        }
        void modoEdicion()
        {
            this.btnNuevo.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.btnEditar.Enabled = true;
            //Navegacion
            ActivarNavegacion(false);

        }
      
      
        void btnImprimir_Click(Object sender,EventArgs e)
        {
            MessageBox.Show("En construcción");
        }
        void btnBuscar_Click(object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.Filtrar();
        }
        void btnReportesControl_Click(Object sender,EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.Reportes();
        }
        void btnRealizarPago_Click(Object sender, EventArgs e)
        {
            Funciones f = (Funciones)panel;
            f.RealizarPago();
        }

        /*-------------------------------FIN ENTORNO-----------------------------------------*/

        private void metroAppButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabItem2_Click(object sender, EventArgs e)
        {

        }

        private void metroTabItem3_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {

        }

    

    }
}