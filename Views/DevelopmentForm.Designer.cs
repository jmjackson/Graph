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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.LblPanel = new MetroFramework.Controls.MetroLabel();
            this.LblRoll = new MetroFramework.Controls.MetroLabel();
            this.LblLength = new MetroFramework.Controls.MetroLabel();
            this.LblWidth = new MetroFramework.Controls.MetroLabel();
            this.LblThickness = new MetroFramework.Controls.MetroLabel();
            this.LblArea = new MetroFramework.Controls.MetroLabel();
            this.LblRemarks = new MetroFramework.Controls.MetroLabel();
            this.TxtPanelNo = new MetroFramework.Controls.MetroTextBox();
            this.TxtRollNo = new MetroFramework.Controls.MetroTextBox();
            this.TxtLenght = new MetroFramework.Controls.MetroTextBox();
            this.TxtArea = new MetroFramework.Controls.MetroTextBox();
            this.TxtThickness = new MetroFramework.Controls.MetroTextBox();
            this.TxtWidth = new MetroFramework.Controls.MetroTextBox();
            this.TxtRemarks = new MetroFramework.Controls.MetroTextBox();
            this.BtnAdd = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.BtnEdit = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.LblTotal = new MetroFramework.Controls.MetroLabel();
            this.LblInspector = new MetroFramework.Controls.MetroLabel();
            this.PanelAdd = new MetroFramework.Controls.MetroPanel();
            this.TxtId = new MetroFramework.Controls.MetroTextBox();
            this.BtnPDF = new MetroFramework.Controls.MetroButton();
            this.TxtDate = new MetroFramework.Controls.MetroDateTime();
            this.LblRClient = new MetroFramework.Controls.MetroLabel();
            this.LblRProject = new MetroFramework.Controls.MetroLabel();
            this.LblRProjectNo = new MetroFramework.Controls.MetroLabel();
            this.LblRContractor = new MetroFramework.Controls.MetroLabel();
            this.LblRSupplier = new MetroFramework.Controls.MetroLabel();
            this.LblRGeosyntetic = new MetroFramework.Controls.MetroLabel();
            this.LblRInspector = new MetroFramework.Controls.MetroLabel();
            this.LblLocation = new MetroFramework.Controls.MetroLabel();
            this.LblRLocation = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PBPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).BeginInit();
            this.PanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblClient
            // 
            this.LblClient.AutoSize = true;
            this.LblClient.Location = new System.Drawing.Point(51, 48);
            this.LblClient.Name = "LblClient";
            this.LblClient.Size = new System.Drawing.Size(42, 19);
            this.LblClient.TabIndex = 0;
            this.LblClient.Text = "Client";
            // 
            // LblProjectNo
            // 
            this.LblProjectNo.AutoSize = true;
            this.LblProjectNo.Location = new System.Drawing.Point(20, 106);
            this.LblProjectNo.Name = "LblProjectNo";
            this.LblProjectNo.Size = new System.Drawing.Size(72, 19);
            this.LblProjectNo.TabIndex = 0;
            this.LblProjectNo.Text = "Project No";
            // 
            // LblProject
            // 
            this.LblProject.AutoSize = true;
            this.LblProject.Location = new System.Drawing.Point(43, 77);
            this.LblProject.Name = "LblProject";
            this.LblProject.Size = new System.Drawing.Size(50, 19);
            this.LblProject.TabIndex = 0;
            this.LblProject.Text = "Project";
            // 
            // LblContractor
            // 
            this.LblContractor.AutoSize = true;
            this.LblContractor.Location = new System.Drawing.Point(353, 48);
            this.LblContractor.Name = "LblContractor";
            this.LblContractor.Size = new System.Drawing.Size(72, 19);
            this.LblContractor.TabIndex = 0;
            this.LblContractor.Text = "Contractor";
            // 
            // LblGeoSynthetic
            // 
            this.LblGeoSynthetic.AutoSize = true;
            this.LblGeoSynthetic.Location = new System.Drawing.Point(343, 106);
            this.LblGeoSynthetic.Name = "LblGeoSynthetic";
            this.LblGeoSynthetic.Size = new System.Drawing.Size(82, 19);
            this.LblGeoSynthetic.TabIndex = 0;
            this.LblGeoSynthetic.Text = "Geosynthetic";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Location = new System.Drawing.Point(368, 77);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(57, 19);
            this.LblSupplier.TabIndex = 0;
            this.LblSupplier.Text = "Supplier";
            // 
            // PBPicture
            // 
            this.PBPicture.Location = new System.Drawing.Point(825, 39);
            this.PBPicture.Name = "PBPicture";
            this.PBPicture.Size = new System.Drawing.Size(221, 57);
            this.PBPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPicture.TabIndex = 1;
            this.PBPicture.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblTitle.Location = new System.Drawing.Point(504, 6);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(137, 25);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "Deployment Log";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DGVDev
            // 
            this.DGVDev.AllowUserToResizeRows = false;
            this.DGVDev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDev.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVDev.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDev.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVDev.EnableHeadersVisualStyles = false;
            this.DGVDev.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVDev.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVDev.Location = new System.Drawing.Point(20, 164);
            this.DGVDev.Name = "DGVDev";
            this.DGVDev.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVDev.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVDev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDev.Size = new System.Drawing.Size(1007, 272);
            this.DGVDev.Style = MetroFramework.MetroColorStyle.Purple;
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
            // LblPanel
            // 
            this.LblPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPanel.AutoSize = true;
            this.LblPanel.Location = new System.Drawing.Point(13, 23);
            this.LblPanel.Name = "LblPanel";
            this.LblPanel.Size = new System.Drawing.Size(62, 19);
            this.LblPanel.TabIndex = 6;
            this.LblPanel.Text = "Panel No";
            // 
            // LblRoll
            // 
            this.LblRoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblRoll.AutoSize = true;
            this.LblRoll.Location = new System.Drawing.Point(22, 56);
            this.LblRoll.Name = "LblRoll";
            this.LblRoll.Size = new System.Drawing.Size(53, 19);
            this.LblRoll.TabIndex = 6;
            this.LblRoll.Text = "Roll No";
            // 
            // LblLength
            // 
            this.LblLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblLength.AutoSize = true;
            this.LblLength.Location = new System.Drawing.Point(27, 85);
            this.LblLength.Name = "LblLength";
            this.LblLength.Size = new System.Drawing.Size(48, 19);
            this.LblLength.TabIndex = 6;
            this.LblLength.Text = "Length";
            // 
            // LblWidth
            // 
            this.LblWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblWidth.AutoSize = true;
            this.LblWidth.Location = new System.Drawing.Point(281, 23);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(44, 19);
            this.LblWidth.TabIndex = 6;
            this.LblWidth.Text = "Width";
            // 
            // LblThickness
            // 
            this.LblThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblThickness.AutoSize = true;
            this.LblThickness.Location = new System.Drawing.Point(263, 56);
            this.LblThickness.Name = "LblThickness";
            this.LblThickness.Size = new System.Drawing.Size(62, 19);
            this.LblThickness.TabIndex = 6;
            this.LblThickness.Text = "Thickness";
            // 
            // LblArea
            // 
            this.LblArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblArea.AutoSize = true;
            this.LblArea.Location = new System.Drawing.Point(258, 85);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(67, 19);
            this.LblArea.TabIndex = 6;
            this.LblArea.Text = "Area (Ft2)";
            // 
            // LblRemarks
            // 
            this.LblRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblRemarks.AutoSize = true;
            this.LblRemarks.Location = new System.Drawing.Point(519, 30);
            this.LblRemarks.Name = "LblRemarks";
            this.LblRemarks.Size = new System.Drawing.Size(59, 19);
            this.LblRemarks.TabIndex = 6;
            this.LblRemarks.Text = "Remarks";
            // 
            // TxtPanelNo
            // 
            this.TxtPanelNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.TxtPanelNo.CustomButton.Image = null;
            this.TxtPanelNo.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.TxtPanelNo.CustomButton.Name = "";
            this.TxtPanelNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPanelNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPanelNo.CustomButton.TabIndex = 1;
            this.TxtPanelNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPanelNo.CustomButton.UseSelectable = true;
            this.TxtPanelNo.CustomButton.Visible = false;
            this.TxtPanelNo.Lines = new string[0];
            this.TxtPanelNo.Location = new System.Drawing.Point(89, 23);
            this.TxtPanelNo.MaxLength = 32767;
            this.TxtPanelNo.Name = "TxtPanelNo";
            this.TxtPanelNo.PasswordChar = '\0';
            this.TxtPanelNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPanelNo.SelectedText = "";
            this.TxtPanelNo.SelectionLength = 0;
            this.TxtPanelNo.SelectionStart = 0;
            this.TxtPanelNo.ShortcutsEnabled = true;
            this.TxtPanelNo.Size = new System.Drawing.Size(153, 23);
            this.TxtPanelNo.TabIndex = 0;
            this.TxtPanelNo.UseSelectable = true;
            this.TxtPanelNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPanelNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtRollNo
            // 
            this.TxtRollNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.TxtRollNo.CustomButton.Image = null;
            this.TxtRollNo.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.TxtRollNo.CustomButton.Name = "";
            this.TxtRollNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRollNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRollNo.CustomButton.TabIndex = 1;
            this.TxtRollNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRollNo.CustomButton.UseSelectable = true;
            this.TxtRollNo.CustomButton.Visible = false;
            this.TxtRollNo.Lines = new string[0];
            this.TxtRollNo.Location = new System.Drawing.Point(89, 52);
            this.TxtRollNo.MaxLength = 32767;
            this.TxtRollNo.Name = "TxtRollNo";
            this.TxtRollNo.PasswordChar = '\0';
            this.TxtRollNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRollNo.SelectedText = "";
            this.TxtRollNo.SelectionLength = 0;
            this.TxtRollNo.SelectionStart = 0;
            this.TxtRollNo.ShortcutsEnabled = true;
            this.TxtRollNo.Size = new System.Drawing.Size(153, 23);
            this.TxtRollNo.TabIndex = 1;
            this.TxtRollNo.UseSelectable = true;
            this.TxtRollNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRollNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtLenght
            // 
            this.TxtLenght.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.TxtLenght.CustomButton.Image = null;
            this.TxtLenght.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.TxtLenght.CustomButton.Name = "";
            this.TxtLenght.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtLenght.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLenght.CustomButton.TabIndex = 1;
            this.TxtLenght.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLenght.CustomButton.UseSelectable = true;
            this.TxtLenght.CustomButton.Visible = false;
            this.TxtLenght.Lines = new string[0];
            this.TxtLenght.Location = new System.Drawing.Point(89, 81);
            this.TxtLenght.MaxLength = 32767;
            this.TxtLenght.Name = "TxtLenght";
            this.TxtLenght.PasswordChar = '\0';
            this.TxtLenght.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLenght.SelectedText = "";
            this.TxtLenght.SelectionLength = 0;
            this.TxtLenght.SelectionStart = 0;
            this.TxtLenght.ShortcutsEnabled = true;
            this.TxtLenght.Size = new System.Drawing.Size(153, 23);
            this.TxtLenght.TabIndex = 2;
            this.TxtLenght.UseSelectable = true;
            this.TxtLenght.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLenght.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtArea
            // 
            this.TxtArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.TxtArea.CustomButton.Image = null;
            this.TxtArea.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.TxtArea.CustomButton.Name = "";
            this.TxtArea.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtArea.CustomButton.TabIndex = 1;
            this.TxtArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtArea.CustomButton.UseSelectable = true;
            this.TxtArea.CustomButton.Visible = false;
            this.TxtArea.Lines = new string[0];
            this.TxtArea.Location = new System.Drawing.Point(337, 81);
            this.TxtArea.MaxLength = 32767;
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.PasswordChar = '\0';
            this.TxtArea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtArea.SelectedText = "";
            this.TxtArea.SelectionLength = 0;
            this.TxtArea.SelectionStart = 0;
            this.TxtArea.ShortcutsEnabled = true;
            this.TxtArea.Size = new System.Drawing.Size(153, 23);
            this.TxtArea.TabIndex = 5;
            this.TxtArea.UseSelectable = true;
            this.TxtArea.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtArea.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtThickness
            // 
            this.TxtThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.TxtThickness.CustomButton.Image = null;
            this.TxtThickness.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.TxtThickness.CustomButton.Name = "";
            this.TxtThickness.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtThickness.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtThickness.CustomButton.TabIndex = 1;
            this.TxtThickness.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtThickness.CustomButton.UseSelectable = true;
            this.TxtThickness.CustomButton.Visible = false;
            this.TxtThickness.Lines = new string[0];
            this.TxtThickness.Location = new System.Drawing.Point(337, 52);
            this.TxtThickness.MaxLength = 32767;
            this.TxtThickness.Name = "TxtThickness";
            this.TxtThickness.PasswordChar = '\0';
            this.TxtThickness.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtThickness.SelectedText = "";
            this.TxtThickness.SelectionLength = 0;
            this.TxtThickness.SelectionStart = 0;
            this.TxtThickness.ShortcutsEnabled = true;
            this.TxtThickness.Size = new System.Drawing.Size(153, 23);
            this.TxtThickness.TabIndex = 4;
            this.TxtThickness.UseSelectable = true;
            this.TxtThickness.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtThickness.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtWidth
            // 
            this.TxtWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.TxtWidth.CustomButton.Image = null;
            this.TxtWidth.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.TxtWidth.CustomButton.Name = "";
            this.TxtWidth.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtWidth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtWidth.CustomButton.TabIndex = 1;
            this.TxtWidth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtWidth.CustomButton.UseSelectable = true;
            this.TxtWidth.CustomButton.Visible = false;
            this.TxtWidth.Lines = new string[0];
            this.TxtWidth.Location = new System.Drawing.Point(337, 23);
            this.TxtWidth.MaxLength = 32767;
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.PasswordChar = '\0';
            this.TxtWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtWidth.SelectedText = "";
            this.TxtWidth.SelectionLength = 0;
            this.TxtWidth.SelectionStart = 0;
            this.TxtWidth.ShortcutsEnabled = true;
            this.TxtWidth.Size = new System.Drawing.Size(153, 23);
            this.TxtWidth.TabIndex = 3;
            this.TxtWidth.UseSelectable = true;
            this.TxtWidth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtWidth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtRemarks
            // 
            this.TxtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.TxtRemarks.CustomButton.Image = null;
            this.TxtRemarks.CustomButton.Location = new System.Drawing.Point(123, 2);
            this.TxtRemarks.CustomButton.Name = "";
            this.TxtRemarks.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.TxtRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRemarks.CustomButton.TabIndex = 1;
            this.TxtRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRemarks.CustomButton.UseSelectable = true;
            this.TxtRemarks.CustomButton.Visible = false;
            this.TxtRemarks.Lines = new string[0];
            this.TxtRemarks.Location = new System.Drawing.Point(519, 52);
            this.TxtRemarks.MaxLength = 32767;
            this.TxtRemarks.Multiline = true;
            this.TxtRemarks.Name = "TxtRemarks";
            this.TxtRemarks.PasswordChar = '\0';
            this.TxtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRemarks.SelectedText = "";
            this.TxtRemarks.SelectionLength = 0;
            this.TxtRemarks.SelectionStart = 0;
            this.TxtRemarks.ShortcutsEnabled = true;
            this.TxtRemarks.Size = new System.Drawing.Size(173, 52);
            this.TxtRemarks.TabIndex = 6;
            this.TxtRemarks.UseSelectable = true;
            this.TxtRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRemarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnAdd.Location = new System.Drawing.Point(729, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(105, 23);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseSelectable = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDelete.Location = new System.Drawing.Point(729, 63);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(105, 23);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnEdit.Location = new System.Drawing.Point(729, 34);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(105, 23);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseSelectable = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnSave.Location = new System.Drawing.Point(729, 92);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(105, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(864, 9);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(95, 19);
            this.LblTotal.TabIndex = 14;
            this.LblTotal.Text = "Total Area (ft2)";
            // 
            // LblInspector
            // 
            this.LblInspector.AutoSize = true;
            this.LblInspector.Location = new System.Drawing.Point(363, 135);
            this.LblInspector.Name = "LblInspector";
            this.LblInspector.Size = new System.Drawing.Size(62, 19);
            this.LblInspector.TabIndex = 0;
            this.LblInspector.Text = "Inspector";
            // 
            // PanelAdd
            // 
            this.PanelAdd.Controls.Add(this.TxtId);
            this.PanelAdd.Controls.Add(this.BtnPDF);
            this.PanelAdd.Controls.Add(this.TxtLenght);
            this.PanelAdd.Controls.Add(this.LblTotal);
            this.PanelAdd.Controls.Add(this.LblPanel);
            this.PanelAdd.Controls.Add(this.BtnEdit);
            this.PanelAdd.Controls.Add(this.LblRoll);
            this.PanelAdd.Controls.Add(this.BtnSave);
            this.PanelAdd.Controls.Add(this.BtnDelete);
            this.PanelAdd.Controls.Add(this.LblLength);
            this.PanelAdd.Controls.Add(this.BtnAdd);
            this.PanelAdd.Controls.Add(this.TxtPanelNo);
            this.PanelAdd.Controls.Add(this.TxtRollNo);
            this.PanelAdd.Controls.Add(this.TxtRemarks);
            this.PanelAdd.Controls.Add(this.TxtArea);
            this.PanelAdd.Controls.Add(this.LblWidth);
            this.PanelAdd.Controls.Add(this.TxtThickness);
            this.PanelAdd.Controls.Add(this.LblRemarks);
            this.PanelAdd.Controls.Add(this.TxtWidth);
            this.PanelAdd.Controls.Add(this.LblThickness);
            this.PanelAdd.Controls.Add(this.LblArea);
            this.PanelAdd.HorizontalScrollbarBarColor = true;
            this.PanelAdd.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelAdd.HorizontalScrollbarSize = 10;
            this.PanelAdd.Location = new System.Drawing.Point(10, 442);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(1036, 119);
            this.PanelAdd.TabIndex = 17;
            this.PanelAdd.VerticalScrollbarBarColor = true;
            this.PanelAdd.VerticalScrollbarHighlightOnWheel = false;
            this.PanelAdd.VerticalScrollbarSize = 10;
            // 
            // TxtId
            // 
            // 
            // 
            // 
            this.TxtId.CustomButton.Image = null;
            this.TxtId.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.TxtId.CustomButton.Name = "";
            this.TxtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtId.CustomButton.TabIndex = 1;
            this.TxtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtId.CustomButton.UseSelectable = true;
            this.TxtId.CustomButton.Visible = false;
            this.TxtId.Lines = new string[0];
            this.TxtId.Location = new System.Drawing.Point(519, 9);
            this.TxtId.MaxLength = 32767;
            this.TxtId.Name = "TxtId";
            this.TxtId.PasswordChar = '\0';
            this.TxtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtId.SelectedText = "";
            this.TxtId.SelectionLength = 0;
            this.TxtId.SelectionStart = 0;
            this.TxtId.ShortcutsEnabled = true;
            this.TxtId.Size = new System.Drawing.Size(173, 23);
            this.TxtId.TabIndex = 16;
            this.TxtId.UseSelectable = true;
            this.TxtId.Visible = false;
            this.TxtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnPDF
            // 
            this.BtnPDF.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnPDF.Location = new System.Drawing.Point(935, 85);
            this.BtnPDF.Name = "BtnPDF";
            this.BtnPDF.Size = new System.Drawing.Size(75, 23);
            this.BtnPDF.TabIndex = 11;
            this.BtnPDF.Text = "BtnPDF";
            this.BtnPDF.UseSelectable = true;
            this.BtnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(825, 115);
            this.TxtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(200, 29);
            this.TxtDate.TabIndex = 15;
            // 
            // LblRClient
            // 
            this.LblRClient.AutoSize = true;
            this.LblRClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRClient.Location = new System.Drawing.Point(100, 47);
            this.LblRClient.Name = "LblRClient";
            this.LblRClient.Size = new System.Drawing.Size(0, 0);
            this.LblRClient.TabIndex = 18;
            // 
            // LblRProject
            // 
            this.LblRProject.AutoSize = true;
            this.LblRProject.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRProject.Location = new System.Drawing.Point(99, 77);
            this.LblRProject.Name = "LblRProject";
            this.LblRProject.Size = new System.Drawing.Size(0, 0);
            this.LblRProject.TabIndex = 18;
            // 
            // LblRProjectNo
            // 
            this.LblRProjectNo.AutoSize = true;
            this.LblRProjectNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRProjectNo.Location = new System.Drawing.Point(99, 106);
            this.LblRProjectNo.Name = "LblRProjectNo";
            this.LblRProjectNo.Size = new System.Drawing.Size(0, 0);
            this.LblRProjectNo.TabIndex = 18;
            // 
            // LblRContractor
            // 
            this.LblRContractor.AutoSize = true;
            this.LblRContractor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRContractor.Location = new System.Drawing.Point(444, 47);
            this.LblRContractor.Name = "LblRContractor";
            this.LblRContractor.Size = new System.Drawing.Size(0, 0);
            this.LblRContractor.TabIndex = 18;
            // 
            // LblRSupplier
            // 
            this.LblRSupplier.AutoSize = true;
            this.LblRSupplier.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRSupplier.Location = new System.Drawing.Point(443, 77);
            this.LblRSupplier.Name = "LblRSupplier";
            this.LblRSupplier.Size = new System.Drawing.Size(0, 0);
            this.LblRSupplier.TabIndex = 18;
            // 
            // LblRGeosyntetic
            // 
            this.LblRGeosyntetic.AutoSize = true;
            this.LblRGeosyntetic.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRGeosyntetic.Location = new System.Drawing.Point(443, 106);
            this.LblRGeosyntetic.Name = "LblRGeosyntetic";
            this.LblRGeosyntetic.Size = new System.Drawing.Size(0, 0);
            this.LblRGeosyntetic.TabIndex = 18;
            // 
            // LblRInspector
            // 
            this.LblRInspector.AutoSize = true;
            this.LblRInspector.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRInspector.Location = new System.Drawing.Point(443, 135);
            this.LblRInspector.Name = "LblRInspector";
            this.LblRInspector.Size = new System.Drawing.Size(0, 0);
            this.LblRInspector.TabIndex = 18;
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(23, 135);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(58, 19);
            this.LblLocation.TabIndex = 0;
            this.LblLocation.Text = "Location";
            // 
            // LblRLocation
            // 
            this.LblRLocation.AutoSize = true;
            this.LblRLocation.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblRLocation.Location = new System.Drawing.Point(103, 135);
            this.LblRLocation.Name = "LblRLocation";
            this.LblRLocation.Size = new System.Drawing.Size(0, 0);
            this.LblRLocation.TabIndex = 18;
            // 
            // DevelopmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 573);
            this.Controls.Add(this.LblRLocation);
            this.Controls.Add(this.LblRInspector);
            this.Controls.Add(this.LblRGeosyntetic);
            this.Controls.Add(this.LblRSupplier);
            this.Controls.Add(this.LblRProjectNo);
            this.Controls.Add(this.LblRContractor);
            this.Controls.Add(this.LblRProject);
            this.Controls.Add(this.LblRClient);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.DGVDev);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.PBPicture);
            this.Controls.Add(this.LblSupplier);
            this.Controls.Add(this.LblProject);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.LblInspector);
            this.Controls.Add(this.LblGeoSynthetic);
            this.Controls.Add(this.LblContractor);
            this.Controls.Add(this.LblProjectNo);
            this.Controls.Add(this.LblClient);
            this.Name = "DevelopmentForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Load += new System.EventHandler(this.DevelopmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).EndInit();
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel LblPanel;
        private MetroFramework.Controls.MetroLabel LblRoll;
        private MetroFramework.Controls.MetroLabel LblLength;
        private MetroFramework.Controls.MetroLabel LblWidth;
        private MetroFramework.Controls.MetroLabel LblThickness;
        private MetroFramework.Controls.MetroLabel LblArea;
        private MetroFramework.Controls.MetroLabel LblRemarks;
        private MetroFramework.Controls.MetroTextBox TxtPanelNo;
        private MetroFramework.Controls.MetroTextBox TxtRollNo;
        private MetroFramework.Controls.MetroTextBox TxtLenght;
        private MetroFramework.Controls.MetroTextBox TxtArea;
        private MetroFramework.Controls.MetroTextBox TxtThickness;
        private MetroFramework.Controls.MetroTextBox TxtWidth;
        private MetroFramework.Controls.MetroTextBox TxtRemarks;
        private MetroFramework.Controls.MetroButton BtnAdd;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroButton BtnEdit;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroLabel LblTotal;
        private MetroFramework.Controls.MetroLabel LblInspector;
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
        private MetroFramework.Controls.MetroTextBox TxtId;
        private MetroFramework.Controls.MetroLabel LblRClient;
        private MetroFramework.Controls.MetroLabel LblRProject;
        private MetroFramework.Controls.MetroLabel LblRProjectNo;
        private MetroFramework.Controls.MetroLabel LblRContractor;
        private MetroFramework.Controls.MetroLabel LblRSupplier;
        private MetroFramework.Controls.MetroLabel LblRGeosyntetic;
        private MetroFramework.Controls.MetroLabel LblRInspector;
        private MetroFramework.Controls.MetroLabel LblLocation;
        private MetroFramework.Controls.MetroLabel LblRLocation;
    }
}