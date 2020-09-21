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
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClose = new ns1.BunifuImageButton();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.BtnRegistrar = new ns1.BunifuThinButton2();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.TxtImage = new ns1.BunifuMetroTextbox();
            this.TxtFecha = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.TxtName = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.TxtCode = new ns1.BunifuMetroTextbox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.BtnClose);
            this.panel3.Controls.Add(this.bunifuCustomLabel5);
            this.panel3.Controls.Add(this.BtnRegistrar);
            this.panel3.Controls.Add(this.bunifuImageButton1);
            this.panel3.Controls.Add(this.bunifuCustomLabel4);
            this.panel3.Controls.Add(this.TxtImage);
            this.panel3.Controls.Add(this.TxtFecha);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.TxtName);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.TxtCode);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(88, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 414);
            this.panel3.TabIndex = 7;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageActive")));
            this.BtnClose.Location = new System.Drawing.Point(627, 14);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(16, 16);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 15;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(100, 36);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(179, 26);
            this.bunifuCustomLabel5.TabIndex = 8;
            this.bunifuCustomLabel5.Text = "Resgistro de Cliente";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.ActiveBorderThickness = 1;
            this.BtnRegistrar.ActiveCornerRadius = 20;
            this.BtnRegistrar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BtnRegistrar.ActiveForecolor = System.Drawing.Color.White;
            this.BtnRegistrar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BtnRegistrar.BackColor = System.Drawing.Color.White;
            this.BtnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrar.BackgroundImage")));
            this.BtnRegistrar.ButtonText = "Registrar";
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnRegistrar.IdleBorderThickness = 1;
            this.BtnRegistrar.IdleCornerRadius = 20;
            this.BtnRegistrar.IdleFillColor = System.Drawing.Color.White;
            this.BtnRegistrar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BtnRegistrar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BtnRegistrar.Location = new System.Drawing.Point(78, 350);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(201, 41);
            this.BtnRegistrar.TabIndex = 13;
            this.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(220, 275);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(59, 46);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 12;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(13, 253);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(46, 18);
            this.bunifuCustomLabel4.TabIndex = 11;
            this.bunifuCustomLabel4.Text = "Image";
            // 
            // TxtImage
            // 
            this.TxtImage.BackColor = System.Drawing.Color.White;
            this.TxtImage.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtImage.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TxtImage.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtImage.BorderThickness = 3;
            this.TxtImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtImage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtImage.isPassword = false;
            this.TxtImage.Location = new System.Drawing.Point(16, 275);
            this.TxtImage.Margin = new System.Windows.Forms.Padding(4);
            this.TxtImage.Name = "TxtImage";
            this.TxtImage.Size = new System.Drawing.Size(197, 46);
            this.TxtImage.TabIndex = 10;
            this.TxtImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtFecha
            // 
            this.TxtFecha.BackColor = System.Drawing.Color.White;
            this.TxtFecha.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtFecha.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TxtFecha.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtFecha.BorderThickness = 3;
            this.TxtFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtFecha.isPassword = false;
            this.TxtFecha.Location = new System.Drawing.Point(220, 102);
            this.TxtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(133, 46);
            this.TxtFecha.TabIndex = 9;
            this.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(217, 80);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(45, 18);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Fecha";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(13, 169);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(44, 18);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.White;
            this.TxtName.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TxtName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtName.BorderThickness = 3;
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtName.isPassword = false;
            this.TxtName.Location = new System.Drawing.Point(16, 191);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(337, 44);
            this.TxtName.TabIndex = 5;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(13, 80);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(40, 18);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Code";
            // 
            // TxtCode
            // 
            this.TxtCode.BackColor = System.Drawing.Color.White;
            this.TxtCode.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtCode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TxtCode.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtCode.BorderThickness = 3;
            this.TxtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCode.isPassword = false;
            this.TxtCode.Location = new System.Drawing.Point(16, 102);
            this.TxtCode.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(133, 46);
            this.TxtCode.TabIndex = 0;
            this.TxtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 490);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuMetroTextbox TxtCode;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuMetroTextbox TxtName;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuMetroTextbox TxtImage;
        private ns1.BunifuMetroTextbox TxtFecha;
        private ns1.BunifuThinButton2 BtnRegistrar;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ns1.BunifuImageButton BtnClose;
    }
}