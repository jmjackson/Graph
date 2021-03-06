﻿namespace Mine.Views
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
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.TileClient = new ns1.BunifuTileButton();
            this.TileProject = new ns1.BunifuTileButton();
            this.TileInspection = new ns1.BunifuTileButton();
            this.BElipse = new ns1.BunifuElipse(this.components);
            this.PanelHead = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.PanelHead.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(219)))));
            this.PanelLeft.Location = new System.Drawing.Point(0, 306);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(292, 482);
            this.PanelLeft.TabIndex = 0;
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
            this.BtnExit.Location = new System.Drawing.Point(993, 710);
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
            this.TileClient.Location = new System.Drawing.Point(61, 198);
            this.TileClient.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TileClient.Name = "TileClient";
            this.TileClient.Size = new System.Drawing.Size(381, 352);
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
            this.TileProject.Location = new System.Drawing.Point(468, 198);
            this.TileProject.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TileProject.Name = "TileProject";
            this.TileProject.Size = new System.Drawing.Size(381, 352);
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
            this.TileInspection.Location = new System.Drawing.Point(877, 198);
            this.TileInspection.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TileInspection.Name = "TileInspection";
            this.TileInspection.Size = new System.Drawing.Size(381, 352);
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
            // PanelContent
            // 
            this.PanelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContent.BackColor = System.Drawing.Color.White;
            this.PanelContent.Controls.Add(this.TileProject);
            this.PanelContent.Controls.Add(this.TileClient);
            this.PanelContent.Controls.Add(this.BtnExit);
            this.PanelContent.Controls.Add(this.TileInspection);
            this.PanelContent.Location = new System.Drawing.Point(282, 0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1105, 788);
            this.PanelContent.TabIndex = 9;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelHead);
            this.Controls.Add(this.PanelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.PanelHead.ResumeLayout(false);
            this.PanelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.PictureBox PbLogo;
        private FontAwesome.Sharp.IconButton BtnExit;
        private ns1.BunifuTileButton TileClient;
        private ns1.BunifuTileButton TileProject;
        private ns1.BunifuTileButton TileInspection;
        private ns1.BunifuElipse BElipse;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Panel PanelContent;
    }
}