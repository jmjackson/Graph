namespace Mine.Modal
{
    partial class ModalDevelopment
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
            this.CBClient = new MetroFramework.Controls.MetroComboBox();
            this.CBProject = new MetroFramework.Controls.MetroComboBox();
            this.BtnNo = new MetroFramework.Controls.MetroButton();
            this.BtnYes = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.LblTitle = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // CBClient
            // 
            this.CBClient.FormattingEnabled = true;
            this.CBClient.ItemHeight = 23;
            this.CBClient.Location = new System.Drawing.Point(113, 54);
            this.CBClient.Name = "CBClient";
            this.CBClient.Size = new System.Drawing.Size(284, 29);
            this.CBClient.TabIndex = 0;
            this.CBClient.UseSelectable = true;
            this.CBClient.SelectedIndexChanged += new System.EventHandler(this.CBClient_SelectedIndexChanged);
            // 
            // CBProject
            // 
            this.CBProject.FormattingEnabled = true;
            this.CBProject.ItemHeight = 23;
            this.CBProject.Location = new System.Drawing.Point(113, 98);
            this.CBProject.Name = "CBProject";
            this.CBProject.Size = new System.Drawing.Size(284, 29);
            this.CBProject.TabIndex = 0;
            this.CBProject.UseSelectable = true;
            // 
            // BtnNo
            // 
            this.BtnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnNo.Location = new System.Drawing.Point(322, 145);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(75, 23);
            this.BtnNo.TabIndex = 1;
            this.BtnNo.Text = "No";
            this.BtnNo.UseSelectable = true;
            // 
            // BtnYes
            // 
            this.BtnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnYes.Location = new System.Drawing.Point(241, 145);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(75, 23);
            this.BtnYes.TabIndex = 1;
            this.BtnYes.Text = "Yes";
            this.BtnYes.UseSelectable = true;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(56, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Client";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(48, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Project";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(72, 14);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(331, 19);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "For a new Deployment Log Choice a Client and Project";
            // 
            // ModalDevelopment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 214);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.CBProject);
            this.Controls.Add(this.CBClient);
            this.Name = "ModalDevelopment";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ModalDevelopment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnNo;
        private MetroFramework.Controls.MetroButton BtnYes;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel LblTitle;
        public MetroFramework.Controls.MetroComboBox CBClient;
        public MetroFramework.Controls.MetroComboBox CBProject;
    }
}