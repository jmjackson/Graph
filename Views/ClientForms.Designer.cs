namespace Mine.Views
{
    partial class ClientForms
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
            this.GDVClients = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.BtnFind = new FontAwesome.Sharp.IconButton();
            this.TxtId = new MetroFramework.Controls.MetroTextBox();
            this.TxtCode = new MetroFramework.Controls.MetroTextBox();
            this.TxtName = new MetroFramework.Controls.MetroTextBox();
            this.LblId = new MetroFramework.Controls.MetroLabel();
            this.LblName = new MetroFramework.Controls.MetroLabel();
            this.LblCode = new MetroFramework.Controls.MetroLabel();
            this.PBImage = new System.Windows.Forms.PictureBox();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.BtnEdit = new FontAwesome.Sharp.IconButton();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.GDVClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.PanelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GDVClients
            // 
            this.GDVClients.AllowUserToResizeRows = false;
            this.GDVClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GDVClients.AutoGenerateColumns = false;
            this.GDVClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GDVClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GDVClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GDVClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GDVClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GDVClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDVClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.GDVClients.DataSource = this.clientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GDVClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.GDVClients.EnableHeadersVisualStyles = false;
            this.GDVClients.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GDVClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GDVClients.Location = new System.Drawing.Point(23, 63);
            this.GDVClients.Name = "GDVClients";
            this.GDVClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GDVClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GDVClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GDVClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GDVClients.Size = new System.Drawing.Size(357, 364);
            this.GDVClients.Style = MetroFramework.MetroColorStyle.Purple;
            this.GDVClients.TabIndex = 0;
            this.GDVClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDVClients_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(Mine.DataModel.Client);
            // 
            // PanelAdd
            // 
            this.PanelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAdd.Controls.Add(this.BtnFind);
            this.PanelAdd.Controls.Add(this.TxtId);
            this.PanelAdd.Controls.Add(this.TxtCode);
            this.PanelAdd.Controls.Add(this.TxtName);
            this.PanelAdd.Controls.Add(this.LblId);
            this.PanelAdd.Controls.Add(this.LblName);
            this.PanelAdd.Controls.Add(this.LblCode);
            this.PanelAdd.Controls.Add(this.PBImage);
            this.PanelAdd.Location = new System.Drawing.Point(386, 64);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(405, 290);
            this.PanelAdd.TabIndex = 1;
            // 
            // BtnFind
            // 
            this.BtnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.BtnFind.FlatAppearance.BorderSize = 0;
            this.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFind.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnFind.ForeColor = System.Drawing.Color.White;
            this.BtnFind.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnFind.IconColor = System.Drawing.Color.White;
            this.BtnFind.IconSize = 16;
            this.BtnFind.Location = new System.Drawing.Point(36, 152);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Rotation = 0D;
            this.BtnFind.Size = new System.Drawing.Size(100, 23);
            this.BtnFind.TabIndex = 3;
            this.BtnFind.Text = "Browse";
            this.BtnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFind.UseVisualStyleBackColor = false;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // TxtId
            // 
            // 
            // 
            // 
            this.TxtId.CustomButton.Image = null;
            this.TxtId.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TxtId.CustomButton.Name = "";
            this.TxtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtId.CustomButton.TabIndex = 1;
            this.TxtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtId.CustomButton.UseSelectable = true;
            this.TxtId.CustomButton.Visible = false;
            this.TxtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Id", true));
            this.TxtId.Lines = new string[0];
            this.TxtId.Location = new System.Drawing.Point(174, 56);
            this.TxtId.MaxLength = 32767;
            this.TxtId.Name = "TxtId";
            this.TxtId.PasswordChar = '\0';
            this.TxtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtId.SelectedText = "";
            this.TxtId.SelectionLength = 0;
            this.TxtId.SelectionStart = 0;
            this.TxtId.ShortcutsEnabled = true;
            this.TxtId.Size = new System.Drawing.Size(219, 23);
            this.TxtId.TabIndex = 2;
            this.TxtId.UseSelectable = true;
            this.TxtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtCode
            // 
            // 
            // 
            // 
            this.TxtCode.CustomButton.Image = null;
            this.TxtCode.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TxtCode.CustomButton.Name = "";
            this.TxtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCode.CustomButton.TabIndex = 1;
            this.TxtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCode.CustomButton.UseSelectable = true;
            this.TxtCode.CustomButton.Visible = false;
            this.TxtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Code", true));
            this.TxtCode.Lines = new string[0];
            this.TxtCode.Location = new System.Drawing.Point(174, 104);
            this.TxtCode.MaxLength = 32767;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.PasswordChar = '\0';
            this.TxtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCode.SelectedText = "";
            this.TxtCode.SelectionLength = 0;
            this.TxtCode.SelectionStart = 0;
            this.TxtCode.ShortcutsEnabled = true;
            this.TxtCode.Size = new System.Drawing.Size(219, 23);
            this.TxtCode.TabIndex = 2;
            this.TxtCode.UseSelectable = true;
            this.TxtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtName
            // 
            // 
            // 
            // 
            this.TxtName.CustomButton.Image = null;
            this.TxtName.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TxtName.CustomButton.Name = "";
            this.TxtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtName.CustomButton.TabIndex = 1;
            this.TxtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtName.CustomButton.UseSelectable = true;
            this.TxtName.CustomButton.Visible = false;
            this.TxtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Name", true));
            this.TxtName.Lines = new string[0];
            this.TxtName.Location = new System.Drawing.Point(174, 152);
            this.TxtName.MaxLength = 32767;
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtName.SelectedText = "";
            this.TxtName.SelectionLength = 0;
            this.TxtName.SelectionStart = 0;
            this.TxtName.ShortcutsEnabled = true;
            this.TxtName.Size = new System.Drawing.Size(219, 23);
            this.TxtName.TabIndex = 2;
            this.TxtName.UseSelectable = true;
            this.TxtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(174, 34);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(20, 19);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Id";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(174, 130);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 19);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(174, 82);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(41, 19);
            this.LblCode.TabIndex = 1;
            this.LblCode.Text = "Code";
            // 
            // PBImage
            // 
            this.PBImage.Location = new System.Drawing.Point(36, 27);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(100, 104);
            this.PBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImage.TabIndex = 0;
            this.PBImage.TabStop = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAdd.IconColor = System.Drawing.Color.Black;
            this.BtnAdd.IconSize = 16;
            this.BtnAdd.Location = new System.Drawing.Point(384, 381);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Rotation = 0D;
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEdit.IconColor = System.Drawing.Color.Black;
            this.BtnEdit.IconSize = 16;
            this.BtnEdit.Location = new System.Drawing.Point(465, 381);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Rotation = 0D;
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnDelete.IconColor = System.Drawing.Color.Black;
            this.BtnDelete.IconSize = 16;
            this.BtnDelete.Location = new System.Drawing.Point(545, 381);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Rotation = 0D;
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCancel.IconColor = System.Drawing.Color.Black;
            this.BtnCancel.IconSize = 16;
            this.BtnCancel.Location = new System.Drawing.Point(626, 381);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Rotation = 0D;
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSave.IconColor = System.Drawing.Color.Black;
            this.BtnSave.IconSize = 16;
            this.BtnSave.Location = new System.Drawing.Point(707, 381);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Rotation = 0D;
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ClientForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.GDVClients);
            this.MaximizeBox = false;
            this.Name = "ClientForms";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GDVClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GDVClients;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel PanelAdd;
        private FontAwesome.Sharp.IconButton BtnFind;
        private MetroFramework.Controls.MetroTextBox TxtCode;
        private MetroFramework.Controls.MetroTextBox TxtName;
        private MetroFramework.Controls.MetroLabel LblName;
        private MetroFramework.Controls.MetroLabel LblCode;
        private System.Windows.Forms.PictureBox PBImage;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private FontAwesome.Sharp.IconButton BtnEdit;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private FontAwesome.Sharp.IconButton BtnSave;
        private MetroFramework.Controls.MetroTextBox TxtId;
        private MetroFramework.Controls.MetroLabel LblId;
    }
}