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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLogout = new FontAwesome.Sharp.IconButton();
            this.BtnOther = new FontAwesome.Sharp.IconButton();
            this.BtnConfig = new FontAwesome.Sharp.IconButton();
            this.BtnClient = new FontAwesome.Sharp.IconButton();
            this.TileClient = new MetroFramework.Controls.MetroTile();
            this.TileProject = new MetroFramework.Controls.MetroTile();
            this.TileInspection = new MetroFramework.Controls.MetroTile();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(219)))));
            this.PanelLeft.Controls.Add(this.pictureBox1);
            this.PanelLeft.Controls.Add(this.BtnLogout);
            this.PanelLeft.Controls.Add(this.BtnOther);
            this.PanelLeft.Controls.Add(this.BtnConfig);
            this.PanelLeft.Controls.Add(this.BtnClient);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(292, 597);
            this.PanelLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.BtnLogout.Location = new System.Drawing.Point(0, 532);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Rotation = 0D;
            this.BtnLogout.Size = new System.Drawing.Size(292, 41);
            this.BtnLogout.TabIndex = 1;
            this.BtnLogout.Text = "Log Out";
            this.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogout.UseVisualStyleBackColor = false;
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
            this.BtnOther.Location = new System.Drawing.Point(0, 485);
            this.BtnOther.Name = "BtnOther";
            this.BtnOther.Rotation = 0D;
            this.BtnOther.Size = new System.Drawing.Size(292, 41);
            this.BtnOther.TabIndex = 1;
            this.BtnOther.Text = "Other";
            this.BtnOther.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOther.UseVisualStyleBackColor = false;
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
            this.BtnConfig.Location = new System.Drawing.Point(0, 438);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Rotation = 0D;
            this.BtnConfig.Size = new System.Drawing.Size(292, 41);
            this.BtnConfig.TabIndex = 1;
            this.BtnConfig.Text = "Configuration";
            this.BtnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfig.UseVisualStyleBackColor = false;
            // 
            // BtnClient
            // 
            this.BtnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(229)))));
            this.BtnClient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnClient.FlatAppearance.BorderSize = 0;
            this.BtnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClient.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClient.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClient.ForeColor = System.Drawing.Color.White;
            this.BtnClient.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnClient.IconColor = System.Drawing.Color.White;
            this.BtnClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClient.IconSize = 20;
            this.BtnClient.Location = new System.Drawing.Point(-3, 391);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Rotation = 0D;
            this.BtnClient.Size = new System.Drawing.Size(295, 41);
            this.BtnClient.TabIndex = 1;
            this.BtnClient.Text = "Clients";
            this.BtnClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClient.UseVisualStyleBackColor = false;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // TileClient
            // 
            this.TileClient.ActiveControl = null;
            this.TileClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(98)))));
            this.TileClient.ForeColor = System.Drawing.Color.White;
            this.TileClient.Location = new System.Drawing.Point(318, 170);
            this.TileClient.Name = "TileClient";
            this.TileClient.Size = new System.Drawing.Size(246, 345);
            this.TileClient.Style = MetroFramework.MetroColorStyle.Blue;
            this.TileClient.TabIndex = 2;
            this.TileClient.Text = "Clients";
            this.TileClient.TileImage = ((System.Drawing.Image)(resources.GetObject("TileClient.TileImage")));
            this.TileClient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileClient.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileClient.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TileClient.UseSelectable = true;
            this.TileClient.UseStyleColors = true;
            this.TileClient.UseTileImage = true;
            this.TileClient.Click += new System.EventHandler(this.TileClient_Click);
            // 
            // TileProject
            // 
            this.TileProject.ActiveControl = null;
            this.TileProject.Location = new System.Drawing.Point(570, 170);
            this.TileProject.Name = "TileProject";
            this.TileProject.Size = new System.Drawing.Size(246, 345);
            this.TileProject.Style = MetroFramework.MetroColorStyle.Blue;
            this.TileProject.TabIndex = 2;
            this.TileProject.Text = "Project";
            this.TileProject.TileImage = ((System.Drawing.Image)(resources.GetObject("TileProject.TileImage")));
            this.TileProject.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileProject.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileProject.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TileProject.UseSelectable = true;
            this.TileProject.UseTileImage = true;
            this.TileProject.Click += new System.EventHandler(this.TileProject_Click);
            // 
            // TileInspection
            // 
            this.TileInspection.ActiveControl = null;
            this.TileInspection.Location = new System.Drawing.Point(822, 170);
            this.TileInspection.Name = "TileInspection";
            this.TileInspection.Size = new System.Drawing.Size(246, 345);
            this.TileInspection.Style = MetroFramework.MetroColorStyle.Blue;
            this.TileInspection.TabIndex = 3;
            this.TileInspection.Text = "Inspection";
            this.TileInspection.TileImage = ((System.Drawing.Image)(resources.GetObject("TileInspection.TileImage")));
            this.TileInspection.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileInspection.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileInspection.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TileInspection.UseSelectable = true;
            this.TileInspection.UseStyleColors = true;
            this.TileInspection.UseTileImage = true;
            this.TileInspection.Click += new System.EventHandler(this.TileInspection_Click);
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
            this.BtnExit.Location = new System.Drawing.Point(997, 521);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Rotation = 0D;
            this.BtnExit.Size = new System.Drawing.Size(99, 66);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 597);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TileInspection);
            this.Controls.Add(this.TileProject);
            this.Controls.Add(this.TileClient);
            this.Controls.Add(this.PanelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.PanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private FontAwesome.Sharp.IconButton BtnLogout;
        private FontAwesome.Sharp.IconButton BtnOther;
        private FontAwesome.Sharp.IconButton BtnConfig;
        private FontAwesome.Sharp.IconButton BtnClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile TileClient;
        private MetroFramework.Controls.MetroTile TileProject;
        private MetroFramework.Controls.MetroTile TileInspection;
        private FontAwesome.Sharp.IconButton BtnExit;
    }
}