namespace Mine.Views
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.BtnOther = new FontAwesome.Sharp.IconButton();
            this.BtnLogout = new FontAwesome.Sharp.IconButton();
            this.BtnConfig = new FontAwesome.Sharp.IconButton();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.TileClient = new ns1.BunifuTileButton();
            this.TileProject = new ns1.BunifuTileButton();
            this.TileInspection = new ns1.BunifuTileButton();
            this.BElipse = new ns1.BunifuElipse(this.components);
            this.PanelHead = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.PanelHead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(219)))));
            this.PanelLeft.Controls.Add(this.BtnOther);
            this.PanelLeft.Controls.Add(this.BtnLogout);
            this.PanelLeft.Controls.Add(this.BtnConfig);
            this.PanelLeft.Location = new System.Drawing.Point(0, 306);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(292, 339);
            this.PanelLeft.TabIndex = 0;
            // 
            // BtnOther
            // 
            this.BtnOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(229)))));
            this.BtnOther.FlatAppearance.BorderSize = 0;
            this.BtnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOther.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOther.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOther.ForeColor = System.Drawing.Color.White;
            this.BtnOther.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.BtnOther.IconColor = System.Drawing.Color.White;
            this.BtnOther.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnOther.IconSize = 20;
            this.BtnOther.Location = new System.Drawing.Point(-3, 143);
            this.BtnOther.Name = "BtnOther";
            this.BtnOther.Rotation = 0D;
            this.BtnOther.Size = new System.Drawing.Size(292, 60);
            this.BtnOther.TabIndex = 1;
            this.BtnOther.Text = "Other";
            this.BtnOther.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOther.UseVisualStyleBackColor = false;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(229)))));
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnLogout.IconColor = System.Drawing.Color.White;
            this.BtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogout.IconSize = 20;
            this.BtnLogout.Location = new System.Drawing.Point(-3, 222);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Rotation = 0D;
            this.BtnLogout.Size = new System.Drawing.Size(292, 61);
            this.BtnLogout.TabIndex = 1;
            this.BtnLogout.Text = "Log Out";
            this.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogout.UseVisualStyleBackColor = false;
            // 
            // BtnConfig
            // 
            this.BtnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(229)))));
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnConfig.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfig.ForeColor = System.Drawing.Color.White;
            this.BtnConfig.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.BtnConfig.IconColor = System.Drawing.Color.White;
            this.BtnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfig.IconSize = 20;
            this.BtnConfig.Location = new System.Drawing.Point(0, 66);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Rotation = 0D;
            this.BtnConfig.Size = new System.Drawing.Size(289, 59);
            this.BtnConfig.TabIndex = 1;
            this.BtnConfig.Text = "Configuration";
            this.BtnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfig.UseVisualStyleBackColor = false;
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(12, 9);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(264, 288);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogo.TabIndex = 1;
            this.PbLogo.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.BtnExit.IconColor = System.Drawing.Color.White;
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.IconSize = 48;
            this.BtnExit.Location = new System.Drawing.Point(922, 567);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Rotation = 0D;
            this.BtnExit.Size = new System.Drawing.Size(99, 66);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TileClient
            // 
            this.TileClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(218)))));
            this.TileClient.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(218)))));
            this.TileClient.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(250)))));
            this.TileClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TileClient.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TileClient.ForeColor = System.Drawing.Color.White;
            this.TileClient.Image = ((System.Drawing.Image)(resources.GetObject("TileClient.Image")));
            this.TileClient.ImagePosition = 50;
            this.TileClient.ImageZoom = 50;
            this.TileClient.LabelPosition = 55;
            this.TileClient.LabelText = "Clients";
            this.TileClient.Location = new System.Drawing.Point(67, 99);
            this.TileClient.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TileClient.Name = "TileClient";
            this.TileClient.Size = new System.Drawing.Size(293, 352);
            this.TileClient.TabIndex = 5;
            this.TileClient.Click += new System.EventHandler(this.TileClient_Click_1);
            // 
            // TileProject
            // 
            this.TileProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.TileProject.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.TileProject.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.TileProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TileProject.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.TileProject.ForeColor = System.Drawing.Color.White;
            this.TileProject.Image = ((System.Drawing.Image)(resources.GetObject("TileProject.Image")));
            this.TileProject.ImagePosition = 50;
            this.TileProject.ImageZoom = 50;
            this.TileProject.LabelPosition = 55;
            this.TileProject.LabelText = "Project";
            this.TileProject.Location = new System.Drawing.Point(388, 99);
            this.TileProject.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TileProject.Name = "TileProject";
            this.TileProject.Size = new System.Drawing.Size(293, 352);
            this.TileProject.TabIndex = 6;
            this.TileProject.Click += new System.EventHandler(this.TileProject_Click_1);
            // 
            // TileInspection
            // 
            this.TileInspection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.TileInspection.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.TileInspection.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.TileInspection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TileInspection.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.TileInspection.ForeColor = System.Drawing.Color.White;
            this.TileInspection.Image = ((System.Drawing.Image)(resources.GetObject("TileInspection.Image")));
            this.TileInspection.ImagePosition = 50;
            this.TileInspection.ImageZoom = 50;
            this.TileInspection.LabelPosition = 55;
            this.TileInspection.LabelText = "Inspection";
            this.TileInspection.Location = new System.Drawing.Point(708, 99);
            this.TileInspection.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TileInspection.Name = "TileInspection";
            this.TileInspection.Size = new System.Drawing.Size(293, 352);
            this.TileInspection.TabIndex = 7;
            this.TileInspection.Click += new System.EventHandler(this.TileInspection_Click_1);
            // 
            // BElipse
            // 
            this.BElipse.ElipseRadius = 5;
            this.BElipse.TargetControl = this;
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.PanelHead.Controls.Add(this.PbLogo);
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(292, 306);
            this.PanelHead.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TileProject);
            this.panel1.Controls.Add(this.TileClient);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.TileInspection);
            this.panel1.Location = new System.Drawing.Point(282, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 645);
            this.panel1.TabIndex = 9;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelHead);
            this.Controls.Add(this.PanelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.PanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.PanelHead.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private FontAwesome.Sharp.IconButton BtnLogout;
        private FontAwesome.Sharp.IconButton BtnOther;
        private FontAwesome.Sharp.IconButton BtnConfig;
        private System.Windows.Forms.PictureBox PbLogo;
        private FontAwesome.Sharp.IconButton BtnExit;
        private ns1.BunifuTileButton TileClient;
        private ns1.BunifuTileButton TileProject;
        private ns1.BunifuTileButton TileInspection;
        private ns1.BunifuElipse BElipse;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Panel panel1;
    }
}