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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDev.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDev.EnableHeadersVisualStyles = false;
            this.DGVDev.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVDev.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DGVDev.Location = new System.Drawing.Point(20, 150);
            this.DGVDev.Name = "DGVDev";
            this.DGVDev.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            // DevelopmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 573);
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
    }
}