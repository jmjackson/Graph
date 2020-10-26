namespace Mine.Views
{
    partial class DevelopmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevelopmentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblClient = new MetroFramework.Controls.MetroLabel();
            this.LblProjectNo = new MetroFramework.Controls.MetroLabel();
            this.LblProject = new MetroFramework.Controls.MetroLabel();
            this.LblContractor = new MetroFramework.Controls.MetroLabel();
            this.LblGeoSynthetic = new MetroFramework.Controls.MetroLabel();
            this.LblSupplier = new MetroFramework.Controls.MetroLabel();
            this.PBPicture = new System.Windows.Forms.PictureBox();
            this.LblTitle = new MetroFramework.Controls.MetroLabel();
            this.DGVDev = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeploymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelAdd = new MetroFramework.Controls.MetroPanel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.BtnEdit = new FontAwesome.Sharp.IconButton();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.BtnPDF = new MetroFramework.Controls.MetroButton();
            this.TxtDate = new MetroFramework.Controls.MetroDateTime();
            this.LblRClient = new MetroFramework.Controls.MetroLabel();
            this.LblRProject = new MetroFramework.Controls.MetroLabel();
            this.LblRProjectNo = new MetroFramework.Controls.MetroLabel();
            this.LblRContractor = new MetroFramework.Controls.MetroLabel();
            this.LblRSupplier = new MetroFramework.Controls.MetroLabel();
            this.LblRGeosyntetic = new MetroFramework.Controls.MetroLabel();
            this.PanelHeader = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BElipse = new ns1.BunifuElipse(this.components);
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.PBPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).BeginInit();
            this.PanelAdd.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblClient
            // 
            this.LblClient.AutoSize = true;
            this.LblClient.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblClient.Location = new System.Drawing.Point(45, 13);
            this.LblClient.Name = "LblClient";
            this.LblClient.Size = new System.Drawing.Size(59, 25);
            this.LblClient.TabIndex = 0;
            this.LblClient.Text = "Client:";
            // 
            // LblProjectNo
            // 
            this.LblProjectNo.AutoSize = true;
            this.LblProjectNo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblProjectNo.Location = new System.Drawing.Point(8, 90);
            this.LblProjectNo.Name = "LblProjectNo";
            this.LblProjectNo.Size = new System.Drawing.Size(96, 25);
            this.LblProjectNo.TabIndex = 0;
            this.LblProjectNo.Text = "Project No:";
            // 
            // LblProject
            // 
            this.LblProject.AutoSize = true;
            this.LblProject.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblProject.Location = new System.Drawing.Point(31, 52);
            this.LblProject.Name = "LblProject";
            this.LblProject.Size = new System.Drawing.Size(68, 25);
            this.LblProject.TabIndex = 0;
            this.LblProject.Text = "Project:";
            // 
            // LblContractor
            // 
            this.LblContractor.AutoSize = true;
            this.LblContractor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblContractor.Location = new System.Drawing.Point(363, 13);
            this.LblContractor.Name = "LblContractor";
            this.LblContractor.Size = new System.Drawing.Size(97, 25);
            this.LblContractor.TabIndex = 0;
            this.LblContractor.Text = "Contractor:";
            // 
            // LblGeoSynthetic
            // 
            this.LblGeoSynthetic.AutoSize = true;
            this.LblGeoSynthetic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblGeoSynthetic.Location = new System.Drawing.Point(347, 90);
            this.LblGeoSynthetic.Name = "LblGeoSynthetic";
            this.LblGeoSynthetic.Size = new System.Drawing.Size(113, 25);
            this.LblGeoSynthetic.TabIndex = 0;
            this.LblGeoSynthetic.Text = "Geosynthetic:";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblSupplier.Location = new System.Drawing.Point(381, 52);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(79, 25);
            this.LblSupplier.TabIndex = 0;
            this.LblSupplier.Text = "Supplier:";
            // 
            // PBPicture
            // 
            this.PBPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBPicture.Image = ((System.Drawing.Image)(resources.GetObject("PBPicture.Image")));
            this.PBPicture.Location = new System.Drawing.Point(973, 14);
            this.PBPicture.Name = "PBPicture";
            this.PBPicture.Size = new System.Drawing.Size(221, 57);
            this.PBPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPicture.TabIndex = 1;
            this.PBPicture.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitle.AutoSize = true;
            this.LblTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblTitle.Location = new System.Drawing.Point(558, 14);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(152, 25);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "Deployment Log";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DGVDev
            // 
            this.DGVDev.AllowUserToResizeRows = false;
            this.DGVDev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDev.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVDev.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DeploymentDate,
            this.PanelNo,
            this.RollNo,
            this.Length,
            this.Width,
            this.Thickness,
            this.Area,
            this.Remarks});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDev.DefaultCellStyle = dataGridViewCellStyle11;
            this.DGVDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDev.EnableHeadersVisualStyles = false;
            this.DGVDev.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVDev.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVDev.Location = new System.Drawing.Point(0, 0);
            this.DGVDev.Name = "DGVDev";
            this.DGVDev.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGVDev.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVDev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDev.Size = new System.Drawing.Size(1386, 435);
            this.DGVDev.Style = MetroFramework.MetroColorStyle.Blue;
            this.DGVDev.TabIndex = 5;
            this.DGVDev.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Id
            // 
            this.Id.HeaderText = "Item";
            this.Id.Name = "Id";
            // 
            // DeploymentDate
            // 
            this.DeploymentDate.FillWeight = 94.8718F;
            this.DeploymentDate.HeaderText = "Deployment Date";
            this.DeploymentDate.Name = "DeploymentDate";
            this.DeploymentDate.Width = 150;
            // 
            // PanelNo
            // 
            this.PanelNo.FillWeight = 162.4365F;
            this.PanelNo.HeaderText = "Panel No";
            this.PanelNo.Name = "PanelNo";
            this.PanelNo.Width = 80;
            // 
            // RollNo
            // 
            this.RollNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RollNo.FillWeight = 68.33269F;
            this.RollNo.HeaderText = "Roll No";
            this.RollNo.Name = "RollNo";
            // 
            // Length
            // 
            this.Length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Length.FillWeight = 94.8718F;
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            // 
            // Width
            // 
            this.Width.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Width.FillWeight = 94.8718F;
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            // 
            // Thickness
            // 
            this.Thickness.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thickness.FillWeight = 94.8718F;
            this.Thickness.HeaderText = "Thickness";
            this.Thickness.Name = "Thickness";
            // 
            // Area
            // 
            this.Area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Area.FillWeight = 94.8718F;
            this.Area.HeaderText = "Area (ft)";
            this.Area.Name = "Area";
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarks.FillWeight = 94.8718F;
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            // 
            // PanelAdd
            // 
            this.PanelAdd.Controls.Add(this.iconButton3);
            this.PanelAdd.Controls.Add(this.BtnEdit);
            this.PanelAdd.Controls.Add(this.BtnAdd);
            this.PanelAdd.Controls.Add(this.BtnPDF);
            this.PanelAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelAdd.ForeColor = System.Drawing.Color.White;
            this.PanelAdd.HorizontalScrollbarBarColor = true;
            this.PanelAdd.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelAdd.HorizontalScrollbarSize = 10;
            this.PanelAdd.Location = new System.Drawing.Point(0, 574);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(1386, 119);
            this.PanelAdd.TabIndex = 17;
            this.PanelAdd.VerticalScrollbarBarColor = true;
            this.PanelAdd.VerticalScrollbarHighlightOnWheel = false;
            this.PanelAdd.VerticalScrollbarSize = 10;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 48;
            this.iconButton3.Location = new System.Drawing.Point(402, 27);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(153, 58);
            this.iconButton3.TabIndex = 15;
            this.iconButton3.Text = "Delete";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEdit.IconColor = System.Drawing.Color.Black;
            this.BtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEdit.IconSize = 48;
            this.BtnEdit.Location = new System.Drawing.Point(234, 27);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Rotation = 0D;
            this.BtnEdit.Size = new System.Drawing.Size(153, 58);
            this.BtnEdit.TabIndex = 15;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAdd.IconColor = System.Drawing.Color.Black;
            this.BtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdd.IconSize = 48;
            this.BtnAdd.Location = new System.Drawing.Point(61, 27);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Rotation = 0D;
            this.BtnAdd.Size = new System.Drawing.Size(153, 58);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnPDF
            // 
            this.BtnPDF.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnPDF.Location = new System.Drawing.Point(1055, 27);
            this.BtnPDF.Name = "BtnPDF";
            this.BtnPDF.Size = new System.Drawing.Size(163, 58);
            this.BtnPDF.TabIndex = 11;
            this.BtnPDF.Text = "BtnPDF";
            this.BtnPDF.UseSelectable = true;
            this.BtnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // TxtDate
            // 
            this.TxtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDate.Location = new System.Drawing.Point(947, 86);
            this.TxtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(328, 29);
            this.TxtDate.TabIndex = 15;
            // 
            // LblRClient
            // 
            this.LblRClient.AutoSize = true;
            this.LblRClient.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblRClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRClient.Location = new System.Drawing.Point(180, 12);
            this.LblRClient.Name = "LblRClient";
            this.LblRClient.Size = new System.Drawing.Size(60, 25);
            this.LblRClient.TabIndex = 18;
            this.LblRClient.Text = "Metro";
            // 
            // LblRProject
            // 
            this.LblRProject.AutoSize = true;
            this.LblRProject.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblRProject.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRProject.Location = new System.Drawing.Point(180, 52);
            this.LblRProject.Name = "LblRProject";
            this.LblRProject.Size = new System.Drawing.Size(60, 25);
            this.LblRProject.TabIndex = 18;
            this.LblRProject.Text = "Metro";
            // 
            // LblRProjectNo
            // 
            this.LblRProjectNo.AutoSize = true;
            this.LblRProjectNo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblRProjectNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRProjectNo.Location = new System.Drawing.Point(179, 90);
            this.LblRProjectNo.Name = "LblRProjectNo";
            this.LblRProjectNo.Size = new System.Drawing.Size(60, 25);
            this.LblRProjectNo.TabIndex = 18;
            this.LblRProjectNo.Text = "Metro";
            // 
            // LblRContractor
            // 
            this.LblRContractor.AutoSize = true;
            this.LblRContractor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblRContractor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRContractor.Location = new System.Drawing.Point(566, 13);
            this.LblRContractor.Name = "LblRContractor";
            this.LblRContractor.Size = new System.Drawing.Size(60, 25);
            this.LblRContractor.TabIndex = 18;
            this.LblRContractor.Text = "Metro";
            // 
            // LblRSupplier
            // 
            this.LblRSupplier.AutoSize = true;
            this.LblRSupplier.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblRSupplier.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRSupplier.Location = new System.Drawing.Point(566, 52);
            this.LblRSupplier.Name = "LblRSupplier";
            this.LblRSupplier.Size = new System.Drawing.Size(60, 25);
            this.LblRSupplier.TabIndex = 18;
            this.LblRSupplier.Text = "Metro";
            // 
            // LblRGeosyntetic
            // 
            this.LblRGeosyntetic.AutoSize = true;
            this.LblRGeosyntetic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblRGeosyntetic.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRGeosyntetic.Location = new System.Drawing.Point(566, 90);
            this.LblRGeosyntetic.Name = "LblRGeosyntetic";
            this.LblRGeosyntetic.Size = new System.Drawing.Size(60, 25);
            this.LblRGeosyntetic.TabIndex = 18;
            this.LblRGeosyntetic.Text = "Metro";
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.BtnClose);
            this.PanelHeader.Controls.Add(this.LblRGeosyntetic);
            this.PanelHeader.Controls.Add(this.LblRContractor);
            this.PanelHeader.Controls.Add(this.TxtDate);
            this.PanelHeader.Controls.Add(this.LblRSupplier);
            this.PanelHeader.Controls.Add(this.PBPicture);
            this.PanelHeader.Controls.Add(this.LblClient);
            this.PanelHeader.Controls.Add(this.LblRProjectNo);
            this.PanelHeader.Controls.Add(this.LblProjectNo);
            this.PanelHeader.Controls.Add(this.LblProject);
            this.PanelHeader.Controls.Add(this.LblRProject);
            this.PanelHeader.Controls.Add(this.LblRClient);
            this.PanelHeader.Controls.Add(this.LblContractor);
            this.PanelHeader.Controls.Add(this.LblSupplier);
            this.PanelHeader.Controls.Add(this.LblGeoSynthetic);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.HorizontalScrollbarBarColor = true;
            this.PanelHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelHeader.HorizontalScrollbarSize = 10;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1386, 139);
            this.PanelHeader.TabIndex = 19;
            this.PanelHeader.VerticalScrollbarBarColor = true;
            this.PanelHeader.VerticalScrollbarHighlightOnWheel = false;
            this.PanelHeader.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVDev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 435);
            this.panel1.TabIndex = 20;
            // 
            // BElipse
            // 
            this.BElipse.ElipseRadius = 5;
            this.BElipse.TargetControl = this;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnClose.IconColor = System.Drawing.Color.Red;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnClose.IconSize = 36;
            this.BtnClose.Location = new System.Drawing.Point(1345, 9);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(32, 33);
            this.BtnClose.TabIndex = 19;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DevelopmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 693);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevelopmentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DevelopmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).EndInit();
            this.PanelAdd.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblClient;
        private MetroFramework.Controls.MetroLabel LblProjectNo;
        private MetroFramework.Controls.MetroLabel LblProject;
        private MetroFramework.Controls.MetroLabel LblContractor;
        private MetroFramework.Controls.MetroLabel LblGeoSynthetic;
        private MetroFramework.Controls.MetroLabel LblSupplier;
        private System.Windows.Forms.PictureBox PBPicture;
        private MetroFramework.Controls.MetroLabel LblTitle;
        private MetroFramework.Controls.MetroGrid DGVDev;
        private MetroFramework.Controls.MetroPanel PanelAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeploymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PanelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private MetroFramework.Controls.MetroButton BtnPDF;
        private MetroFramework.Controls.MetroDateTime TxtDate;
        private MetroFramework.Controls.MetroLabel LblRClient;
        private MetroFramework.Controls.MetroLabel LblRProject;
        private MetroFramework.Controls.MetroLabel LblRProjectNo;
        private MetroFramework.Controls.MetroLabel LblRContractor;
        private MetroFramework.Controls.MetroLabel LblRSupplier;
        private MetroFramework.Controls.MetroLabel LblRGeosyntetic;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton BtnEdit;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private MetroFramework.Controls.MetroPanel PanelHeader;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuElipse BElipse;
        private FontAwesome.Sharp.IconButton BtnClose;
    }
}