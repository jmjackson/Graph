namespace Grap.Principal.Views.Details
{
    partial class ClientDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDetails));
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.bunifuCards1 = new ns1.BunifuCards();
            this.LblCode = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtItem = new ns1.BunifuMaterialTextbox();
            this.TxtCode = new ns1.BunifuMaterialTextbox();
            this.TxtName = new ns1.BunifuMaterialTextbox();
            this.PanelHeader.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.White;
            this.PanelHeader.Controls.Add(this.bunifuCards1);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(800, 150);
            this.PanelHeader.TabIndex = 0;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.TxtName);
            this.bunifuCards1.Controls.Add(this.TxtCode);
            this.bunifuCards1.Controls.Add(this.TxtItem);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.Controls.Add(this.LblName);
            this.bunifuCards1.Controls.Add(this.LblId);
            this.bunifuCards1.Controls.Add(this.LblCode);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.Enabled = false;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(800, 150);
            this.bunifuCards1.TabIndex = 0;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCode.Location = new System.Drawing.Point(156, 41);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(60, 21);
            this.LblCode.TabIndex = 1;
            this.LblCode.Text = "Codigo";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(38, 41);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(40, 21);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Item";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(374, 41);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(66, 21);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(708, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TxtItem
            // 
            this.TxtItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtItem.Enabled = false;
            this.TxtItem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtItem.HintForeColor = System.Drawing.Color.Empty;
            this.TxtItem.HintText = "";
            this.TxtItem.isPassword = false;
            this.TxtItem.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtItem.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtItem.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtItem.LineThickness = 1;
            this.TxtItem.Location = new System.Drawing.Point(85, 33);
            this.TxtItem.Margin = new System.Windows.Forms.Padding(4);
            this.TxtItem.Name = "TxtItem";
            this.TxtItem.Size = new System.Drawing.Size(64, 29);
            this.TxtItem.TabIndex = 3;
            this.TxtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtCode
            // 
            this.TxtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCode.Enabled = false;
            this.TxtCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCode.HintForeColor = System.Drawing.Color.Empty;
            this.TxtCode.HintText = "";
            this.TxtCode.isPassword = false;
            this.TxtCode.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtCode.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtCode.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtCode.LineThickness = 1;
            this.TxtCode.Location = new System.Drawing.Point(241, 33);
            this.TxtCode.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(104, 29);
            this.TxtCode.TabIndex = 3;
            this.TxtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtName
            // 
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.Enabled = false;
            this.TxtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtName.HintForeColor = System.Drawing.Color.Empty;
            this.TxtName.HintText = "";
            this.TxtName.isPassword = false;
            this.TxtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtName.LineThickness = 1;
            this.TxtName.Location = new System.Drawing.Point(447, 33);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(242, 29);
            this.TxtName.TabIndex = 3;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelHeader);
            this.Name = "ClientDetails";
            this.Text = "Detalles del Cliente";
            this.Load += new System.EventHandler(this.ClientDetails_Load);
            this.PanelHeader.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private ns1.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuMaterialTextbox TxtItem;
        private ns1.BunifuMaterialTextbox TxtName;
        private ns1.BunifuMaterialTextbox TxtCode;
    }
}