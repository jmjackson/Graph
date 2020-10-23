namespace Mine.Views
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgCordenada = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PbLienzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgLpn)).BeginInit();
            this.toolBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCordenada)).BeginInit();
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
            this.BntAddPanelNo.Location = new System.Drawing.Point(26, 38);
            this.BntAddPanelNo.Name = "BntAddPanelNo";
            this.BntAddPanelNo.Rotation = 0D;
            this.BntAddPanelNo.Size = new System.Drawing.Size(134, 23);
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
            this.BntSave.Location = new System.Drawing.Point(26, 66);
            this.BntSave.Name = "BntSave";
            this.BntSave.Rotation = 0D;
            this.BntSave.Size = new System.Drawing.Size(134, 23);
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
            this.BtnClear.Location = new System.Drawing.Point(26, 95);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Rotation = 0D;
            this.BtnClear.Size = new System.Drawing.Size(134, 23);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgLpn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgLpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLpn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PanelNo});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgLpn.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgLpn.EnableHeadersVisualStyles = false;
            this.DgLpn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgLpn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgLpn.Location = new System.Drawing.Point(6, 159);
            this.DgLpn.Name = "DgLpn";
            this.DgLpn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgLpn.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            this.toolBox.Size = new System.Drawing.Size(177, 150);
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
            this.BtnAC.Location = new System.Drawing.Point(26, 123);
            this.BtnAC.Name = "BtnAC";
            this.BtnAC.Rotation = 0D;
            this.BtnAC.Size = new System.Drawing.Size(134, 23);
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
            this.BtnDraw.Location = new System.Drawing.Point(26, 12);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Rotation = 0D;
            this.BtnDraw.Size = new System.Drawing.Size(134, 23);
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
            this.panel1.Location = new System.Drawing.Point(562, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 370);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PbLienzo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 370);
            this.panel2.TabIndex = 10;
            // 
            // DgCordenada
            // 
            this.DgCordenada.AllowUserToResizeRows = false;
            this.DgCordenada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgCordenada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgCordenada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgCordenada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgCordenada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DgCordenada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCordenada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Simbolo});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgCordenada.DefaultCellStyle = dataGridViewCellStyle11;
            this.DgCordenada.EnableHeadersVisualStyles = false;
            this.DgCordenada.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgCordenada.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgCordenada.Location = new System.Drawing.Point(6, 269);
            this.DgCordenada.Name = "DgCordenada";
            this.DgCordenada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgCordenada.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            // Dibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dibujo";
            this.Text = "Dibujo";
            this.Load += new System.EventHandler(this.Dibujo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLienzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgLpn)).EndInit();
            this.toolBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgCordenada)).EndInit();
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