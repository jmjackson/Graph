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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnAdd = new MetroFramework.Controls.MetroButton();
            this.BtnEdit = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.DGVDev = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGeoMembrane = new MetroFramework.Controls.MetroButton();
            this.BtnDeployment = new MetroFramework.Controls.MetroButton();
            this.BtnDraw = new MetroFramework.Controls.MetroButton();
            this.TxtBoxId = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnAdd.Location = new System.Drawing.Point(744, 33);
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
            this.BtnEdit.Location = new System.Drawing.Point(744, 62);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(93, 23);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseSelectable = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDelete.Location = new System.Drawing.Point(744, 94);
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
            this.BtnSave.Location = new System.Drawing.Point(744, 123);
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
            this.DGVDev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDev.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVDev.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DevTime,
            this.Project,
            this.Inspector,
            this.Location,
            this.Operator,
            this.MachineNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDev.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDev.EnableHeadersVisualStyles = false;
            this.DGVDev.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVDev.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVDev.Location = new System.Drawing.Point(23, 63);
            this.DGVDev.Name = "DGVDev";
            this.DGVDev.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDev.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVDev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDev.Size = new System.Drawing.Size(687, 249);
            this.DGVDev.Style = MetroFramework.MetroColorStyle.Blue;
            this.DGVDev.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.HeaderText = "Item";
            this.Id.Name = "Id";
            // 
            // DevTime
            // 
            this.DevTime.HeaderText = "Date";
            this.DevTime.Name = "DevTime";
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
            // Operator
            // 
            this.Operator.HeaderText = "Operator";
            this.Operator.Name = "Operator";
            // 
            // MachineNo
            // 
            this.MachineNo.HeaderText = "Machine No";
            this.MachineNo.Name = "MachineNo";
            // 
            // BtnGeoMembrane
            // 
            this.BtnGeoMembrane.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnGeoMembrane.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnGeoMembrane.Location = new System.Drawing.Point(744, 247);
            this.BtnGeoMembrane.Name = "BtnGeoMembrane";
            this.BtnGeoMembrane.Size = new System.Drawing.Size(110, 23);
            this.BtnGeoMembrane.TabIndex = 5;
            this.BtnGeoMembrane.Text = "Seaming";
            this.BtnGeoMembrane.UseSelectable = true;
            this.BtnGeoMembrane.Click += new System.EventHandler(this.BtnGeoMembrane_Click);
            // 
            // BtnDeployment
            // 
            this.BtnDeployment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnDeployment.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDeployment.Location = new System.Drawing.Point(744, 218);
            this.BtnDeployment.Name = "BtnDeployment";
            this.BtnDeployment.Size = new System.Drawing.Size(110, 23);
            this.BtnDeployment.TabIndex = 5;
            this.BtnDeployment.Text = "Deployment";
            this.BtnDeployment.UseSelectable = true;
            this.BtnDeployment.Click += new System.EventHandler(this.BtnDeployment_Click);
            // 
            // BtnDraw
            // 
            this.BtnDraw.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnDraw.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDraw.Location = new System.Drawing.Point(744, 276);
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
            this.TxtBoxId.Location = new System.Drawing.Point(331, 436);
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
            this.ClientSize = new System.Drawing.Size(877, 482);
            this.Controls.Add(this.TxtBoxId);
            this.Controls.Add(this.DGVDev);
            this.Controls.Add(this.BtnDeployment);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.BtnGeoMembrane);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Name = "DevForm";
            this.Text = "Inspection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DevForm_FormClosed);
            this.Load += new System.EventHandler(this.DevForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnAdd;
        private MetroFramework.Controls.MetroButton BtnEdit;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroGrid DGVDev;
        private MetroFramework.Controls.MetroButton BtnGeoMembrane;
        private MetroFramework.Controls.MetroButton BtnDeployment;
        private MetroFramework.Controls.MetroButton BtnDraw;
        private MetroFramework.Controls.MetroTextBox TxtBoxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineNo;
    }
}