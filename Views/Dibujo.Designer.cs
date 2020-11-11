namespace Mine.Views
{
    partial class Dibujo
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GbTools = new System.Windows.Forms.GroupBox();
            this.BtnTriangulo = new System.Windows.Forms.Button();
            this.BtnCirculo = new System.Windows.Forms.Button();
            this.BtnCuadrado = new System.Windows.Forms.Button();
            this.BtnRectangulo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBoxData = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbDraw = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeployButton = new FontAwesome.Sharp.IconButton();
            this.SeamingButton = new FontAwesome.Sharp.IconButton();
            this.PanelHeader.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GbTools.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbDraw)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.label1);
            this.PanelHeader.Controls.Add(this.BtnClose);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1386, 52);
            this.PanelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Draw";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnClose.IconColor = System.Drawing.Color.Red;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnClose.IconSize = 42;
            this.BtnClose.Location = new System.Drawing.Point(1338, 9);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(39, 39);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // PanelLeft
            // 
            this.PanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelLeft.Controls.Add(this.groupBox1);
            this.PanelLeft.Controls.Add(this.GbTools);
            this.PanelLeft.Location = new System.Drawing.Point(0, 52);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(190, 647);
            this.PanelLeft.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(22, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(63, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            // 
            // GbTools
            // 
            this.GbTools.Controls.Add(this.BtnTriangulo);
            this.GbTools.Controls.Add(this.BtnCirculo);
            this.GbTools.Controls.Add(this.BtnCuadrado);
            this.GbTools.Controls.Add(this.BtnRectangulo);
            this.GbTools.Location = new System.Drawing.Point(22, 34);
            this.GbTools.Name = "GbTools";
            this.GbTools.Size = new System.Drawing.Size(145, 325);
            this.GbTools.TabIndex = 0;
            this.GbTools.TabStop = false;
            this.GbTools.Text = "Tools";
            // 
            // BtnTriangulo
            // 
            this.BtnTriangulo.Location = new System.Drawing.Point(33, 232);
            this.BtnTriangulo.Name = "BtnTriangulo";
            this.BtnTriangulo.Size = new System.Drawing.Size(75, 65);
            this.BtnTriangulo.TabIndex = 3;
            this.BtnTriangulo.Text = "button4";
            this.BtnTriangulo.UseVisualStyleBackColor = true;
            this.BtnTriangulo.Click += new System.EventHandler(this.BtnTriangulo_Click);
            // 
            // BtnCirculo
            // 
            this.BtnCirculo.Location = new System.Drawing.Point(33, 161);
            this.BtnCirculo.Name = "BtnCirculo";
            this.BtnCirculo.Size = new System.Drawing.Size(75, 65);
            this.BtnCirculo.TabIndex = 2;
            this.BtnCirculo.Text = "button3";
            this.BtnCirculo.UseVisualStyleBackColor = true;
            this.BtnCirculo.Click += new System.EventHandler(this.BtnCirculo_Click);
            // 
            // BtnCuadrado
            // 
            this.BtnCuadrado.Location = new System.Drawing.Point(33, 90);
            this.BtnCuadrado.Name = "BtnCuadrado";
            this.BtnCuadrado.Size = new System.Drawing.Size(75, 65);
            this.BtnCuadrado.TabIndex = 1;
            this.BtnCuadrado.Text = "button2";
            this.BtnCuadrado.UseVisualStyleBackColor = true;
            this.BtnCuadrado.Click += new System.EventHandler(this.BtnCuadrado_Click);
            // 
            // BtnRectangulo
            // 
            this.BtnRectangulo.Location = new System.Drawing.Point(33, 19);
            this.BtnRectangulo.Name = "BtnRectangulo";
            this.BtnRectangulo.Size = new System.Drawing.Size(75, 65);
            this.BtnRectangulo.TabIndex = 0;
            this.BtnRectangulo.Text = "button1";
            this.BtnRectangulo.UseVisualStyleBackColor = true;
            this.BtnRectangulo.Click += new System.EventHandler(this.BtnRectangulo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ListBoxData);
            this.panel1.Location = new System.Drawing.Point(1186, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 647);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Panel No";
            // 
            // ListBoxData
            // 
            this.ListBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxData.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxData.FormattingEnabled = true;
            this.ListBoxData.ItemHeight = 32;
            this.ListBoxData.Location = new System.Drawing.Point(27, 430);
            this.ListBoxData.Name = "ListBoxData";
            this.ListBoxData.Size = new System.Drawing.Size(161, 196);
            this.ListBoxData.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.PbDraw);
            this.panel2.Location = new System.Drawing.Point(188, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 647);
            this.panel2.TabIndex = 3;
            // 
            // PbDraw
            // 
            this.PbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbDraw.Location = new System.Drawing.Point(0, 0);
            this.PbDraw.Name = "PbDraw";
            this.PbDraw.Size = new System.Drawing.Size(1003, 647);
            this.PbDraw.TabIndex = 0;
            this.PbDraw.TabStop = false;
            this.PbDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbDraw_MouseClick);
            this.PbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDraw_MouseDown);
            this.PbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbDraw_MouseMove);
            this.PbDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDraw_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.DeployButton);
            this.panel3.Controls.Add(this.SeamingButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 699);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1386, 89);
            this.panel3.TabIndex = 4;
            // 
            // DeployButton
            // 
            this.DeployButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.DeployButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeployButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DeployButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeployButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeployButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DeployButton.IconColor = System.Drawing.Color.Black;
            this.DeployButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeployButton.IconSize = 48;
            this.DeployButton.Location = new System.Drawing.Point(230, 19);
            this.DeployButton.Name = "DeployButton";
            this.DeployButton.Rotation = 0D;
            this.DeployButton.Size = new System.Drawing.Size(209, 58);
            this.DeployButton.TabIndex = 17;
            this.DeployButton.Text = "Deployment";
            this.DeployButton.UseVisualStyleBackColor = false;
            this.DeployButton.Click += new System.EventHandler(this.DeployButton_Click);
            // 
            // SeamingButton
            // 
            this.SeamingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.SeamingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeamingButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SeamingButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeamingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SeamingButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SeamingButton.IconColor = System.Drawing.Color.Black;
            this.SeamingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SeamingButton.IconSize = 48;
            this.SeamingButton.Location = new System.Drawing.Point(464, 19);
            this.SeamingButton.Name = "SeamingButton";
            this.SeamingButton.Rotation = 0D;
            this.SeamingButton.Size = new System.Drawing.Size(209, 58);
            this.SeamingButton.TabIndex = 17;
            this.SeamingButton.Text = "Seaming";
            this.SeamingButton.UseVisualStyleBackColor = false;
            this.SeamingButton.Click += new System.EventHandler(this.SeamingButton_Click);
            // 
            // Dibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dibujo";
            this.Text = "b ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dibujo_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelLeft.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbTools.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbDraw)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton SeamingButton;
        private FontAwesome.Sharp.IconButton DeployButton;
        private System.Windows.Forms.ListBox ListBoxData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbTools;
        private System.Windows.Forms.Button BtnTriangulo;
        private System.Windows.Forms.Button BtnCirculo;
        private System.Windows.Forms.Button BtnCuadrado;
        private System.Windows.Forms.Button BtnRectangulo;
        private System.Windows.Forms.PictureBox PbDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}