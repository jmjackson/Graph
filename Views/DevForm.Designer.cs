namespace Mine.Views
{
    partial class DevForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblClient = new MetroFramework.Controls.MetroLabel();
            this.LblInspector = new MetroFramework.Controls.MetroLabel();
            this.LblProject = new MetroFramework.Controls.MetroLabel();
            this.LblDate = new MetroFramework.Controls.MetroLabel();
            this.CbClient = new MetroFramework.Controls.MetroComboBox();
            this.CbProject = new MetroFramework.Controls.MetroComboBox();
            this.TxtInspector = new MetroFramework.Controls.MetroTextBox();
            this.BtnAdd = new MetroFramework.Controls.MetroButton();
            this.BtnEdit = new MetroFramework.Controls.MetroButton();
            this.DateDev = new MetroFramework.Controls.MetroDateTime();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.DGVDev = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGeoMembrane = new MetroFramework.Controls.MetroButton();
            this.BtnDeployment = new MetroFramework.Controls.MetroButton();
            this.LblLocation = new MetroFramework.Controls.MetroLabel();
            this.TxtLocation = new MetroFramework.Controls.MetroTextBox();
            this.BtnDraw = new MetroFramework.Controls.MetroButton();
            this.TxtBoxId = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).BeginInit();
            this.SuspendLayout();
            // 
            // LblClient
            // 
            this.LblClient.AutoSize = true;
            this.LblClient.Location = new System.Drawing.Point(43, 59);
            this.LblClient.Name = "LblClient";
            this.LblClient.Size = new System.Drawing.Size(42, 19);
            this.LblClient.TabIndex = 0;
            this.LblClient.Text = "Client";
            // 
            // LblInspector
            // 
            this.LblInspector.AutoSize = true;
            this.LblInspector.Location = new System.Drawing.Point(23, 88);
            this.LblInspector.Name = "LblInspector";
            this.LblInspector.Size = new System.Drawing.Size(62, 19);
            this.LblInspector.TabIndex = 0;
            this.LblInspector.Text = "Inspector";
            // 
            // LblProject
            // 
            this.LblProject.AutoSize = true;
            this.LblProject.Location = new System.Drawing.Point(317, 59);
            this.LblProject.Name = "LblProject";
            this.LblProject.Size = new System.Drawing.Size(50, 19);
            this.LblProject.TabIndex = 0;
            this.LblProject.Text = "Project";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(331, 99);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(36, 19);
            this.LblDate.TabIndex = 0;
            this.LblDate.Text = "Date";
            // 
            // CbClient
            // 
            this.CbClient.FormattingEnabled = true;
            this.CbClient.ItemHeight = 23;
            this.CbClient.Location = new System.Drawing.Point(91, 49);
            this.CbClient.Name = "CbClient";
            this.CbClient.Size = new System.Drawing.Size(201, 29);
            this.CbClient.TabIndex = 2;
            this.CbClient.UseSelectable = true;
            this.CbClient.SelectedIndexChanged += new System.EventHandler(this.CbClient_SelectedIndexChanged);
            // 
            // CbProject
            // 
            this.CbProject.FormattingEnabled = true;
            this.CbProject.ItemHeight = 23;
            this.CbProject.Location = new System.Drawing.Point(373, 52);
            this.CbProject.Name = "CbProject";
            this.CbProject.Size = new System.Drawing.Size(240, 29);
            this.CbProject.TabIndex = 2;
            this.CbProject.UseSelectable = true;
            // 
            // TxtInspector
            // 
            // 
            // 
            // 
            this.TxtInspector.CustomButton.Image = null;
            this.TxtInspector.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.TxtInspector.CustomButton.Name = "";
            this.TxtInspector.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtInspector.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtInspector.CustomButton.TabIndex = 1;
            this.TxtInspector.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtInspector.CustomButton.UseSelectable = true;
            this.TxtInspector.CustomButton.Visible = false;
            this.TxtInspector.Lines = new string[0];
            this.TxtInspector.Location = new System.Drawing.Point(91, 84);
            this.TxtInspector.MaxLength = 32767;
            this.TxtInspector.Name = "TxtInspector";
            this.TxtInspector.PasswordChar = '\0';
            this.TxtInspector.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtInspector.SelectedText = "";
            this.TxtInspector.SelectionLength = 0;
            this.TxtInspector.SelectionStart = 0;
            this.TxtInspector.ShortcutsEnabled = true;
            this.TxtInspector.Size = new System.Drawing.Size(201, 23);
            this.TxtInspector.TabIndex = 1;
            this.TxtInspector.UseSelectable = true;
            this.TxtInspector.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtInspector.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnAdd
            // 
            this.BtnAdd.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnAdd.Location = new System.Drawing.Point(653, 34);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(93, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseSelectable = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnEdit.Location = new System.Drawing.Point(653, 63);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(93, 23);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseSelectable = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // DateDev
            // 
            this.DateDev.Location = new System.Drawing.Point(374, 89);
            this.DateDev.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateDev.Name = "DateDev";
            this.DateDev.Size = new System.Drawing.Size(239, 29);
            this.DateDev.TabIndex = 4;
            // 
            // BtnDelete
            // 
            this.BtnDelete.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDelete.Location = new System.Drawing.Point(653, 95);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(93, 23);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnSave.Location = new System.Drawing.Point(653, 124);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(93, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DGVDev
            // 
            this.DGVDev.AllowUserToResizeRows = false;
            this.DGVDev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDev.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVDev.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Project,
            this.Inspector,
            this.Location,
            this.DevTime});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDev.DefaultCellStyle = dataGridViewCellStyle11;
            this.DGVDev.EnableHeadersVisualStyles = false;
            this.DGVDev.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVDev.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVDev.Location = new System.Drawing.Point(24, 181);
            this.DGVDev.Name = "DGVDev";
            this.DGVDev.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGVDev.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVDev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDev.Size = new System.Drawing.Size(589, 190);
            this.DGVDev.Style = MetroFramework.MetroColorStyle.Purple;
            this.DGVDev.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.HeaderText = "Item";
            this.Id.Name = "Id";
            // 
            // Project
            // 
            this.Project.HeaderText = "Project";
            this.Project.Name = "Project";
            // 
            // Inspector
            // 
            this.Inspector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Inspector.HeaderText = "Inspector";
            this.Inspector.Name = "Inspector";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // DevTime
            // 
            this.DevTime.HeaderText = "Date";
            this.DevTime.Name = "DevTime";
            // 
            // BtnGeoMembrane
            // 
            this.BtnGeoMembrane.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnGeoMembrane.Location = new System.Drawing.Point(653, 248);
            this.BtnGeoMembrane.Name = "BtnGeoMembrane";
            this.BtnGeoMembrane.Size = new System.Drawing.Size(110, 23);
            this.BtnGeoMembrane.TabIndex = 5;
            this.BtnGeoMembrane.Text = "GeoMembrane";
            this.BtnGeoMembrane.UseSelectable = true;
            // 
            // BtnDeployment
            // 
            this.BtnDeployment.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDeployment.Location = new System.Drawing.Point(653, 219);
            this.BtnDeployment.Name = "BtnDeployment";
            this.BtnDeployment.Size = new System.Drawing.Size(110, 23);
            this.BtnDeployment.TabIndex = 5;
            this.BtnDeployment.Text = "Deployment";
            this.BtnDeployment.UseSelectable = true;
            this.BtnDeployment.Click += new System.EventHandler(this.BtnDeployment_Click);
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(23, 117);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(58, 19);
            this.LblLocation.TabIndex = 0;
            this.LblLocation.Text = "Location";
            // 
            // TxtLocation
            // 
            // 
            // 
            // 
            this.TxtLocation.CustomButton.Image = null;
            this.TxtLocation.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.TxtLocation.CustomButton.Name = "";
            this.TxtLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLocation.CustomButton.TabIndex = 1;
            this.TxtLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLocation.CustomButton.UseSelectable = true;
            this.TxtLocation.CustomButton.Visible = false;
            this.TxtLocation.Lines = new string[0];
            this.TxtLocation.Location = new System.Drawing.Point(91, 113);
            this.TxtLocation.MaxLength = 32767;
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.PasswordChar = '\0';
            this.TxtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLocation.SelectedText = "";
            this.TxtLocation.SelectionLength = 0;
            this.TxtLocation.SelectionStart = 0;
            this.TxtLocation.ShortcutsEnabled = true;
            this.TxtLocation.Size = new System.Drawing.Size(201, 23);
            this.TxtLocation.TabIndex = 1;
            this.TxtLocation.UseSelectable = true;
            this.TxtLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnDraw
            // 
            this.BtnDraw.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDraw.Location = new System.Drawing.Point(653, 277);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(110, 23);
            this.BtnDraw.TabIndex = 5;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseSelectable = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // TxtBoxId
            // 
            // 
            // 
            // 
            this.TxtBoxId.CustomButton.Image = null;
            this.TxtBoxId.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.TxtBoxId.CustomButton.Name = "";
            this.TxtBoxId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBoxId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBoxId.CustomButton.TabIndex = 1;
            this.TxtBoxId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBoxId.CustomButton.UseSelectable = true;
            this.TxtBoxId.CustomButton.Visible = false;
            this.TxtBoxId.Lines = new string[0];
            this.TxtBoxId.Location = new System.Drawing.Point(373, 125);
            this.TxtBoxId.MaxLength = 32767;
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.PasswordChar = '\0';
            this.TxtBoxId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBoxId.SelectedText = "";
            this.TxtBoxId.SelectionLength = 0;
            this.TxtBoxId.SelectionStart = 0;
            this.TxtBoxId.ShortcutsEnabled = true;
            this.TxtBoxId.Size = new System.Drawing.Size(240, 23);
            this.TxtBoxId.TabIndex = 7;
            this.TxtBoxId.UseSelectable = true;
            this.TxtBoxId.Visible = false;
            this.TxtBoxId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBoxId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBoxId);
            this.Controls.Add(this.DGVDev);
            this.Controls.Add(this.BtnDeployment);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.BtnGeoMembrane);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.DateDev);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CbProject);
            this.Controls.Add(this.CbClient);
            this.Controls.Add(this.TxtLocation);
            this.Controls.Add(this.TxtInspector);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.LblProject);
            this.Controls.Add(this.LblInspector);
            this.Controls.Add(this.LblClient);
            this.Name = "DevForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Load += new System.EventHandler(this.DevForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblClient;
        private MetroFramework.Controls.MetroLabel LblInspector;
        private MetroFramework.Controls.MetroLabel LblProject;
        private MetroFramework.Controls.MetroLabel LblDate;
        private MetroFramework.Controls.MetroComboBox CbClient;
        private MetroFramework.Controls.MetroComboBox CbProject;
        private MetroFramework.Controls.MetroTextBox TxtInspector;
        private MetroFramework.Controls.MetroButton BtnAdd;
        private MetroFramework.Controls.MetroButton BtnEdit;
        private MetroFramework.Controls.MetroDateTime DateDev;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroGrid DGVDev;
        private MetroFramework.Controls.MetroButton BtnGeoMembrane;
        private MetroFramework.Controls.MetroButton BtnDeployment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevTime;
        private MetroFramework.Controls.MetroLabel LblLocation;
        private MetroFramework.Controls.MetroTextBox TxtLocation;
        private MetroFramework.Controls.MetroButton BtnDraw;
        private MetroFramework.Controls.MetroTextBox TxtBoxId;
    }
}