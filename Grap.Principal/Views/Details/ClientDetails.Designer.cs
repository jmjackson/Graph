namespace Grap.Principal.Views.Details
{
    partial class ClientDetails
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.bunifuCards1 = new ns1.BunifuCards();
            this.TxtName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtItem = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.LblCode = new System.Windows.Forms.Label();
            this.DGVProject = new ns1.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contractor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeoSynthetic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeachPad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelHeader.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProject)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.White;
            this.PanelHeader.Controls.Add(this.bunifuCards1);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(842, 150);
            this.PanelHeader.TabIndex = 0;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.TxtName);
            this.bunifuCards1.Controls.Add(this.TxtCode);
            this.bunifuCards1.Controls.Add(this.TxtItem);
            this.bunifuCards1.Controls.Add(this.PBLogo);
            this.bunifuCards1.Controls.Add(this.LblName);
            this.bunifuCards1.Controls.Add(this.LblId);
            this.bunifuCards1.Controls.Add(this.LblCode);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.Enabled = false;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(842, 150);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.BunifuCards1_Paint);
            // 
            // TxtName
            // 
            this.TxtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.TxtName.Location = new System.Drawing.Point(419, 41);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(269, 20);
            this.TxtName.TabIndex = 6;
            // 
            // TxtCode
            // 
            this.TxtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtCode.Location = new System.Drawing.Point(222, 42);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(100, 20);
            this.TxtCode.TabIndex = 5;
            // 
            // TxtItem
            // 
            this.TxtItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtItem.Location = new System.Drawing.Point(84, 42);
            this.TxtItem.Name = "TxtItem";
            this.TxtItem.Size = new System.Drawing.Size(66, 20);
            this.TxtItem.TabIndex = 4;
            // 
            // PBLogo
            // 
            this.PBLogo.Location = new System.Drawing.Point(708, 12);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(122, 99);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 2;
            this.PBLogo.TabStop = false;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(347, 41);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(66, 21);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Nombre";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(38, 41);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(40, 21);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Item";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCode.Location = new System.Drawing.Point(156, 41);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(60, 21);
            this.LblCode.TabIndex = 1;
            this.LblCode.Text = "Codigo";
            // 
            // DGVProject
            // 
            this.DGVProject.AllowUserToAddRows = false;
            this.DGVProject.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVProject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVProject.BackgroundColor = System.Drawing.Color.White;
            this.DGVProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVProject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProjectName,
            this.ProjectNo,
            this.Contractor,
            this.Supplier,
            this.GeoSynthetic,
            this.LeachPad,
            this.Operator,
            this.MachineNo,
            this.ClientsId});
            this.DGVProject.DoubleBuffered = true;
            this.DGVProject.EnableHeadersVisualStyles = false;
            this.DGVProject.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.DGVProject.HeaderForeColor = System.Drawing.Color.White;
            this.DGVProject.Location = new System.Drawing.Point(12, 156);
            this.DGVProject.Name = "DGVProject";
            this.DGVProject.ReadOnly = true;
            this.DGVProject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVProject.Size = new System.Drawing.Size(818, 282);
            this.DGVProject.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Item";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // ProjectNo
            // 
            this.ProjectNo.HeaderText = "Project No";
            this.ProjectNo.Name = "ProjectNo";
            this.ProjectNo.ReadOnly = true;
            // 
            // Contractor
            // 
            this.Contractor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contractor.HeaderText = "Contractor";
            this.Contractor.Name = "Contractor";
            this.Contractor.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // GeoSynthetic
            // 
            this.GeoSynthetic.HeaderText = "Geosynthetic";
            this.GeoSynthetic.Name = "GeoSynthetic";
            this.GeoSynthetic.ReadOnly = true;
            // 
            // LeachPad
            // 
            this.LeachPad.HeaderText = "Leachpad";
            this.LeachPad.Name = "LeachPad";
            this.LeachPad.ReadOnly = true;
            // 
            // Operator
            // 
            this.Operator.HeaderText = "Operator";
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            // 
            // MachineNo
            // 
            this.MachineNo.HeaderText = "MachineNo";
            this.MachineNo.Name = "MachineNo";
            this.MachineNo.ReadOnly = true;
            // 
            // ClientsId
            // 
            this.ClientsId.HeaderText = "ClientId";
            this.ClientsId.Name = "ClientsId";
            this.ClientsId.ReadOnly = true;
            // 
            // ClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.DGVProject);
            this.Controls.Add(this.PanelHeader);
            this.Name = "ClientDetails";
            this.Text = "Detalles del Cliente";
            this.Load += new System.EventHandler(this.ClientDetails_Load);
            this.PanelHeader.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private ns1.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.PictureBox PBLogo;
        private ns1.BunifuCustomDataGrid DGVProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contractor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeoSynthetic;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeachPad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientsId;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtItem;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtCode;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtName;
    }
}