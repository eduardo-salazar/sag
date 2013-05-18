using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;

namespace Sistema_De_Administracion_De_Servicios
{
    public partial class FormularioReportes : Form
    {
        private System.Windows.Forms.BindingSource bindingSource;
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource;
        private ToolStripItem find;
        private String[] reportsNames;
        private String[] reportsSources;
        String reportCollection;
        private Boolean showFilterButton;

        public static void showFormularioReportes(String reportCollection) {
            FormularioReportes f = new FormularioReportes();
            f.fillListVersionReporte(reportCollection);
            f.handleDataSource(reportCollection);
            f.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            f.ShowDialog();
        }

        private void handleDataSource(string reportCollection)
        {
            switch (reportCollection)
            {
                case "ReporteCompleto":
                    {
                        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource.Name = "Cantidades";
                        reportDataSource.Value = new ReportesDataSetTableAdapters.CantidadesTableAdapter().GetData();
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource.Name = "DepartamentosCantidad";
                        reportDataSource.Value = new ReportesDataSetTableAdapters.DepartamentosCantidadTableAdapter().GetData();
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource.Name = "SectoresCantidad";
                        reportDataSource.Value = new ReportesDataSetTableAdapters.SectoresCantidadTableAdapter().GetData();
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                        reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource.Name = "UsuarioCantidad";
                        reportDataSource.Value = new ReportesDataSetTableAdapters.UsuarioCantidadTableAdapter().GetData();
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                        reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
                        reportDataSource.Name = "UsuaCasoEmprProbActi";
                        reportDataSource.Value = new ReportesDataSetTableAdapters.UsuaCasoEmprProbActiTableAdapter().GetData();
                        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        
                        this.reportViewer1.RefreshReport();
                    } break;
            }
        }

        public FormularioReportes() {
            InitializeComponent();
            this.reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
        }

        public FormularioReportes(BindingSource bindingSource, String reportCollection) {
            InitializeComponent();
            ToolStrip toolStrip = (ToolStrip)this.reportViewer1.Controls.Find("toolStrip1", true)[0];
            find = new ToolStripButton("", Properties.Resources.find48, toolStripFiltrar_Click);
            //toolStrip.Items.Add("", Properties.Resources.find48, tollStripFiltrar_Click);
            toolStrip.Items.Add(find);
            this.reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportCollection = reportCollection;
            handleDataSource(bindingSource, reportCollection);
            //this.5bindingSource = bindingSource;
            this.reportDataSource.Name = "dataSet";
            this.reportViewer1.LocalReport.DataSources.Add(this.reportDataSource);
            //this.bindingSource.DataSource = (DataTable)bindingSource.DataSource;
            this.reportDataSource.Value = this.bindingSource;
            fillListVersionReporte(reportCollection);
            configureParameters();
            this.reportViewer1.LocalReport.SubreportProcessing += new Microsoft.Reporting.WinForms.SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }

        void LocalReport_SubreportProcessing(object sender, Microsoft.Reporting.WinForms.SubreportProcessingEventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportDataSource dt = new Microsoft.Reporting.WinForms.ReportDataSource();
            dt.Name = "dataSet";
            switch (reportCollection)
            {
                case ("ReporteCompleto"):
                    Microsoft.Reporting.WinForms.ReportDataSource dt2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    dt2.Name = "Cantidades";
                    dt2.Value = new ReportesDataSetTableAdapters.CantidadesTableAdapter().GetData();
                    e.DataSources.Add(dt2);
                    break;
                case ("Casos"):
                    BindingSource bs = new BindingSource();
                    bs.DataSource = new ReportesDataSetTableAdapters.ActividadesTableAdapter().GetData();
                    dt.Value = bs;
                    break;
            }
            e.DataSources.Add(dt);
        }

