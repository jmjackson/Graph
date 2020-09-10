namespace Grap.Principal
{
    partial class Report2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report2));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.LabelName = new ns1.BunifuCustomLabel();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.Close_Button = new ns1.BunifuImageButton();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV1 = new ns1.BunifuCustomDataGrid();
            this.Lbl_Client = new ns1.BunifuCustomLabel();
            this.Lbl_Project = new ns1.BunifuCustomLabel();
            this.Lbl_ProjectNo = new ns1.BunifuCustomLabel();
            this.Lbl_Contractor = new ns1.BunifuCustomLabel();
            this.Lbl_Supplier = new ns1.BunifuCustomLabel();
            this.Lbl_Geosynthetic = new ns1.BunifuCustomLabel();
            this.Btn_PrintReport1 = new ns1.BunifuFlatButton();
            this.Lbl_InfoClient = new ns1.BunifuCustomLabel();
            this.Lbl_InfoProject = new ns1.BunifuCustomLabel();
            this.Lbl_InfoProjectNo = new ns1.BunifuCustomLabel();
            this.Lbl_InfoContractor = new ns1.BunifuCustomLabel();
            this.Lbl_InfoSupplier = new ns1.BunifuCustomLabel();
            this.Lbl_InfoGeosynthetic = new ns1.BunifuCustomLabel();
            this.Btn_ReturnReport = new ns1.BunifuFlatButton();
            this.Lbl_InfoMachineNo = new ns1.BunifuCustomLabel();
            this.Lbl_InfoOperator = new ns1.BunifuCustomLabel();
            this.Lbl_MachineNo = new ns1.BunifuCustomLabel();
            this.Lbl_Operator = new ns1.BunifuCustomLabel();
            this.Seaming_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seam_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seam_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seam_Lenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carry_Over = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destructive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reamarks_Destructive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.SteelBlue;
            this.Header.Controls.Add(this.LabelName);
            this.Header.Controls.Add(this.PictureLogo);
            this.Header.Controls.Add(this.Close_Button);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1195, 61);
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
            this.Close_Button.Location = new System.Drawing.Point(1141, 12);
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
            this.panel1.Location = new System.Drawing.Point(12, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 515);
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
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
            this.Temp,
            this.Speed,
            this.Seam_Lenght,
            this.Carry_Over,
            this.Destructive,
            this.Reamarks_Destructive});
            this.DGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV1.DoubleBuffered = true;
            this.DGV1.EnableHeadersVisualStyles = false;
            this.DGV1.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.DGV1.HeaderForeColor = System.Drawing.Color.White;
            this.DGV1.Location = new System.Drawing.Point(0, 0);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.Size = new System.Drawing.Size(1171, 515);
            this.DGV1.TabIndex = 1;
            // 
            // Lbl_Client
            // 
            this.Lbl_Client.AutoSize = true;
            this.Lbl_Client.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_Client.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Client.Location = new System.Drawing.Point(34, 77);
            this.Lbl_Client.Name = "Lbl_Client";
            this.Lbl_Client.Size = new System.Drawing.Size(60, 21);
            this.Lbl_Client.TabIndex = 2;
            this.Lbl_Client.Text = "Client :";
            // 
            // Lbl_Project
            // 
            this.Lbl_Project.AutoSize = true;
            this.Lbl_Project.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_Project.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Project.Location = new System.Drawing.Point(34, 112);
            this.Lbl_Project.Name = "Lbl_Project";
            this.Lbl_Project.Size = new System.Drawing.Size(70, 21);
            this.Lbl_Project.TabIndex = 3;
            this.Lbl_Project.Text = "Project :";
            // 
            // Lbl_ProjectNo
            // 
            this.Lbl_ProjectNo.AutoSize = true;
            this.Lbl_ProjectNo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_ProjectNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProjectNo.Location = new System.Drawing.Point(34, 149);
            this.Lbl_ProjectNo.Name = "Lbl_ProjectNo";
            this.Lbl_ProjectNo.Size = new System.Drawing.Size(100, 21);
            this.Lbl_ProjectNo.TabIndex = 4;
            this.Lbl_ProjectNo.Text = "Project No. :";
            // 
            // Lbl_Contractor
            // 
            this.Lbl_Contractor.AutoSize = true;
            this.Lbl_Contractor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_Contractor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contractor.Location = new System.Drawing.Point(360, 77);
            this.Lbl_Contractor.Name = "Lbl_Contractor";
            this.Lbl_Contractor.Size = new System.Drawing.Size(97, 21);
            this.Lbl_Contractor.TabIndex = 5;
            this.Lbl_Contractor.Text = "Contractor :";
            // 
            // Lbl_Supplier
            // 
            this.Lbl_Supplier.AutoSize = true;
            this.Lbl_Supplier.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_Supplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Supplier.Location = new System.Drawing.Point(360, 112);
            this.Lbl_Supplier.Name = "Lbl_Supplier";
            this.Lbl_Supplier.Size = new System.Drawing.Size(79, 21);
            this.Lbl_Supplier.TabIndex = 6;
            this.Lbl_Supplier.Text = "Supplier :";
            // 
            // Lbl_Geosynthetic
            // 
            this.Lbl_Geosynthetic.AutoSize = true;
            this.Lbl_Geosynthetic.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_Geosynthetic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Geosynthetic.Location = new System.Drawing.Point(360, 149);
            this.Lbl_Geosynthetic.Name = "Lbl_Geosynthetic";
            this.Lbl_Geosynthetic.Size = new System.Drawing.Size(114, 21);
            this.Lbl_Geosynthetic.TabIndex = 3;
            this.Lbl_Geosynthetic.Text = "Geosynthetic :";
            // 
            // Btn_PrintReport1
            // 
            this.Btn_PrintReport1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_PrintReport1.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_PrintReport1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_PrintReport1.BorderRadius = 0;
            this.Btn_PrintReport1.ButtonText = "Print Report";
            this.Btn_PrintReport1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PrintReport1.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_PrintReport1.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_PrintReport1.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_PrintReport1.Iconimage")));
            this.Btn_PrintReport1.Iconimage_right = null;
            this.Btn_PrintReport1.Iconimage_right_Selected = null;
            this.Btn_PrintReport1.Iconimage_Selected = null;
            this.Btn_PrintReport1.IconMarginLeft = 0;
            this.Btn_PrintReport1.IconMarginRight = 0;
            this.Btn_PrintReport1.IconRightVisible = true;
            this.Btn_PrintReport1.IconRightZoom = 0D;
            this.Btn_PrintReport1.IconVisible = true;
            this.Btn_PrintReport1.IconZoom = 90D;
            this.Btn_PrintReport1.IsTab = false;
            this.Btn_PrintReport1.Location = new System.Drawing.Point(1042, 67);
            this.Btn_PrintReport1.Name = "Btn_PrintReport1";
            this.Btn_PrintReport1.Normalcolor = System.Drawing.Color.SteelBlue;
            this.Btn_PrintReport1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_PrintReport1.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_PrintReport1.selected = false;
            this.Btn_PrintReport1.Size = new System.Drawing.Size(141, 56);
            this.Btn_PrintReport1.TabIndex = 13;
            this.Btn_PrintReport1.Text = "Print Report";
            this.Btn_PrintReport1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_PrintReport1.Textcolor = System.Drawing.Color.White;
            this.Btn_PrintReport1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Lbl_InfoClient
            // 
            this.Lbl_InfoClient.AutoSize = true;
            this.Lbl_InfoClient.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoClient.Location = new System.Drawing.Point(139, 74);
            this.Lbl_InfoClient.Name = "Lbl_InfoClient";
            this.Lbl_InfoClient.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoClient.TabIndex = 14;
            this.Lbl_InfoClient.Text = "                                     ";
            // 
            // Lbl_InfoProject
            // 
            this.Lbl_InfoProject.AutoSize = true;
            this.Lbl_InfoProject.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoProject.Location = new System.Drawing.Point(139, 109);
            this.Lbl_InfoProject.Name = "Lbl_InfoProject";
            this.Lbl_InfoProject.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoProject.TabIndex = 15;
            this.Lbl_InfoProject.Text = "                                     ";
            // 
            // Lbl_InfoProjectNo
            // 
            this.Lbl_InfoProjectNo.AutoSize = true;
            this.Lbl_InfoProjectNo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoProjectNo.Location = new System.Drawing.Point(139, 146);
            this.Lbl_InfoProjectNo.Name = "Lbl_InfoProjectNo";
            this.Lbl_InfoProjectNo.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoProjectNo.TabIndex = 15;
            this.Lbl_InfoProjectNo.Text = "                                     ";
            // 
            // Lbl_InfoContractor
            // 
            this.Lbl_InfoContractor.AutoSize = true;
            this.Lbl_InfoContractor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoContractor.Location = new System.Drawing.Point(476, 74);
            this.Lbl_InfoContractor.Name = "Lbl_InfoContractor";
            this.Lbl_InfoContractor.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoContractor.TabIndex = 16;
            this.Lbl_InfoContractor.Text = "                                     ";
            // 
            // Lbl_InfoSupplier
            // 
            this.Lbl_InfoSupplier.AutoSize = true;
            this.Lbl_InfoSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoSupplier.Location = new System.Drawing.Point(476, 109);
            this.Lbl_InfoSupplier.Name = "Lbl_InfoSupplier";
            this.Lbl_InfoSupplier.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoSupplier.TabIndex = 17;
            this.Lbl_InfoSupplier.Text = "                                     ";
            // 
            // Lbl_InfoGeosynthetic
            // 
            this.Lbl_InfoGeosynthetic.AutoSize = true;
            this.Lbl_InfoGeosynthetic.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoGeosynthetic.Location = new System.Drawing.Point(476, 146);
            this.Lbl_InfoGeosynthetic.Name = "Lbl_InfoGeosynthetic";
            this.Lbl_InfoGeosynthetic.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoGeosynthetic.TabIndex = 15;
            this.Lbl_InfoGeosynthetic.Text = "                                     ";
            // 
            // Btn_ReturnReport
            // 
            this.Btn_ReturnReport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_ReturnReport.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_ReturnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ReturnReport.BorderRadius = 0;
            this.Btn_ReturnReport.ButtonText = "Return Report";
            this.Btn_ReturnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ReturnReport.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_ReturnReport.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_ReturnReport.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_ReturnReport.Iconimage")));
            this.Btn_ReturnReport.Iconimage_right = null;
            this.Btn_ReturnReport.Iconimage_right_Selected = null;
            this.Btn_ReturnReport.Iconimage_Selected = null;
            this.Btn_ReturnReport.IconMarginLeft = 0;
            this.Btn_ReturnReport.IconMarginRight = 0;
            this.Btn_ReturnReport.IconRightVisible = true;
            this.Btn_ReturnReport.IconRightZoom = 0D;
            this.Btn_ReturnReport.IconVisible = true;
            this.Btn_ReturnReport.IconZoom = 90D;
            this.Btn_ReturnReport.IsTab = false;
            this.Btn_ReturnReport.Location = new System.Drawing.Point(1042, 129);
            this.Btn_ReturnReport.Name = "Btn_ReturnReport";
            this.Btn_ReturnReport.Normalcolor = System.Drawing.Color.SteelBlue;
            this.Btn_ReturnReport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_ReturnReport.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_ReturnReport.selected = false;
            this.Btn_ReturnReport.Size = new System.Drawing.Size(141, 56);
            this.Btn_ReturnReport.TabIndex = 18;
            this.Btn_ReturnReport.Text = "Return Report";
            this.Btn_ReturnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ReturnReport.Textcolor = System.Drawing.Color.White;
            this.Btn_ReturnReport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Lbl_InfoMachineNo
            // 
            this.Lbl_InfoMachineNo.AutoSize = true;
            this.Lbl_InfoMachineNo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoMachineNo.Location = new System.Drawing.Point(820, 110);
            this.Lbl_InfoMachineNo.Name = "Lbl_InfoMachineNo";
            this.Lbl_InfoMachineNo.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoMachineNo.TabIndex = 24;
            this.Lbl_InfoMachineNo.Text = "                                     ";
            // 
            // Lbl_InfoOperator
            // 
            this.Lbl_InfoOperator.AutoSize = true;
            this.Lbl_InfoOperator.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoOperator.Location = new System.Drawing.Point(820, 75);
            this.Lbl_InfoOperator.Name = "Lbl_InfoOperator";
            this.Lbl_InfoOperator.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoOperator.TabIndex = 23;
            this.Lbl_InfoOperator.Text = "                                     ";
            // 
            // Lbl_MachineNo
            // 
            this.Lbl_MachineNo.AutoSize = true;
            this.Lbl_MachineNo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_MachineNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MachineNo.Location = new System.Drawing.Point(704, 113);
            this.Lbl_MachineNo.Name = "Lbl_MachineNo";
            this.Lbl_MachineNo.Size = new System.Drawing.Size(110, 21);
            this.Lbl_MachineNo.TabIndex = 21;
            this.Lbl_MachineNo.Text = "Machine No. :";
            // 
            // Lbl_Operator
            // 
            this.Lbl_Operator.AutoSize = true;
            this.Lbl_Operator.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lbl_Operator.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Operator.Location = new System.Drawing.Point(704, 78);
            this.Lbl_Operator.Name = "Lbl_Operator";
            this.Lbl_Operator.Size = new System.Drawing.Size(85, 21);
            this.Lbl_Operator.TabIndex = 20;
            this.Lbl_Operator.Text = "Operator :";
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
            // Temp
            // 
            this.Temp.HeaderText = "Temp.";
            this.Temp.Name = "Temp";
            this.Temp.ReadOnly = true;
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
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
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1195, 725);
            this.Controls.Add(this.Lbl_InfoMachineNo);
            this.Controls.Add(this.Lbl_InfoOperator);
            this.Controls.Add(this.Lbl_MachineNo);
            this.Controls.Add(this.Lbl_Operator);
            this.Controls.Add(this.Btn_ReturnReport);
            this.Controls.Add(this.Lbl_InfoGeosynthetic);
            this.Controls.Add(this.Lbl_InfoSupplier);
            this.Controls.Add(this.Lbl_InfoContractor);
            this.Controls.Add(this.Lbl_InfoProjectNo);
            this.Controls.Add(this.Lbl_InfoProject);
            this.Controls.Add(this.Lbl_InfoClient);
            this.Controls.Add(this.Btn_PrintReport1);
            this.Controls.Add(this.Lbl_Geosynthetic);
            this.Controls.Add(this.Lbl_Supplier);
            this.Controls.Add(this.Lbl_Contractor);
            this.Controls.Add(this.Lbl_ProjectNo);
            this.Controls.Add(this.Lbl_Project);
            this.Controls.Add(this.Lbl_Client);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report2";
            this.Text = "Report";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
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
        private ns1.BunifuCustomLabel Lbl_Geosynthetic;
        private ns1.BunifuCustomLabel Lbl_Supplier;
        private ns1.BunifuCustomLabel Lbl_Contractor;
        private ns1.BunifuCustomLabel Lbl_ProjectNo;
        private ns1.BunifuCustomLabel Lbl_Project;
        private ns1.BunifuCustomLabel Lbl_Client;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomDataGrid DGV1;
        private ns1.BunifuFlatButton Btn_PrintReport1;
        private ns1.BunifuCustomLabel Lbl_InfoClient;
        private ns1.BunifuCustomLabel Lbl_InfoGeosynthetic;
        private ns1.BunifuCustomLabel Lbl_InfoSupplier;
        private ns1.BunifuCustomLabel Lbl_InfoContractor;
        private ns1.BunifuCustomLabel Lbl_InfoProjectNo;
        private ns1.BunifuCustomLabel Lbl_InfoProject;
        private ns1.BunifuFlatButton Btn_ReturnReport;
        private ns1.BunifuCustomLabel Lbl_InfoMachineNo;
        private ns1.BunifuCustomLabel Lbl_InfoOperator;
        private ns1.BunifuCustomLabel Lbl_MachineNo;
        private ns1.BunifuCustomLabel Lbl_Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seaming_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seam_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seam_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seam_Lenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carry_Over;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destructive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reamarks_Destructive;
    }
}