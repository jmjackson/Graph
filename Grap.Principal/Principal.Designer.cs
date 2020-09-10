namespace Grap.Principal
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
            this.PanelDock = new System.Windows.Forms.Panel();
            this.TxtUser = new ns1.BunifuMaterialTextbox();
            this.TxtPassword = new ns1.BunifuMaterialTextbox();
            this.BtnSingIn = new ns1.BunifuThinButton2();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.BtnClose = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDock
            // 
            this.PanelDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PanelDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelDock.Location = new System.Drawing.Point(0, 0);
            this.PanelDock.Name = "PanelDock";
            this.PanelDock.Size = new System.Drawing.Size(352, 401);
            this.PanelDock.TabIndex = 0;
            // 
            // TxtUser
            // 
            this.TxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUser.HintForeColor = System.Drawing.Color.Empty;
            this.TxtUser.HintText = "";
            this.TxtUser.isPassword = false;
            this.TxtUser.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.TxtUser.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtUser.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.TxtUser.LineThickness = 2;
            this.TxtUser.Location = new System.Drawing.Point(464, 150);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(205, 30);
            this.TxtUser.TabIndex = 1;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPassword.HintText = "";
            this.TxtPassword.isPassword = true;
            this.TxtPassword.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.TxtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtPassword.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.TxtPassword.LineThickness = 2;
            this.TxtPassword.Location = new System.Drawing.Point(464, 200);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(205, 30);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnSingIn
            // 
            this.BtnSingIn.ActiveBorderThickness = 1;
            this.BtnSingIn.ActiveCornerRadius = 20;
            this.BtnSingIn.ActiveFillColor = System.Drawing.Color.LightSlateGray;
            this.BtnSingIn.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSingIn.ActiveLineColor = System.Drawing.Color.LightSlateGray;
            this.BtnSingIn.BackColor = System.Drawing.Color.White;
            this.BtnSingIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSingIn.BackgroundImage")));
            this.BtnSingIn.ButtonText = "Entrar";
            this.BtnSingIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSingIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSingIn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnSingIn.IdleBorderThickness = 1;
            this.BtnSingIn.IdleCornerRadius = 20;
            this.BtnSingIn.IdleFillColor = System.Drawing.Color.White;
            this.BtnSingIn.IdleForecolor = System.Drawing.Color.LightSlateGray;
            this.BtnSingIn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.BtnSingIn.Location = new System.Drawing.Point(529, 239);
            this.BtnSingIn.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSingIn.Name = "BtnSingIn";
            this.BtnSingIn.Size = new System.Drawing.Size(140, 41);
            this.BtnSingIn.TabIndex = 2;
            this.BtnSingIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSingIn.Click += new System.EventHandler(this.BtnSingIn_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(396, 162);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(55, 18);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Usuario";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(373, 212);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(78, 18);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Contraseña";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(494, 68);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(124, 26);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Iniciar Sesión";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageActive")));
            this.BtnClose.Location = new System.Drawing.Point(676, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(16, 16);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 5;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 401);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.BtnSingIn);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.PanelDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDock;
        private ns1.BunifuMaterialTextbox TxtUser;
        private ns1.BunifuMaterialTextbox TxtPassword;
        private ns1.BunifuThinButton2 BtnSingIn;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuImageButton BtnClose;
    }
}

