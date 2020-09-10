namespace Grap.Principal
{
    partial class Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
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
            this.Deployment_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Widht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_InfoClient = new ns1.BunifuCustomLabel();
            this.Lbl_InfoProject = new ns1.BunifuCustomLabel();
            this.Lbl_InfoProjectNo = new ns1.BunifuCustomLabel();
            this.Lbl_InfoContractor = new ns1.BunifuCustomLabel();
            this.Lbl_InfoSupplier = new ns1.BunifuCustomLabel();
            this.Lbl_InfoGeosynthetic = new ns1.BunifuCustomLabel();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.BackgroundColor = System.Drawing.Color.White;
            this.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.Lbl_Client.Location = new System.Drawing.Point(246, 77);
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
            this.Lbl_Project.Location = new System.Drawing.Point(246, 112);
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
            this.Lbl_ProjectNo.Location = new System.Drawing.Point(246, 149);
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
            this.Lbl_Contractor.Location = new System.Drawing.Point(618, 77);
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
            this.Lbl_Supplier.Location = new System.Drawing.Point(618, 112);
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
            this.Lbl_Geosynthetic.Location = new System.Drawing.Point(618, 149);
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
            // Lbl_InfoClient
            // 
            this.Lbl_InfoClient.AutoSize = true;
            this.Lbl_InfoClient.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoClient.Location = new System.Drawing.Point(351, 74);
            this.Lbl_InfoClient.Name = "Lbl_InfoClient";
            this.Lbl_InfoClient.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoClient.TabIndex = 14;
            this.Lbl_InfoClient.Text = "                                     ";
            // 
            // Lbl_InfoProject
            // 
            this.Lbl_InfoProject.AutoSize = true;
            this.Lbl_InfoProject.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoProject.Location = new System.Drawing.Point(351, 109);
            this.Lbl_InfoProject.Name = "Lbl_InfoProject";
            this.Lbl_InfoProject.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoProject.TabIndex = 15;
            this.Lbl_InfoProject.Text = "                                     ";
            // 
            // Lbl_InfoProjectNo
            // 
            this.Lbl_InfoProjectNo.AutoSize = true;
            this.Lbl_InfoProjectNo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoProjectNo.Location = new System.Drawing.Point(351, 146);
            this.Lbl_InfoProjectNo.Name = "Lbl_InfoProjectNo";
            this.Lbl_InfoProjectNo.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoProjectNo.TabIndex = 15;
            this.Lbl_InfoProjectNo.Text = "                                     ";
            // 
            // Lbl_InfoContractor
            // 
            this.Lbl_InfoContractor.AutoSize = true;
            this.Lbl_InfoContractor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoContractor.Location = new System.Drawing.Point(734, 74);
            this.Lbl_InfoContractor.Name = "Lbl_InfoContractor";
            this.Lbl_InfoContractor.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoContractor.TabIndex = 16;
            this.Lbl_InfoContractor.Text = "                                     ";
            // 
            // Lbl_InfoSupplier
            // 
            this.Lbl_InfoSupplier.AutoSize = true;
            this.Lbl_InfoSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoSupplier.Location = new System.Drawing.Point(734, 109);
            this.Lbl_InfoSupplier.Name = "Lbl_InfoSupplier";
            this.Lbl_InfoSupplier.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoSupplier.TabIndex = 17;
            this.Lbl_InfoSupplier.Text = "                                     ";
            // 
            // Lbl_InfoGeosynthetic
            // 
            this.Lbl_InfoGeosynthetic.AutoSize = true;
            this.Lbl_InfoGeosynthetic.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoGeosynthetic.Location = new System.Drawing.Point(734, 146);
            this.Lbl_InfoGeosynthetic.Name = "Lbl_InfoGeosynthetic";
            this.Lbl_InfoGeosynthetic.Size = new System.Drawing.Size(197, 25);
            this.Lbl_InfoGeosynthetic.TabIndex = 15;
            this.Lbl_InfoGeosynthetic.Text = "                                     ";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Next Report";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1042, 129);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.SteelBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(141, 56);
            this.bunifuFlatButton1.TabIndex = 18;
            this.bunifuFlatButton1.Text = "Next Report";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1195, 725);
            this.Controls.Add(this.bunifuFlatButton1);
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
            this.Name = "Report";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Deployment_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Panel_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn Widht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private ns1.BunifuCustomLabel Lbl_InfoClient;
        private ns1.BunifuCustomLabel Lbl_InfoGeosynthetic;
        private ns1.BunifuCustomLabel Lbl_InfoSupplier;
        private ns1.BunifuCustomLabel Lbl_InfoContractor;
        private ns1.BunifuCustomLabel Lbl_InfoProjectNo;
        private ns1.BunifuCustomLabel Lbl_InfoProject;
        private ns1.BunifuFlatButton bunifuFlatButton1;
    }
}