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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PbLienzo = new System.Windows.Forms.PictureBox();
            this.BntAdd = new FontAwesome.Sharp.IconButton();
            this.BntSave = new FontAwesome.Sharp.IconButton();
            this.BtnClear = new FontAwesome.Sharp.IconButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DgLpn = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PbLienzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgLpn)).BeginInit();
            this.SuspendLayout();
            // 
            // PbLienzo
            // 
            this.PbLienzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbLienzo.Location = new System.Drawing.Point(23, 63);
            this.PbLienzo.Name = "PbLienzo";
            this.PbLienzo.Size = new System.Drawing.Size(522, 364);
            this.PbLienzo.TabIndex = 0;
            this.PbLienzo.TabStop = false;
            this.PbLienzo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseClick);
            this.PbLienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseDown);
            this.PbLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseMove);
            this.PbLienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseUp);
            // 
            // BntAdd
            // 
            this.BntAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BntAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BntAdd.IconColor = System.Drawing.Color.Black;
            this.BntAdd.IconSize = 16;
            this.BntAdd.Location = new System.Drawing.Point(643, 98);
            this.BntAdd.Name = "BntAdd";
            this.BntAdd.Rotation = 0D;
            this.BntAdd.Size = new System.Drawing.Size(134, 23);
            this.BntAdd.TabIndex = 3;
            this.BntAdd.Text = "Add";
            this.BntAdd.UseVisualStyleBackColor = true;
            this.BntAdd.Click += new System.EventHandler(this.BntAdd_Click);
            // 
            // BntSave
            // 
            this.BntSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BntSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BntSave.IconColor = System.Drawing.Color.Black;
            this.BntSave.IconSize = 16;
            this.BntSave.Location = new System.Drawing.Point(643, 127);
            this.BntSave.Name = "BntSave";
            this.BntSave.Rotation = 0D;
            this.BntSave.Size = new System.Drawing.Size(134, 23);
            this.BntSave.TabIndex = 4;
            this.BntSave.Text = "Save";
            this.BntSave.UseVisualStyleBackColor = true;
            this.BntSave.Click += new System.EventHandler(this.BntSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnClear.IconColor = System.Drawing.Color.Black;
            this.BtnClear.IconSize = 16;
            this.BtnClear.Location = new System.Drawing.Point(643, 156);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgLpn.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgLpn.EnableHeadersVisualStyles = false;
            this.DgLpn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgLpn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgLpn.Location = new System.Drawing.Point(559, 196);
            this.DgLpn.Name = "DgLpn";
            this.DgLpn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgLpn.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgLpn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgLpn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLpn.Size = new System.Drawing.Size(218, 231);
            this.DgLpn.Style = MetroFramework.MetroColorStyle.Purple;
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
            // Dibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgLpn);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BntSave);
            this.Controls.Add(this.BntAdd);
            this.Controls.Add(this.PbLienzo);
            this.Name = "Dibujo";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Dibujo";
            this.Load += new System.EventHandler(this.Dibujo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLienzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgLpn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLienzo;
        private FontAwesome.Sharp.IconButton BntAdd;
        private FontAwesome.Sharp.IconButton BntSave;
        private FontAwesome.Sharp.IconButton BtnClear;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroGrid DgLpn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PanelNo;
    }
}