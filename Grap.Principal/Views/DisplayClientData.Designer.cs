namespace Grap.Principal
{
    partial class DisplayClientData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayClientData));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.Close_Button = new ns1.BunifuImageButton();
            this.LblClientData = new ns1.BunifuCustomLabel();
            this.PboxClientLogo = new System.Windows.Forms.PictureBox();
            this.LblID = new ns1.BunifuCustomLabel();
            this.LblInfoID = new ns1.BunifuCustomLabel();
            this.LblInfoCode = new ns1.BunifuCustomLabel();
            this.LblCode = new ns1.BunifuCustomLabel();
            this.LblInfoName = new ns1.BunifuCustomLabel();
            this.LblName = new ns1.BunifuCustomLabel();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxClientLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            this.Header.Controls.Add(this.Close_Button);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(458, 61);
            this.Header.TabIndex = 0;
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.ImageActive = null;
            this.Close_Button.Location = new System.Drawing.Point(414, 12);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(32, 37);
            this.Close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Button.TabIndex = 6;
            this.Close_Button.TabStop = false;
            this.Close_Button.Zoom = 10;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // LblClientData
            // 
            this.LblClientData.AutoSize = true;
            this.LblClientData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientData.Location = new System.Drawing.Point(205, 71);
            this.LblClientData.Name = "LblClientData";
            this.LblClientData.Size = new System.Drawing.Size(67, 15);
            this.LblClientData.TabIndex = 30;
            this.LblClientData.Text = "Client Data";
            this.LblClientData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblClientData.Click += new System.EventHandler(this.LblClientData_Click);
            // 
            // PboxClientLogo
            // 
            this.PboxClientLogo.Location = new System.Drawing.Point(13, 89);
            this.PboxClientLogo.Name = "PboxClientLogo";
            this.PboxClientLogo.Size = new System.Drawing.Size(144, 139);
            this.PboxClientLogo.TabIndex = 31;
            this.PboxClientLogo.TabStop = false;
            // 
            // LblID
            // 
            this.LblID.AutoEllipsis = true;
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblID.Location = new System.Drawing.Point(172, 108);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(23, 15);
            this.LblID.TabIndex = 32;
            this.LblID.Text = "Id :";
            // 
            // LblInfoID
            // 
            this.LblInfoID.AutoSize = true;
            this.LblInfoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoID.Location = new System.Drawing.Point(226, 108);
            this.LblInfoID.Name = "LblInfoID";
            this.LblInfoID.Size = new System.Drawing.Size(217, 15);
            this.LblInfoID.TabIndex = 33;
            this.LblInfoID.Text = "______________________________";
            // 
            // LblInfoCode
            // 
            this.LblInfoCode.AutoSize = true;
            this.LblInfoCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoCode.Location = new System.Drawing.Point(226, 150);
            this.LblInfoCode.Name = "LblInfoCode";
            this.LblInfoCode.Size = new System.Drawing.Size(217, 15);
            this.LblInfoCode.TabIndex = 35;
            this.LblInfoCode.Text = "______________________________";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblCode.Location = new System.Drawing.Point(172, 150);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(42, 15);
            this.LblCode.TabIndex = 34;
            this.LblCode.Text = "Code :";
            // 
            // LblInfoName
            // 
            this.LblInfoName.AutoSize = true;
            this.LblInfoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoName.Location = new System.Drawing.Point(226, 189);
            this.LblInfoName.Name = "LblInfoName";
            this.LblInfoName.Size = new System.Drawing.Size(217, 15);
            this.LblInfoName.TabIndex = 37;
            this.LblInfoName.Text = "______________________________";
            this.LblInfoName.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblName.Location = new System.Drawing.Point(172, 189);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(47, 15);
            this.LblName.TabIndex = 36;
            this.LblName.Text = "Name :";
            // 
            // DisplayClientData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 241);
            this.Controls.Add(this.LblInfoName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblInfoCode);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.LblInfoID);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.PboxClientLogo);
            this.Controls.Add(this.LblClientData);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayClientData";
            this.Text = "DisplayClientData";
            this.Load += new System.EventHandler(this.DisplayClientData_Load);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxClientLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Header;
        private ns1.BunifuImageButton Close_Button;
        private System.Windows.Forms.PictureBox PboxClientLogo;
        private ns1.BunifuCustomLabel LblClientData;
        private ns1.BunifuCustomLabel LblInfoID;
        private ns1.BunifuCustomLabel LblID;
        private ns1.BunifuCustomLabel LblInfoName;
        private ns1.BunifuCustomLabel LblName;
        private ns1.BunifuCustomLabel LblInfoCode;
        private ns1.BunifuCustomLabel LblCode;
    }
}