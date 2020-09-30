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
            this.LblImage = new ns1.BunifuCustomLabel();
            this.PBox = new System.Windows.Forms.PictureBox();
            this.BtnRegistrar = new ns1.BunifuFlatButton();
            this.BtnImage = new FontAwesome.Sharp.IconButton();
            this.TxtName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.LblRegister = new ns1.BunifuCustomLabel();
            this.BtnClose = new ns1.BunifuImageButton();
            this.LblImg = new ns1.BunifuCustomLabel();
            this.LblName = new ns1.BunifuCustomLabel();
            this.LblCodigo = new ns1.BunifuCustomLabel();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // LblImage
            // 
            this.LblImage.AutoSize = true;
            this.LblImage.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImage.Location = new System.Drawing.Point(295, 166);
            this.LblImage.Name = "LblImage";
            this.LblImage.Size = new System.Drawing.Size(110, 21);
            this.LblImage.TabIndex = 34;
            this.LblImage.Text = "Cargar Imagen";
            // 
            // PBox
            // 
            this.PBox.Location = new System.Drawing.Point(133, 120);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(156, 121);
            this.PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBox.TabIndex = 33;
            this.PBox.TabStop = false;
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
            this.BtnRegistrar.Location = new System.Drawing.Point(511, 217);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnRegistrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(90)))));
            this.BtnRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnRegistrar.selected = false;
            this.BtnRegistrar.Size = new System.Drawing.Size(110, 30);
            this.BtnRegistrar.TabIndex = 32;
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
            this.BtnImage.Location = new System.Drawing.Point(299, 139);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Rotation = 0D;
            this.BtnImage.Size = new System.Drawing.Size(98, 24);
            this.BtnImage.TabIndex = 31;
            this.BtnImage.Text = "Examinar";
            this.BtnImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImage.UseVisualStyleBackColor = false;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // TxtName
            // 
            this.TxtName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtName.Location = new System.Drawing.Point(342, 94);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(279, 20);
            this.TxtName.TabIndex = 30;
            // 
            // TxtCode
            // 
            this.TxtCode.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtCode.Location = new System.Drawing.Point(113, 94);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(137, 20);
            this.TxtCode.TabIndex = 29;
            // 
            // LblRegister
            // 
            this.LblRegister.AutoSize = true;
            this.LblRegister.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegister.Location = new System.Drawing.Point(23, 15);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(250, 30);
            this.LblRegister.TabIndex = 26;
            this.LblRegister.Text = "Editar Registro del Cliente";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageActive")));
            this.BtnClose.Location = new System.Drawing.Point(662, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(16, 16);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 28;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            // 
            // LblImg
            // 
            this.LblImg.AutoSize = true;
            this.LblImg.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImg.Location = new System.Drawing.Point(47, 142);
            this.LblImg.Name = "LblImg";
            this.LblImg.Size = new System.Drawing.Size(61, 21);
            this.LblImg.TabIndex = 27;
            this.LblImg.Text = "Imagen";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(274, 93);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(66, 21);
            this.LblName.TabIndex = 25;
            this.LblName.Text = "Nombre";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(47, 94);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(60, 21);
            this.LblCodigo.TabIndex = 24;
            this.LblCodigo.Text = "Codigo";
            // 
            // OFDialog
            // 
            this.OFDialog.FileName = "openFileDialog1";
            // 
            // ModalEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 279);
            this.Controls.Add(this.LblImage);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnImage);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.LblRegister);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblImg);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblCodigo);
            this.Name = "ModalEditar";
            this.Text = "ModalEditar";
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomLabel LblImage;
        private System.Windows.Forms.PictureBox PBox;
        private ns1.BunifuFlatButton BtnRegistrar;
        private FontAwesome.Sharp.IconButton BtnImage;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtCode;
        private ns1.BunifuCustomLabel LblRegister;
        private ns1.BunifuImageButton BtnClose;
        private ns1.BunifuCustomLabel LblImg;
        private ns1.BunifuCustomLabel LblName;
        private ns1.BunifuCustomLabel LblCodigo;
        private System.Windows.Forms.OpenFileDialog OFDialog;
    }
}