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
            this.TxtClient = new MetroFramework.Controls.MetroTextBox();
            this.TxtProject = new MetroFramework.Controls.MetroTextBox();
            this.TxtContractor = new MetroFramework.Controls.MetroTextBox();
            this.TxtSupplier = new MetroFramework.Controls.MetroTextBox();
            this.TxtProjectNo = new MetroFramework.Controls.MetroTextBox();
            this.TxtGeoSynthetic = new MetroFramework.Controls.MetroTextBox();
            this.LblTitle = new MetroFramework.Controls.MetroLabel();
            this.DGVDev = new MetroFramework.Controls.MetroGrid();
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.BtnCreate = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.LblInspector = new MetroFramework.Controls.MetroLabel();
            this.LblName = new MetroFramework.Controls.MetroLabel();
            this.LblTotal = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PBPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).BeginInit();
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
            // TxtClient
            // 
            // 
            // 
            // 
            this.TxtClient.CustomButton.Image = null;
            this.TxtClient.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.TxtClient.CustomButton.Name = "";
            this.TxtClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtClient.CustomButton.TabIndex = 1;
            this.TxtClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtClient.CustomButton.UseSelectable = true;
            this.TxtClient.CustomButton.Visible = false;
            this.TxtClient.Lines = new string[0];
            this.TxtClient.Location = new System.Drawing.Point(99, 44);
            this.TxtClient.MaxLength = 32767;
            this.TxtClient.Name = "TxtClient";
            this.TxtClient.PasswordChar = '\0';
            this.TxtClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtClient.SelectedText = "";
            this.TxtClient.SelectionLength = 0;
            this.TxtClient.SelectionStart = 0;
            this.TxtClient.ShortcutsEnabled = true;
            this.TxtClient.Size = new System.Drawing.Size(210, 23);
            this.TxtClient.TabIndex = 2;
            this.TxtClient.UseSelectable = true;
            this.TxtClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtProject
            // 
            // 
            // 
            // 
            this.TxtProject.CustomButton.Image = null;
            this.TxtProject.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.TxtProject.CustomButton.Name = "";
            this.TxtProject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtProject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtProject.CustomButton.TabIndex = 1;
            this.TxtProject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtProject.CustomButton.UseSelectable = true;
            this.TxtProject.CustomButton.Visible = false;
            this.TxtProject.Lines = new string[0];
            this.TxtProject.Location = new System.Drawing.Point(99, 73);
            this.TxtProject.MaxLength = 32767;
            this.TxtProject.Name = "TxtProject";
            this.TxtProject.PasswordChar = '\0';
            this.TxtProject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtProject.SelectedText = "";
            this.TxtProject.SelectionLength = 0;
            this.TxtProject.SelectionStart = 0;
            this.TxtProject.ShortcutsEnabled = true;
            this.TxtProject.Size = new System.Drawing.Size(210, 23);
            this.TxtProject.TabIndex = 2;
            this.TxtProject.UseSelectable = true;
            this.TxtProject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtProject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtContractor
            // 
            // 
            // 
            // 
            this.TxtContractor.CustomButton.Image = null;
            this.TxtContractor.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.TxtContractor.CustomButton.Name = "";
            this.TxtContractor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtContractor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtContractor.CustomButton.TabIndex = 1;
            this.TxtContractor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtContractor.CustomButton.UseSelectable = true;
            this.TxtContractor.CustomButton.Visible = false;
            this.TxtContractor.Lines = new string[0];
            this.TxtContractor.Location = new System.Drawing.Point(431, 44);
            this.TxtContractor.MaxLength = 32767;
            this.TxtContractor.Name = "TxtContractor";
            this.TxtContractor.PasswordChar = '\0';
            this.TxtContractor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtContractor.SelectedText = "";
            this.TxtContractor.SelectionLength = 0;
            this.TxtContractor.SelectionStart = 0;
            this.TxtContractor.ShortcutsEnabled = true;
            this.TxtContractor.Size = new System.Drawing.Size(210, 23);
            this.TxtContractor.TabIndex = 2;
            this.TxtContractor.UseSelectable = true;
            this.TxtContractor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContractor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtSupplier
            // 
            // 
            // 
            // 
            this.TxtSupplier.CustomButton.Image = null;
            this.TxtSupplier.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.TxtSupplier.CustomButton.Name = "";
            this.TxtSupplier.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSupplier.CustomButton.TabIndex = 1;
            this.TxtSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSupplier.CustomButton.UseSelectable = true;
            this.TxtSupplier.CustomButton.Visible = false;
            this.TxtSupplier.Lines = new string[0];
            this.TxtSupplier.Location = new System.Drawing.Point(431, 73);
            this.TxtSupplier.MaxLength = 32767;
            this.TxtSupplier.Name = "TxtSupplier";
            this.TxtSupplier.PasswordChar = '\0';
            this.TxtSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSupplier.SelectedText = "";
            this.TxtSupplier.SelectionLength = 0;
            this.TxtSupplier.SelectionStart = 0;
            this.TxtSupplier.ShortcutsEnabled = true;
            this.TxtSupplier.Size = new System.Drawing.Size(210, 23);
            this.TxtSupplier.TabIndex = 2;
            this.TxtSupplier.UseSelectable = true;
            this.TxtSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSupplier.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtProjectNo
            // 
            // 
            // 
            // 
            this.TxtProjectNo.CustomButton.Image = null;
            this.TxtProjectNo.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.TxtProjectNo.CustomButton.Name = "";
            this.TxtProjectNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtProjectNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtProjectNo.CustomButton.TabIndex = 1;
            this.TxtProjectNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtProjectNo.CustomButton.UseSelectable = true;
            this.TxtProjectNo.CustomButton.Visible = false;
            this.TxtProjectNo.Lines = new string[0];
            this.TxtProjectNo.Location = new System.Drawing.Point(99, 102);
            this.TxtProjectNo.MaxLength = 32767;
            this.TxtProjectNo.Name = "TxtProjectNo";
            this.TxtProjectNo.PasswordChar = '\0';
            this.TxtProjectNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtProjectNo.SelectedText = "";
            this.TxtProjectNo.SelectionLength = 0;
            this.TxtProjectNo.SelectionStart = 0;
            this.TxtProjectNo.ShortcutsEnabled = true;
            this.TxtProjectNo.Size = new System.Drawing.Size(210, 23);
            this.TxtProjectNo.TabIndex = 2;
            this.TxtProjectNo.UseSelectable = true;
            this.TxtProjectNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtProjectNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtGeoSynthetic
            // 
            // 
            // 
            // 
            this.TxtGeoSynthetic.CustomButton.Image = null;
            this.TxtGeoSynthetic.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.TxtGeoSynthetic.CustomButton.Name = "";
            this.TxtGeoSynthetic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtGeoSynthetic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtGeoSynthetic.CustomButton.TabIndex = 1;
            this.TxtGeoSynthetic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtGeoSynthetic.CustomButton.UseSelectable = true;
            this.TxtGeoSynthetic.CustomButton.Visible = false;
            this.TxtGeoSynthetic.Lines = new string[0];
            this.TxtGeoSynthetic.Location = new System.Drawing.Point(431, 102);
            this.TxtGeoSynthetic.MaxLength = 32767;
            this.TxtGeoSynthetic.Name = "TxtGeoSynthetic";
            this.TxtGeoSynthetic.PasswordChar = '\0';
            this.TxtGeoSynthetic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtGeoSynthetic.SelectedText = "";
            this.TxtGeoSynthetic.SelectionLength = 0;
            this.TxtGeoSynthetic.SelectionStart = 0;
            this.TxtGeoSynthetic.ShortcutsEnabled = true;
            this.TxtGeoSynthetic.Size = new System.Drawing.Size(210, 23);
            this.TxtGeoSynthetic.TabIndex = 2;
            this.TxtGeoSynthetic.UseSelectable = true;
            this.TxtGeoSynthetic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtGeoSynthetic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.DGVDev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DGVDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDev.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVDev.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeploymentDate,
            this.PanelNo,
            this.RollNo,
            this.Length,
            this.Width,
            this.Thickness,
            this.Area,
            this.Remarks});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDev.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVDev.EnableHeadersVisualStyles = false;
            this.DGVDev.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVDev.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DGVDev.Location = new System.Drawing.Point(20, 150);
            this.DGVDev.Name = "DGVDev";
            this.DGVDev.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVDev.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVDev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDev.Size = new System.Drawing.Size(1007, 286);
            this.DGVDev.TabIndex = 5;
            this.DGVDev.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.LblPanel.AutoSize = true;
            this.LblPanel.Location = new System.Drawing.Point(23, 457);
            this.LblPanel.Name = "LblPanel";
            this.LblPanel.Size = new System.Drawing.Size(62, 19);
            this.LblPanel.TabIndex = 6;
            this.LblPanel.Text = "Panel No";
            // 
            // LblRoll
            // 
            this.LblRoll.AutoSize = true;
            this.LblRoll.Location = new System.Drawing.Point(32, 490);
            this.LblRoll.Name = "LblRoll";
            this.LblRoll.Size = new System.Drawing.Size(53, 19);
            this.LblRoll.TabIndex = 6;
            this.LblRoll.Text = "Roll No";
            // 
            // LblLength
            // 
            this.LblLength.AutoSize = true;
            this.LblLength.Location = new System.Drawing.Point(37, 519);
            this.LblLength.Name = "LblLength";
            this.LblLength.Size = new System.Drawing.Size(48, 19);
            this.LblLength.TabIndex = 6;
            this.LblLength.Text = "Length";
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Location = new System.Drawing.Point(287, 457);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(44, 19);
            this.LblWidth.TabIndex = 6;
            this.LblWidth.Text = "Width";
            // 
            // LblThickness
            // 
            this.LblThickness.AutoSize = true;
            this.LblThickness.Location = new System.Drawing.Point(269, 490);
            this.LblThickness.Name = "LblThickness";
            this.LblThickness.Size = new System.Drawing.Size(62, 19);
            this.LblThickness.TabIndex = 6;
            this.LblThickness.Text = "Thickness";
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Location = new System.Drawing.Point(264, 519);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(67, 19);
            this.LblArea.TabIndex = 6;
            this.LblArea.Text = "Area (Ft2)";
            // 
            // LblRemarks
            // 
            this.LblRemarks.AutoSize = true;
            this.LblRemarks.Location = new System.Drawing.Point(525, 457);
            this.LblRemarks.Name = "LblRemarks";
            this.LblRemarks.Size = new System.Drawing.Size(59, 19);
            this.LblRemarks.TabIndex = 6;
            this.LblRemarks.Text = "Remarks";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(99, 457);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(153, 23);
            this.metroTextBox1.TabIndex = 7;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(99, 486);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(153, 23);
            this.metroTextBox2.TabIndex = 7;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(99, 515);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(153, 23);
            this.metroTextBox3.TabIndex = 7;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(343, 515);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(153, 23);
            this.metroTextBox4.TabIndex = 8;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(343, 486);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(153, 23);
            this.metroTextBox5.TabIndex = 9;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.Lines = new string[0];
            this.metroTextBox6.Location = new System.Drawing.Point(343, 457);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.ShortcutsEnabled = true;
            this.metroTextBox6.Size = new System.Drawing.Size(153, 23);
            this.metroTextBox6.TabIndex = 10;
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox7
            // 
            // 
            // 
            // 
            this.metroTextBox7.CustomButton.Image = null;
            this.metroTextBox7.CustomButton.Location = new System.Drawing.Point(123, 2);
            this.metroTextBox7.CustomButton.Name = "";
            this.metroTextBox7.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.metroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox7.CustomButton.TabIndex = 1;
            this.metroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox7.CustomButton.UseSelectable = true;
            this.metroTextBox7.CustomButton.Visible = false;
            this.metroTextBox7.Lines = new string[0];
            this.metroTextBox7.Location = new System.Drawing.Point(525, 486);
            this.metroTextBox7.MaxLength = 32767;
            this.metroTextBox7.Multiline = true;
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.PasswordChar = '\0';
            this.metroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox7.SelectedText = "";
            this.metroTextBox7.SelectionLength = 0;
            this.metroTextBox7.SelectionStart = 0;
            this.metroTextBox7.ShortcutsEnabled = true;
            this.metroTextBox7.Size = new System.Drawing.Size(173, 52);
            this.metroTextBox7.TabIndex = 11;
            this.metroTextBox7.UseSelectable = true;
            this.metroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnCreate
            // 
            this.BtnCreate.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnCreate.Location = new System.Drawing.Point(720, 440);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(105, 23);
            this.BtnCreate.TabIndex = 12;
            this.BtnCreate.Text = "Add";
            this.BtnCreate.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton2.Location = new System.Drawing.Point(720, 498);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(105, 23);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "Delete";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton3.Location = new System.Drawing.Point(720, 469);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(105, 23);
            this.metroButton3.TabIndex = 12;
            this.metroButton3.Text = "Edit";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton4.Location = new System.Drawing.Point(720, 527);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(105, 23);
            this.metroButton4.TabIndex = 12;
            this.metroButton4.Text = "Save";
            this.metroButton4.UseSelectable = true;
            // 
            // LblInspector
            // 
            this.LblInspector.AutoSize = true;
            this.LblInspector.Location = new System.Drawing.Point(877, 502);
            this.LblInspector.Name = "LblInspector";
            this.LblInspector.Size = new System.Drawing.Size(62, 19);
            this.LblInspector.TabIndex = 13;
            this.LblInspector.Text = "Inspector";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(877, 527);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 19);
            this.LblName.TabIndex = 14;
            this.LblName.Text = "Name";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(877, 469);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(95, 19);
            this.LblTotal.TabIndex = 14;
            this.LblTotal.Text = "Total Area (ft2)";
            // 
            // DevelopmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 573);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblInspector);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.metroTextBox7);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.metroTextBox5);
            this.Controls.Add(this.metroTextBox6);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.LblThickness);
            this.Controls.Add(this.LblLength);
            this.Controls.Add(this.LblRemarks);
            this.Controls.Add(this.LblWidth);
            this.Controls.Add(this.LblRoll);
            this.Controls.Add(this.LblPanel);
            this.Controls.Add(this.DGVDev);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtSupplier);
            this.Controls.Add(this.TxtGeoSynthetic);
            this.Controls.Add(this.TxtProjectNo);
            this.Controls.Add(this.TxtProject);
            this.Controls.Add(this.TxtContractor);
            this.Controls.Add(this.TxtClient);
            this.Controls.Add(this.PBPicture);
            this.Controls.Add(this.LblSupplier);
            this.Controls.Add(this.LblProject);
            this.Controls.Add(this.LblGeoSynthetic);
            this.Controls.Add(this.LblContractor);
            this.Controls.Add(this.LblProjectNo);
            this.Controls.Add(this.LblClient);
            this.Name = "DevelopmentForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Load += new System.EventHandler(this.DevelopmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox TxtClient;
        private MetroFramework.Controls.MetroTextBox TxtProject;
        private MetroFramework.Controls.MetroTextBox TxtContractor;
        private MetroFramework.Controls.MetroTextBox TxtSupplier;
        private MetroFramework.Controls.MetroTextBox TxtProjectNo;
        private MetroFramework.Controls.MetroTextBox TxtGeoSynthetic;
        private MetroFramework.Controls.MetroLabel LblTitle;
        private MetroFramework.Controls.MetroGrid DGVDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeploymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PanelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private MetroFramework.Controls.MetroLabel LblPanel;
        private MetroFramework.Controls.MetroLabel LblRoll;
        private MetroFramework.Controls.MetroLabel LblLength;
        private MetroFramework.Controls.MetroLabel LblWidth;
        private MetroFramework.Controls.MetroLabel LblThickness;
        private MetroFramework.Controls.MetroLabel LblArea;
        private MetroFramework.Controls.MetroLabel LblRemarks;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroButton BtnCreate;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel LblInspector;
        private MetroFramework.Controls.MetroLabel LblName;
        private MetroFramework.Controls.MetroLabel LblTotal;
    }
}