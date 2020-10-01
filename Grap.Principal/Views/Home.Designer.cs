namespace Grap.Principal.Views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.BtnOut = new FontAwesome.Sharp.IconButton();
            this.LblWelcome = new ns1.BunifuCustomLabel();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnOther = new FontAwesome.Sharp.IconButton();
            this.BtnConfig = new FontAwesome.Sharp.IconButton();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BtnMaximize = new ns1.BunifuImageButton();
            this.BtnMinimize = new ns1.BunifuImageButton();
            this.ButtonClose = new ns1.BunifuImageButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.bunifuTileButton4 = new ns1.BunifuTileButton();
            this.bunifuTileButton2 = new ns1.BunifuTileButton();
            this.BtnDeploy = new ns1.BunifuTileButton();
            this.DragControl = new ns1.BunifuDragControl(this.components);
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(142)))));
            this.PanelLeft.Controls.Add(this.BtnOut);
            this.PanelLeft.Controls.Add(this.LblWelcome);
            this.PanelLeft.Controls.Add(this.PbLogo);
            this.PanelLeft.Controls.Add(this.BtnOther);
            this.PanelLeft.Controls.Add(this.BtnConfig);
            this.PanelLeft.Controls.Add(this.BtnClientes);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(199, 527);
            this.PanelLeft.TabIndex = 0;
            // 
            // BtnOut
            // 
            this.BtnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(142)))));
            this.BtnOut.FlatAppearance.BorderSize = 0;
            this.BtnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOut.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnOut.IconColor = System.Drawing.Color.White;
            this.BtnOut.IconSize = 18;
            this.BtnOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOut.Location = new System.Drawing.Point(-3, 321);
            this.BtnOut.Name = "BtnOut";
            this.BtnOut.Rotation = 0D;
            this.BtnOut.Size = new System.Drawing.Size(196, 35);
            this.BtnOut.TabIndex = 3;
            this.BtnOut.Text = "Cerrar Sesión";
            this.BtnOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOut.UseVisualStyleBackColor = false;
            this.BtnOut.Click += new System.EventHandler(this.BtnOut_Click);
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.ForeColor = System.Drawing.Color.White;
            this.LblWelcome.Location = new System.Drawing.Point(43, 134);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(87, 21);
            this.LblWelcome.TabIndex = 2;
            this.LblWelcome.Text = "Bienvenido";
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(47, 37);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(77, 94);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogo.TabIndex = 1;
            this.PbLogo.TabStop = false;
            // 
            // BtnOther
            // 
            this.BtnOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(142)))));
            this.BtnOther.FlatAppearance.BorderSize = 0;
            this.BtnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOther.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOther.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOther.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.BtnOther.IconColor = System.Drawing.Color.White;
            this.BtnOther.IconSize = 18;
            this.BtnOther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther.Location = new System.Drawing.Point(0, 280);
            this.BtnOther.Name = "BtnOther";
            this.BtnOther.Rotation = 0D;
            this.BtnOther.Size = new System.Drawing.Size(196, 35);
            this.BtnOther.TabIndex = 0;
            this.BtnOther.Text = "Otros";
            this.BtnOther.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOther.UseVisualStyleBackColor = false;
            this.BtnOther.Click += new System.EventHandler(this.BtnOther_Click);
            // 
            // BtnConfig
            // 
            this.BtnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(142)))));
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConfig.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.BtnConfig.IconColor = System.Drawing.Color.White;
            this.BtnConfig.IconSize = 18;
            this.BtnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfig.Location = new System.Drawing.Point(0, 239);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Rotation = 0D;
            this.BtnConfig.Size = new System.Drawing.Size(196, 35);
            this.BtnConfig.TabIndex = 0;
            this.BtnConfig.Text = "Configuración";
            this.BtnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfig.UseVisualStyleBackColor = false;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(142)))));
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnClientes.IconColor = System.Drawing.Color.White;
            this.BtnClientes.IconSize = 18;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 198);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Rotation = 0D;
            this.BtnClientes.Size = new System.Drawing.Size(196, 35);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(142)))));
            this.PanelHeader.Controls.Add(this.BtnMaximize);
            this.PanelHeader.Controls.Add(this.BtnMinimize);
            this.PanelHeader.Controls.Add(this.ButtonClose);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(199, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(776, 37);
            this.PanelHeader.TabIndex = 1;
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(158)))));
            this.BtnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximize.Image")));
            this.BtnMaximize.ImageActive = null;
            this.BtnMaximize.Location = new System.Drawing.Point(719, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(24, 24);
            this.BtnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMaximize.TabIndex = 3;
            this.BtnMaximize.TabStop = false;
            this.BtnMaximize.Zoom = 10;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(158)))));
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.ImageActive = null;
            this.BtnMinimize.Location = new System.Drawing.Point(691, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(24, 24);
            this.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMinimize.TabIndex = 2;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.Zoom = 10;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(158)))));
            this.ButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("ButtonClose.Image")));
            this.ButtonClose.ImageActive = null;
            this.ButtonClose.Location = new System.Drawing.Point(749, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(24, 24);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Zoom = 10;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.bunifuTileButton4);
            this.panelContenedor.Controls.Add(this.bunifuTileButton2);
            this.panelContenedor.Controls.Add(this.BtnDeploy);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(199, 37);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(776, 490);
            this.panelContenedor.TabIndex = 2;
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(142)))));
            this.bunifuTileButton4.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(142)))));
            this.bunifuTileButton4.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 20;
            this.bunifuTileButton4.ImageZoom = 40;
            this.bunifuTileButton4.LabelPosition = 51;
            this.bunifuTileButton4.LabelText = "Geomembrane";
            this.bunifuTileButton4.Location = new System.Drawing.Point(201, 28);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(135, 118);
            this.bunifuTileButton4.TabIndex = 0;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(142)))));
            this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(142)))));
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 40;
            this.bunifuTileButton2.LabelPosition = 51;
            this.bunifuTileButton2.LabelText = "Clients";
            this.bunifuTileButton2.Location = new System.Drawing.Point(348, 28);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(135, 118);
            this.bunifuTileButton2.TabIndex = 0;
            // 
            // BtnDeploy
            // 
            this.BtnDeploy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(142)))));
            this.BtnDeploy.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(142)))));
            this.BtnDeploy.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.BtnDeploy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeploy.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeploy.ForeColor = System.Drawing.Color.White;
            this.BtnDeploy.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeploy.Image")));
            this.BtnDeploy.ImagePosition = 5;
            this.BtnDeploy.ImageZoom = 40;
            this.BtnDeploy.LabelPosition = 40;
            this.BtnDeploy.LabelText = "Deployments";
            this.BtnDeploy.Location = new System.Drawing.Point(54, 28);
            this.BtnDeploy.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnDeploy.Name = "BtnDeploy";
            this.BtnDeploy.Size = new System.Drawing.Size(135, 118);
            this.BtnDeploy.TabIndex = 0;
            this.BtnDeploy.Click += new System.EventHandler(this.BtnDeploy_Click);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.PanelHeader;
            this.DragControl.Vertical = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 527);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.PanelLeft.ResumeLayout(false);
            this.PanelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelHeader;
        private FontAwesome.Sharp.IconButton BtnOther;
        private FontAwesome.Sharp.IconButton BtnConfig;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox PbLogo;
        private ns1.BunifuCustomLabel LblWelcome;
        private FontAwesome.Sharp.IconButton BtnOut;
        private ns1.BunifuTileButton bunifuTileButton4;
        private ns1.BunifuTileButton bunifuTileButton2;
        private ns1.BunifuTileButton BtnDeploy;
        private ns1.BunifuImageButton ButtonClose;
        private ns1.BunifuImageButton BtnMaximize;
        private ns1.BunifuImageButton BtnMinimize;
        private ns1.BunifuDragControl DragControl;
    }
}