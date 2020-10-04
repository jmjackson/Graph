namespace Mine.Views
{
    partial class ProjectForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblId = new MetroFramework.Controls.MetroLabel();
            this.LblName = new MetroFramework.Controls.MetroLabel();
            this.LblCode = new MetroFramework.Controls.MetroLabel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.TxtId = new MetroFramework.Controls.MetroTextBox();
            this.TxtCode = new MetroFramework.Controls.MetroTextBox();
            this.TxtName = new MetroFramework.Controls.MetroTextBox();
            this.DGVProject = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contractor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geosynthetic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.TxtGeosynthetic = new MetroFramework.Controls.MetroTextBox();
            this.TxtPNumber = new MetroFramework.Controls.MetroTextBox();
            this.TxtSupplier = new MetroFramework.Controls.MetroTextBox();
            this.TxtPName = new MetroFramework.Controls.MetroTextBox();
            this.TxtPid = new MetroFramework.Controls.MetroTextBox();
            this.TxtContractor = new MetroFramework.Controls.MetroTextBox();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnEdit = new MetroFramework.Controls.MetroButton();
            this.BtnCreate = new MetroFramework.Controls.MetroButton();
            this.LblPNumber = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.LblSupplier = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.LblPId = new MetroFramework.Controls.MetroLabel();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProject)).BeginInit();
            this.PanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(49, 27);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(20, 19);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "Id";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(445, 27);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(82, 19);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Client Name";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(177, 27);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(78, 19);
            this.LblCode.TabIndex = 0;
            this.LblCode.Text = "Client Code";
            // 
            // PBLogo
            // 
            this.PBLogo.Location = new System.Drawing.Point(717, 23);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(153, 50);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 1;
            this.PBLogo.TabStop = false;
            // 
            // TxtId
            // 
            // 
            // 
            // 
            this.TxtId.CustomButton.Image = null;
            this.TxtId.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.TxtId.CustomButton.Name = "";
            this.TxtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtId.CustomButton.TabIndex = 1;
            this.TxtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtId.CustomButton.UseSelectable = true;
            this.TxtId.CustomButton.Visible = false;
            this.TxtId.Lines = new string[0];
            this.TxtId.Location = new System.Drawing.Point(75, 23);
            this.TxtId.MaxLength = 32767;
            this.TxtId.Name = "TxtId";
            this.TxtId.PasswordChar = '\0';
            this.TxtId.ReadOnly = true;
            this.TxtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtId.SelectedText = "";
            this.TxtId.SelectionLength = 0;
            this.TxtId.SelectionStart = 0;
            this.TxtId.ShortcutsEnabled = true;
            this.TxtId.Size = new System.Drawing.Size(75, 23);
            this.TxtId.TabIndex = 3;
            this.TxtId.UseSelectable = true;
            this.TxtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtCode
            // 
            // 
            // 
            // 
            this.TxtCode.CustomButton.Image = null;
            this.TxtCode.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.TxtCode.CustomButton.Name = "";
            this.TxtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCode.CustomButton.TabIndex = 1;
            this.TxtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCode.CustomButton.UseSelectable = true;
            this.TxtCode.CustomButton.Visible = false;
            this.TxtCode.Lines = new string[0];
            this.TxtCode.Location = new System.Drawing.Point(261, 23);
            this.TxtCode.MaxLength = 32767;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.PasswordChar = '\0';
            this.TxtCode.ReadOnly = true;
            this.TxtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCode.SelectedText = "";
            this.TxtCode.SelectionLength = 0;
            this.TxtCode.SelectionStart = 0;
            this.TxtCode.ShortcutsEnabled = true;
            this.TxtCode.Size = new System.Drawing.Size(178, 23);
            this.TxtCode.TabIndex = 3;
            this.TxtCode.UseSelectable = true;
            this.TxtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtName
            // 
            // 
            // 
            // 
            this.TxtName.CustomButton.Image = null;
            this.TxtName.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.TxtName.CustomButton.Name = "";
            this.TxtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtName.CustomButton.TabIndex = 1;
            this.TxtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtName.CustomButton.UseSelectable = true;
            this.TxtName.CustomButton.Visible = false;
            this.TxtName.Lines = new string[0];
            this.TxtName.Location = new System.Drawing.Point(533, 23);
            this.TxtName.MaxLength = 32767;
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.ReadOnly = true;
            this.TxtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtName.SelectedText = "";
            this.TxtName.SelectionLength = 0;
            this.TxtName.SelectionStart = 0;
            this.TxtName.ShortcutsEnabled = true;
            this.TxtName.Size = new System.Drawing.Size(178, 23);
            this.TxtName.TabIndex = 3;
            this.TxtName.UseSelectable = true;
            this.TxtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DGVProject
            // 
            this.DGVProject.AllowUserToResizeRows = false;
            this.DGVProject.BackgroundColor = System.Drawing.Color.White;
            this.DGVProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVProject.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVProject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.ProjectNo,
            this.Contractor,
            this.Supplier,
            this.Geosynthetic});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVProject.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVProject.EnableHeadersVisualStyles = false;
            this.DGVProject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVProject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVProject.Location = new System.Drawing.Point(23, 116);
            this.DGVProject.Name = "DGVProject";
            this.DGVProject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProject.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVProject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProject.Size = new System.Drawing.Size(886, 239);
            this.DGVProject.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Item";
            this.Id.Name = "Id";
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            // 
            // ProjectNo
            // 
            this.ProjectNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectNo.HeaderText = "Project No";
            this.ProjectNo.Name = "ProjectNo";
            // 
            // Contractor
            // 
            this.Contractor.HeaderText = "Contractor";
            this.Contractor.Name = "Contractor";
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            // 
            // Geosynthetic
            // 
            this.Geosynthetic.HeaderText = "GeoSynthetic";
            this.Geosynthetic.Name = "Geosynthetic";
            // 
            // PanelAdd
            // 
            this.PanelAdd.Controls.Add(this.TxtGeosynthetic);
            this.PanelAdd.Controls.Add(this.TxtPNumber);
            this.PanelAdd.Controls.Add(this.TxtSupplier);
            this.PanelAdd.Controls.Add(this.TxtPName);
            this.PanelAdd.Controls.Add(this.TxtPid);
            this.PanelAdd.Controls.Add(this.TxtContractor);
            this.PanelAdd.Controls.Add(this.BtnDelete);
            this.PanelAdd.Controls.Add(this.BtnSave);
            this.PanelAdd.Controls.Add(this.BtnEdit);
            this.PanelAdd.Controls.Add(this.BtnCreate);
            this.PanelAdd.Controls.Add(this.LblPNumber);
            this.PanelAdd.Controls.Add(this.metroLabel5);
            this.PanelAdd.Controls.Add(this.metroLabel4);
            this.PanelAdd.Controls.Add(this.LblSupplier);
            this.PanelAdd.Controls.Add(this.metroLabel2);
            this.PanelAdd.Controls.Add(this.LblPId);
            this.PanelAdd.Location = new System.Drawing.Point(23, 370);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(886, 130);
            this.PanelAdd.TabIndex = 5;
            // 
            // TxtGeosynthetic
            // 
            // 
            // 
            // 
            this.TxtGeosynthetic.CustomButton.Image = null;
            this.TxtGeosynthetic.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.TxtGeosynthetic.CustomButton.Name = "";
            this.TxtGeosynthetic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtGeosynthetic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtGeosynthetic.CustomButton.TabIndex = 1;
            this.TxtGeosynthetic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtGeosynthetic.CustomButton.UseSelectable = true;
            this.TxtGeosynthetic.CustomButton.Visible = false;
            this.TxtGeosynthetic.Lines = new string[0];
            this.TxtGeosynthetic.Location = new System.Drawing.Point(578, 58);
            this.TxtGeosynthetic.MaxLength = 32767;
            this.TxtGeosynthetic.Name = "TxtGeosynthetic";
            this.TxtGeosynthetic.PasswordChar = '\0';
            this.TxtGeosynthetic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtGeosynthetic.SelectedText = "";
            this.TxtGeosynthetic.SelectionLength = 0;
            this.TxtGeosynthetic.SelectionStart = 0;
            this.TxtGeosynthetic.ShortcutsEnabled = true;
            this.TxtGeosynthetic.Size = new System.Drawing.Size(153, 23);
            this.TxtGeosynthetic.TabIndex = 5;
            this.TxtGeosynthetic.UseSelectable = true;
            this.TxtGeosynthetic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtGeosynthetic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPNumber
            // 
            // 
            // 
            // 
            this.TxtPNumber.CustomButton.Image = null;
            this.TxtPNumber.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.TxtPNumber.CustomButton.Name = "";
            this.TxtPNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPNumber.CustomButton.TabIndex = 1;
            this.TxtPNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPNumber.CustomButton.UseSelectable = true;
            this.TxtPNumber.CustomButton.Visible = false;
            this.TxtPNumber.Lines = new string[0];
            this.TxtPNumber.Location = new System.Drawing.Point(578, 18);
            this.TxtPNumber.MaxLength = 32767;
            this.TxtPNumber.Name = "TxtPNumber";
            this.TxtPNumber.PasswordChar = '\0';
            this.TxtPNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPNumber.SelectedText = "";
            this.TxtPNumber.SelectionLength = 0;
            this.TxtPNumber.SelectionStart = 0;
            this.TxtPNumber.ShortcutsEnabled = true;
            this.TxtPNumber.Size = new System.Drawing.Size(153, 23);
            this.TxtPNumber.TabIndex = 2;
            this.TxtPNumber.UseSelectable = true;
            this.TxtPNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtSupplier
            // 
            // 
            // 
            // 
            this.TxtSupplier.CustomButton.Image = null;
            this.TxtSupplier.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.TxtSupplier.CustomButton.Name = "";
            this.TxtSupplier.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSupplier.CustomButton.TabIndex = 1;
            this.TxtSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSupplier.CustomButton.UseSelectable = true;
            this.TxtSupplier.CustomButton.Visible = false;
            this.TxtSupplier.Lines = new string[0];
            this.TxtSupplier.Location = new System.Drawing.Point(304, 58);
            this.TxtSupplier.MaxLength = 32767;
            this.TxtSupplier.Name = "TxtSupplier";
            this.TxtSupplier.PasswordChar = '\0';
            this.TxtSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSupplier.SelectedText = "";
            this.TxtSupplier.SelectionLength = 0;
            this.TxtSupplier.SelectionStart = 0;
            this.TxtSupplier.ShortcutsEnabled = true;
            this.TxtSupplier.Size = new System.Drawing.Size(183, 23);
            this.TxtSupplier.TabIndex = 4;
            this.TxtSupplier.UseSelectable = true;
            this.TxtSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSupplier.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPName
            // 
            // 
            // 
            // 
            this.TxtPName.CustomButton.Image = null;
            this.TxtPName.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.TxtPName.CustomButton.Name = "";
            this.TxtPName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPName.CustomButton.TabIndex = 1;
            this.TxtPName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPName.CustomButton.UseSelectable = true;
            this.TxtPName.CustomButton.Visible = false;
            this.TxtPName.Lines = new string[0];
            this.TxtPName.Location = new System.Drawing.Point(306, 18);
            this.TxtPName.MaxLength = 32767;
            this.TxtPName.Name = "TxtPName";
            this.TxtPName.PasswordChar = '\0';
            this.TxtPName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPName.SelectedText = "";
            this.TxtPName.SelectionLength = 0;
            this.TxtPName.SelectionStart = 0;
            this.TxtPName.ShortcutsEnabled = true;
            this.TxtPName.Size = new System.Drawing.Size(183, 23);
            this.TxtPName.TabIndex = 1;
            this.TxtPName.UseSelectable = true;
            this.TxtPName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPid
            // 
            // 
            // 
            // 
            this.TxtPid.CustomButton.Image = null;
            this.TxtPid.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.TxtPid.CustomButton.Name = "";
            this.TxtPid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPid.CustomButton.TabIndex = 1;
            this.TxtPid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPid.CustomButton.UseSelectable = true;
            this.TxtPid.CustomButton.Visible = false;
            this.TxtPid.Lines = new string[0];
            this.TxtPid.Location = new System.Drawing.Point(78, 18);
            this.TxtPid.MaxLength = 32767;
            this.TxtPid.Name = "TxtPid";
            this.TxtPid.PasswordChar = '\0';
            this.TxtPid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPid.SelectedText = "";
            this.TxtPid.SelectionLength = 0;
            this.TxtPid.SelectionStart = 0;
            this.TxtPid.ShortcutsEnabled = true;
            this.TxtPid.Size = new System.Drawing.Size(161, 23);
            this.TxtPid.TabIndex = 0;
            this.TxtPid.UseSelectable = true;
            this.TxtPid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtContractor
            // 
            // 
            // 
            // 
            this.TxtContractor.CustomButton.Image = null;
            this.TxtContractor.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.TxtContractor.CustomButton.Name = "";
            this.TxtContractor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtContractor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtContractor.CustomButton.TabIndex = 1;
            this.TxtContractor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtContractor.CustomButton.UseSelectable = true;
            this.TxtContractor.CustomButton.Visible = false;
            this.TxtContractor.Lines = new string[0];
            this.TxtContractor.Location = new System.Drawing.Point(78, 58);
            this.TxtContractor.MaxLength = 32767;
            this.TxtContractor.Name = "TxtContractor";
            this.TxtContractor.PasswordChar = '\0';
            this.TxtContractor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtContractor.SelectedText = "";
            this.TxtContractor.SelectionLength = 0;
            this.TxtContractor.SelectionStart = 0;
            this.TxtContractor.ShortcutsEnabled = true;
            this.TxtContractor.Size = new System.Drawing.Size(161, 23);
            this.TxtContractor.TabIndex = 3;
            this.TxtContractor.UseSelectable = true;
            this.TxtContractor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContractor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(751, 97);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(119, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseSelectable = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(751, 39);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(119, 23);
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseSelectable = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(751, 10);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(119, 23);
            this.BtnCreate.TabIndex = 6;
            this.BtnCreate.Text = "Add";
            this.BtnCreate.UseSelectable = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // LblPNumber
            // 
            this.LblPNumber.AutoSize = true;
            this.LblPNumber.Location = new System.Drawing.Point(500, 22);
            this.LblPNumber.Name = "LblPNumber";
            this.LblPNumber.Size = new System.Drawing.Size(72, 19);
            this.LblPNumber.TabIndex = 0;
            this.LblPNumber.Text = "Project No";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(488, 62);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "GeoSynthetic";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(246, 22);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Name";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Location = new System.Drawing.Point(241, 62);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(57, 19);
            this.LblSupplier.TabIndex = 0;
            this.LblSupplier.Text = "Supplier";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Contractor";
            // 
            // LblPId
            // 
            this.LblPId.AutoSize = true;
            this.LblPId.Location = new System.Drawing.Point(52, 18);
            this.LblPId.Name = "LblPId";
            this.LblPId.Size = new System.Drawing.Size(20, 19);
            this.LblPId.TabIndex = 0;
            this.LblPId.Text = "Id";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(751, 68);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(119, 23);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseSelectable = true;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 506);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.DGVProject);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.PBLogo);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblId);
            this.Name = "ProjectForm";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProject)).EndInit();
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblId;
        private MetroFramework.Controls.MetroLabel LblName;
        private MetroFramework.Controls.MetroLabel LblCode;
        private System.Windows.Forms.PictureBox PBLogo;
        private MetroFramework.Controls.MetroTextBox TxtId;
        private MetroFramework.Controls.MetroTextBox TxtCode;
        private MetroFramework.Controls.MetroTextBox TxtName;
        private MetroFramework.Controls.MetroGrid DGVProject;
        private System.Windows.Forms.Panel PanelAdd;
        private MetroFramework.Controls.MetroButton BtnCreate;
        private MetroFramework.Controls.MetroLabel LblPNumber;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel LblSupplier;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel LblPId;
        private MetroFramework.Controls.MetroTextBox TxtGeosynthetic;
        private MetroFramework.Controls.MetroTextBox TxtPNumber;
        private MetroFramework.Controls.MetroTextBox TxtSupplier;
        private MetroFramework.Controls.MetroTextBox TxtPName;
        private MetroFramework.Controls.MetroTextBox TxtPid;
        private MetroFramework.Controls.MetroTextBox TxtContractor;
        private MetroFramework.Controls.MetroButton BtnEdit;
        private MetroFramework.Controls.MetroButton BtnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contractor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geosynthetic;
        private MetroFramework.Controls.MetroButton BtnDelete;
    }
}