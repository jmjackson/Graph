namespace Grap.Principal
{
    partial class ReportDeployment
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
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.CardDeployment = new ns1.BunifuCards();
            this.LblTitle = new ns1.BunifuCustomLabel();
            this.LblProject = new System.Windows.Forms.Label();
            this.LblContractor = new System.Windows.Forms.Label();
            this.LblClient = new System.Windows.Forms.Label();
            this.LblProjectNo = new System.Windows.Forms.Label();
            this.LblGeosynthetic = new System.Windows.Forms.Label();
            this.LblSupplier = new System.Windows.Forms.Label();
            this.TxtClient = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtProject = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtPNumber = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtContractor = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtGeoSynthetic = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtSupplier = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.DGDeployment = new ns1.BunifuCustomDataGrid();
            this.BtnProject = new FontAwesome.Sharp.IconButton();
            this.BtnDetails = new FontAwesome.Sharp.IconButton();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelPrincipal.SuspendLayout();
            this.CardDeployment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDeployment)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.CardDeployment);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(957, 683);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // CardDeployment
            // 
            this.CardDeployment.BackColor = System.Drawing.Color.White;
            this.CardDeployment.BorderRadius = 5;
            this.CardDeployment.BottomSahddow = true;
            this.CardDeployment.color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.CardDeployment.Controls.Add(this.BtnDelete);
            this.CardDeployment.Controls.Add(this.BtnDetails);
            this.CardDeployment.Controls.Add(this.BtnProject);
            this.CardDeployment.Controls.Add(this.DGDeployment);
            this.CardDeployment.Controls.Add(this.PBImage);
            this.CardDeployment.Controls.Add(this.TxtGeoSynthetic);
            this.CardDeployment.Controls.Add(this.TxtSupplier);
            this.CardDeployment.Controls.Add(this.TxtPNumber);
            this.CardDeployment.Controls.Add(this.TxtContractor);
            this.CardDeployment.Controls.Add(this.TxtProject);
            this.CardDeployment.Controls.Add(this.TxtClient);
            this.CardDeployment.Controls.Add(this.LblSupplier);
            this.CardDeployment.Controls.Add(this.LblGeosynthetic);
            this.CardDeployment.Controls.Add(this.LblProjectNo);
            this.CardDeployment.Controls.Add(this.LblClient);
            this.CardDeployment.Controls.Add(this.LblContractor);
            this.CardDeployment.Controls.Add(this.LblProject);
            this.CardDeployment.Controls.Add(this.LblTitle);
            this.CardDeployment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardDeployment.LeftSahddow = false;
            this.CardDeployment.Location = new System.Drawing.Point(0, 0);
            this.CardDeployment.Name = "CardDeployment";
            this.CardDeployment.RightSahddow = true;
            this.CardDeployment.ShadowDepth = 20;
            this.CardDeployment.Size = new System.Drawing.Size(957, 683);
            this.CardDeployment.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(453, 18);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(118, 20);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Deployment Log";
            // 
            // LblProject
            // 
            this.LblProject.AutoSize = true;
            this.LblProject.Location = new System.Drawing.Point(50, 82);
            this.LblProject.Name = "LblProject";
            this.LblProject.Size = new System.Drawing.Size(40, 13);
            this.LblProject.TabIndex = 2;
            this.LblProject.Text = "Project";
            // 
            // LblContractor
            // 
            this.LblContractor.AutoSize = true;
            this.LblContractor.Location = new System.Drawing.Point(441, 51);
            this.LblContractor.Name = "LblContractor";
            this.LblContractor.Size = new System.Drawing.Size(56, 13);
            this.LblContractor.TabIndex = 2;
            this.LblContractor.Text = "Contractor";
            // 
            // LblClient
            // 
            this.LblClient.AutoSize = true;
            this.LblClient.Location = new System.Drawing.Point(50, 51);
            this.LblClient.Name = "LblClient";
            this.LblClient.Size = new System.Drawing.Size(33, 13);
            this.LblClient.TabIndex = 2;
            this.LblClient.Text = "Client";
            // 
            // LblProjectNo
            // 
            this.LblProjectNo.AutoSize = true;
            this.LblProjectNo.Location = new System.Drawing.Point(50, 122);
            this.LblProjectNo.Name = "LblProjectNo";
            this.LblProjectNo.Size = new System.Drawing.Size(57, 13);
            this.LblProjectNo.TabIndex = 2;
            this.LblProjectNo.Text = "Project No";
            // 
            // LblGeosynthetic
            // 
            this.LblGeosynthetic.AutoSize = true;
            this.LblGeosynthetic.Location = new System.Drawing.Point(426, 122);
            this.LblGeosynthetic.Name = "LblGeosynthetic";
            this.LblGeosynthetic.Size = new System.Drawing.Size(71, 13);
            this.LblGeosynthetic.TabIndex = 2;
            this.LblGeosynthetic.Text = "GeoSynthetic";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Location = new System.Drawing.Point(454, 82);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(45, 13);
            this.LblSupplier.TabIndex = 2;
            this.LblSupplier.Text = "Supplier";
            // 
            // TxtClient
            // 
            this.TxtClient.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtClient.Location = new System.Drawing.Point(126, 48);
            this.TxtClient.Name = "TxtClient";
            this.TxtClient.ReadOnly = true;
            this.TxtClient.Size = new System.Drawing.Size(266, 20);
            this.TxtClient.TabIndex = 3;
            // 
            // TxtProject
            // 
            this.TxtProject.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtProject.Location = new System.Drawing.Point(126, 82);
            this.TxtProject.Name = "TxtProject";
            this.TxtProject.ReadOnly = true;
            this.TxtProject.Size = new System.Drawing.Size(266, 20);
            this.TxtProject.TabIndex = 3;
            // 
            // TxtPNumber
            // 
            this.TxtPNumber.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPNumber.Location = new System.Drawing.Point(126, 115);
            this.TxtPNumber.Name = "TxtPNumber";
            this.TxtPNumber.ReadOnly = true;
            this.TxtPNumber.Size = new System.Drawing.Size(266, 20);
            this.TxtPNumber.TabIndex = 3;
            // 
            // TxtContractor
            // 
            this.TxtContractor.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtContractor.Location = new System.Drawing.Point(505, 48);
            this.TxtContractor.Name = "TxtContractor";
            this.TxtContractor.ReadOnly = true;
            this.TxtContractor.Size = new System.Drawing.Size(266, 20);
            this.TxtContractor.TabIndex = 3;
            // 
            // TxtGeoSynthetic
            // 
            this.TxtGeoSynthetic.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtGeoSynthetic.Location = new System.Drawing.Point(505, 115);
            this.TxtGeoSynthetic.Name = "TxtGeoSynthetic";
            this.TxtGeoSynthetic.ReadOnly = true;
            this.TxtGeoSynthetic.Size = new System.Drawing.Size(266, 20);
            this.TxtGeoSynthetic.TabIndex = 3;
            // 
            // TxtSupplier
            // 
            this.TxtSupplier.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSupplier.Location = new System.Drawing.Point(505, 82);
            this.TxtSupplier.Name = "TxtSupplier";
            this.TxtSupplier.ReadOnly = true;
            this.TxtSupplier.Size = new System.Drawing.Size(266, 20);
            this.TxtSupplier.TabIndex = 3;
            // 
            // PBImage
            // 
            this.PBImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBImage.Location = new System.Drawing.Point(790, 48);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(155, 87);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImage.TabIndex = 4;
            this.PBImage.TabStop = false;
            // 
            // DGDeployment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGDeployment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGDeployment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGDeployment.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGDeployment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGDeployment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDeployment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGDeployment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDeployment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.DateCreated,
            this.PanelNo,
            this.RollNo,
            this.Length,
            this.DWidth,
            this.Thickness,
            this.Area,
            this.Remarks});
            this.DGDeployment.DoubleBuffered = true;
            this.DGDeployment.EnableHeadersVisualStyles = false;
            this.DGDeployment.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.DGDeployment.HeaderForeColor = System.Drawing.Color.White;
            this.DGDeployment.Location = new System.Drawing.Point(12, 188);
            this.DGDeployment.Name = "DGDeployment";
            this.DGDeployment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGDeployment.Size = new System.Drawing.Size(933, 408);
            this.DGDeployment.TabIndex = 5;
            // 
            // BtnProject
            // 
            this.BtnProject.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnProject.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnProject.IconColor = System.Drawing.Color.Black;
            this.BtnProject.IconSize = 16;
            this.BtnProject.Location = new System.Drawing.Point(684, 602);
            this.BtnProject.Name = "BtnProject";
            this.BtnProject.Rotation = 0D;
            this.BtnProject.Size = new System.Drawing.Size(75, 23);
            this.BtnProject.TabIndex = 6;
            this.BtnProject.Text = "Save";
            this.BtnProject.UseVisualStyleBackColor = true;
            // 
            // BtnDetails
            // 
            this.BtnDetails.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDetails.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnDetails.IconColor = System.Drawing.Color.Black;
            this.BtnDetails.IconSize = 16;
            this.BtnDetails.Location = new System.Drawing.Point(781, 602);
            this.BtnDetails.Name = "BtnDetails";
            this.BtnDetails.Rotation = 0D;
            this.BtnDetails.Size = new System.Drawing.Size(75, 23);
            this.BtnDetails.TabIndex = 6;
            this.BtnDetails.Text = "Edit";
            this.BtnDetails.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnDelete.IconColor = System.Drawing.Color.Black;
            this.BtnDelete.IconSize = 16;
            this.BtnDelete.Location = new System.Drawing.Point(870, 602);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Rotation = 0D;
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // DateCreated
            // 
            this.DateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateCreated.HeaderText = "Date Created";
            this.DateCreated.Name = "DateCreated";
            // 
            // PanelNo
            // 
            this.PanelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PanelNo.HeaderText = "PanelNo";
            this.PanelNo.Name = "PanelNo";
            // 
            // RollNo
            // 
            this.RollNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RollNo.HeaderText = "Roll No";
            this.RollNo.Name = "RollNo";
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            // 
            // DWidth
            // 
            this.DWidth.HeaderText = "Width";
            this.DWidth.Name = "DWidth";
            // 
            // Thickness
            // 
            this.Thickness.HeaderText = "Thickness";
            this.Thickness.Name = "Thickness";
            // 
            // Area
            // 
            this.Area.HeaderText = "Area(Ft2)";
            this.Area.Name = "Area";
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            // 
            // ReportDeployment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 683);
            this.Controls.Add(this.PanelPrincipal);
            this.Name = "ReportDeployment";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportDeployment_Load);
            this.PanelPrincipal.ResumeLayout(false);
            this.CardDeployment.ResumeLayout(false);
            this.CardDeployment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDeployment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private ns1.BunifuCards CardDeployment;
        private ns1.BunifuCustomLabel LblTitle;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtGeoSynthetic;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtSupplier;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtPNumber;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtContractor;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtProject;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtClient;
        private System.Windows.Forms.Label LblSupplier;
        private System.Windows.Forms.Label LblGeosynthetic;
        private System.Windows.Forms.Label LblProjectNo;
        private System.Windows.Forms.Label LblClient;
        private System.Windows.Forms.Label LblContractor;
        private System.Windows.Forms.Label LblProject;
        private System.Windows.Forms.PictureBox PBImage;
        private ns1.BunifuCustomDataGrid DGDeployment;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnDetails;
        private FontAwesome.Sharp.IconButton BtnProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn PanelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn DWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}