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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.BElipse = new ns1.BunifuElipse(this.components);
            this.DragControl = new ns1.BunifuDragControl(this.components);
            this.BCard = new ns1.BunifuCards();
            this.LblError = new ns1.BunifuCustomLabel();
            this.PbUser = new FontAwesome.Sharp.IconPictureBox();
            this.PbPassword = new FontAwesome.Sharp.IconPictureBox();
            this.LblTitle = new ns1.BunifuCustomLabel();
            this.BtnSignIn = new ns1.BunifuFlatButton();
            this.TxtPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtUser = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.PLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new ns1.BunifuImageButton();
            this.BCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPassword)).BeginInit();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // BElipse
            // 
            this.BElipse.ElipseRadius = 5;
            this.BElipse.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.BCard;
            this.DragControl.Vertical = true;
            // 
            // BCard
            // 
            this.BCard.BackColor = System.Drawing.Color.White;
            this.BCard.BorderRadius = 5;
            this.BCard.BottomSahddow = true;
            this.BCard.color = System.Drawing.Color.MidnightBlue;
            this.BCard.Controls.Add(this.LblError);
            this.BCard.Controls.Add(this.PbUser);
            this.BCard.Controls.Add(this.PbPassword);
            this.BCard.Controls.Add(this.LblTitle);
            this.BCard.Controls.Add(this.BtnSignIn);
            this.BCard.Controls.Add(this.TxtPassword);
            this.BCard.Controls.Add(this.TxtUser);
            this.BCard.Controls.Add(this.PLogo);
            this.BCard.Controls.Add(this.BtnClose);
            this.BCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BCard.LeftSahddow = false;
            this.BCard.Location = new System.Drawing.Point(0, 0);
            this.BCard.Name = "BCard";
            this.BCard.RightSahddow = true;
            this.BCard.ShadowDepth = 20;
            this.BCard.Size = new System.Drawing.Size(700, 401);
            this.BCard.TabIndex = 0;
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(456, 136);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 7;
            // 
            // PbUser
            // 
            this.PbUser.BackColor = System.Drawing.Color.White;
            this.PbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.PbUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.PbUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.PbUser.IconSize = 20;
            this.PbUser.Location = new System.Drawing.Point(423, 198);
            this.PbUser.Name = "PbUser";
            this.PbUser.Size = new System.Drawing.Size(20, 20);
            this.PbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbUser.TabIndex = 6;
            this.PbUser.TabStop = false;
            // 
            // PbPassword
            // 
            this.PbPassword.BackColor = System.Drawing.Color.White;
            this.PbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.PbPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.PbPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.PbPassword.IconSize = 20;
            this.PbPassword.Location = new System.Drawing.Point(423, 224);
            this.PbPassword.Name = "PbPassword";
            this.PbPassword.Size = new System.Drawing.Size(20, 20);
            this.PbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbPassword.TabIndex = 6;
            this.PbPassword.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.LblTitle.Location = new System.Drawing.Point(481, 63);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(148, 32);
            this.LblTitle.TabIndex = 5;
            this.LblTitle.Text = "Iniciar Sesión";
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(25)))), ((int)(((byte)(98)))));
            this.BtnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSignIn.BorderRadius = 0;
            this.BtnSignIn.ButtonText = "Aceptar";
            this.BtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignIn.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSignIn.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSignIn.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSignIn.Iconimage")));
            this.BtnSignIn.Iconimage_right = null;
            this.BtnSignIn.Iconimage_right_Selected = null;
            this.BtnSignIn.Iconimage_Selected = null;
            this.BtnSignIn.IconMarginLeft = 0;
            this.BtnSignIn.IconMarginRight = 0;
            this.BtnSignIn.IconRightVisible = true;
            this.BtnSignIn.IconRightZoom = 0D;
            this.BtnSignIn.IconVisible = true;
            this.BtnSignIn.IconZoom = 90D;
            this.BtnSignIn.IsTab = false;
            this.BtnSignIn.Location = new System.Drawing.Point(555, 262);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnSignIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnSignIn.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSignIn.selected = false;
            this.BtnSignIn.Size = new System.Drawing.Size(106, 36);
            this.BtnSignIn.TabIndex = 2;
            this.BtnSignIn.Text = "Aceptar";
            this.BtnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSignIn.Textcolor = System.Drawing.Color.White;
            this.BtnSignIn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            this.BtnSignIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnSignIn_KeyPress);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.TxtPassword.Location = new System.Drawing.Point(459, 224);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(202, 20);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtUser
            // 
            this.TxtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.TxtUser.Location = new System.Drawing.Point(459, 198);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(202, 20);
            this.TxtUser.TabIndex = 0;
            // 
            // PLogo
            // 
            this.PLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.PLogo.Controls.Add(this.pictureBox1);
            this.PLogo.Location = new System.Drawing.Point(0, 3);
            this.PLogo.Name = "PLogo";
            this.PLogo.Size = new System.Drawing.Size(350, 398);
            this.PLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageActive")));
            this.BtnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.InitialImage")));
            this.BtnClose.Location = new System.Drawing.Point(673, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(20, 20);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 1;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 401);
            this.Controls.Add(this.BCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.BCard.ResumeLayout(false);
            this.BCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPassword)).EndInit();
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse BElipse;
        private ns1.BunifuDragControl DragControl;
        private ns1.BunifuCards BCard;
        private ns1.BunifuImageButton BtnClose;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtPassword;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtUser;
        private ns1.BunifuFlatButton BtnSignIn;
        private ns1.BunifuCustomLabel LblTitle;
        private FontAwesome.Sharp.IconPictureBox PbUser;
        private FontAwesome.Sharp.IconPictureBox PbPassword;
        private ns1.BunifuCustomLabel LblError;
    }
}

