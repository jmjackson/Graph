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
            this.Pdraw = new System.Windows.Forms.Panel();
            this.GbTools = new System.Windows.Forms.GroupBox();
            this.TxtGrosor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGrosor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbGrosor = new System.Windows.Forms.TrackBar();
            this.BtnTriangulo = new FontAwesome.Sharp.IconButton();
            this.BtnCuadrado = new FontAwesome.Sharp.IconButton();
            this.BtnRectangulo = new FontAwesome.Sharp.IconButton();
            this.BtnCircle = new FontAwesome.Sharp.IconButton();
            this.BtnPen = new FontAwesome.Sharp.IconButton();
            this.BtnErase = new FontAwesome.Sharp.IconButton();
            this.BtnLine = new FontAwesome.Sharp.IconButton();
            this.Pdibujo = new System.Windows.Forms.Panel();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.BtnSet = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBoxData = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeployButton = new FontAwesome.Sharp.IconButton();
            this.BtnExport = new FontAwesome.Sharp.IconButton();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.SeamingButton = new FontAwesome.Sharp.IconButton();
            this.PanelHeader.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            this.GbTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbGrosor)).BeginInit();
            this.PanelRight.SuspendLayout();
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
            this.PanelLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelLeft.Controls.Add(this.Pdraw);
            this.PanelLeft.Controls.Add(this.GbTools);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 52);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(190, 736);
            this.PanelLeft.TabIndex = 1;
            // 
            // Pdraw
            // 
            this.Pdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pdraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pdraw.Location = new System.Drawing.Point(188, 0);
            this.Pdraw.Name = "Pdraw";
            this.Pdraw.Size = new System.Drawing.Size(1003, 736);
            this.Pdraw.TabIndex = 3;
            // 
            // GbTools
            // 
            this.GbTools.Controls.Add(this.TxtGrosor);
            this.GbTools.Controls.Add(this.label4);
            this.GbTools.Controls.Add(this.lblGrosor);
            this.GbTools.Controls.Add(this.label3);
            this.GbTools.Controls.Add(this.TbGrosor);
            this.GbTools.Controls.Add(this.BtnTriangulo);
            this.GbTools.Controls.Add(this.BtnCuadrado);
            this.GbTools.Controls.Add(this.BtnRectangulo);
            this.GbTools.Controls.Add(this.BtnCircle);
            this.GbTools.Controls.Add(this.BtnPen);
            this.GbTools.Controls.Add(this.BtnErase);
            this.GbTools.Controls.Add(this.BtnLine);
            this.GbTools.Location = new System.Drawing.Point(12, 34);
            this.GbTools.Name = "GbTools";
            this.GbTools.Size = new System.Drawing.Size(170, 434);
            this.GbTools.TabIndex = 0;
            this.GbTools.TabStop = false;
            this.GbTools.Text = "Tools";
            // 
            // TxtGrosor
            // 
            this.TxtGrosor.Location = new System.Drawing.Point(81, 357);
            this.TxtGrosor.Name = "TxtGrosor";
            this.TxtGrosor.Size = new System.Drawing.Size(39, 20);
            this.TxtGrosor.TabIndex = 39;
            this.TxtGrosor.Text = "1";
            this.TxtGrosor.TextChanged += new System.EventHandler(this.TxtGrosor_TextChanged);
            this.TxtGrosor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGrosor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Grosor:";
            // 
            // lblGrosor
            // 
            this.lblGrosor.AutoSize = true;
            this.lblGrosor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrosor.Location = new System.Drawing.Point(78, 290);
            this.lblGrosor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrosor.Name = "lblGrosor";
            this.lblGrosor.Size = new System.Drawing.Size(15, 15);
            this.lblGrosor.TabIndex = 37;
            this.lblGrosor.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Grosor:";
            // 
            // TbGrosor
            // 
            this.TbGrosor.Location = new System.Drawing.Point(6, 306);
            this.TbGrosor.Name = "TbGrosor";
            this.TbGrosor.Size = new System.Drawing.Size(141, 45);
            this.TbGrosor.TabIndex = 5;
            this.TbGrosor.Scroll += new System.EventHandler(this.TbGrosor_Scroll);
            // 
            // BtnTriangulo
            // 
            this.BtnTriangulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.BtnTriangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTriangulo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnTriangulo.ForeColor = System.Drawing.Color.White;
            this.BtnTriangulo.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.BtnTriangulo.IconColor = System.Drawing.Color.White;
            this.BtnTriangulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTriangulo.IconSize = 36;
            this.BtnTriangulo.Location = new System.Drawing.Point(23, 212);
            this.BtnTriangulo.Name = "BtnTriangulo";
            this.BtnTriangulo.Rotation = 0D;
            this.BtnTriangulo.Size = new System.Drawing.Size(58, 55);
            this.BtnTriangulo.TabIndex = 4;
            this.BtnTriangulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnTriangulo.UseVisualStyleBackColor = false;
            this.BtnTriangulo.Click += new System.EventHandler(this.BtnTriangulo_Click);
            // 
            // BtnCuadrado
            // 
            this.BtnCuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.BtnCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuadrado.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCuadrado.ForeColor = System.Drawing.Color.White;
            this.BtnCuadrado.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.BtnCuadrado.IconColor = System.Drawing.Color.White;
            this.BtnCuadrado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCuadrado.IconSize = 36;
            this.BtnCuadrado.Location = new System.Drawing.Point(87, 151);
            this.BtnCuadrado.Name = "BtnCuadrado";
            this.BtnCuadrado.Rotation = 0D;
            this.BtnCuadrado.Size = new System.Drawing.Size(58, 55);
            this.BtnCuadrado.TabIndex = 3;
            this.BtnCuadrado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCuadrado.UseVisualStyleBackColor = false;
            this.BtnCuadrado.Click += new System.EventHandler(this.BtnCuadrado_Click);
            // 
            // BtnRectangulo
            // 
            this.BtnRectangulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.BtnRectangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRectangulo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnRectangulo.ForeColor = System.Drawing.Color.White;
            this.BtnRectangulo.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.BtnRectangulo.IconColor = System.Drawing.Color.White;
            this.BtnRectangulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRectangulo.IconSize = 36;
            this.BtnRectangulo.Location = new System.Drawing.Point(23, 151);
            this.BtnRectangulo.Name = "BtnRectangulo";
            this.BtnRectangulo.Rotation = 0D;
            this.BtnRectangulo.Size = new System.Drawing.Size(58, 55);
            this.BtnRectangulo.TabIndex = 2;
            this.BtnRectangulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRectangulo.UseVisualStyleBackColor = false;
            this.BtnRectangulo.Click += new System.EventHandler(this.BtnRectangulo_Click);
            // 
            // BtnCircle
            // 
            this.BtnCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.BtnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCircle.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCircle.ForeColor = System.Drawing.Color.White;
            this.BtnCircle.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.BtnCircle.IconColor = System.Drawing.Color.White;
            this.BtnCircle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCircle.IconSize = 36;
            this.BtnCircle.Location = new System.Drawing.Point(23, 90);
            this.BtnCircle.Name = "BtnCircle";
            this.BtnCircle.Rotation = 0D;
            this.BtnCircle.Size = new System.Drawing.Size(58, 55);
            this.BtnCircle.TabIndex = 1;
            this.BtnCircle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCircle.UseVisualStyleBackColor = false;
            this.BtnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // BtnPen
            // 
            this.BtnPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.BtnPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnPen.ForeColor = System.Drawing.Color.White;
            this.BtnPen.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.BtnPen.IconColor = System.Drawing.Color.White;
            this.BtnPen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPen.IconSize = 36;
            this.BtnPen.Location = new System.Drawing.Point(23, 19);
            this.BtnPen.Name = "BtnPen";
            this.BtnPen.Rotation = 0D;
            this.BtnPen.Size = new System.Drawing.Size(58, 55);
            this.BtnPen.TabIndex = 1;
            this.BtnPen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPen.UseVisualStyleBackColor = false;
            this.BtnPen.Click += new System.EventHandler(this.BtnPluma_Click);
            // 
            // BtnErase
            // 
            this.BtnErase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.BtnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnErase.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnErase.ForeColor = System.Drawing.Color.White;
            this.BtnErase.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.BtnErase.IconColor = System.Drawing.Color.White;
            this.BtnErase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnErase.IconSize = 36;
            this.BtnErase.Location = new System.Drawing.Point(87, 19);
            this.BtnErase.Name = "BtnErase";
            this.BtnErase.Rotation = 0D;
            this.BtnErase.Size = new System.Drawing.Size(58, 55);
            this.BtnErase.TabIndex = 1;
            this.BtnErase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnErase.UseVisualStyleBackColor = false;
            this.BtnErase.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.BtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnLine.ForeColor = System.Drawing.Color.White;
            this.BtnLine.IconChar = FontAwesome.Sharp.IconChar.GripLinesVertical;
            this.BtnLine.IconColor = System.Drawing.Color.White;
            this.BtnLine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLine.IconSize = 48;
            this.BtnLine.Location = new System.Drawing.Point(87, 90);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Rotation = 0D;
            this.BtnLine.Size = new System.Drawing.Size(58, 55);
            this.BtnLine.TabIndex = 1;
            this.BtnLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnLine.UseVisualStyleBackColor = false;
            this.BtnLine.Click += new System.EventHandler(this.BtnLinia_Click);
            // 
            // Pdibujo
            // 
            this.Pdibujo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Pdibujo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pdibujo.Location = new System.Drawing.Point(190, 52);
            this.Pdibujo.Name = "Pdibujo";
            this.Pdibujo.Size = new System.Drawing.Size(996, 647);
            this.Pdibujo.TabIndex = 5;
            this.Pdibujo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pdibujo_MouseClick);
            this.Pdibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pdibujo_MouseDown);
            this.Pdibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pdibujo_MouseMove);
            this.Pdibujo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pdibujo_MouseUp);
            // 
            // PanelRight
            // 
            this.PanelRight.BackColor = System.Drawing.SystemColors.Control;
            this.PanelRight.Controls.Add(this.BtnSet);
            this.PanelRight.Controls.Add(this.label2);
            this.PanelRight.Controls.Add(this.ListBoxData);
            this.PanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRight.Location = new System.Drawing.Point(1186, 52);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(200, 736);
            this.PanelRight.TabIndex = 2;
            // 
            // BtnSet
            // 
            this.BtnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.BtnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSet.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSet.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSet.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSet.IconColor = System.Drawing.Color.Black;
            this.BtnSet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSet.IconSize = 48;
            this.BtnSet.Location = new System.Drawing.Point(42, 381);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Rotation = 0D;
            this.BtnSet.Size = new System.Drawing.Size(112, 56);
            this.BtnSet.TabIndex = 2;
            this.BtnSet.Text = "Set";
            this.BtnSet.UseVisualStyleBackColor = false;
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
            this.ListBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxData.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxData.FormattingEnabled = true;
            this.ListBoxData.ItemHeight = 32;
            this.ListBoxData.Location = new System.Drawing.Point(27, 519);
            this.ListBoxData.Name = "ListBoxData";
            this.ListBoxData.Size = new System.Drawing.Size(161, 196);
            this.ListBoxData.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.DeployButton);
            this.panel3.Controls.Add(this.BtnExport);
            this.panel3.Controls.Add(this.BtnSave);
            this.panel3.Controls.Add(this.SeamingButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(190, 699);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 89);
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
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnExport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnExport.IconColor = System.Drawing.Color.Black;
            this.BtnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExport.IconSize = 48;
            this.BtnExport.Location = new System.Drawing.Point(899, 19);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Rotation = 0D;
            this.BtnExport.Size = new System.Drawing.Size(191, 58);
            this.BtnExport.TabIndex = 17;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSave.IconColor = System.Drawing.Color.Black;
            this.BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSave.IconSize = 48;
            this.BtnSave.Location = new System.Drawing.Point(696, 19);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Rotation = 0D;
            this.BtnSave.Size = new System.Drawing.Size(172, 58);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.Controls.Add(this.Pdibujo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanelRight);
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
            this.GbTools.ResumeLayout(false);
            this.GbTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbGrosor)).EndInit();
            this.PanelRight.ResumeLayout(false);
            this.PanelRight.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.Panel Pdraw;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton SeamingButton;
        private FontAwesome.Sharp.IconButton DeployButton;
        private System.Windows.Forms.ListBox ListBoxData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbTools;
        private FontAwesome.Sharp.IconButton BtnLine;
        private FontAwesome.Sharp.IconButton BtnErase;
        private FontAwesome.Sharp.IconButton BtnPen;
        private FontAwesome.Sharp.IconButton BtnCircle;
        private FontAwesome.Sharp.IconButton BtnSet;
        private FontAwesome.Sharp.IconButton BtnExport;
        private FontAwesome.Sharp.IconButton BtnSave;
        private System.Windows.Forms.Panel Pdibujo;
        private FontAwesome.Sharp.IconButton BtnRectangulo;
        private FontAwesome.Sharp.IconButton BtnCuadrado;
        private FontAwesome.Sharp.IconButton BtnTriangulo;
        private System.Windows.Forms.TrackBar TbGrosor;
        private System.Windows.Forms.Label lblGrosor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGrosor;
        private System.Windows.Forms.Label label4;
    }
}