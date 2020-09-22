namespace Grap.Principal.Views
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.BtnClose = new ns1.BunifuImageButton();
            this.LblRegister = new ns1.BunifuCustomLabel();
            this.LblImg = new ns1.BunifuCustomLabel();
            this.LblName = new ns1.BunifuCustomLabel();
            this.LblCodigo = new ns1.BunifuCustomLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CardCliente = new ns1.BunifuCards();
            this.BtnRegistrar = new ns1.BunifuFlatButton();
            this.BtnImage = new FontAwesome.Sharp.IconButton();
            this.TxtImage = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.CardCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageActive")));
            this.BtnClose.Location = new System.Drawing.Point(681, 7);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(16, 16);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 15;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // LblRegister
            // 
            this.LblRegister.AutoSize = true;
            this.LblRegister.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegister.Location = new System.Drawing.Point(42, 18);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(186, 30);
            this.LblRegister.TabIndex = 8;
            this.LblRegister.Text = "Registro de Cliente";
            // 
            // LblImg
            // 
            this.LblImg.AutoSize = true;
            this.LblImg.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImg.Location = new System.Drawing.Point(66, 145);
            this.LblImg.Name = "LblImg";
            this.LblImg.Size = new System.Drawing.Size(52, 21);
            this.LblImg.TabIndex = 11;
            this.LblImg.Text = "Image";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(293, 96);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(51, 21);
            this.LblName.TabIndex = 6;
            this.LblName.Text = "Name";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(66, 97);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(46, 21);
            this.LblCodigo.TabIndex = 4;
            this.LblCodigo.Text = "Code";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CardCliente
            // 
            this.CardCliente.BackColor = System.Drawing.Color.White;
            this.CardCliente.BorderRadius = 5;
            this.CardCliente.BottomSahddow = true;
            this.CardCliente.color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.CardCliente.Controls.Add(this.BtnRegistrar);
            this.CardCliente.Controls.Add(this.BtnImage);
            this.CardCliente.Controls.Add(this.TxtImage);
            this.CardCliente.Controls.Add(this.TxtName);
            this.CardCliente.Controls.Add(this.TxtCode);
            this.CardCliente.Controls.Add(this.LblRegister);
            this.CardCliente.Controls.Add(this.BtnClose);
            this.CardCliente.Controls.Add(this.LblImg);
            this.CardCliente.Controls.Add(this.LblName);
            this.CardCliente.Controls.Add(this.LblCodigo);
            this.CardCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardCliente.LeftSahddow = false;
            this.CardCliente.Location = new System.Drawing.Point(0, 0);
            this.CardCliente.Name = "CardCliente";
            this.CardCliente.RightSahddow = true;
            this.CardCliente.ShadowDepth = 20;
            this.CardCliente.Size = new System.Drawing.Size(705, 290);
            this.CardCliente.TabIndex = 8;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(90)))));
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrar.BorderRadius = 0;
            this.BtnRegistrar.ButtonText = "Guardar";
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnRegistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrar.Iconimage")));
            this.BtnRegistrar.Iconimage_right = null;
            this.BtnRegistrar.Iconimage_right_Selected = null;
            this.BtnRegistrar.Iconimage_Selected = null;
            this.BtnRegistrar.IconMarginLeft = 0;
            this.BtnRegistrar.IconMarginRight = 0;
            this.BtnRegistrar.IconRightVisible = true;
            this.BtnRegistrar.IconRightZoom = 0D;
            this.BtnRegistrar.IconVisible = true;
            this.BtnRegistrar.IconZoom = 90D;
            this.BtnRegistrar.IsTab = false;
            this.BtnRegistrar.Location = new System.Drawing.Point(530, 220);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnRegistrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(90)))));
            this.BtnRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnRegistrar.selected = false;
            this.BtnRegistrar.Size = new System.Drawing.Size(110, 30);
            this.BtnRegistrar.TabIndex = 20;
            this.BtnRegistrar.Text = "Guardar";
            this.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.Textcolor = System.Drawing.Color.White;
            this.BtnRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnImage
            // 
            this.BtnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnImage.ForeColor = System.Drawing.Color.White;
            this.BtnImage.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnImage.IconColor = System.Drawing.Color.White;
            this.BtnImage.IconSize = 16;
            this.BtnImage.Location = new System.Drawing.Point(542, 147);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Rotation = 0D;
            this.BtnImage.Size = new System.Drawing.Size(98, 24);
            this.BtnImage.TabIndex = 19;
            this.BtnImage.Text = "Examinar";
            this.BtnImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImage.UseVisualStyleBackColor = false;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // TxtImage
            // 
            this.TxtImage.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtImage.Location = new System.Drawing.Point(132, 151);
            this.TxtImage.Name = "TxtImage";
            this.TxtImage.Size = new System.Drawing.Size(392, 20);
            this.TxtImage.TabIndex = 18;
            // 
            // TxtName
            // 
            this.TxtName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtName.Location = new System.Drawing.Point(361, 97);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(279, 20);
            this.TxtName.TabIndex = 17;
            // 
            // TxtCode
            // 
            this.TxtCode.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtCode.Location = new System.Drawing.Point(132, 97);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(137, 20);
            this.TxtCode.TabIndex = 16;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 290);
            this.Controls.Add(this.CardCliente);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.CardCliente.ResumeLayout(false);
            this.CardCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.BunifuCustomLabel LblCodigo;
        private ns1.BunifuCustomLabel LblName;
        private ns1.BunifuCustomLabel LblImg;
        private ns1.BunifuCustomLabel LblRegister;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ns1.BunifuImageButton BtnClose;
        private ns1.BunifuCards CardCliente;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtCode;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtImage;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtName;
        private FontAwesome.Sharp.IconButton BtnImage;
        private ns1.BunifuFlatButton BtnRegistrar;
    }
}