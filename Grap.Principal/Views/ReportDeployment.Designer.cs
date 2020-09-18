namespace Grap.Principal
{
    partial class ReportDeployment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDeployment));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.LabelName = new ns1.BunifuCustomLabel();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.Close_Button = new ns1.BunifuImageButton();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV1 = new ns1.BunifuCustomDataGrid();
            this.Deployment_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Widht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblClient = new ns1.BunifuCustomLabel();
            this.LblProject = new ns1.BunifuCustomLabel();
            this.LblProjectNo = new ns1.BunifuCustomLabel();
            this.LblContractor = new ns1.BunifuCustomLabel();
            this.LblSupplier = new ns1.BunifuCustomLabel();
            this.LblGeosynthetic = new ns1.BunifuCustomLabel();
            this.LblInfoClient = new ns1.BunifuCustomLabel();
            this.LblInfoProject = new ns1.BunifuCustomLabel();
            this.LblInfoProjectNo = new ns1.BunifuCustomLabel();
            this.LblInfoContractor = new ns1.BunifuCustomLabel();
            this.LblInfoSupplier = new ns1.BunifuCustomLabel();
            this.LblInfoGeosynthetic = new ns1.BunifuCustomLabel();
            this.PBLogoImage = new System.Windows.Forms.PictureBox();
            this.BtnGetPDF = new FontAwesome.Sharp.IconButton();
            this.BtnNextReport = new FontAwesome.Sharp.IconButton();
            this.LblGeomembranePanel = new ns1.BunifuCustomLabel();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            this.Header.Controls.Add(this.LabelName);
            this.Header.Controls.Add(this.PictureLogo);
            this.Header.Controls.Add(this.Close_Button);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1435, 61);
            this.Header.TabIndex = 0;
            this.Header.Paint += new System.Windows.Forms.PaintEventHandler(this.Header_Paint);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Calibri", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelName.Location = new System.Drawing.Point(64, 17);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(81, 32);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Graph";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PictureLogo
            // 
            this.PictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogo.Image")));
            this.PictureLogo.Location = new System.Drawing.Point(3, 3);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(55, 55);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLogo.TabIndex = 6;
            this.PictureLogo.TabStop = false;
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.ImageActive = null;
            this.Close_Button.Location = new System.Drawing.Point(1394, 12);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(32, 37);
            this.Close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Button.TabIndex = 5;
            this.Close_Button.TabStop = false;
            this.Close_Button.Zoom = 10;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGV1);
            this.panel1.Location = new System.Drawing.Point(12, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1414, 446);
            this.panel1.TabIndex = 1;
            // 
            // DGV1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.BackgroundColor = System.Drawing.Color.White;
            this.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV1.ColumnHeadersHeight = 45;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deployment_Date,
            this.Panel_No,
            this.Roll_No,
            this.Lenght,
            this.Widht,
            this.Thickness,
            this.Area,
            this.Remarks});
            this.DGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV1.DoubleBuffered = true;
            this.DGV1.EnableHeadersVisualStyles = false;
            this.DGV1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            this.DGV1.HeaderForeColor = System.Drawing.Color.White;
            this.DGV1.Location = new System.Drawing.Point(0, 0);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.Size = new System.Drawing.Size(1414, 446);
            this.DGV1.TabIndex = 1;
            // 
            // Deployment_Date
            // 
            this.Deployment_Date.HeaderText = "Deployment Date";
            this.Deployment_Date.Name = "Deployment_Date";
            this.Deployment_Date.ReadOnly = true;
            // 
            // Panel_No
            // 
            this.Panel_No.HeaderText = "Panel No.";
            this.Panel_No.Name = "Panel_No";
            this.Panel_No.ReadOnly = true;
            // 
            // Roll_No
            // 
            this.Roll_No.HeaderText = "Roll No.";
            this.Roll_No.Name = "Roll_No";
            this.Roll_No.ReadOnly = true;
            // 
            // Lenght
            // 
            this.Lenght.HeaderText = "Lenght";
            this.Lenght.Name = "Lenght";
            this.Lenght.ReadOnly = true;
            // 
            // Widht
            // 
            this.Widht.HeaderText = "Width";
            this.Widht.Name = "Widht";
            this.Widht.ReadOnly = true;
            // 
            // Thickness
            // 
            this.Thickness.HeaderText = "Thickness";
            this.Thickness.Name = "Thickness";
            this.Thickness.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // LblClient
            // 
            this.LblClient.AutoSize = true;
            this.LblClient.BackColor = System.Drawing.Color.White;
            this.LblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClient.Location = new System.Drawing.Point(451, 115);
            this.LblClient.Name = "LblClient";
            this.LblClient.Size = new System.Drawing.Size(44, 15);
            this.LblClient.TabIndex = 2;
            this.LblClient.Text = "Client :";
            // 
            // LblProject
            // 
            this.LblProject.AutoSize = true;
            this.LblProject.BackColor = System.Drawing.Color.White;
            this.LblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblProject.Location = new System.Drawing.Point(451, 150);
            this.LblProject.Name = "LblProject";
            this.LblProject.Size = new System.Drawing.Size(51, 15);
            this.LblProject.TabIndex = 3;
            this.LblProject.Text = "Project :";
            // 
            // LblProjectNo
            // 
            this.LblProjectNo.AutoSize = true;
            this.LblProjectNo.BackColor = System.Drawing.Color.White;
            this.LblProjectNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblProjectNo.Location = new System.Drawing.Point(451, 187);
            this.LblProjectNo.Name = "LblProjectNo";
            this.LblProjectNo.Size = new System.Drawing.Size(73, 15);
            this.LblProjectNo.TabIndex = 4;
            this.LblProjectNo.Text = "Project No. :";
            // 
            // LblContractor
            // 
            this.LblContractor.AutoSize = true;
            this.LblContractor.BackColor = System.Drawing.Color.White;
            this.LblContractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblContractor.Location = new System.Drawing.Point(752, 115);
            this.LblContractor.Name = "LblContractor";
            this.LblContractor.Size = new System.Drawing.Size(69, 15);
            this.LblContractor.TabIndex = 5;
            this.LblContractor.Text = "Contractor :";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.BackColor = System.Drawing.Color.White;
            this.LblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblSupplier.Location = new System.Drawing.Point(752, 150);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(59, 15);
            this.LblSupplier.TabIndex = 6;
            this.LblSupplier.Text = "Supplier :";
            // 
            // LblGeosynthetic
            // 
            this.LblGeosynthetic.AutoSize = true;
            this.LblGeosynthetic.BackColor = System.Drawing.Color.White;
            this.LblGeosynthetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblGeosynthetic.Location = new System.Drawing.Point(752, 187);
            this.LblGeosynthetic.Name = "LblGeosynthetic";
            this.LblGeosynthetic.Size = new System.Drawing.Size(83, 15);
            this.LblGeosynthetic.TabIndex = 3;
            this.LblGeosynthetic.Text = "Geosynthetic :";
            // 
            // LblInfoClient
            // 
            this.LblInfoClient.AutoSize = true;
            this.LblInfoClient.BackColor = System.Drawing.Color.White;
            this.LblInfoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblInfoClient.Location = new System.Drawing.Point(533, 115);
            this.LblInfoClient.Name = "LblInfoClient";
            this.LblInfoClient.Size = new System.Drawing.Size(182, 15);
            this.LblInfoClient.TabIndex = 14;
            this.LblInfoClient.Text = "_________________________";
            // 
            // LblInfoProject
            // 
            this.LblInfoProject.AutoSize = true;
            this.LblInfoProject.BackColor = System.Drawing.Color.White;
            this.LblInfoProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblInfoProject.Location = new System.Drawing.Point(533, 150);
            this.LblInfoProject.Name = "LblInfoProject";
            this.LblInfoProject.Size = new System.Drawing.Size(182, 15);
            this.LblInfoProject.TabIndex = 15;
            this.LblInfoProject.Text = "_________________________";
            // 
            // LblInfoProjectNo
            // 
            this.LblInfoProjectNo.AutoSize = true;
            this.LblInfoProjectNo.BackColor = System.Drawing.Color.White;
            this.LblInfoProjectNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblInfoProjectNo.Location = new System.Drawing.Point(533, 187);
            this.LblInfoProjectNo.Name = "LblInfoProjectNo";
            this.LblInfoProjectNo.Size = new System.Drawing.Size(182, 15);
            this.LblInfoProjectNo.TabIndex = 15;
            this.LblInfoProjectNo.Text = "_________________________";
            // 
            // LblInfoContractor
            // 
            this.LblInfoContractor.AutoSize = true;
            this.LblInfoContractor.BackColor = System.Drawing.Color.White;
            this.LblInfoContractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblInfoContractor.Location = new System.Drawing.Point(843, 112);
            this.LblInfoContractor.Name = "LblInfoContractor";
            this.LblInfoContractor.Size = new System.Drawing.Size(182, 15);
            this.LblInfoContractor.TabIndex = 16;
            this.LblInfoContractor.Text = "_________________________";
            // 
            // LblInfoSupplier
            // 
            this.LblInfoSupplier.AutoSize = true;
            this.LblInfoSupplier.BackColor = System.Drawing.Color.White;
            this.LblInfoSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblInfoSupplier.Location = new System.Drawing.Point(843, 150);
            this.LblInfoSupplier.Name = "LblInfoSupplier";
            this.LblInfoSupplier.Size = new System.Drawing.Size(182, 15);
            this.LblInfoSupplier.TabIndex = 17;
            this.LblInfoSupplier.Text = "_________________________";
            // 
            // LblInfoGeosynthetic
            // 
            this.LblInfoGeosynthetic.AutoSize = true;
            this.LblInfoGeosynthetic.BackColor = System.Drawing.Color.White;
            this.LblInfoGeosynthetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblInfoGeosynthetic.Location = new System.Drawing.Point(843, 187);
            this.LblInfoGeosynthetic.Name = "LblInfoGeosynthetic";
            this.LblInfoGeosynthetic.Size = new System.Drawing.Size(182, 15);
            this.LblInfoGeosynthetic.TabIndex = 15;
            this.LblInfoGeosynthetic.Text = "_________________________";
            // 
            // PBLogoImage
            // 
            this.PBLogoImage.Image = ((System.Drawing.Image)(resources.GetObject("PBLogoImage.Image")));
            this.PBLogoImage.Location = new System.Drawing.Point(1229, 67);
            this.PBLogoImage.Name = "PBLogoImage";
            this.PBLogoImage.Size = new System.Drawing.Size(157, 151);
            this.PBLogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogoImage.TabIndex = 26;
            this.PBLogoImage.TabStop = false;
            // 
            // BtnGetPDF
            // 
            this.BtnGetPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.BtnGetPDF.FlatAppearance.BorderSize = 0;
            this.BtnGetPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetPDF.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnGetPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGetPDF.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.BtnGetPDF.IconColor = System.Drawing.Color.White;
            this.BtnGetPDF.IconSize = 18;
            this.BtnGetPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGetPDF.Location = new System.Drawing.Point(1052, 123);
            this.BtnGetPDF.Name = "BtnGetPDF";
            this.BtnGetPDF.Rotation = 0D;
            this.BtnGetPDF.Size = new System.Drawing.Size(127, 35);
            this.BtnGetPDF.TabIndex = 27;
            this.BtnGetPDF.Text = "PDF";
            this.BtnGetPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGetPDF.UseVisualStyleBackColor = false;
            // 
            // BtnNextReport
            // 
            this.BtnNextReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.BtnNextReport.FlatAppearance.BorderSize = 0;
            this.BtnNextReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextReport.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnNextReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNextReport.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BtnNextReport.IconColor = System.Drawing.Color.White;
            this.BtnNextReport.IconSize = 18;
            this.BtnNextReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNextReport.Location = new System.Drawing.Point(1052, 168);
            this.BtnNextReport.Name = "BtnNextReport";
            this.BtnNextReport.Rotation = 0D;
            this.BtnNextReport.Size = new System.Drawing.Size(127, 35);
            this.BtnNextReport.TabIndex = 28;
            this.BtnNextReport.Text = "Next Report";
            this.BtnNextReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNextReport.UseVisualStyleBackColor = false;
            // 
            // LblGeomembranePanel
            // 
            this.LblGeomembranePanel.AutoSize = true;
            this.LblGeomembranePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGeomembranePanel.Location = new System.Drawing.Point(629, 79);
            this.LblGeomembranePanel.Name = "LblGeomembranePanel";
            this.LblGeomembranePanel.Size = new System.Drawing.Size(219, 15);
            this.LblGeomembranePanel.TabIndex = 29;
            this.LblGeomembranePanel.Text = "Geomembrane Panel Deployment Log";
            this.LblGeomembranePanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReportDeployment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1435, 683);
            this.Controls.Add(this.LblGeomembranePanel);
            this.Controls.Add(this.BtnNextReport);
            this.Controls.Add(this.BtnGetPDF);
            this.Controls.Add(this.PBLogoImage);
            this.Controls.Add(this.LblInfoGeosynthetic);
            this.Controls.Add(this.LblInfoSupplier);
            this.Controls.Add(this.LblInfoContractor);
            this.Controls.Add(this.LblInfoProjectNo);
            this.Controls.Add(this.LblInfoProject);
            this.Controls.Add(this.LblInfoClient);
            this.Controls.Add(this.LblGeosynthetic);
            this.Controls.Add(this.LblSupplier);
            this.Controls.Add(this.LblContractor);
            this.Controls.Add(this.LblProjectNo);
            this.Controls.Add(this.LblProject);
            this.Controls.Add(this.LblClient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportDeployment";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportDeployment_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Header;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuImageButton Close_Button;
        private System.Windows.Forms.PictureBox PictureLogo;
        private ns1.BunifuCustomLabel LabelName;
        private ns1.BunifuCustomLabel LblGeosynthetic;
        private ns1.BunifuCustomLabel LblSupplier;
        private ns1.BunifuCustomLabel LblContractor;
        private ns1.BunifuCustomLabel LblProjectNo;
        private ns1.BunifuCustomLabel LblProject;
        private ns1.BunifuCustomLabel LblClient;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomDataGrid DGV1;
        private ns1.BunifuCustomLabel LblInfoClient;
        private ns1.BunifuCustomLabel LblInfoGeosynthetic;
        private ns1.BunifuCustomLabel LblInfoSupplier;
        private ns1.BunifuCustomLabel LblInfoContractor;
        private ns1.BunifuCustomLabel LblInfoProjectNo;
        private ns1.BunifuCustomLabel LblInfoProject;
        private System.Windows.Forms.PictureBox PBLogoImage;
        private FontAwesome.Sharp.IconButton BtnNextReport;
        private FontAwesome.Sharp.IconButton BtnGetPDF;
        private ns1.BunifuCustomLabel LblGeomembranePanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deployment_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Panel_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn Widht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}