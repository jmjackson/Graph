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
            this.CbClients.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CbClients.FormattingEnabled = true;
            this.CbClients.ItemHeight = 29;
            this.CbClients.Location = new System.Drawing.Point(61, 87);
            this.CbClients.Name = "CbClients";
            this.CbClients.Size = new System.Drawing.Size(351, 35);
            this.CbClients.TabIndex = 0;
            this.CbClients.UseSelectable = true;
            // 
            // BtnYes
            // 
            this.BtnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnYes.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnYes.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnYes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnYes.Location = new System.Drawing.Point(106, 149);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(124, 36);
            this.BtnYes.TabIndex = 1;
            this.BtnYes.Text = "Yes";
            this.BtnYes.UseCustomBackColor = true;
            this.BtnYes.UseCustomForeColor = true;
            this.BtnYes.UseSelectable = true;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.BtnNo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnNo.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnNo.Location = new System.Drawing.Point(252, 149);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(124, 36);
            this.BtnNo.TabIndex = 1;
            this.BtnNo.Text = "No";
            this.BtnNo.UseCustomBackColor = true;
            this.BtnNo.UseCustomForeColor = true;
            this.BtnNo.UseSelectable = true;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // LblClients
            // 
            this.LblClients.AutoSize = true;
            this.LblClients.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblClients.Location = new System.Drawing.Point(61, 59);
            this.LblClients.Name = "LblClients";
            this.LblClients.Size = new System.Drawing.Size(62, 25);
            this.LblClients.TabIndex = 2;
            this.LblClients.Text = "Clients";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblTitle.Location = new System.Drawing.Point(61, 11);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(351, 25);
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "Choice The Client For add o modify a project";
            // 
            // ModalProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 220);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblClients);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.CbClients);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalProject";
            this.Resizable = false;
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