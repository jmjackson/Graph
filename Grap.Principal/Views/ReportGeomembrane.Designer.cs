namespace Grap.Principal
{
    partial class ReportGeomembrane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGeomembrane));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.LabelName = new ns1.BunifuCustomLabel();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.Close_Button = new ns1.BunifuImageButton();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV1 = new ns1.BunifuCustomDataGrid();
            this.Seaming_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seam_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seam_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seam_Lenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carry_Over = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destructive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reamarks_Destructive = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.LblInfoMachineNo = new ns1.BunifuCustomLabel();
            this.LblInfoOperator = new ns1.BunifuCustomLabel();
            this.LblMachineNo = new ns1.BunifuCustomLabel();
            this.LblOperator = new ns1.BunifuCustomLabel();
            this.BtnReturnReport = new FontAwesome.Sharp.IconButton();
            this.BtnGetPDF = new FontAwesome.Sharp.IconButton();
            this.PBLogoImage = new System.Windows.Forms.PictureBox();
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
            this.Header.Size = new System.Drawing.Size(1386, 61);
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
            this.Seaming_Date,
            this.Seam_No,
            this.Seam_Time,
            this.WTemp,
            this.WSpeed,
            this.Seam_Lenght,
            this.Carry_Over,
            this.Destructive,
            this.Reamarks_Destructive});
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
            // Seaming_Date
            // 
            this.Seaming_Date.HeaderText = "Seaming Date";
            this.Seaming_Date.Name = "Seaming_Date";
            this.Seaming_Date.ReadOnly = true;
            // 
            // Seam_No
            // 
            this.Seam_No.HeaderText = "Seam No.";
            this.Seam_No.Name = "Seam_No";
            this.Seam_No.ReadOnly = true;
            // 
            // Seam_Time
            // 
            this.Seam_Time.HeaderText = "Seam Time";
            this.Seam_Time.Name = "Seam_Time";
            this.Seam_Time.ReadOnly = true;
            // 
            // WTemp
            // 
            this.WTemp.HeaderText = "Wedge Temp.";
            this.WTemp.Name = "WTemp";
            this.WTemp.ReadOnly = true;
            // 
            // WSpeed
            // 
            this.WSpeed.HeaderText = "Wedge Speed";
            this.WSpeed.Name = "WSpeed";
            this.WSpeed.ReadOnly = true;
            // 
            // Seam_Lenght
            // 
            this.Seam_Lenght.HeaderText = "Seam Lenght";
            this.Seam_Lenght.Name = "Seam_Lenght";
            this.Seam_Lenght.ReadOnly = true;
            // 
            // Carry_Over
            // 
            this.Carry_Over.HeaderText = "Carry Over";
            this.Carry_Over.Name = "Carry_Over";
            this.Carry_Over.ReadOnly = true;
            // 
            // Destructive
            // 
            this.Destructive.HeaderText = "Destructive";
            this.Destructive.Name = "Destructive";
            this.Destructive.ReadOnly = true;
            // 
            // Reamarks_Destructive
            // 
            this.Reamarks_Destructive.HeaderText = "Remarks / Destructive";
            this.Reamarks_Destructive.Name = "Reamarks_Destructive";
            this.Reamarks_Destructive.ReadOnly = true;
            // 
            // LblClient
            // 
            this.LblClient.AutoSize = true;
            this.LblClient.BackColor = System.Drawing.Color.White;
            this.LblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblClient.Location = new System.Drawing.Point(182, 113);
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
            this.LblProject.Location = new System.Drawing.Point(182, 148);
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
            this.LblProjectNo.Location = new System.Drawing.Point(182, 185);
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
            this.LblContractor.Location = new System.Drawing.Point(483, 113);
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
            this.LblSupplier.Location = new System.Drawing.Point(483, 148);
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
            this.LblGeosynthetic.Location = new System.Drawing.Point(485, 185);
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
            this.LblInfoClient.Location = new System.Drawing.Point(262, 113);
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
            this.LblInfoProject.Location = new System.Drawing.Point(262, 148);
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
            this.LblInfoProjectNo.Location = new System.Drawing.Point(262, 185);
            this.LblInfoProjectNo.Name = "LblInfoProjectNo";
            this.LblInfoProjectNo.Size = new System.Drawing.Size(182, 15);
            this.LblInfoProjectNo.TabIndex = 15;
            this.LblInfoProjectNo.Text = "_________________________";
            this.LblInfoProjectNo.Click += new System.EventHandler(this.Lbl_InfoProjectNo_Click);
            // 
            // LblInfoContractor
            // 
            this.LblInfoContractor.AutoSize = true;
            this.LblInfoContractor.BackColor = System.Drawing.Color.White;
            this.LblInfoContractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblInfoContractor.Location = new System.Drawing.Point(574, 113);
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
            this.LblInfoSupplier.Location = new System.Drawing.Point(574, 148);
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
            this.LblInfoGeosynthetic.Location = new System.Drawing.Point(574, 185);
            this.LblInfoGeosynthetic.Name = "LblInfoGeosynthetic";
            this.LblInfoGeosynthetic.Size = new System.Drawing.Size(182, 15);
            this.LblInfoGeosynthetic.TabIndex = 15;
            this.LblInfoGeosynthetic.Text = "_________________________";
            // 
            // LblInfoMachineNo
            // 
            this.LblInfoMachineNo.AutoSize = true;
            this.LblInfoMachineNo.BackColor = System.Drawing.Color.White;
            this.LblInfoMachineNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblInfoMachineNo.Location = new System.Drawing.Point(905, 148);
            this.LblInfoMachineNo.Name = "LblInfoMachineNo";
            this.LblInfoMachineNo.Size = new System.Drawing.Size(182, 15);
            this.LblInfoMachineNo.TabIndex = 24;
            this.LblInfoMachineNo.Text = "_________________________";
            // 
            // LblInfoOperator
            // 
            this.LblInfoOperator.AutoSize = true;
            this.LblInfoOperator.BackColor = System.Drawing.Color.White;
            this.LblInfoOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblInfoOperator.Location = new System.Drawing.Point(905, 113);
            this.LblInfoOperator.Name = "LblInfoOperator";
            this.LblInfoOperator.Size = new System.Drawing.Size(182, 15);
            this.LblInfoOperator.TabIndex = 23;
            this.LblInfoOperator.Text = "_________________________";
            // 
            // LblMachineNo
            // 
            this.LblMachineNo.AutoSize = true;
            this.LblMachineNo.BackColor = System.Drawing.Color.White;
            this.LblMachineNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblMachineNo.Location = new System.Drawing.Point(801, 148);
            this.LblMachineNo.Name = "LblMachineNo";
            this.LblMachineNo.Size = new System.Drawing.Size(83, 15);
            this.LblMachineNo.TabIndex = 21;
            this.LblMachineNo.Text = "Machine No. :";
            // 
            // LblOperator
            // 
            this.LblOperator.AutoSize = true;
            this.LblOperator.BackColor = System.Drawing.Color.White;
            this.LblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblOperator.Location = new System.Drawing.Point(801, 113);
            this.LblOperator.Name = "LblOperator";
            this.LblOperator.Size = new System.Drawing.Size(61, 15);
            this.LblOperator.TabIndex = 20;
            this.LblOperator.Text = "Operator :";
            // 
            // BtnReturnReport
            // 
            this.BtnReturnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.BtnReturnReport.FlatAppearance.BorderSize = 0;
            this.BtnReturnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturnReport.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnReturnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReturnReport.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.BtnReturnReport.IconColor = System.Drawing.Color.White;
            this.BtnReturnReport.IconSize = 18;
            this.BtnReturnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReturnReport.Location = new System.Drawing.Point(1123, 159);
            this.BtnReturnReport.Name = "BtnReturnReport";
            this.BtnReturnReport.Rotation = 0D;
            this.BtnReturnReport.Size = new System.Drawing.Size(127, 35);
            this.BtnReturnReport.TabIndex = 30;
            this.BtnReturnReport.Text = "Next Report";
            this.BtnReturnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReturnReport.UseVisualStyleBackColor = false;
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
            this.BtnGetPDF.Location = new System.Drawing.Point(1123, 114);
            this.BtnGetPDF.Name = "BtnGetPDF";
            this.BtnGetPDF.Rotation = 0D;
            this.BtnGetPDF.Size = new System.Drawing.Size(127, 35);
            this.BtnGetPDF.TabIndex = 29;
            this.BtnGetPDF.Text = "PDF";
            this.BtnGetPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGetPDF.UseVisualStyleBackColor = false;
            // 
            // PBLogoImage
            // 
            this.PBLogoImage.Image = ((System.Drawing.Image)(resources.GetObject("PBLogoImage.Image")));
            this.PBLogoImage.Location = new System.Drawing.Point(1269, 67);
            this.PBLogoImage.Name = "PBLogoImage";
            this.PBLogoImage.Size = new System.Drawing.Size(157, 151);
            this.PBLogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogoImage.TabIndex = 31;
            this.PBLogoImage.TabStop = false;
            // 
            // LblGeomembranePanel
            // 
            this.LblGeomembranePanel.AutoSize = true;
            this.LblGeomembranePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGeomembranePanel.Location = new System.Drawing.Point(629, 79);
            this.LblGeomembranePanel.Name = "LblGeomembranePanel";
            this.LblGeomembranePanel.Size = new System.Drawing.Size(198, 15);
            this.LblGeomembranePanel.TabIndex = 32;
            this.LblGeomembranePanel.Text = "Geomembrane Field Seaming Log";
            this.LblGeomembranePanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReportGeomembrane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 725);
            this.Controls.Add(this.LblGeomembranePanel);
            this.Controls.Add(this.PBLogoImage);
            this.Controls.Add(this.BtnReturnReport);
            this.Controls.Add(this.BtnGetPDF);
            this.Controls.Add(this.LblInfoMachineNo);
            this.Controls.Add(this.LblInfoOperator);
            this.Controls.Add(this.LblMachineNo);
            this.Controls.Add(this.LblOperator);
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
            this.Name = "ReportGeomembrane";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportGeomembrane_Load);
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
        private ns1.BunifuCustomLabel LblInfoMachineNo;
        private ns1.BunifuCustomLabel LblInfoOperator;
        private ns1.BunifuCustomLabel LblMachineNo;
        private ns1.BunifuCustomLabel LblOperator;
        private FontAwesome.Sharp.IconButton BtnReturnReport;
        private FontAwesome.Sharp.IconButton BtnGetPDF;
        private System.Windows.Forms.PictureBox PBLogoImage;
        private ns1.BunifuCustomLabel LblGeomembranePanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seaming_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seam_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seam_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn WTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn WSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seam_Lenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carry_Over;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destructive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reamarks_Destructive;
    }
}