namespace Mine.Views
{
    partial class ReportDev
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
            this.DevelopmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDevView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DevelopmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DevelopmentBindingSource
            // 
            this.DevelopmentBindingSource.DataSource = typeof(Mine.DataModel.Development);
            // 
            // ProjectBindingSource
            // 
            this.ProjectBindingSource.DataSource = typeof(Mine.DataModel.Project);
            // 
            // ReportDevView
            // 
            this.ReportDevView.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DevelopmentBindinSource";
            reportDataSource1.Value = this.DevelopmentBindingSource;
            reportDataSource2.Name = "ProjectBindingSource";
            reportDataSource2.Value = this.ProjectBindingSource;
            reportDataSource3.Name = "ClientBindingSource";
            reportDataSource3.Value = this.ClientBindingSource;
            this.ReportDevView.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportDevView.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportDevView.LocalReport.DataSources.Add(reportDataSource3);
            this.ReportDevView.LocalReport.ReportEmbeddedResource = "Mine.Views.ReportViewDeploy.rdlc";
            this.ReportDevView.Location = new System.Drawing.Point(0, 0);
            this.ReportDevView.Name = "ReportDevView";
            this.ReportDevView.ServerReport.BearerToken = null;
            this.ReportDevView.Size = new System.Drawing.Size(913, 493);
            this.ReportDevView.TabIndex = 0;
            this.ReportDevView.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // ClientBindingSource
            // 
            this.ClientBindingSource.DataSource = typeof(Mine.DataModel.Client);
            // 
            // ReportDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 493);
            this.Controls.Add(this.ReportDevView);
            this.Name = "ReportDev";
            this.Text = "ReportDev";
            this.Load += new System.EventHandler(this.ReportDev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DevelopmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportDevView;
        private System.Windows.Forms.BindingSource DevelopmentBindingSource;
        private System.Windows.Forms.BindingSource ProjectBindingSource;
        private System.Windows.Forms.BindingSource ClientBindingSource;
    }
}