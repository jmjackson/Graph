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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.ToolsBox = new System.Windows.Forms.GroupBox();
            this.BtnClear = new FontAwesome.Sharp.IconButton();
            this.BtnAC = new FontAwesome.Sharp.IconButton();
            this.BntSave = new FontAwesome.Sharp.IconButton();
            this.BntAddPanelNo = new FontAwesome.Sharp.IconButton();
            this.BtnDraw = new FontAwesome.Sharp.IconButton();
            this.DgCordenada = new System.Windows.Forms.DataGridView();
            this.Cordenada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgLpn = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbLienzo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.ToolsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCordenada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgLpn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.ToolsBox);
            this.panel1.Controls.Add(this.DgCordenada);
            this.panel1.Controls.Add(this.DgLpn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1128, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 788);
            this.panel1.TabIndex = 9;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnClose.IconColor = System.Drawing.Color.Red;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnClose.IconSize = 42;
            this.BtnClose.Location = new System.Drawing.Point(210, 9);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(39, 42);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ToolsBox
            // 
            this.ToolsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolsBox.Controls.Add(this.BtnClear);
            this.ToolsBox.Controls.Add(this.BtnAC);
            this.ToolsBox.Controls.Add(this.BntSave);
            this.ToolsBox.Controls.Add(this.BntAddPanelNo);
            this.ToolsBox.Controls.Add(this.BtnDraw);
            this.ToolsBox.Location = new System.Drawing.Point(18, 54);
            this.ToolsBox.Name = "ToolsBox";
            this.ToolsBox.Size = new System.Drawing.Size(226, 407);
            this.ToolsBox.TabIndex = 1;
            this.ToolsBox.TabStop = false;
            this.ToolsBox.Text = "Tools";
            this.ToolsBox.Enter += new System.EventHandler(this.ToolsBox_Enter);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnClear.IconColor = System.Drawing.Color.White;
            this.BtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClear.IconSize = 25;
            this.BtnClear.Location = new System.Drawing.Point(33, 303);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Rotation = 0D;
            this.BtnClear.Size = new System.Drawing.Size(172, 61);
            this.BtnClear.TabIndex = 23;
            this.BtnClear.Text = "Clear";
            this.BtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click_1);
            // 
            // BtnAC
            // 
            this.BtnAC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAC.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAC.ForeColor = System.Drawing.Color.White;
            this.BtnAC.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAC.IconColor = System.Drawing.Color.White;
            this.BtnAC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAC.IconSize = 25;
            this.BtnAC.Location = new System.Drawing.Point(33, 236);
            this.BtnAC.Name = "BtnAC";
            this.BtnAC.Rotation = 0D;
            this.BtnAC.Size = new System.Drawing.Size(172, 61);
            this.BtnAC.TabIndex = 22;
            this.BtnAC.Text = "Add Symbol";
            this.BtnAC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAC.UseVisualStyleBackColor = false;
            this.BtnAC.Click += new System.EventHandler(this.BtnAC_Click_1);
            // 
            // BntSave
            // 
            this.BntSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BntSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BntSave.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntSave.ForeColor = System.Drawing.Color.White;
            this.BntSave.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BntSave.IconColor = System.Drawing.Color.White;
            this.BntSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BntSave.IconSize = 25;
            this.BntSave.Location = new System.Drawing.Point(33, 169);
            this.BntSave.Name = "BntSave";
            this.BntSave.Rotation = 0D;
            this.BntSave.Size = new System.Drawing.Size(172, 61);
            this.BntSave.TabIndex = 21;
            this.BntSave.Text = "Save Images";
            this.BntSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BntSave.UseVisualStyleBackColor = false;
            this.BntSave.Click += new System.EventHandler(this.BntSave_Click_1);
            // 
            // BntAddPanelNo
            // 
            this.BntAddPanelNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntAddPanelNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BntAddPanelNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntAddPanelNo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BntAddPanelNo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntAddPanelNo.ForeColor = System.Drawing.Color.White;
            this.BntAddPanelNo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BntAddPanelNo.IconColor = System.Drawing.Color.White;
            this.BntAddPanelNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BntAddPanelNo.IconSize = 25;
            this.BntAddPanelNo.Location = new System.Drawing.Point(33, 102);
            this.BntAddPanelNo.Name = "BntAddPanelNo";
            this.BntAddPanelNo.Rotation = 0D;
            this.BntAddPanelNo.Size = new System.Drawing.Size(172, 61);
            this.BntAddPanelNo.TabIndex = 20;
            this.BntAddPanelNo.Text = "Add Panel No";
            this.BntAddPanelNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BntAddPanelNo.UseVisualStyleBackColor = false;
            this.BntAddPanelNo.Click += new System.EventHandler(this.BntAddPanelNo_Click_1);
            // 
            // BtnDraw
            // 
            this.BtnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDraw.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDraw.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDraw.ForeColor = System.Drawing.Color.White;
            this.BtnDraw.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnDraw.IconColor = System.Drawing.Color.White;
            this.BtnDraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDraw.IconSize = 25;
            this.BtnDraw.Location = new System.Drawing.Point(33, 35);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Rotation = 0D;
            this.BtnDraw.Size = new System.Drawing.Size(172, 61);
            this.BtnDraw.TabIndex = 19;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDraw.UseVisualStyleBackColor = false;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click_1);
            // 
            // DgCordenada
            // 
            this.DgCordenada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DgCordenada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgCordenada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgCordenada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgCordenada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCordenada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cordenada,
            this.Simbolo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgCordenada.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgCordenada.Location = new System.Drawing.Point(39, 625);
            this.DgCordenada.Name = "DgCordenada";
            this.DgCordenada.Size = new System.Drawing.Size(205, 163);
            this.DgCordenada.TabIndex = 2;
            // 
            // Cordenada
            // 
            this.Cordenada.HeaderText = "Cordenada";
            this.Cordenada.Name = "Cordenada";
            this.Cordenada.Width = 129;
            // 
            // Simbolo
            // 
            this.Simbolo.HeaderText = "Simbolo";
            this.Simbolo.Name = "Simbolo";
            this.Simbolo.Width = 104;
            // 
            // DgLpn
            // 
            this.DgLpn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DgLpn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgLpn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgLpn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgLpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLpn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PanelNo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgLpn.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgLpn.Location = new System.Drawing.Point(39, 467);
            this.DgLpn.Name = "DgLpn";
            this.DgLpn.Size = new System.Drawing.Size(205, 133);
            this.DgLpn.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Item";
            this.Id.Name = "Id";
            this.Id.Width = 70;
            // 
            // PanelNo
            // 
            this.PanelNo.HeaderText = "Panel No";
            this.PanelNo.Name = "PanelNo";
            this.PanelNo.Width = 113;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PbLienzo);
            this.panel2.Location = new System.Drawing.Point(14, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 650);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PbLienzo
            // 
            this.PbLienzo.Location = new System.Drawing.Point(-1, -1);
            this.PbLienzo.Name = "PbLienzo";
            this.PbLienzo.Size = new System.Drawing.Size(3000, 3000);
            this.PbLienzo.TabIndex = 0;
            this.PbLienzo.TabStop = false;
            this.PbLienzo.Click += new System.EventHandler(this.PBLienzo_Click);
            this.PbLienzo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseClick_1);
            this.PbLienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseDown_1);
            this.PbLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseMove_1);
            this.PbLienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseUp_1);
            // 
            // Dibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dibujo";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dibujo_Load);
            this.panel1.ResumeLayout(false);
            this.ToolsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgCordenada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgLpn)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLienzo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgLpn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PanelNo;
        private System.Windows.Forms.DataGridView DgCordenada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cordenada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Simbolo;
        private System.Windows.Forms.GroupBox ToolsBox;
        private FontAwesome.Sharp.IconButton BtnClear;
        private FontAwesome.Sharp.IconButton BtnAC;
        private FontAwesome.Sharp.IconButton BntSave;
        private FontAwesome.Sharp.IconButton BntAddPanelNo;
        private FontAwesome.Sharp.IconButton BtnDraw;
        private System.Windows.Forms.PictureBox PbLienzo;
        private FontAwesome.Sharp.IconButton BtnClose;
    }
}