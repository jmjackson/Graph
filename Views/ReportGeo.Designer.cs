namespace Mine.Views
{
    partial class ReportGeo
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGeo));
            this.ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GeoMembraneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportViewGeom = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProjectDevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeoMembraneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDevBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewGeom
            // 
            this.ReportViewGeom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewGeom.DocumentMapWidth = 75;
            reportDataSource1.Name = "ProjectBinding";
            reportDataSource1.Value = this.ProjectBindingSource;
            reportDataSource2.Name = "GeoMemBinding";
            reportDataSource2.Value = this.GeoMembraneBindingSource;
            reportDataSource3.Name = "ClientBindingSource";
            reportDataSource3.Value = this.ClientBindingSource;
            reportDataSource4.Name = "InspectionBinding";
            reportDataSource4.Value = this.ProjectDevBindingSource;
            this.ReportViewGeom.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewGeom.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewGeom.LocalReport.DataSources.Add(reportDataSource3);
            this.ReportViewGeom.LocalReport.DataSources.Add(reportDataSource4);
            this.ReportViewGeom.LocalReport.ReportEmbeddedResource = "Mine.Views.ReportViewGeo.rdlc";
            this.ReportViewGeom.Location = new System.Drawing.Point(0, 0);
            this.ReportViewGeom.Name = "ReportViewGeom";
            this.ReportViewGeom.ServerReport.BearerToken = null;
            this.ReportViewGeom.Size = new System.Drawing.Size(1370, 749);
            this.ReportViewGeom.TabIndex = 0;
            this.ReportViewGeom.ZoomPercent = 75;
            // 
            // ProjectDevBindingSource
            // 
            this.ProjectDevBindingSource.DataSource = typeof(Mine.DataModel.ProjectDev);
            // 
            // ReportGeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ReportViewGeom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportGeo";
            this.Text = "ReportGeo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportGeo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeoMembraneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDevBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewGeom;
        private System.Windows.Forms.BindingSource ProjectBindingSource;
        private System.Windows.Forms.BindingSource GeoMembraneBindingSource;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private System.Windows.Forms.BindingSource ProjectDevBindingSource;
    }
}