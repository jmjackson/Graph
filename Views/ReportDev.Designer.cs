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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDev));
            this.DevelopmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDevView = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DevelopmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.ReportDevView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportDevView.Name = "ReportDevView";
            this.ReportDevView.ServerReport.BearerToken = null;
            this.ReportDevView.Size = new System.Drawing.Size(1392, 758);
            this.ReportDevView.TabIndex = 0;
            this.ReportDevView.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // ReportDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1392, 758);
            this.Controls.Add(this.ReportDevView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportDev";
            this.Text = "ReportDev";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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