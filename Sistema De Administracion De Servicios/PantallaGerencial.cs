using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class PantallaGerencial : UserControl, Funciones
    {
        CADINDataSetTableAdapters.CasoTableAdapter cta;
        CADINDataSetTableAdapters.Actividades3TableAdapter ata3;
        CADINDataSet.CasoDataTable cdt;
        CADINDataSet.Actividades3DataTable adt3;
        BindingSource s1, s2;

        public PantallaGerencial()
        {
            InitializeComponent();
            cta = new CADINDataSetTableAdapters.CasoTableAdapter();
            ata3 = new CADINDataSetTableAdapters.Actividades3TableAdapter();
            
            s1 = new BindingSource();
            s2 = new BindingSource();

            cdt = cta.GetData();
            
            s1.DataSource = cdt;
            s2.DataSource = adt3;

            llenarActividades();

            String q = "SELECT COUNT(*) FROM Caso";
            SqlCommand comand;

            comand = new SqlCommand(q, cta.Connection);
            comand.Connection.Open();
            comand.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter(q, cta.Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataTable table = new DataTable();
            da.Fill(table);
            
            System.Data.DataRow row = table.Rows[0];
            txtotal.Text = row.ItemArray.GetValue(0).ToString();
            comand.Connection.Close();
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormularioReportes.showReport(s1, "Casos"); 
            
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            if (superValidator1.Validate())
            {
                SqlCommand comand;

                int opc2 = Convert.ToInt32(comboBoxEx3.SelectedIndex);
                int opc = Convert.ToInt32(comboBoxEx1.SelectedIndex);
                String consulta = "", consulta2 = "";

                switch (opc)
                {
                    case 0:
                        switch (opc2)
                        {
                            case 0:
                                consulta = "Select * from Caso where fech_solic='" + DateTime.Today.ToString("dd-MM-yyyy") + "';";
                                consulta2 = "Select COUNT(*) from Caso where fech_solic='" + DateTime.Today.ToString("dd-MM-yyyy") + "';";
                                break;
                            case 1:
                                consulta = "Select * from Caso where fech_solic between '" + DateTime.Today.AddDays(-7).ToString("dd-MM-yyyy") + "' and '" + DateTime.Today.ToString("dd-MM-yyyy") + "' ;";
                                consulta2 = "Select COUNT(*) from Caso where fech_solic between '" + DateTime.Today.AddDays(-7).ToString("dd-MM-yyyy") + "' and '" + DateTime.Today.ToString("dd-MM-yyyy") + "' ;";
                                break;
                            case 2:
                                consulta = "Select * from Caso where month(fech_solic)= '" + DateTime.Today.Month + "';";
                                consulta2 = "Select COUNT(*) from Caso where month(fech_solic)= '" + DateTime.Today.Month + "';";
                                break;
                            case 3:
                                consulta = "Select * from Caso where year(fech_solic)= '" + DateTime.Today.Year + "';";
                                consulta2 = "Select COUNT(*) from Caso where year(fech_solic)= '" + DateTime.Today.Year + "';";
                                break;
                            default:
                                consulta = "Select * from Caso;";
                                consulta2 = "Select COUNT(*) from Caso;";
                                break;
                        } break;
                    case 1:
                        switch (opc2)
                        {
                            case 0:
                                consulta = "Select * from Caso where fech_solic='" + DateTime.Today.ToString("dd-MM-yyyy") + "' and caso_cerrado = 'false';";
                                consulta2 = "Select COUNT(*) from Caso where fech_solic='" + DateTime.Today.ToString("dd-MM-yyyy") + "' and caso_cerrado = 'false';";
                                break;
                            case 1:
                                consulta = "Select * from Caso where caso_cerrado = 'false' and fech_solic between '" + DateTime.Today.AddDays(-7).ToString("dd-MM-yyyy") + "' and '" + DateTime.Today.ToString("dd-MM-yyyy") + "' ;";
                                consulta2 = "Select COUNT(*) from Caso where caso_cerrado = 'false' and fech_solic between '" + DateTime.Today.AddDays(-7).ToString("dd-MM-yyyy") + "' and '" + DateTime.Today.ToString("dd-MM-yyyy") + "' ;";
                                break;
                            case 2:
                                consulta = "Select * from Caso where month(fech_solic)='" + DateTime.Today.Month + "' and caso_cerrado = 'false';";
                                consulta2 = "Select COUNT(*) from Caso where month(fech_solic)='" + DateTime.Today.Month + "' and caso_cerrado = 'false';";
                                break;
                            case 3:
                                consulta = "Select * from Caso where year(fech_solic)='" + DateTime.Today.Year + "' and caso_cerrado = 'false';";
                                consulta2 = "Select COUNT(*) from Caso where year(fech_solic)='" + DateTime.Today.Year + "' and caso_cerrado = 'false';";
                                break;
                            default:
                                consulta = "Select * from Caso where caso_cerrado = 'false';";
                                consulta2 = "Select COUNT(*) from Caso where caso_cerrado = 'false';";
                                break;
                        } break;
                    case 2:
                        switch (opc2)
                        {
                            case 0:
                                consulta = "Select * from Caso where fech_solf='" + DateTime.Today.ToString("dd-MM-yyyy") + "' and caso_cerrado = 'true';";
                                consulta2 = "Select COUNT(*) from Caso where fech_solf='" + DateTime.Today.ToString("dd-MM-yyyy") + "' and caso_cerrado = 'true';";
                                break;
                            case 1:
                                consulta = "Select * from Caso where caso_cerrado = 'true' and fech_solf between '" + DateTime.Today.AddDays(-7).ToString("dd-MM-yyyy") + "' and '" + DateTime.Today.ToString("dd-MM-yyyy") + "' ;";
                                consulta2 = "Select COUNT(*) from Caso where caso_cerrado = 'true' and fech_solf between '" + DateTime.Today.AddDays(-7).ToString("dd-MM-yyyy") + "' and '" + DateTime.Today.ToString("dd-MM-yyyy") + "' ;";
                                break;
                            case 2:
                                consulta = "Select * from Caso where month(fech_solf)='" + DateTime.Today.Month + "' and caso_cerrado = 'true';";
                                consulta2 = "Select COUNT(*) from Caso where month(fech_solf)='" + DateTime.Today.Month + "' and caso_cerrado = 'true';";
                                break;
                            case 3:
                                consulta = "Select * from Caso where year(fech_solf) = '" + DateTime.Today.Year + "' and caso_cerrado = 'true';";
                                consulta2 = "Select COUNT(*) from Caso where year(fech_solf) = '" + DateTime.Today.Year + "' and caso_cerrado = 'true';";
                                break;
                            default:
                                consulta = "Select * from Caso where caso_cerrado = 'true';";
                                consulta2 = "Select COUNT(*) from Caso where caso_cerrado = 'true';";
                                break;
                        } break;
                    default:
                        consulta = "Select * from Caso where caso_cerrado = 'true';";
                        consulta2 = "Select COUNT(*) from Caso where caso_cerrado = 'true';";
                        break;
                    /*case 3 :
                        switch (opc2)
                        {
                            case 0:
                                consulta = "Select * from Caso where fech_soluf='" + DateTime.Today.ToString("dd-MM-yyyy") + "';";
                                consulta2 = "Select COUNT(*) from Caso where fech_soluf='" + DateTime.Today.ToString("dd-MM-yyyy") + "';";
                                break;
                            case 1:
                                consulta = "Select * from Caso where caso_cerrado = true and fech_soluf between '" + DateTime.Today.ToString("dd-MM-yyyy") + "' and '" + DateTime.Today.AddDays(-7).ToString("dd-MM-yyyy") + "' ;";
                                consulta2 = "Select COUNT(*) from Caso where caso_cerrado = true and fech_soluf between '" + DateTime.Today.ToString("dd-MM-yyyy") + "' and '" + DateTime.Today.AddDays(-7).ToString("dd-MM-yyyy") + "' ;";
                                break;
                            case 2:
                                consulta = "Select * from Caso where fech_soluf like '" + DateTime.Today.ToString("MM-yyyy") + "' and caso_cerrado = true;";
                                consulta2 = "Select COUNT(*) from Caso where fech_soluf like '" + DateTime.Today.ToString("MM-yyyy") + "' and caso_cerrado = true;";
                                break;
                            case 3:
                                consulta = "Select * from Caso where fech_soluf like '" + DateTime.Today.ToString("yyyy") + "' and caso_cerrado = true;";
                                consulta2 = "Select COUNT(*) from Caso where fech_soluf like '" + DateTime.Today.ToString("yyyy") + "' and caso_cerrado = true;";
                                break;
                        } break;*/
                }

                comand = new SqlCommand(consulta, cta.Connection);
                comand.Connection.Open();
                comand.ExecuteNonQuery();


                SqlDataAdapter da = new SqlDataAdapter(consulta, cta.Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                DataTable table = new DataTable();
                da.Fill(table);
                comand.Connection.Close();

                this.dgvCasosG.DataSource = table;

                comand = new SqlCommand(consulta2, cta.Connection);
                comand.Connection.Open();
                comand.ExecuteNonQuery();


                SqlDataAdapter da2 = new SqlDataAdapter(consulta, cta.Connection);
                SqlCommandBuilder builder2 = new SqlCommandBuilder(da);
                DataTable table2 = new DataTable();
                da.Fill(table2);
                int n = table2.Rows.Count;

                LCantidad.Text = n.ToString();
                LEstado.Text = comboBoxEx1.SelectedItem.ToString();
                comand.Connection.Close();
            }
            
        else{
            MessageBox.Show("Debe de elegir una opcion en el campo señalado");
        }
      }


        public void Nuevo()
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public void Cancelar()
        {
            throw new NotImplementedException();
        }

        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Borrar()
        {
            throw new NotImplementedException();
        }

        public void IrPrimero()
        {
            throw new NotImplementedException();
        }

        public void Anterior()
        {
            throw new NotImplementedException();
        }

        public void Siguiente()
        {
            throw new NotImplementedException();
        }

        public void IrFinal()
        {
            throw new NotImplementedException();
        }

        public bool vacio()
        {
            return true;
        }

        public void Reportes()
        {
            throw new NotImplementedException();
        }

        public void RealizarPago()
        {
            throw new NotImplementedException();
        }

        public void Filtrar()
        {
            throw new NotImplementedException();
        }
        
        private void llenarActividades()
        {
            if (s1.Position != -1)
            {
                this.dgvActividadesH.Columns.Clear();

                adt3 = ata3.GetDataByFecha(Convert.ToDateTime(DateTime.Today.ToString("dd-MM-yyyy")));
                
                this.dgvActividadesH.DataSource = adt3;
                this.dgvActividadesH.Columns["cod_actv"].Visible = false;
                this.dgvActividadesH.Columns["cod_caso"].Visible = false;
                this.dgvActividadesH.Columns["solicitud_apoyo"].HeaderText = "Tipo de Solicitud";
                this.dgvActividadesH.Columns["tipo_actividad"].HeaderText = "Tipo de Actividad";
                this.dgvActividadesH.Columns["nombre_responsable"].HeaderText = "Funcionario Asignado";
                this.dgvActividadesH.Columns["referencia"].HeaderText = "Referencia";
                this.dgvActividadesH.Columns["fech_prog"].HeaderText = "Fecha Programada";
                this.dgvActividadesH.Columns["realizado"].HeaderText = "Realizado";
                this.dgvActividadesH.Columns["acti_cerrada"].HeaderText = "Actividad Cerrada";
                this.dgvActividadesH.Columns["fech_cierre"].HeaderText = "Fecha de Cierre";
                this.dgvActividadesH.Columns["observaciones"].HeaderText = "Observaciones";

            }
        }
        }
}

