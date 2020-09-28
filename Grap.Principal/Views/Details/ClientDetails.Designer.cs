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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.CardPrincipal = new ns1.BunifuCards();
            this.DGVProject = new ns1.BunifuCustomDataGrid();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contractor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeoSynthetic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeachPad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.TxtCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtItem = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.LblName = new ns1.BunifuCustomLabel();
            this.LblItem = new ns1.BunifuCustomLabel();
            this.LblCode = new ns1.BunifuCustomLabel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnGeo = new FontAwesome.Sharp.IconButton();
            this.BtnDeploy = new FontAwesome.Sharp.IconButton();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.PanelPrincipal.SuspendLayout();
            this.CardPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.CardPrincipal);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(842, 450);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // CardPrincipal
            // 
            this.CardPrincipal.BackColor = System.Drawing.Color.White;
            this.CardPrincipal.BorderRadius = 5;
            this.CardPrincipal.BottomSahddow = true;
            this.CardPrincipal.color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.CardPrincipal.Controls.Add(this.DGVProject);
            this.CardPrincipal.Controls.Add(this.PBImage);
            this.CardPrincipal.Controls.Add(this.TxtCode);
            this.CardPrincipal.Controls.Add(this.TxtName);
            this.CardPrincipal.Controls.Add(this.TxtItem);
            this.CardPrincipal.Controls.Add(this.LblName);
            this.CardPrincipal.Controls.Add(this.LblItem);
            this.CardPrincipal.Controls.Add(this.LblCode);
            this.CardPrincipal.Controls.Add(this.BtnClose);
            this.CardPrincipal.Controls.Add(this.BtnGeo);
            this.CardPrincipal.Controls.Add(this.BtnDeploy);
            this.CardPrincipal.Controls.Add(this.BtnAdd);
            this.CardPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardPrincipal.LeftSahddow = false;
            this.CardPrincipal.Location = new System.Drawing.Point(0, 0);
            this.CardPrincipal.Name = "CardPrincipal";
            this.CardPrincipal.RightSahddow = true;
            this.CardPrincipal.ShadowDepth = 20;
            this.CardPrincipal.Size = new System.Drawing.Size(842, 450);
            this.CardPrincipal.TabIndex = 0;
            // 
            // DGVProject
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVProject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVProject.BackgroundColor = System.Drawing.Color.White;
            this.DGVProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVProject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.ProjectNo,
            this.ProjectName,
            this.Contractor,
            this.Supplier,
            this.GeoSynthetic,
            this.LeachPad,
            this.Operator,
            this.MachineNo});
            this.DGVProject.DoubleBuffered = true;
            this.DGVProject.EnableHeadersVisualStyles = false;
            this.DGVProject.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.DGVProject.HeaderForeColor = System.Drawing.Color.White;
            this.DGVProject.Location = new System.Drawing.Point(12, 163);
            this.DGVProject.Name = "DGVProject";
            this.DGVProject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVProject.Size = new System.Drawing.Size(818, 275);
            this.DGVProject.TabIndex = 5;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // ProjectNo
            // 
            this.ProjectNo.HeaderText = "Project No";
            this.ProjectNo.Name = "ProjectNo";
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
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
            // GeoSynthetic
            // 
            this.GeoSynthetic.HeaderText = "GeoSynthetic";
            this.GeoSynthetic.Name = "GeoSynthetic";
            // 
            // LeachPad
            // 
            this.LeachPad.HeaderText = "LeachPad";
            this.LeachPad.Name = "LeachPad";
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
            // PBImage
            // 
            this.PBImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBImage.Location = new System.Drawing.Point(652, 15);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(165, 105);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImage.TabIndex = 4;
            this.PBImage.TabStop = false;
            // 
            // TxtCode
            // 
            this.TxtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtCode.Location = new System.Drawing.Point(195, 45);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.ReadOnly = true;
            this.TxtCode.Size = new System.Drawing.Size(100, 20);
            this.TxtCode.TabIndex = 3;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtName.Location = new System.Drawing.Point(371, 45);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(244, 20);
            this.TxtName.TabIndex = 3;
            // 
            // TxtItem
            // 
            this.TxtItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.TxtItem.Location = new System.Drawing.Point(73, 45);
            this.TxtItem.Name = "TxtItem";
            this.TxtItem.ReadOnly = true;
            this.TxtItem.Size = new System.Drawing.Size(54, 20);
            this.TxtItem.TabIndex = 3;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(321, 48);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 13);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Nombre";
            // 
            // LblItem
            // 
            this.LblItem.AutoSize = true;
            this.LblItem.Location = new System.Drawing.Point(40, 48);
            this.LblItem.Name = "LblItem";
            this.LblItem.Size = new System.Drawing.Size(27, 13);
            this.LblItem.TabIndex = 2;
            this.LblItem.Text = "Item";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(149, 48);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(40, 13);
            this.LblCode.TabIndex = 2;
            this.LblCode.Text = "Codigo";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnClose.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClose.IconSize = 16;
            this.BtnClose.Location = new System.Drawing.Point(412, 113);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(107, 33);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // BtnGeo
            // 
            this.BtnGeo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnGeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnGeo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGeo.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnGeo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGeo.IconSize = 16;
            this.BtnGeo.Location = new System.Drawing.Point(299, 113);
            this.BtnGeo.Name = "BtnGeo";
            this.BtnGeo.Rotation = 0D;
            this.BtnGeo.Size = new System.Drawing.Size(107, 33);
            this.BtnGeo.TabIndex = 1;
            this.BtnGeo.Text = "GeoMembrane";
            this.BtnGeo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGeo.UseVisualStyleBackColor = false;
            // 
            // BtnDeploy
            // 
            this.BtnDeploy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnDeploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeploy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDeploy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeploy.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnDeploy.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeploy.IconSize = 16;
            this.BtnDeploy.Location = new System.Drawing.Point(186, 113);
            this.BtnDeploy.Name = "BtnDeploy";
            this.BtnDeploy.Rotation = 0D;
            this.BtnDeploy.Size = new System.Drawing.Size(107, 33);
            this.BtnDeploy.TabIndex = 1;
            this.BtnDeploy.Text = "Deployment";
            this.BtnDeploy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDeploy.UseVisualStyleBackColor = false;
            this.BtnDeploy.Click += new System.EventHandler(this.BtnDeploy_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAdd.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdd.IconSize = 16;
            this.BtnAdd.Location = new System.Drawing.Point(73, 113);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Rotation = 0D;
            this.BtnAdd.Size = new System.Drawing.Size(107, 33);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add Project";
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.PanelPrincipal);
            this.Name = "ClientDetails";
            this.Text = "Detalles del Cliente";
            this.Load += new System.EventHandler(this.ClientDetails_Load);
            this.PanelPrincipal.ResumeLayout(false);
            this.CardPrincipal.ResumeLayout(false);
            this.CardPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private ns1.BunifuCards CardPrincipal;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private System.Windows.Forms.PictureBox PBImage;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtCode;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtItem;
        private ns1.BunifuCustomLabel LblName;
        private ns1.BunifuCustomLabel LblItem;
        private ns1.BunifuCustomLabel LblCode;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnGeo;
        private FontAwesome.Sharp.IconButton BtnDeploy;
        private ns1.BunifuCustomDataGrid DGVProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contractor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeoSynthetic;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeachPad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineNo;
    }
}