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
            this.ReportViewGeom = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GeoMembraneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeoMembraneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewGeom
            // 
            this.ReportViewGeom.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProjectBinding";
            reportDataSource1.Value = this.ProjectBindingSource;
            reportDataSource2.Name = "GeoMemBinding";
            reportDataSource2.Value = this.GeoMembraneBindingSource;
            reportDataSource3.Name = "ClientBindingSource";
            reportDataSource3.Value = this.ClientBindingSource;
            this.ReportViewGeom.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewGeom.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewGeom.LocalReport.DataSources.Add(reportDataSource3);
            this.ReportViewGeom.LocalReport.ReportEmbeddedResource = "Mine.Views.ReportViewGeo.rdlc";
            this.ReportViewGeom.Location = new System.Drawing.Point(0, 0);
            this.ReportViewGeom.Name = "ReportViewGeom";
            this.ReportViewGeom.ServerReport.BearerToken = null;
            this.ReportViewGeom.Size = new System.Drawing.Size(934, 490);
            this.ReportViewGeom.TabIndex = 0;
            // 
            // ProjectBindingSource
            // 
            // 
            // GeoMembraneBindingSource
            // 
            // 
            // ClientBindingSource
            // 
            // 
            // ReportGeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 490);
            this.Controls.Add(this.ReportViewGeom);
            this.Name = "ReportGeo";
            this.Text = "ReportGeo";
            this.Load += new System.EventHandler(this.ReportGeo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeoMembraneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewGeom;
        private System.Windows.Forms.BindingSource ProjectBindingSource;
        private System.Windows.Forms.BindingSource GeoMembraneBindingSource;
        private System.Windows.Forms.BindingSource ClientBindingSource;
    }
}