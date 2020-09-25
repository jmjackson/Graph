namespace Grap.Principal.Views.Modal
{
    partial class ModalEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalEditar));
            this.BtnEditar = new ns1.BunifuFlatButton();
            this.BtnImage = new FontAwesome.Sharp.IconButton();
            this.TxtImage = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.LblRegister = new ns1.BunifuCustomLabel();
            this.BtnClose = new ns1.BunifuImageButton();
            this.LblImg = new ns1.BunifuCustomLabel();
            this.LblName = new ns1.BunifuCustomLabel();
            this.LblCodigo = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditar
            // 
            this.BtnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(90)))));
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.BorderRadius = 0;
            this.BtnEditar.ButtonText = "Guardar";
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Iconimage")));
            this.BtnEditar.Iconimage_right = null;
            this.BtnEditar.Iconimage_right_Selected = null;
            this.BtnEditar.Iconimage_Selected = null;
            this.BtnEditar.IconMarginLeft = 0;
            this.BtnEditar.IconMarginRight = 0;
            this.BtnEditar.IconRightVisible = true;
            this.BtnEditar.IconRightZoom = 0D;
            this.BtnEditar.IconVisible = true;
            this.BtnEditar.IconZoom = 90D;
            this.BtnEditar.IsTab = false;
            this.BtnEditar.Location = new System.Drawing.Point(505, 224);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(90)))));
            this.BtnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditar.selected = false;
            this.BtnEditar.Size = new System.Drawing.Size(110, 30);
            this.BtnEditar.TabIndex = 30;
            this.BtnEditar.Text = "Guardar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Textcolor = System.Drawing.Color.White;
            this.BtnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
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
            this.BtnImage.Location = new System.Drawing.Point(517, 151);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Rotation = 0D;
            this.BtnImage.Size = new System.Drawing.Size(98, 24);
            this.BtnImage.TabIndex = 29;
            this.BtnImage.Text = "Examinar";
            this.BtnImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImage.UseVisualStyleBackColor = false;
            // 
            // TxtImage
            // 
            this.TxtImage.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtImage.Location = new System.Drawing.Point(107, 155);
            this.TxtImage.Name = "TxtImage";
            this.TxtImage.Size = new System.Drawing.Size(392, 20);
            this.TxtImage.TabIndex = 28;
            // 
            // TxtName
            // 
            this.TxtName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtName.Location = new System.Drawing.Point(336, 101);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(279, 20);
            this.TxtName.TabIndex = 27;
            // 
            // TxtCode
            // 
            this.TxtCode.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtCode.Location = new System.Drawing.Point(107, 101);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(137, 20);
            this.TxtCode.TabIndex = 26;
            // 
            // LblRegister
            // 
            this.LblRegister.AutoSize = true;
            this.LblRegister.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegister.Location = new System.Drawing.Point(17, 22);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(186, 30);
            this.LblRegister.TabIndex = 23;
            this.LblRegister.Text = "Registro de Cliente";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageActive")));
            this.BtnClose.Location = new System.Drawing.Point(656, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(16, 16);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 25;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            // 
            // LblImg
            // 
            this.LblImg.AutoSize = true;
            this.LblImg.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImg.Location = new System.Drawing.Point(41, 149);
            this.LblImg.Name = "LblImg";
            this.LblImg.Size = new System.Drawing.Size(52, 21);
            this.LblImg.TabIndex = 24;
            this.LblImg.Text = "Image";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(268, 100);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(51, 21);
            this.LblName.TabIndex = 22;
            this.LblName.Text = "Name";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(41, 101);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(46, 21);
            this.LblCodigo.TabIndex = 21;
            this.LblCodigo.Text = "Code";
            // 
            // ModalEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 279);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnImage);
            this.Controls.Add(this.TxtImage);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.LblRegister);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblImg);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblCodigo);
            this.Name = "ModalEditar";
            this.Text = "ModalEditar";
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuFlatButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnImage;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtImage;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtCode;
        private ns1.BunifuCustomLabel LblRegister;
        private ns1.BunifuImageButton BtnClose;
        private ns1.BunifuCustomLabel LblImg;
        private ns1.BunifuCustomLabel LblName;
        private ns1.BunifuCustomLabel LblCodigo;
    }
}