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
            this.BtnSingIn = new ns1.BunifuThinButton2();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.BtnClose = new ns1.BunifuImageButton();
            this.LblError = new ns1.BunifuCustomLabel();
            this.TxtUser = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDock
            // 
            this.PanelDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PanelDock.Controls.Add(this.pictureBox1);
            this.PanelDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelDock.Location = new System.Drawing.Point(0, 0);
            this.PanelDock.Name = "PanelDock";
            this.PanelDock.Size = new System.Drawing.Size(352, 401);
            this.PanelDock.TabIndex = 0;
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
            this.BtnSingIn.TabIndex = 3;
            this.BtnSingIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSingIn.Click += new System.EventHandler(this.BtnSingIn_Click);
            this.BtnSingIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnSingIn_KeyPress);
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
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(482, 130);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 14);
            this.LblError.TabIndex = 6;
            // 
            // TxtUser
            // 
            this.TxtUser.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtUser.Location = new System.Drawing.Point(462, 158);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(196, 20);
            this.TxtUser.TabIndex = 7;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPassword.Location = new System.Drawing.Point(462, 210);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(196, 20);
            this.TxtPassword.TabIndex = 7;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 401);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.BtnSingIn);
            this.Controls.Add(this.PanelDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.PanelDock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDock;
        private ns1.BunifuThinButton2 BtnSingIn;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuImageButton BtnClose;
        private ns1.BunifuCustomLabel LblError;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtUser;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

