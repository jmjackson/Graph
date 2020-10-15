namespace Mine.Modal
{
    partial class ModalProject
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
            this.CbClients = new MetroFramework.Controls.MetroComboBox();
            this.BtnYes = new MetroFramework.Controls.MetroButton();
            this.BtnNo = new MetroFramework.Controls.MetroButton();
            this.LblClients = new MetroFramework.Controls.MetroLabel();
            this.LblTitle = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // CbClients
            // 
            this.CbClients.FormattingEnabled = true;
            this.CbClients.ItemHeight = 23;
            this.CbClients.Location = new System.Drawing.Point(73, 76);
            this.CbClients.Name = "CbClients";
            this.CbClients.Size = new System.Drawing.Size(254, 29);
            this.CbClients.TabIndex = 0;
            this.CbClients.UseSelectable = true;
            // 
            // BtnYes
            // 
            this.BtnYes.Location = new System.Drawing.Point(170, 132);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(75, 23);
            this.BtnYes.TabIndex = 1;
            this.BtnYes.Text = "Yes";
            this.BtnYes.UseSelectable = true;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.Location = new System.Drawing.Point(251, 132);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(75, 23);
            this.BtnNo.TabIndex = 1;
            this.BtnNo.Text = "No";
            this.BtnNo.UseSelectable = true;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // LblClients
            // 
            this.LblClients.AutoSize = true;
            this.LblClients.Location = new System.Drawing.Point(73, 43);
            this.LblClients.Name = "LblClients";
            this.LblClients.Size = new System.Drawing.Size(47, 19);
            this.LblClients.TabIndex = 2;
            this.LblClients.Text = "Clients";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(61, 11);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(275, 19);
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "Choice The Client For add o modify a project";
            // 
            // ModalProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 194);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblClients);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.CbClients);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalProject";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Load += new System.EventHandler(this.ModalProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox CbClients;
        private MetroFramework.Controls.MetroButton BtnYes;
        private MetroFramework.Controls.MetroButton BtnNo;
        private MetroFramework.Controls.MetroLabel LblClients;
        private MetroFramework.Controls.MetroLabel LblTitle;
    }
}