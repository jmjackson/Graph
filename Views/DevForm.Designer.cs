﻿namespace Mine.Views
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevForm));
            this.DGVDev = new MetroFramework.Controls.MetroGrid();
            this.BtnGeoMembrane = new MetroFramework.Controls.MetroButton();
            this.BtnDeployment = new MetroFramework.Controls.MetroButton();
            this.BtnDraw = new MetroFramework.Controls.MetroButton();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.BtnEdit = new FontAwesome.Sharp.IconButton();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.LblTitle = new ns1.BunifuCustomLabel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BElipse = new ns1.BunifuElipse(this.components);
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.PanelFooter.SuspendLayout();
            this.PanelRight.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDev
            // 
            this.DGVDev.AllowUserToAddRows = false;
            this.DGVDev.AllowUserToDeleteRows = false;
            this.DGVDev.AllowUserToResizeColumns = false;
            this.DGVDev.AllowUserToResizeRows = false;
            this.DGVDev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVDev.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVDev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDev.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVDev.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Operator,
            this.MachineNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDev.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDev.EnableHeadersVisualStyles = false;
            this.DGVDev.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVDev.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVDev.Location = new System.Drawing.Point(0, 0);
            this.DGVDev.Name = "DGVDev";
            this.DGVDev.ReadOnly = true;
            this.DGVDev.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDev.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDev.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DGVDev.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVDev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDev.Size = new System.Drawing.Size(1122, 580);
            this.DGVDev.Style = MetroFramework.MetroColorStyle.Blue;
            this.DGVDev.TabIndex = 6;
            this.DGVDev.UseCustomBackColor = true;
            this.DGVDev.UseCustomForeColor = true;
            this.DGVDev.UseStyleColors = true;
            // 
            // BtnGeoMembrane
            // 
            this.BtnGeoMembrane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGeoMembrane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnGeoMembrane.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnGeoMembrane.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnGeoMembrane.ForeColor = System.Drawing.Color.White;
            this.BtnGeoMembrane.Location = new System.Drawing.Point(56, 401);
            this.BtnGeoMembrane.Name = "BtnGeoMembrane";
            this.BtnGeoMembrane.Size = new System.Drawing.Size(172, 71);
            this.BtnGeoMembrane.TabIndex = 5;
            this.BtnGeoMembrane.Text = "Seaming";
            this.BtnGeoMembrane.UseCustomBackColor = true;
            this.BtnGeoMembrane.UseCustomForeColor = true;
            this.BtnGeoMembrane.UseSelectable = true;
            this.BtnGeoMembrane.Click += new System.EventHandler(this.BtnGeoMembrane_Click);
            // 
            // BtnDeployment
            // 
            this.BtnDeployment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeployment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnDeployment.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnDeployment.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDeployment.ForeColor = System.Drawing.Color.White;
            this.BtnDeployment.Location = new System.Drawing.Point(56, 310);
            this.BtnDeployment.Name = "BtnDeployment";
            this.BtnDeployment.Size = new System.Drawing.Size(172, 70);
            this.BtnDeployment.TabIndex = 5;
            this.BtnDeployment.Text = "Deployment";
            this.BtnDeployment.UseCustomBackColor = true;
            this.BtnDeployment.UseCustomForeColor = true;
            this.BtnDeployment.UseSelectable = true;
            this.BtnDeployment.Click += new System.EventHandler(this.BtnDeployment_Click);
            // 
            // BtnDraw
            // 
            this.BtnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnDraw.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnDraw.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDraw.ForeColor = System.Drawing.Color.White;
            this.BtnDraw.Location = new System.Drawing.Point(56, 493);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(172, 72);
            this.BtnDraw.TabIndex = 5;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseCustomBackColor = true;
            this.BtnDraw.UseCustomForeColor = true;
            this.BtnDraw.UseSelectable = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.BtnExit.IconColor = System.Drawing.Color.White;
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.IconSize = 48;
            this.BtnExit.Location = new System.Drawing.Point(1284, 15);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Rotation = 0D;
            this.BtnExit.Size = new System.Drawing.Size(99, 66);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.BtnBack.IconColor = System.Drawing.Color.White;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 48;
            this.BtnBack.Location = new System.Drawing.Point(1175, 15);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Rotation = 0D;
            this.BtnBack.Size = new System.Drawing.Size(99, 66);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAdd.IconColor = System.Drawing.Color.White;
            this.BtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdd.IconSize = 25;
            this.BtnAdd.Location = new System.Drawing.Point(56, 17);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Rotation = 0D;
            this.BtnAdd.Size = new System.Drawing.Size(172, 61);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.BtnEdit.IconColor = System.Drawing.Color.White;
            this.BtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEdit.IconSize = 25;
            this.BtnEdit.Location = new System.Drawing.Point(56, 90);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Rotation = 0D;
            this.BtnEdit.Size = new System.Drawing.Size(172, 61);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnDelete.IconColor = System.Drawing.Color.White;
            this.BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDelete.IconSize = 25;
            this.BtnDelete.Location = new System.Drawing.Point(56, 172);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Rotation = 0D;
            this.BtnDelete.Size = new System.Drawing.Size(172, 61);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.LblTitle.Location = new System.Drawing.Point(12, 24);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(174, 47);
            this.LblTitle.TabIndex = 9;
            this.LblTitle.Text = "Inspection";
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.LblTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1386, 100);
            this.PanelHeader.TabIndex = 10;
            // 
            // BElipse
            // 
            this.BElipse.ElipseRadius = 5;
            this.BElipse.TargetControl = this;
            // 
            // PanelFooter
            // 
            this.PanelFooter.Controls.Add(this.BtnExit);
            this.PanelFooter.Controls.Add(this.BtnBack);
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(0, 688);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(1386, 100);
            this.PanelFooter.TabIndex = 11;
            // 
            // PanelRight
            // 
            this.PanelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRight.Controls.Add(this.BtnDelete);
            this.PanelRight.Controls.Add(this.BtnAdd);
            this.PanelRight.Controls.Add(this.BtnEdit);
            this.PanelRight.Controls.Add(this.BtnDeployment);
            this.PanelRight.Controls.Add(this.BtnDraw);
            this.PanelRight.Controls.Add(this.BtnGeoMembrane);
            this.PanelRight.Location = new System.Drawing.Point(1128, 102);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(258, 580);
            this.PanelRight.TabIndex = 12;
            // 
            // PanelContent
            // 
            this.PanelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContent.Controls.Add(this.DGVDev);
            this.PanelContent.Location = new System.Drawing.Point(0, 102);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1122, 580);
            this.PanelContent.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Item";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // DevTime
            // 
            this.DevTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DevTime.HeaderText = "Date";
            this.DevTime.Name = "DevTime";
            this.DevTime.ReadOnly = true;
            // 
            // Project
            // 
            this.Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Project.HeaderText = "Project";
            this.Project.Name = "Project";
            this.Project.ReadOnly = true;
            // 
            // Operator
            // 
            this.Operator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Operator.HeaderText = "Operator";
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            // 
            // MachineNo
            // 
            this.MachineNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineNo.HeaderText = "Machine No";
            this.MachineNo.Name = "MachineNo";
            this.MachineNo.ReadOnly = true;
            // 
            // DevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevForm";
            this.Text = "Inspection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DevForm_FormClosed);
            this.Load += new System.EventHandler(this.DevForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDev)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelFooter.ResumeLayout(false);
            this.PanelRight.ResumeLayout(false);
            this.PanelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid DGVDev;
        private MetroFramework.Controls.MetroButton BtnGeoMembrane;
        private MetroFramework.Controls.MetroButton BtnDeployment;
        private MetroFramework.Controls.MetroButton BtnDraw;
        private FontAwesome.Sharp.IconButton BtnExit;
        private FontAwesome.Sharp.IconButton BtnBack;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private FontAwesome.Sharp.IconButton BtnEdit;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private ns1.BunifuCustomLabel LblTitle;
        private System.Windows.Forms.Panel PanelHeader;
        private ns1.BunifuElipse BElipse;
        private System.Windows.Forms.Panel PanelFooter;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineNo;
    }
}