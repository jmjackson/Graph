namespace Mine.Views
{
    partial class GeomembraneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeomembraneForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblClient = new MetroFramework.Controls.MetroLabel();
            this.LblProject = new MetroFramework.Controls.MetroLabel();
            this.LblProjectNo = new MetroFramework.Controls.MetroLabel();
            this.MetroClient = new MetroFramework.Controls.MetroLabel();
            this.MetroProject = new MetroFramework.Controls.MetroLabel();
            this.MetroProjectNo = new MetroFramework.Controls.MetroLabel();
            this.LblContractor = new MetroFramework.Controls.MetroLabel();
            this.LblSupplier = new MetroFramework.Controls.MetroLabel();
            this.LblGeosynthetic = new MetroFramework.Controls.MetroLabel();
            this.MetroContractor = new MetroFramework.Controls.MetroLabel();
            this.MetroSupplier = new MetroFramework.Controls.MetroLabel();
            this.MetroGeosynthetic = new MetroFramework.Controls.MetroLabel();
            this.LblOperator = new MetroFramework.Controls.MetroLabel();
            this.LblMachine = new MetroFramework.Controls.MetroLabel();
            this.MetroOperator = new MetroFramework.Controls.MetroLabel();
            this.MetroMachineNo = new MetroFramework.Controls.MetroLabel();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnAdd = new MetroFramework.Controls.MetroButton();
            this.BtnEdit = new MetroFramework.Controls.MetroButton();
            this.BtnPdf = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.PanelHead = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.PanelFoot = new System.Windows.Forms.Panel();
            this.BtnData = new MetroFramework.Controls.MetroButton();
            this.BtnDrawing = new MetroFramework.Controls.MetroButton();
            this.DeploymentBtn = new MetroFramework.Controls.MetroButton();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.DGVGeo = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeamingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeamNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeamTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WedgeTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WedgeSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeamLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarryOver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destructive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarksDestructive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDevId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projectdev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geoMembraneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.PanelHead.SuspendLayout();
            this.PanelFoot.SuspendLayout();
            this.PanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoMembraneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblClient
            // 
            this.LblClient.AutoSize = true;
            this.LblClient.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblClient.Location = new System.Drawing.Point(4, 8);
            this.LblClient.Name = "LblClient";
            this.LblClient.Size = new System.Drawing.Size(64, 25);
            this.LblClient.TabIndex = 0;
            this.LblClient.Text = "Client :";
            // 
            // LblProject
            // 
            this.LblProject.AutoSize = true;
            this.LblProject.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblProject.Location = new System.Drawing.Point(4, 51);
            this.LblProject.Name = "LblProject";
            this.LblProject.Size = new System.Drawing.Size(73, 25);
            this.LblProject.TabIndex = 0;
            this.LblProject.Text = "Project :";
            // 
            // LblProjectNo
            // 
            this.LblProjectNo.AutoSize = true;
            this.LblProjectNo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblProjectNo.Location = new System.Drawing.Point(4, 88);
            this.LblProjectNo.Name = "LblProjectNo";
            this.LblProjectNo.Size = new System.Drawing.Size(101, 25);
            this.LblProjectNo.TabIndex = 0;
            this.LblProjectNo.Text = "Project No :";
            // 
            // MetroClient
            // 
            this.MetroClient.AutoSize = true;
            this.MetroClient.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MetroClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MetroClient.Location = new System.Drawing.Point(234, 5);
            this.MetroClient.Name = "MetroClient";
            this.MetroClient.Size = new System.Drawing.Size(60, 25);
            this.MetroClient.TabIndex = 0;
            this.MetroClient.Text = "Metro";
            // 
            // MetroProject
            // 
            this.MetroProject.AutoSize = true;
            this.MetroProject.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MetroProject.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MetroProject.Location = new System.Drawing.Point(234, 51);
            this.MetroProject.Name = "MetroProject";
            this.MetroProject.Size = new System.Drawing.Size(60, 25);
            this.MetroProject.TabIndex = 0;
            this.MetroProject.Text = "Metro";
            // 
            // MetroProjectNo
            // 
            this.MetroProjectNo.AutoSize = true;
            this.MetroProjectNo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MetroProjectNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MetroProjectNo.Location = new System.Drawing.Point(234, 85);
            this.MetroProjectNo.Name = "MetroProjectNo";
            this.MetroProjectNo.Size = new System.Drawing.Size(60, 25);
            this.MetroProjectNo.TabIndex = 0;
            this.MetroProjectNo.Text = "Metro";
            // 
            // LblContractor
            // 
            this.LblContractor.AutoSize = true;
            this.LblContractor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblContractor.Location = new System.Drawing.Point(437, 8);
            this.LblContractor.Name = "LblContractor";
            this.LblContractor.Size = new System.Drawing.Size(101, 25);
            this.LblContractor.TabIndex = 0;
            this.LblContractor.Text = "Contractor :";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblSupplier.Location = new System.Drawing.Point(437, 51);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(83, 25);
            this.LblSupplier.TabIndex = 0;
            this.LblSupplier.Text = "Supplier :";
            // 
            // LblGeosynthetic
            // 
            this.LblGeosynthetic.AutoSize = true;
            this.LblGeosynthetic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblGeosynthetic.Location = new System.Drawing.Point(437, 88);
            this.LblGeosynthetic.Name = "LblGeosynthetic";
            this.LblGeosynthetic.Size = new System.Drawing.Size(118, 25);
            this.LblGeosynthetic.TabIndex = 0;
            this.LblGeosynthetic.Text = "Geosynthetic :";
            // 
            // MetroContractor
            // 
            this.MetroContractor.AutoSize = true;
            this.MetroContractor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MetroContractor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MetroContractor.Location = new System.Drawing.Point(614, 8);
            this.MetroContractor.Name = "MetroContractor";
            this.MetroContractor.Size = new System.Drawing.Size(60, 25);
            this.MetroContractor.TabIndex = 0;
            this.MetroContractor.Text = "Metro";
            // 
            // MetroSupplier
            // 
            this.MetroSupplier.AutoSize = true;
            this.MetroSupplier.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MetroSupplier.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MetroSupplier.Location = new System.Drawing.Point(614, 51);
            this.MetroSupplier.Name = "MetroSupplier";
            this.MetroSupplier.Size = new System.Drawing.Size(60, 25);
            this.MetroSupplier.TabIndex = 0;
            this.MetroSupplier.Text = "Metro";
            // 
            // MetroGeosynthetic
            // 
            this.MetroGeosynthetic.AutoSize = true;
            this.MetroGeosynthetic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MetroGeosynthetic.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MetroGeosynthetic.Location = new System.Drawing.Point(614, 85);
            this.MetroGeosynthetic.Name = "MetroGeosynthetic";
            this.MetroGeosynthetic.Size = new System.Drawing.Size(60, 25);
            this.MetroGeosynthetic.TabIndex = 0;
            this.MetroGeosynthetic.Text = "Metro";
            // 
            // LblOperator
            // 
            this.LblOperator.AutoSize = true;
            this.LblOperator.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblOperator.Location = new System.Drawing.Point(843, 8);
            this.LblOperator.Name = "LblOperator";
            this.LblOperator.Size = new System.Drawing.Size(90, 25);
            this.LblOperator.TabIndex = 0;
            this.LblOperator.Text = "Operator :";
            // 
            // LblMachine
            // 
            this.LblMachine.AutoSize = true;
            this.LblMachine.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblMachine.Location = new System.Drawing.Point(843, 51);
            this.LblMachine.Name = "LblMachine";
            this.LblMachine.Size = new System.Drawing.Size(97, 25);
            this.LblMachine.TabIndex = 0;
            this.LblMachine.Text = "Machine #:";
            // 
            // MetroOperator
            // 
            this.MetroOperator.AutoSize = true;
            this.MetroOperator.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MetroOperator.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MetroOperator.Location = new System.Drawing.Point(1004, 8);
            this.MetroOperator.Name = "MetroOperator";
            this.MetroOperator.Size = new System.Drawing.Size(60, 25);
            this.MetroOperator.TabIndex = 0;
            this.MetroOperator.Text = "Metro";
            // 
            // MetroMachineNo
            // 
            this.MetroMachineNo.AutoSize = true;
            this.MetroMachineNo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MetroMachineNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MetroMachineNo.Location = new System.Drawing.Point(1004, 51);
            this.MetroMachineNo.Name = "MetroMachineNo";
            this.MetroMachineNo.Size = new System.Drawing.Size(60, 25);
            this.MetroMachineNo.TabIndex = 0;
            this.MetroMachineNo.Text = "Metro";
            // 
            // PbLogo
            // 
            this.PbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(1100, 5);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(189, 50);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogo.TabIndex = 1;
            this.PbLogo.TabStop = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnAdd.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(45, 15);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(153, 58);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseCustomBackColor = true;
            this.BtnAdd.UseCustomForeColor = true;
            this.BtnAdd.UseSelectable = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnEdit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnEdit.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(208, 15);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(153, 58);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseCustomBackColor = true;
            this.BtnEdit.UseCustomForeColor = true;
            this.BtnEdit.UseSelectable = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnPdf
            // 
            this.BtnPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPdf.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPdf.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnPdf.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnPdf.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnPdf.Location = new System.Drawing.Point(1165, 27);
            this.BtnPdf.Name = "BtnPdf";
            this.BtnPdf.Size = new System.Drawing.Size(163, 58);
            this.BtnPdf.TabIndex = 5;
            this.BtnPdf.Text = "Report";
            this.BtnPdf.UseCustomBackColor = true;
            this.BtnPdf.UseSelectable = true;
            this.BtnPdf.Click += new System.EventHandler(this.BtnPdf_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.BtnDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnDelete.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(381, 15);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(153, 58);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseCustomBackColor = true;
            this.BtnDelete.UseCustomForeColor = true;
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.White;
            this.PanelHead.Controls.Add(this.BtnClose);
            this.PanelHead.Controls.Add(this.LblMachine);
            this.PanelHead.Controls.Add(this.LblClient);
            this.PanelHead.Controls.Add(this.MetroOperator);
            this.PanelHead.Controls.Add(this.LblProject);
            this.PanelHead.Controls.Add(this.MetroContractor);
            this.PanelHead.Controls.Add(this.LblProjectNo);
            this.PanelHead.Controls.Add(this.MetroClient);
            this.PanelHead.Controls.Add(this.LblContractor);
            this.PanelHead.Controls.Add(this.MetroProject);
            this.PanelHead.Controls.Add(this.PbLogo);
            this.PanelHead.Controls.Add(this.MetroProjectNo);
            this.PanelHead.Controls.Add(this.LblOperator);
            this.PanelHead.Controls.Add(this.MetroMachineNo);
            this.PanelHead.Controls.Add(this.LblSupplier);
            this.PanelHead.Controls.Add(this.LblGeosynthetic);
            this.PanelHead.Controls.Add(this.MetroGeosynthetic);
            this.PanelHead.Controls.Add(this.MetroSupplier);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(1370, 139);
            this.PanelHead.TabIndex = 7;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnClose.IconColor = System.Drawing.Color.Red;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnClose.IconSize = 36;
            this.BtnClose.Location = new System.Drawing.Point(1319, 5);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(29, 34);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PanelFoot
            // 
            this.PanelFoot.BackColor = System.Drawing.Color.White;
            this.PanelFoot.Controls.Add(this.BtnPdf);
            this.PanelFoot.Controls.Add(this.BtnAdd);
            this.PanelFoot.Controls.Add(this.BtnEdit);
            this.PanelFoot.Controls.Add(this.BtnData);
            this.PanelFoot.Controls.Add(this.BtnDrawing);
            this.PanelFoot.Controls.Add(this.DeploymentBtn);
            this.PanelFoot.Controls.Add(this.BtnDelete);
            this.PanelFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFoot.Location = new System.Drawing.Point(0, 679);
            this.PanelFoot.Name = "PanelFoot";
            this.PanelFoot.Size = new System.Drawing.Size(1370, 109);
            this.PanelFoot.TabIndex = 8;
            // 
            // BtnData
            // 
            this.BtnData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnData.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnData.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnData.ForeColor = System.Drawing.Color.White;
            this.BtnData.Location = new System.Drawing.Point(894, 15);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(153, 58);
            this.BtnData.TabIndex = 5;
            this.BtnData.Text = "Inspector";
            this.BtnData.UseCustomBackColor = true;
            this.BtnData.UseCustomForeColor = true;
            this.BtnData.UseSelectable = true;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // BtnDrawing
            // 
            this.BtnDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDrawing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnDrawing.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnDrawing.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDrawing.ForeColor = System.Drawing.Color.White;
            this.BtnDrawing.Location = new System.Drawing.Point(722, 15);
            this.BtnDrawing.Name = "BtnDrawing";
            this.BtnDrawing.Size = new System.Drawing.Size(153, 58);
            this.BtnDrawing.TabIndex = 5;
            this.BtnDrawing.Text = "Drawing";
            this.BtnDrawing.UseCustomBackColor = true;
            this.BtnDrawing.UseCustomForeColor = true;
            this.BtnDrawing.UseSelectable = true;
            this.BtnDrawing.Click += new System.EventHandler(this.BtnDrawing_Click);
            // 
            // DeploymentBtn
            // 
            this.DeploymentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeploymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.DeploymentBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.DeploymentBtn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.DeploymentBtn.ForeColor = System.Drawing.Color.White;
            this.DeploymentBtn.Location = new System.Drawing.Point(556, 15);
            this.DeploymentBtn.Name = "DeploymentBtn";
            this.DeploymentBtn.Size = new System.Drawing.Size(153, 58);
            this.DeploymentBtn.TabIndex = 5;
            this.DeploymentBtn.Text = "Deployment";
            this.DeploymentBtn.UseCustomBackColor = true;
            this.DeploymentBtn.UseCustomForeColor = true;
            this.DeploymentBtn.UseSelectable = true;
            this.DeploymentBtn.Click += new System.EventHandler(this.DeploymentBtn_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.DGVGeo);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 139);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1370, 540);
            this.PanelContent.TabIndex = 9;
            // 
            // DGVGeo
            // 
            this.DGVGeo.AutoGenerateColumns = false;
            this.DGVGeo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVGeo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVGeo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGeo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SeamingDate,
            this.SeamNo,
            this.SeamTime,
            this.WedgeTemp,
            this.WedgeSpeed,
            this.SeamLength,
            this.CarryOver,
            this.Destructive,
            this.RemarksDestructive,
            this.ProjectDevId,
            this.Projectdev});
            this.DGVGeo.DataSource = this.geoMembraneBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVGeo.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVGeo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVGeo.Location = new System.Drawing.Point(0, 0);
            this.DGVGeo.Name = "DGVGeo";
            this.DGVGeo.Size = new System.Drawing.Size(1370, 540);
            this.DGVGeo.TabIndex = 0;
            this.DGVGeo.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGVGeo_CellValidating);
            this.DGVGeo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGVGeo_DataError);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // SeamingDate
            // 
            this.SeamingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SeamingDate.DataPropertyName = "SeamingDate";
            this.SeamingDate.HeaderText = "SeamingDate";
            this.SeamingDate.Name = "SeamingDate";
            this.SeamingDate.ReadOnly = true;
            // 
            // SeamNo
            // 
            this.SeamNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SeamNo.DataPropertyName = "SeamNo";
            this.SeamNo.HeaderText = "SeamNo";
            this.SeamNo.Name = "SeamNo";
            // 
            // SeamTime
            // 
            this.SeamTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SeamTime.DataPropertyName = "SeamTime";
            this.SeamTime.HeaderText = "SeamTime";
            this.SeamTime.Name = "SeamTime";
            // 
            // WedgeTemp
            // 
            this.WedgeTemp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WedgeTemp.DataPropertyName = "WedgeTemp";
            this.WedgeTemp.HeaderText = "WedgeTemp";
            this.WedgeTemp.Name = "WedgeTemp";
            // 
            // WedgeSpeed
            // 
            this.WedgeSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WedgeSpeed.DataPropertyName = "WedgeSpeed";
            this.WedgeSpeed.HeaderText = "WedgeSpeed";
            this.WedgeSpeed.Name = "WedgeSpeed";
            // 
            // SeamLength
            // 
            this.SeamLength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SeamLength.DataPropertyName = "SeamLength";
            this.SeamLength.HeaderText = "SeamLength";
            this.SeamLength.Name = "SeamLength";
            // 
            // CarryOver
            // 
            this.CarryOver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarryOver.DataPropertyName = "CarryOver";
            this.CarryOver.HeaderText = "CarryOver";
            this.CarryOver.Name = "CarryOver";
            this.CarryOver.ReadOnly = true;
            // 
            // Destructive
            // 
            this.Destructive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Destructive.DataPropertyName = "Destructive";
            this.Destructive.HeaderText = "Destructive";
            this.Destructive.Name = "Destructive";
            // 
            // RemarksDestructive
            // 
            this.RemarksDestructive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RemarksDestructive.DataPropertyName = "RemarksDestructive";
            this.RemarksDestructive.HeaderText = "RemarksDestructive";
            this.RemarksDestructive.Name = "RemarksDestructive";
            // 
            // ProjectDevId
            // 
            this.ProjectDevId.DataPropertyName = "ProjectDevId";
            this.ProjectDevId.HeaderText = "ProjectDevId";
            this.ProjectDevId.Name = "ProjectDevId";
            this.ProjectDevId.Visible = false;
            // 
            // Projectdev
            // 
            this.Projectdev.DataPropertyName = "ProjectDev";
            this.Projectdev.HeaderText = "ProjectDev";
            this.Projectdev.Name = "Projectdev";
            this.Projectdev.Visible = false;
            // 
            // geoMembraneBindingSource
            // 
            this.geoMembraneBindingSource.DataSource = typeof(Mine.DataModel.GeoMembrane);
            // 
            // GeomembraneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 788);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelFoot);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeomembraneForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GeomembraneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.PanelFoot.ResumeLayout(false);
            this.PanelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoMembraneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblClient;
        private MetroFramework.Controls.MetroLabel LblProject;
        private MetroFramework.Controls.MetroLabel LblProjectNo;
        private MetroFramework.Controls.MetroLabel MetroClient;
        private MetroFramework.Controls.MetroLabel MetroProject;
        private MetroFramework.Controls.MetroLabel MetroProjectNo;
        private MetroFramework.Controls.MetroLabel LblContractor;
        private MetroFramework.Controls.MetroLabel LblSupplier;
        private MetroFramework.Controls.MetroLabel LblGeosynthetic;
        private MetroFramework.Controls.MetroLabel MetroContractor;
        private MetroFramework.Controls.MetroLabel MetroSupplier;
        private MetroFramework.Controls.MetroLabel MetroGeosynthetic;
        private MetroFramework.Controls.MetroLabel LblOperator;
        private MetroFramework.Controls.MetroLabel LblMachine;
        private MetroFramework.Controls.MetroLabel MetroOperator;
        private MetroFramework.Controls.MetroLabel MetroMachineNo;
        private System.Windows.Forms.PictureBox PbLogo;
        private MetroFramework.Controls.MetroButton BtnAdd;
        private MetroFramework.Controls.MetroButton BtnEdit;
        private MetroFramework.Controls.MetroButton BtnPdf;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Panel PanelFoot;
        private System.Windows.Forms.Panel PanelContent;
        private FontAwesome.Sharp.IconButton BtnClose;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView DGVGeo;
        private MetroFramework.Controls.MetroButton DeploymentBtn;
        private MetroFramework.Controls.MetroButton BtnData;
        private MetroFramework.Controls.MetroButton BtnDrawing;
        private System.Windows.Forms.BindingSource geoMembraneBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeamingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeamNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeamTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WedgeTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn WedgeSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeamLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarryOver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destructive;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarksDestructive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDevId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projectdev;
    }
}