        private void handleDataSource(BindingSource bindingSource,string reportCollection)
        {
            switch (reportCollection)
            {
                case "Empresas":
                    {
                        if (!(bindingSource.DataSource is EmpresaDataSet.EmpresaFullDataTableDataTable))
                        {
                            EmpresaDataSet.EmpresaFullDataTableDataTable empresaFullDataTable = new EmpresaDataSetTableAdapters.EmpresaFullDataTableTableAdapter().GetData();
                            this.bindingSource = new BindingSource();
                            this.bindingSource.DataSource = empresaFullDataTable;
                            this.bindingSource.Filter = bindingSource.Filter;
                        }
                        else {
                            this.bindingSource = bindingSource;
                        }
                    } break;
                case "ReporteCompleto": {
                    Microsoft.Reporting.WinForms.ReportDataSource dt2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    dt2.Name = "Cantidades";
                    dt2.Value = new ReportesDataSetTableAdapters.CantidadesTableAdapter().GetData();
                    this.reportViewer1.LocalReport.DataSources.Add(dt2);
                    Microsoft.Reporting.WinForms.ReportDataSource dt3 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    dt3.Name = "DepartamentosCantidad";
                    dt3.Value = new ReportesDataSetTableAdapters.DepartamentosCantidadTableAdapter().GetData();
                    this.reportViewer1.LocalReport.DataSources.Add(dt3);
                    Microsoft.Reporting.WinForms.ReportDataSource dt4 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    dt4.Name = "SectoresCantidad";
                    dt4.Value = new ReportesDataSetTableAdapters.SectoresCantidadTableAdapter().GetData();
                    this.reportViewer1.LocalReport.DataSources.Add(dt4);
                } break;
                default: this.bindingSource = bindingSource; break;
            }

        }

        void toolStripFiltrar_Click(object sender, EventArgs args) {
            FormularioFiltroBusqueda.showFormularioFiltroBusqueda(this.bindingSource);
            configureParameters();
        }

        private void configureReportViewer(DataTable dataTable) {
            this.reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bindingSource = new System.Windows.Forms.BindingSource();
            this.reportDataSource.Name = "dataSet";
            this.reportViewer1.LocalReport.DataSources.Add(this.reportDataSource);
            this.bindingSource.DataSource = dataTable;
            this.reportDataSource.Value = this.bindingSource;
        }

        private void configureParameters() {
            String filter = this.bindingSource.Filter;
            if(filter!=null)
                if(filter.Equals(""))
                    filter=null;
            if (this.reportViewer1.LocalReport.GetParameters().Count != 0)
            {
                Microsoft.Reporting.WinForms.ReportParameter p = new Microsoft.Reporting.WinForms.ReportParameter("filtro", filter);
                this.reportViewer1.LocalReport.SetParameters(p);
                find.Visible = true;
            }
            else
                find.Visible = false;
            this.reportViewer1.RefreshReport();
        }

        private void fillListVersionReporte(String reportCollection) {
            reportsSources = EmbeddedResource.EmbeddedResource.getEmbeddedResources("Sistema_De_Administracion_De_Servicios.Reportes."+reportCollection,"rdlc");
            reportsNames=EmbeddedResource.EmbeddedResource.getEmbeddedResourcesNames("Sistema_De_Administracion_De_Servicios.Reportes."+reportCollection,"rdlc",reportsSources);
            foreach (String s in reportsNames) {
                MetroTileItem item = new MetroTileItem(s);
                item.Text = s;
                item.TileSize = new System.Drawing.Size(180, 30);
                item.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                this.itemPanelVersionReporte.Items.Add(item);
            }
            itemPanel1_ItemClick(itemPanelVersionReporte.Items[0], null);
        }

        public static void showReport(BindingSource bindingSource, String reportCollection)
        {
            FormularioReportes formularioReportes = new FormularioReportes(bindingSource, reportCollection);
            //Microsoft.Reporting.WinForms.ReportParameter p = new Microsoft.Reporting.WinForms.ReportParameter("filtro", bindingSource.Filter);
            //formularioReportes.reportViewer1.LocalReport.SetParameters(p);
            formularioReportes.configureParameters();
            formularioReportes.ShowDialog();
        }

        public static void showReporteEmpresa(int cod_empr)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = new EmpresaDataSetTableAdapters.EmpresaFullDataTableTableAdapter().GetDataByCodEmpr(cod_empr);
            bindingSource.Filter = "cod_empr=" + cod_empr;
            FormularioReportes.showReport(bindingSource, @"Empresas");
        }

        public static void showReporteEmpresa(int cod_empr, BindingSource bindingSource)
        {
            bindingSource.Filter = "cod_empr=" + cod_empr;
            FormularioReportes.showReport(bindingSource, @"Empresas");
        }

        private void FormularioReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.Reset();
            this.Dispose();
        }

        private void itemPanel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
        }

        private void itemPanel1_ItemClick(object sender, EventArgs e)
        {
            try
            {
                DevComponents.DotNetBar.BaseItem item = (DevComponents.DotNetBar.BaseItem)sender;
                this.txtSelectedVersionReporte.Text = item.Text;
                this.reportViewer1.LocalReport.ReportEmbeddedResource = reportsSources[itemPanelVersionReporte.Items.IndexOf(item)];
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex) { 
            }
        }
    }
}
