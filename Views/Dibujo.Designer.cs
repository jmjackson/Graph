﻿namespace Mine.Views
{
    partial class Dibujo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dibujo));
            this.PbLienzo = new System.Windows.Forms.PictureBox();
            this.BntAddPanelNo = new FontAwesome.Sharp.IconButton();
            this.BntSave = new FontAwesome.Sharp.IconButton();
            this.BtnClear = new FontAwesome.Sharp.IconButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DgLpn = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolBox = new System.Windows.Forms.GroupBox();
            this.BtnAC = new FontAwesome.Sharp.IconButton();
            this.BtnDraw = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgCordenada = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PbLienzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgLpn)).BeginInit();
            this.toolBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCordenada)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbLienzo
            // 
            this.PbLienzo.Location = new System.Drawing.Point(0, 0);
            this.PbLienzo.Name = "PbLienzo";
            this.PbLienzo.Size = new System.Drawing.Size(3000, 3000);
            this.PbLienzo.TabIndex = 0;
            this.PbLienzo.TabStop = false;
            this.PbLienzo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseClick);
            this.PbLienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseDown);
            this.PbLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseMove);
            this.PbLienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseUp);
            // 
            // BntAddPanelNo
            // 
            this.BntAddPanelNo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BntAddPanelNo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BntAddPanelNo.IconColor = System.Drawing.Color.Black;
            this.BntAddPanelNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BntAddPanelNo.IconSize = 16;
            this.BntAddPanelNo.Location = new System.Drawing.Point(26, 79);
            this.BntAddPanelNo.Name = "BntAddPanelNo";
            this.BntAddPanelNo.Rotation = 0D;
            this.BntAddPanelNo.Size = new System.Drawing.Size(134, 44);
            this.BntAddPanelNo.TabIndex = 3;
            this.BntAddPanelNo.Text = "Add Panel No";
            this.BntAddPanelNo.UseVisualStyleBackColor = true;
            this.BntAddPanelNo.Click += new System.EventHandler(this.BntAddPanelNo_Click);
            // 
            // BntSave
            // 
            this.BntSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BntSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BntSave.IconColor = System.Drawing.Color.Black;
            this.BntSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BntSave.IconSize = 16;
            this.BntSave.Location = new System.Drawing.Point(26, 139);
            this.BntSave.Name = "BntSave";
            this.BntSave.Rotation = 0D;
            this.BntSave.Size = new System.Drawing.Size(134, 44);
            this.BntSave.TabIndex = 4;
            this.BntSave.Text = "Save Images";
            this.BntSave.UseVisualStyleBackColor = true;
            this.BntSave.Click += new System.EventHandler(this.BntSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnClear.IconColor = System.Drawing.Color.Black;
            this.BtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClear.IconSize = 16;
            this.BtnClear.Location = new System.Drawing.Point(26, 199);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Rotation = 0D;
            this.BtnClear.Size = new System.Drawing.Size(134, 44);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // DgLpn
            // 
            this.DgLpn.AllowUserToResizeRows = false;
            this.DgLpn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgLpn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgLpn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgLpn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgLpn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgLpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLpn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PanelNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgLpn.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgLpn.EnableHeadersVisualStyles = false;
            this.DgLpn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgLpn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgLpn.Location = new System.Drawing.Point(3, 342);
            this.DgLpn.Name = "DgLpn";
            this.DgLpn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgLpn.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgLpn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgLpn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLpn.Size = new System.Drawing.Size(209, 98);
            this.DgLpn.Style = MetroFramework.MetroColorStyle.Blue;
            this.DgLpn.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.HeaderText = "Item";
            this.Id.Name = "Id";
            // 
            // PanelNo
            // 
            this.PanelNo.HeaderText = "Panel No";
            this.PanelNo.Name = "PanelNo";
            // 
            // toolBox
            // 
            this.toolBox.Controls.Add(this.BtnAC);
            this.toolBox.Controls.Add(this.BtnDraw);
            this.toolBox.Controls.Add(this.BtnClear);
            this.toolBox.Controls.Add(this.BntSave);
            this.toolBox.Controls.Add(this.BntAddPanelNo);
            this.toolBox.Location = new System.Drawing.Point(20, 3);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(177, 317);
            this.toolBox.TabIndex = 8;
            this.toolBox.TabStop = false;
            this.toolBox.Text = "Herramientas";
            // 
            // BtnAC
            // 
            this.BtnAC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAC.IconColor = System.Drawing.Color.Black;
            this.BtnAC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAC.IconSize = 16;
            this.BtnAC.Location = new System.Drawing.Point(26, 259);
            this.BtnAC.Name = "BtnAC";
            this.BtnAC.Rotation = 0D;
            this.BtnAC.Size = new System.Drawing.Size(134, 44);
            this.BtnAC.TabIndex = 9;
            this.BtnAC.Text = "Add Symbol";
            this.BtnAC.UseVisualStyleBackColor = true;
            this.BtnAC.Click += new System.EventHandler(this.BtnEO_Click);
            // 
            // BtnDraw
            // 
            this.BtnDraw.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDraw.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnDraw.IconColor = System.Drawing.Color.Black;
            this.BtnDraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDraw.IconSize = 16;
            this.BtnDraw.Location = new System.Drawing.Point(26, 19);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Rotation = 0D;
            this.BtnDraw.Size = new System.Drawing.Size(134, 44);
            this.BtnDraw.TabIndex = 9;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgCordenada);
            this.panel1.Controls.Add(this.toolBox);
            this.panel1.Controls.Add(this.DgLpn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1148, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 626);
            this.panel1.TabIndex = 9;
            // 
            // DgCordenada
            // 
            this.DgCordenada.AllowUserToResizeRows = false;
            this.DgCordenada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgCordenada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgCordenada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgCordenada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgCordenada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgCordenada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCordenada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Simbolo});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgCordenada.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgCordenada.EnableHeadersVisualStyles = false;
            this.DgCordenada.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgCordenada.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgCordenada.Location = new System.Drawing.Point(3, 479);
            this.DgCordenada.Name = "DgCordenada";
            this.DgCordenada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgCordenada.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgCordenada.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgCordenada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCordenada.Size = new System.Drawing.Size(209, 98);
            this.DgCordenada.Style = MetroFramework.MetroColorStyle.Blue;
            this.DgCordenada.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cordenada";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Simbolo
            // 
            this.Simbolo.HeaderText = "Simbolo";
            this.Simbolo.Name = "Simbolo";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PbLienzo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 626);
            this.panel2.TabIndex = 10;
            // 
            // Dibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 706);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dibujo";
            this.Text = "Dibujo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dibujo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLienzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgLpn)).EndInit();
            this.toolBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgCordenada)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLienzo;
        private FontAwesome.Sharp.IconButton BntAddPanelNo;
        private FontAwesome.Sharp.IconButton BntSave;
        private FontAwesome.Sharp.IconButton BtnClear;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroGrid DgLpn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PanelNo;
        private System.Windows.Forms.GroupBox toolBox;
        private FontAwesome.Sharp.IconButton BtnDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnAC;
        private MetroFramework.Controls.MetroGrid DgCordenada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Simbolo;
    }
}