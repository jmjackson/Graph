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
            this.BunifuPrincipal = new ns1.BunifuElipse(this.components);
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.LabelName = new ns1.BunifuCustomLabel();
            this.TxtUserName = new ns1.BunifuMaterialTextbox();
            this.TxtPassword = new ns1.BunifuMaterialTextbox();
            this.BtnSignIn = new ns1.BunifuFlatButton();
            this.BtnClose = new ns1.BunifuImageButton();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DCMove = new ns1.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BunifuPrincipal
            // 
            this.BunifuPrincipal.ElipseRadius = 5;
            this.BunifuPrincipal.TargetControl = this;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuPanel.BackgroundImage")));
            this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuPanel.Location = new System.Drawing.Point(2, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(463, 580);
            this.MenuPanel.TabIndex = 0;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Calibri", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelName.Location = new System.Drawing.Point(649, 79);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(219, 32);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Welcome To Graph";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtUserName.ForeColor = System.Drawing.Color.White;
            this.TxtUserName.HintForeColor = System.Drawing.Color.Empty;
            this.TxtUserName.HintText = "";
            this.TxtUserName.isPassword = false;
            this.TxtUserName.LineFocusedColor = System.Drawing.Color.AliceBlue;
            this.TxtUserName.LineIdleColor = System.Drawing.Color.White;
            this.TxtUserName.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.TxtUserName.LineThickness = 2;
            this.TxtUserName.Location = new System.Drawing.Point(637, 269);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(256, 44);
            this.TxtUserName.TabIndex = 2;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtPassword.ForeColor = System.Drawing.Color.White;
            this.TxtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPassword.HintText = "";
            this.TxtPassword.isPassword = false;
            this.TxtPassword.LineFocusedColor = System.Drawing.Color.AliceBlue;
            this.TxtPassword.LineIdleColor = System.Drawing.Color.White;
            this.TxtPassword.LineMouseHoverColor = System.Drawing.Color.AliceBlue;
            this.TxtPassword.LineThickness = 2;
            this.TxtPassword.Location = new System.Drawing.Point(637, 321);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(256, 44);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSignIn.BackColor = System.Drawing.Color.SlateGray;
            this.BtnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSignIn.BorderRadius = 0;
            this.BtnSignIn.ButtonText = "Sing In ";
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
            this.BtnSignIn.Location = new System.Drawing.Point(780, 401);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Normalcolor = System.Drawing.Color.SlateGray;
            this.BtnSignIn.OnHovercolor = System.Drawing.Color.LightSlateGray;
            this.BtnSignIn.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSignIn.selected = false;
            this.BtnSignIn.Size = new System.Drawing.Size(113, 38);
            this.BtnSignIn.TabIndex = 3;
            this.BtnSignIn.Text = "Sing In ";
            this.BtnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSignIn.Textcolor = System.Drawing.Color.White;
            this.BtnSignIn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(901, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(25, 26);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 4;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PictureLogo
            // 
            this.PictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogo.Image")));
            this.PictureLogo.Location = new System.Drawing.Point(698, 134);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(112, 111);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLogo.TabIndex = 5;
            this.PictureLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(606, 289);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(606, 341);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // DCMove
            // 
            this.DCMove.Fixed = true;
            this.DCMove.Horizontal = true;
            this.DCMove.TargetControl = this;
            this.DCMove.Vertical = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(932, 578);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PictureLogo);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse BunifuPrincipal;
        private System.Windows.Forms.Panel MenuPanel;
        private ns1.BunifuCustomLabel LabelName;
        private ns1.BunifuFlatButton BtnSignIn;
        private ns1.BunifuMaterialTextbox TxtPassword;
        private ns1.BunifuMaterialTextbox TxtUserName;
        private ns1.BunifuImageButton BtnClose;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ns1.BunifuDragControl DCMove;
    }
}

