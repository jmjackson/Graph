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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
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
            this.LblId.BackColor = System.Drawing.SystemColors.Control;
            this.LblId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblId.Location = new System.Drawing.Point(53, 41);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(26, 25);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "Id";
            this.LblId.UseCustomBackColor = true;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.SystemColors.Control;
            this.LblName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblName.Location = new System.Drawing.Point(489, 41);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(106, 25);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Client Name";
            this.LblName.UseCustomBackColor = true;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.BackColor = System.Drawing.SystemColors.Control;
            this.LblCode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblCode.Location = new System.Drawing.Point(216, 41);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(100, 25);
            this.LblCode.TabIndex = 0;
            this.LblCode.Text = "Client Code";
            this.LblCode.UseCustomBackColor = true;
            // 
            // PBLogo
            // 
            this.PBLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBLogo.Location = new System.Drawing.Point(827, 19);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.ProjectNo,
            this.Contractor,
            this.Supplier,
            this.Geosynthetic});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVProject.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProject.EnableHeadersVisualStyles = false;
            this.DGVProject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVProject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVProject.Location = new System.Drawing.Point(0, 0);
            this.DGVProject.Name = "DGVProject";
            this.DGVProject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProject.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVProject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DGVProject.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProject.Size = new System.Drawing.Size(1004, 362);
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
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Location = new System.Drawing.Point(588, 48);
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
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEdit.Location = new System.Drawing.Point(432, 48);
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
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCreate.Location = new System.Drawing.Point(277, 48);
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
            this.LblRId.BackColor = System.Drawing.SystemColors.Control;
            this.LblRId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblRId.Location = new System.Drawing.Point(79, 41);
            this.LblRId.Name = "LblRId";
            this.LblRId.Size = new System.Drawing.Size(103, 25);
            this.LblRId.TabIndex = 9;
            this.LblRId.Text = "metroLabel1";
            this.LblRId.UseCustomBackColor = true;
            // 
            // LblRCode
            // 
            this.LblRCode.AutoSize = true;
            this.LblRCode.BackColor = System.Drawing.SystemColors.Control;
            this.LblRCode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblRCode.Location = new System.Drawing.Point(322, 41);
            this.LblRCode.Name = "LblRCode";
            this.LblRCode.Size = new System.Drawing.Size(103, 25);
            this.LblRCode.TabIndex = 9;
            this.LblRCode.Text = "metroLabel1";
            this.LblRCode.UseCustomBackColor = true;
            // 
            // LblRCName
            // 
            this.LblRCName.AutoSize = true;
            this.LblRCName.BackColor = System.Drawing.SystemColors.Control;
            this.LblRCName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblRCName.Location = new System.Drawing.Point(620, 41);
            this.LblRCName.Name = "LblRCName";
            this.LblRCName.Size = new System.Drawing.Size(103, 25);
            this.LblRCName.TabIndex = 9;
            this.LblRCName.Text = "metroLabel1";
            this.LblRCName.UseCustomBackColor = true;
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
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(1004, 100);
            this.PanelHead.TabIndex = 10;
            // 
            // PanelFoot
            // 
            this.PanelFoot.Controls.Add(this.BtnExit);
            this.PanelFoot.Controls.Add(this.BtnBack);
            this.PanelFoot.Controls.Add(this.BtnDelete);
            this.PanelFoot.Controls.Add(this.BtnEdit);
            this.PanelFoot.Controls.Add(this.BtnCreate);
            this.PanelFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFoot.Location = new System.Drawing.Point(0, 462);
            this.PanelFoot.Name = "PanelFoot";
            this.PanelFoot.Size = new System.Drawing.Size(1004, 100);
            this.PanelFoot.TabIndex = 11;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.BtnExit.IconColor = System.Drawing.Color.White;
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.IconSize = 48;
            this.BtnExit.Location = new System.Drawing.Point(893, 22);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Rotation = 0D;
            this.BtnExit.Size = new System.Drawing.Size(99, 66);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.BtnBack.IconColor = System.Drawing.Color.White;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 48;
            this.BtnBack.Location = new System.Drawing.Point(788, 22);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Rotation = 0D;
            this.BtnBack.Size = new System.Drawing.Size(99, 66);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PanelBody
            // 
            this.PanelBody.Controls.Add(this.DGVProject);
            this.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBody.Location = new System.Drawing.Point(0, 100);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(1004, 362);
            this.PanelBody.TabIndex = 12;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 562);
            this.Controls.Add(this.PanelBody);
            this.Controls.Add(this.PanelFoot);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private FontAwesome.Sharp.IconButton BtnExit;
        private FontAwesome.Sharp.IconButton BtnBack;
    }
}