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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblClient = new MetroFramework.Controls.MetroLabel();
            this.LblProjectNo = new MetroFramework.Controls.MetroLabel();
            this.LblProject = new MetroFramework.Controls.MetroLabel();
            this.LblContractor = new MetroFramework.Controls.MetroLabel();
            this.LblGeoSynthetic = new MetroFramework.Controls.MetroLabel();
            this.LblSupplier = new MetroFramework.Controls.MetroLabel();
            this.PBPicture = new System.Windows.Forms.PictureBox();
            this.LblTitle = new MetroFramework.Controls.MetroLabel();
            this.PanelAdd = new MetroFramework.Controls.MetroPanel();
            this.BtnData = new FontAwesome.Sharp.IconButton();
            this.BtnDrawing = new FontAwesome.Sharp.IconButton();
            this.SeamingButton = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.BtnEdit = new FontAwesome.Sharp.IconButton();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.BtnPDF = new MetroFramework.Controls.MetroButton();
            this.PanelHeader = new MetroFramework.Controls.MetroPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVDev = new System.Windows.Forms.DataGridView();
            this.BElipse = new ns1.BunifuElipse(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeploymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thickness = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDevId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBPicture)).BeginInit();
            this.PanelAdd.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developmentBindingSource)).BeginInit();
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
            this.LblContractor.Location = new System.Drawing.Point(458, 13);
            this.LblContractor.Name = "LblContractor";
            this.LblContractor.Size = new System.Drawing.Size(97, 25);
            this.LblContractor.TabIndex = 0;
            this.LblContractor.Text = "Contractor:";
            // 
            // LblGeoSynthetic
            // 
            this.LblGeoSynthetic.AutoSize = true;
            this.LblGeoSynthetic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblGeoSynthetic.Location = new System.Drawing.Point(442, 90);
            this.LblGeoSynthetic.Name = "LblGeoSynthetic";
            this.LblGeoSynthetic.Size = new System.Drawing.Size(113, 25);
            this.LblGeoSynthetic.TabIndex = 0;
            this.LblGeoSynthetic.Text = "Geosynthetic:";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblSupplier.Location = new System.Drawing.Point(476, 52);
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
            // PanelAdd
            // 
            this.PanelAdd.Controls.Add(this.BtnData);
            this.PanelAdd.Controls.Add(this.BtnDrawing);
            this.PanelAdd.Controls.Add(this.SeamingButton);
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
            // BtnData
            // 
            this.BtnData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnData.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnData.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnData.IconColor = System.Drawing.Color.Black;
            this.BtnData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnData.IconSize = 48;
            this.BtnData.Location = new System.Drawing.Point(991, 27);
            this.BtnData.Name = "BtnData";
            this.BtnData.Rotation = 0D;
            this.BtnData.Size = new System.Drawing.Size(153, 58);
            this.BtnData.TabIndex = 16;
            this.BtnData.Text = "Inspector";
            this.BtnData.UseVisualStyleBackColor = false;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // BtnDrawing
            // 
            this.BtnDrawing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnDrawing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDrawing.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDrawing.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrawing.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnDrawing.IconColor = System.Drawing.Color.Black;
            this.BtnDrawing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDrawing.IconSize = 48;
            this.BtnDrawing.Location = new System.Drawing.Point(832, 27);
            this.BtnDrawing.Name = "BtnDrawing";
            this.BtnDrawing.Rotation = 0D;
            this.BtnDrawing.Size = new System.Drawing.Size(153, 58);
            this.BtnDrawing.TabIndex = 16;
            this.BtnDrawing.Text = "Drawing";
            this.BtnDrawing.UseVisualStyleBackColor = false;
            this.BtnDrawing.Click += new System.EventHandler(this.BtnDrawing_Click);
            // 
            // SeamingButton
            // 
            this.SeamingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.SeamingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeamingButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SeamingButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeamingButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SeamingButton.IconColor = System.Drawing.Color.Black;
            this.SeamingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SeamingButton.IconSize = 48;
            this.SeamingButton.Location = new System.Drawing.Point(661, 27);
            this.SeamingButton.Name = "SeamingButton";
            this.SeamingButton.Rotation = 0D;
            this.SeamingButton.Size = new System.Drawing.Size(153, 58);
            this.SeamingButton.TabIndex = 16;
            this.SeamingButton.Text = "Seaming";
            this.SeamingButton.UseVisualStyleBackColor = false;
            this.SeamingButton.Click += new System.EventHandler(this.SeamingButton_Click);
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
            this.BtnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPDF.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnPDF.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnPDF.Location = new System.Drawing.Point(1190, 27);
            this.BtnPDF.Name = "BtnPDF";
            this.BtnPDF.Size = new System.Drawing.Size(163, 58);
            this.BtnPDF.TabIndex = 11;
            this.BtnPDF.Text = "Report";
            this.BtnPDF.UseSelectable = true;
            this.BtnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.BtnClose);
            this.PanelHeader.Controls.Add(this.PBPicture);
            this.PanelHeader.Controls.Add(this.LblClient);
            this.PanelHeader.Controls.Add(this.LblProjectNo);
            this.PanelHeader.Controls.Add(this.LblProject);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVDev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 435);
            this.panel1.TabIndex = 20;
            // 
            // DGVDev
            // 
            this.DGVDev.AutoGenerateColumns = false;
            this.DGVDev.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DeploymentDate,
            this.PanelNo,
            this.RollNo,
            this.Lenght,
            this.Width,
            this.Thickness,
            this.Area,
            this.Remarks,
            this.ProjectDevId,
            this.ProjectDev});
            this.DGVDev.DataSource = this.developmentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDev.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDev.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVDev.Location = new System.Drawing.Point(0, 0);
            this.DGVDev.Name = "DGVDev";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDev.Size = new System.Drawing.Size(1386, 435);
            this.DGVDev.TabIndex = 0;
            this.DGVDev.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDev_CellValidated);
            // 
            // BElipse
            // 
            this.BElipse.ElipseRadius = 5;
            this.BElipse.TargetControl = this;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // DeploymentDate
            // 
            this.DeploymentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeploymentDate.DataPropertyName = "DeploymentDate";
            this.DeploymentDate.HeaderText = "DeploymentDate";
            this.DeploymentDate.Name = "DeploymentDate";
            this.DeploymentDate.ReadOnly = true;
            // 
            // PanelNo
            // 
            this.PanelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PanelNo.DataPropertyName = "PanelNo";
            this.PanelNo.HeaderText = "PanelNo";
            this.PanelNo.Name = "PanelNo";
            // 
            // RollNo
            // 
            this.RollNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RollNo.DataPropertyName = "RollNo";
            this.RollNo.HeaderText = "RollNo";
            this.RollNo.Name = "RollNo";
            // 
            // Lenght
            // 
            this.Lenght.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lenght.DataPropertyName = "Lenght";
            this.Lenght.HeaderText = "Lenght";
            this.Lenght.Name = "Lenght";
            // 
            // Width
            // 
            this.Width.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Width.DataPropertyName = "Width";
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            // 
            // Thickness
            // 
            this.Thickness.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thickness.DataPropertyName = "Thickness";
            this.Thickness.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Thickness.HeaderText = "Thickness";
            this.Thickness.Items.AddRange(new object[] {
            "40 mil",
            "60 mil",
            "80 mil"});
            this.Thickness.Name = "Thickness";
            this.Thickness.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thickness.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Thickness.ToolTipText = "Thickness";
            // 
            // Area
            // 
            this.Area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Area.DataPropertyName = "Area";
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            // 
            // ProjectDevId
            // 
            this.ProjectDevId.DataPropertyName = "ProjectDevId";
            this.ProjectDevId.HeaderText = "ProjectDevId";
            this.ProjectDevId.Name = "ProjectDevId";
            this.ProjectDevId.Visible = false;
            // 
            // ProjectDev
            // 
            this.ProjectDev.DataPropertyName = "ProjectDev";
            this.ProjectDev.HeaderText = "ProjectDev";
            this.ProjectDev.Name = "ProjectDev";
            this.ProjectDev.Visible = false;
            // 
            // developmentBindingSource
            // 
            this.developmentBindingSource.DataSource = typeof(Mine.DataModel.Development);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevelopmentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DevelopmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBPicture)).EndInit();
            this.PanelAdd.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developmentBindingSource)).EndInit();
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
        private MetroFramework.Controls.MetroPanel PanelAdd;
        private MetroFramework.Controls.MetroButton BtnPDF;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton BtnEdit;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private MetroFramework.Controls.MetroPanel PanelHeader;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuElipse BElipse;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.DataGridView DGVDev;
        private FontAwesome.Sharp.IconButton SeamingButton;
        private FontAwesome.Sharp.IconButton BtnDrawing;
        private FontAwesome.Sharp.IconButton BtnData;
        private System.Windows.Forms.BindingSource developmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeploymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PanelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewComboBoxColumn Thickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDevId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDev;
    }
}