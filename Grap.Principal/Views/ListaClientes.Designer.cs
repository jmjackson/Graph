namespace Grap.Principal.Views
{
    partial class ListaClientes
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
            this.PanelHead = new System.Windows.Forms.Panel();
            this.SpContainer = new System.Windows.Forms.SplitContainer();
            this.CardDGrid = new ns1.BunifuCards();
            this.DGVClients = new ns1.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardBtn = new ns1.BunifuCards();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnDetalle = new FontAwesome.Sharp.IconButton();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.BtnActualizar = new FontAwesome.Sharp.IconButton();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BtnRegistro = new FontAwesome.Sharp.IconButton();
            this.LblTitle = new ns1.BunifuCustomLabel();
            this.PanelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpContainer)).BeginInit();
            this.SpContainer.Panel1.SuspendLayout();
            this.SpContainer.Panel2.SuspendLayout();
            this.SpContainer.SuspendLayout();
            this.CardDGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClients)).BeginInit();
            this.CardBtn.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.Controls.Add(this.SpContainer);
            this.PanelHead.Controls.Add(this.PanelHeader);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(760, 451);
            this.PanelHead.TabIndex = 0;
            // 
            // SpContainer
            // 
            this.SpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpContainer.Location = new System.Drawing.Point(0, 43);
            this.SpContainer.Name = "SpContainer";
            // 
            // SpContainer.Panel1
            // 
            this.SpContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.SpContainer.Panel1.Controls.Add(this.CardDGrid);
            // 
            // SpContainer.Panel2
            // 
            this.SpContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.SpContainer.Panel2.Controls.Add(this.CardBtn);
            this.SpContainer.Size = new System.Drawing.Size(760, 408);
            this.SpContainer.SplitterDistance = 575;
            this.SpContainer.TabIndex = 1;
            // 
            // CardDGrid
            // 
            this.CardDGrid.BackColor = System.Drawing.Color.White;
            this.CardDGrid.BorderRadius = 5;
            this.CardDGrid.BottomSahddow = true;
            this.CardDGrid.color = System.Drawing.Color.DarkSlateBlue;
            this.CardDGrid.Controls.Add(this.DGVClients);
            this.CardDGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardDGrid.LeftSahddow = false;
            this.CardDGrid.Location = new System.Drawing.Point(0, 0);
            this.CardDGrid.Name = "CardDGrid";
            this.CardDGrid.RightSahddow = true;
            this.CardDGrid.ShadowDepth = 20;
            this.CardDGrid.Size = new System.Drawing.Size(575, 408);
            this.CardDGrid.TabIndex = 0;
            // 
            // DGVClients
            // 
            this.DGVClients.AllowUserToAddRows = false;
            this.DGVClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVClients.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGVClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Code,
            this.CName});
            this.DGVClients.DoubleBuffered = true;
            this.DGVClients.EnableHeadersVisualStyles = false;
            this.DGVClients.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.DGVClients.HeaderForeColor = System.Drawing.Color.White;
            this.DGVClients.Location = new System.Drawing.Point(12, 17);
            this.DGVClients.Name = "DGVClients";
            this.DGVClients.ReadOnly = true;
            this.DGVClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVClients.Size = new System.Drawing.Size(560, 257);
            this.DGVClients.TabIndex = 1;
            this.DGVClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClients_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Code.HeaderText = "Código";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // CName
            // 
            this.CName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CName.HeaderText = "Nombre";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            // 
            // CardBtn
            // 
            this.CardBtn.AutoSize = true;
            this.CardBtn.BackColor = System.Drawing.Color.White;
            this.CardBtn.BorderRadius = 5;
            this.CardBtn.BottomSahddow = true;
            this.CardBtn.color = System.Drawing.Color.DarkSlateBlue;
            this.CardBtn.Controls.Add(this.BtnEditar);
            this.CardBtn.Controls.Add(this.BtnDetalle);
            this.CardBtn.Controls.Add(this.BtnDelete);
            this.CardBtn.Controls.Add(this.BtnActualizar);
            this.CardBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardBtn.LeftSahddow = false;
            this.CardBtn.Location = new System.Drawing.Point(0, 0);
            this.CardBtn.Name = "CardBtn";
            this.CardBtn.RightSahddow = true;
            this.CardBtn.ShadowDepth = 20;
            this.CardBtn.Size = new System.Drawing.Size(181, 408);
            this.CardBtn.TabIndex = 0;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconSize = 16;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(30, 126);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Rotation = 0D;
            this.BtnEditar.Size = new System.Drawing.Size(114, 29);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnDetalle
            // 
            this.BtnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetalle.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDetalle.ForeColor = System.Drawing.Color.White;
            this.BtnDetalle.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnDetalle.IconColor = System.Drawing.Color.White;
            this.BtnDetalle.IconSize = 16;
            this.BtnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDetalle.Location = new System.Drawing.Point(30, 21);
            this.BtnDetalle.Name = "BtnDetalle";
            this.BtnDetalle.Rotation = 0D;
            this.BtnDetalle.Size = new System.Drawing.Size(114, 29);
            this.BtnDetalle.TabIndex = 2;
            this.BtnDetalle.Text = "Detalle";
            this.BtnDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDetalle.UseVisualStyleBackColor = false;
            this.BtnDetalle.Click += new System.EventHandler(this.BtnDetalle_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnDelete.IconColor = System.Drawing.Color.White;
            this.BtnDelete.IconSize = 16;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(30, 91);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Rotation = 0D;
            this.BtnDelete.Size = new System.Drawing.Size(114, 29);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnActualizar.IconColor = System.Drawing.Color.White;
            this.BtnActualizar.IconSize = 16;
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(30, 56);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Rotation = 0D;
            this.BtnActualizar.Size = new System.Drawing.Size(114, 29);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.White;
            this.PanelHeader.Controls.Add(this.BtnRegistro);
            this.PanelHeader.Controls.Add(this.LblTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(760, 43);
            this.PanelHeader.TabIndex = 0;
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistro.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnRegistro.ForeColor = System.Drawing.Color.White;
            this.BtnRegistro.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnRegistro.IconColor = System.Drawing.Color.White;
            this.BtnRegistro.IconSize = 16;
            this.BtnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistro.Location = new System.Drawing.Point(634, 7);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Rotation = 0D;
            this.BtnRegistro.Size = new System.Drawing.Size(114, 29);
            this.BtnRegistro.TabIndex = 0;
            this.BtnRegistro.Text = "Nuevo Cliente";
            this.BtnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistro.UseVisualStyleBackColor = false;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.LblTitle.Location = new System.Drawing.Point(36, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(148, 25);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Lista de Clientes";
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 451);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaClientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaClientes_FormClosing);
            this.Load += new System.EventHandler(this.ListaClientes_Load);
            this.PanelHead.ResumeLayout(false);
            this.SpContainer.Panel1.ResumeLayout(false);
            this.SpContainer.Panel2.ResumeLayout(false);
            this.SpContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpContainer)).EndInit();
            this.SpContainer.ResumeLayout(false);
            this.CardDGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClients)).EndInit();
            this.CardBtn.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.Panel PanelHeader;
        private ns1.BunifuCustomLabel LblTitle;
        private FontAwesome.Sharp.IconButton BtnRegistro;
        private System.Windows.Forms.SplitContainer SpContainer;
        private ns1.BunifuCards CardDGrid;
        private ns1.BunifuCustomDataGrid DGVClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private ns1.BunifuCards CardBtn;
        private FontAwesome.Sharp.IconButton BtnDetalle;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnActualizar;
        private FontAwesome.Sharp.IconButton BtnEditar;
    }
}