﻿namespace Mine.Views
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDev));
            this.DevelopmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDevView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProjectDevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DevelopmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDevBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportDevView
            // 
            this.ReportDevView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportDevView.AutoSize = true;
            this.ReportDevView.DocumentMapWidth = 75;
            this.ReportDevView.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "DevelopmentBindinSource";
            reportDataSource1.Value = this.DevelopmentBindingSource;
            reportDataSource2.Name = "ProjectBindingSource";
            reportDataSource2.Value = this.ProjectBindingSource;
            reportDataSource3.Name = "ClientBindingSource";
            reportDataSource3.Value = this.ClientBindingSource;
            reportDataSource4.Name = "InspectionBinding";
            reportDataSource4.Value = this.ProjectDevBindingSource;
            this.ReportDevView.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportDevView.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportDevView.LocalReport.DataSources.Add(reportDataSource3);
            this.ReportDevView.LocalReport.DataSources.Add(reportDataSource4);
            this.ReportDevView.LocalReport.ReportEmbeddedResource = "Mine.Views.ReportViewDeploy.rdlc";
            this.ReportDevView.Location = new System.Drawing.Point(0, 0);
            this.ReportDevView.Name = "ReportDevView";
            this.ReportDevView.ServerReport.BearerToken = null;
            this.ReportDevView.Size = new System.Drawing.Size(1370, 749);
            this.ReportDevView.TabIndex = 0;
            this.ReportDevView.ZoomPercent = 75;
            // 
            // ProjectDevBindingSource
            // 
            this.ProjectDevBindingSource.DataSource = typeof(Mine.DataModel.ProjectDev);
            // 
            // ReportDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ReportDevView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportDev";
            this.Text = "ReportDev";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportDev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DevelopmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDevBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportDevView;
        private System.Windows.Forms.BindingSource DevelopmentBindingSource;
        private System.Windows.Forms.BindingSource ProjectBindingSource;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private System.Windows.Forms.BindingSource ProjectDevBindingSource;
    }
}