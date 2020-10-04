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
            this.LblTitle = new MetroFramework.Controls.MetroLabel();
            this.TileClient = new MetroFramework.Controls.MetroTile();
            this.TileProject = new MetroFramework.Controls.MetroTile();
            this.TileDevelopment = new MetroFramework.Controls.MetroTile();
            this.TileGeomembrane = new MetroFramework.Controls.MetroTile();
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(46)))), ((int)(((byte)(153)))));
            this.PanelLeft.Controls.Add(this.pictureBox1);
            this.PanelLeft.Controls.Add(this.BtnLogout);
            this.PanelLeft.Controls.Add(this.BtnOther);
            this.PanelLeft.Controls.Add(this.BtnConfig);
            this.PanelLeft.Controls.Add(this.BtnClient);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(20, 60);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(204, 440);
            this.PanelLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnLogout.IconColor = System.Drawing.Color.White;
            this.BtnLogout.IconSize = 20;
            this.BtnLogout.Location = new System.Drawing.Point(0, 341);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Rotation = 0D;
            this.BtnLogout.Size = new System.Drawing.Size(204, 41);
            this.BtnLogout.TabIndex = 1;
            this.BtnLogout.Text = "Log Out";
            this.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogout.UseVisualStyleBackColor = false;
            // 
            // BtnOther
            // 
            this.BtnOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.BtnOther.FlatAppearance.BorderSize = 0;
            this.BtnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOther.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOther.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOther.ForeColor = System.Drawing.Color.White;
            this.BtnOther.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.BtnOther.IconColor = System.Drawing.Color.White;
            this.BtnOther.IconSize = 20;
            this.BtnOther.Location = new System.Drawing.Point(0, 294);
            this.BtnOther.Name = "BtnOther";
            this.BtnOther.Rotation = 0D;
            this.BtnOther.Size = new System.Drawing.Size(204, 41);
            this.BtnOther.TabIndex = 1;
            this.BtnOther.Text = "Other";
            this.BtnOther.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOther.UseVisualStyleBackColor = false;
            // 
            // BtnConfig
            // 
            this.BtnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnConfig.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfig.ForeColor = System.Drawing.Color.White;
            this.BtnConfig.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.BtnConfig.IconColor = System.Drawing.Color.White;
            this.BtnConfig.IconSize = 20;
            this.BtnConfig.Location = new System.Drawing.Point(0, 247);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Rotation = 0D;
            this.BtnConfig.Size = new System.Drawing.Size(204, 41);
            this.BtnConfig.TabIndex = 1;
            this.BtnConfig.Text = "Configuration";
            this.BtnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfig.UseVisualStyleBackColor = false;
            // 
            // BtnClient
            // 
            this.BtnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.BtnClient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnClient.FlatAppearance.BorderSize = 0;
            this.BtnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClient.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClient.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClient.ForeColor = System.Drawing.Color.White;
            this.BtnClient.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnClient.IconColor = System.Drawing.Color.White;
            this.BtnClient.IconSize = 20;
            this.BtnClient.Location = new System.Drawing.Point(-3, 200);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Rotation = 0D;
            this.BtnClient.Size = new System.Drawing.Size(204, 41);
            this.BtnClient.TabIndex = 1;
            this.BtnClient.Text = "Clients";
            this.BtnClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClient.UseVisualStyleBackColor = false;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(211, 17);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(73, 19);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Dashboard";
            // 
            // TileClient
            // 
            this.TileClient.ActiveControl = null;
            this.TileClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(68)))), ((int)(((byte)(98)))));
            this.TileClient.ForeColor = System.Drawing.Color.White;
            this.TileClient.Location = new System.Drawing.Point(235, 63);
            this.TileClient.Name = "TileClient";
            this.TileClient.Size = new System.Drawing.Size(116, 125);
            this.TileClient.Style = MetroFramework.MetroColorStyle.Purple;
            this.TileClient.TabIndex = 2;
            this.TileClient.Text = "Clients";
            this.TileClient.TileImage = ((System.Drawing.Image)(resources.GetObject("TileClient.TileImage")));
            this.TileClient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileClient.UseSelectable = true;
            this.TileClient.UseStyleColors = true;
            this.TileClient.UseTileImage = true;
            this.TileClient.Click += new System.EventHandler(this.TileClient_Click);
            // 
            // TileProject
            // 
            this.TileProject.ActiveControl = null;
            this.TileProject.Location = new System.Drawing.Point(370, 63);
            this.TileProject.Name = "TileProject";
            this.TileProject.Size = new System.Drawing.Size(116, 125);
            this.TileProject.Style = MetroFramework.MetroColorStyle.Purple;
            this.TileProject.TabIndex = 2;
            this.TileProject.Text = "Project";
            this.TileProject.TileImage = ((System.Drawing.Image)(resources.GetObject("TileProject.TileImage")));
            this.TileProject.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileProject.UseSelectable = true;
            this.TileProject.UseTileImage = true;
            this.TileProject.Click += new System.EventHandler(this.TileProject_Click);
            // 
            // TileDevelopment
            // 
            this.TileDevelopment.ActiveControl = null;
            this.TileDevelopment.Location = new System.Drawing.Point(492, 63);
            this.TileDevelopment.Name = "TileDevelopment";
            this.TileDevelopment.Size = new System.Drawing.Size(116, 125);
            this.TileDevelopment.Style = MetroFramework.MetroColorStyle.Purple;
            this.TileDevelopment.TabIndex = 2;
            this.TileDevelopment.Text = "Development";
            this.TileDevelopment.TileImage = ((System.Drawing.Image)(resources.GetObject("TileDevelopment.TileImage")));
            this.TileDevelopment.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileDevelopment.UseSelectable = true;
            this.TileDevelopment.UseTileImage = true;
            // 
            // TileGeomembrane
            // 
            this.TileGeomembrane.ActiveControl = null;
            this.TileGeomembrane.Location = new System.Drawing.Point(614, 63);
            this.TileGeomembrane.Name = "TileGeomembrane";
            this.TileGeomembrane.Size = new System.Drawing.Size(116, 125);
            this.TileGeomembrane.Style = MetroFramework.MetroColorStyle.Purple;
            this.TileGeomembrane.TabIndex = 2;
            this.TileGeomembrane.Text = "Geomembrane";
            this.TileGeomembrane.TileImage = ((System.Drawing.Image)(resources.GetObject("TileGeomembrane.TileImage")));
            this.TileGeomembrane.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileGeomembrane.UseSelectable = true;
            this.TileGeomembrane.UseTileImage = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 520);
            this.Controls.Add(this.TileGeomembrane);
            this.Controls.Add(this.TileDevelopment);
            this.Controls.Add(this.TileProject);
            this.Controls.Add(this.TileClient);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.PanelLeft);
            this.Name = "Principal";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.PanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private FontAwesome.Sharp.IconButton BtnLogout;
        private FontAwesome.Sharp.IconButton BtnOther;
        private FontAwesome.Sharp.IconButton BtnConfig;
        private FontAwesome.Sharp.IconButton BtnClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel LblTitle;
        private MetroFramework.Controls.MetroTile TileClient;
        private MetroFramework.Controls.MetroTile TileProject;
        private MetroFramework.Controls.MetroTile TileDevelopment;
        private MetroFramework.Controls.MetroTile TileGeomembrane;
    }
}