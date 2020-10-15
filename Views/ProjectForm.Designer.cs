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
            this.DGVProject = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contractor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geosynthetic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.BtnEdit = new MetroFramework.Controls.MetroButton();
            this.BtnCreate = new MetroFramework.Controls.MetroButton();
            this.LblRId = new MetroFramework.Controls.MetroLabel();
            this.LblRCode = new MetroFramework.Controls.MetroLabel();
            this.LblRCName = new MetroFramework.Controls.MetroLabel();
            this.PanelHead = new System.Windows.Forms.Panel();
            this.PanelFoot = new System.Windows.Forms.Panel();
            this.PanelBody = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProject)).BeginInit();
            this.PanelHead.SuspendLayout();
            this.PanelFoot.SuspendLayout();
            this.PanelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(8, 23);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(20, 19);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "Id";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(444, 23);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(82, 19);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Client Name";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(171, 23);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(78, 19);
            this.LblCode.TabIndex = 0;
            this.LblCode.Text = "Client Code";
            // 
            // PBLogo
            // 
            this.PBLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBLogo.Location = new System.Drawing.Point(682, 19);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(153, 50);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 1;
            this.PBLogo.TabStop = false;
            // 
            // DGVProject
            // 
            this.DGVProject.AllowUserToResizeRows = false;
            this.DGVProject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.DGVProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProject.EnableHeadersVisualStyles = false;
            this.DGVProject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVProject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVProject.Location = new System.Drawing.Point(0, 0);
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
            this.DGVProject.Size = new System.Drawing.Size(859, 282);
            this.DGVProject.Style = MetroFramework.MetroColorStyle.Blue;
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
            this.PName.HeaderText = "Project";
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
            // BtnDelete
            // 
            this.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.BtnDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnDelete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Location = new System.Drawing.Point(515, 48);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(135, 33);
            this.BtnDelete.Style = MetroFramework.MetroColorStyle.Purple;
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseCustomBackColor = true;
            this.BtnDelete.UseCustomForeColor = true;
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.UseStyleColors = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnEdit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnEdit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEdit.Location = new System.Drawing.Point(359, 48);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(135, 33);
            this.BtnEdit.Style = MetroFramework.MetroColorStyle.Purple;
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseCustomBackColor = true;
            this.BtnEdit.UseCustomForeColor = true;
            this.BtnEdit.UseSelectable = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnCreate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnCreate.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCreate.Location = new System.Drawing.Point(204, 48);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(135, 33);
            this.BtnCreate.Style = MetroFramework.MetroColorStyle.Purple;
            this.BtnCreate.TabIndex = 6;
            this.BtnCreate.Text = "Add";
            this.BtnCreate.UseCustomBackColor = true;
            this.BtnCreate.UseCustomForeColor = true;
            this.BtnCreate.UseSelectable = true;
            this.BtnCreate.UseStyleColors = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // LblRId
            // 
            this.LblRId.AutoSize = true;
            this.LblRId.Location = new System.Drawing.Point(34, 23);
            this.LblRId.Name = "LblRId";
            this.LblRId.Size = new System.Drawing.Size(81, 19);
            this.LblRId.TabIndex = 9;
            this.LblRId.Text = "metroLabel1";
            // 
            // LblRCode
            // 
            this.LblRCode.AutoSize = true;
            this.LblRCode.Location = new System.Drawing.Point(255, 23);
            this.LblRCode.Name = "LblRCode";
            this.LblRCode.Size = new System.Drawing.Size(81, 19);
            this.LblRCode.TabIndex = 9;
            this.LblRCode.Text = "metroLabel1";
            // 
            // LblRCName
            // 
            this.LblRCName.AutoSize = true;
            this.LblRCName.Location = new System.Drawing.Point(544, 23);
            this.LblRCName.Name = "LblRCName";
            this.LblRCName.Size = new System.Drawing.Size(81, 19);
            this.LblRCName.TabIndex = 9;
            this.LblRCName.Text = "metroLabel1";
            // 
            // PanelHead
            // 
            this.PanelHead.Controls.Add(this.LblRCode);
            this.PanelHead.Controls.Add(this.LblRCName);
            this.PanelHead.Controls.Add(this.LblId);
            this.PanelHead.Controls.Add(this.LblName);
            this.PanelHead.Controls.Add(this.LblRId);
            this.PanelHead.Controls.Add(this.LblCode);
            this.PanelHead.Controls.Add(this.PBLogo);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(20, 60);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(859, 100);
            this.PanelHead.TabIndex = 10;
            // 
            // PanelFoot
            // 
            this.PanelFoot.Controls.Add(this.BtnDelete);
            this.PanelFoot.Controls.Add(this.BtnEdit);
            this.PanelFoot.Controls.Add(this.BtnCreate);
            this.PanelFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFoot.Location = new System.Drawing.Point(20, 442);
            this.PanelFoot.Name = "PanelFoot";
            this.PanelFoot.Size = new System.Drawing.Size(859, 100);
            this.PanelFoot.TabIndex = 11;
            // 
            // PanelBody
            // 
            this.PanelBody.Controls.Add(this.DGVProject);
            this.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBody.Location = new System.Drawing.Point(20, 160);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(859, 282);
            this.PanelBody.TabIndex = 12;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 562);
            this.Controls.Add(this.PanelBody);
            this.Controls.Add(this.PanelFoot);
            this.Controls.Add(this.PanelHead);
            this.Name = "ProjectForm";
            this.Text = "Projects";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectForm_FormClosed);
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProject)).EndInit();
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.PanelFoot.ResumeLayout(false);
            this.PanelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblId;
        private MetroFramework.Controls.MetroLabel LblName;
        private MetroFramework.Controls.MetroLabel LblCode;
        private System.Windows.Forms.PictureBox PBLogo;
        private MetroFramework.Controls.MetroGrid DGVProject;
        private MetroFramework.Controls.MetroButton BtnCreate;
        private MetroFramework.Controls.MetroButton BtnEdit;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contractor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geosynthetic;
        private MetroFramework.Controls.MetroLabel LblRId;
        private MetroFramework.Controls.MetroLabel LblRCode;
        private MetroFramework.Controls.MetroLabel LblRCName;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Panel PanelFoot;
        private System.Windows.Forms.Panel PanelBody;
    }
}