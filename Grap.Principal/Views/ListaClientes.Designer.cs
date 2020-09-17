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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNuevo = new ns1.BunifuThinButton2();
            this.LblCliente = new ns1.BunifuCustomLabel();
            this.DgvPersonas = new ns1.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnNuevo);
            this.panel1.Controls.Add(this.LblCliente);
            this.panel1.Controls.Add(this.DgvPersonas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 451);
            this.panel1.TabIndex = 0;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ActiveBorderThickness = 1;
            this.BtnNuevo.ActiveCornerRadius = 20;
            this.BtnNuevo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BtnNuevo.ActiveForecolor = System.Drawing.Color.White;
            this.BtnNuevo.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BtnNuevo.BackColor = System.Drawing.Color.White;
            this.BtnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.BackgroundImage")));
            this.BtnNuevo.ButtonText = "Nuevo Cliente ";
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnNuevo.IdleBorderThickness = 1;
            this.BtnNuevo.IdleCornerRadius = 20;
            this.BtnNuevo.IdleFillColor = System.Drawing.Color.White;
            this.BtnNuevo.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BtnNuevo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BtnNuevo.Location = new System.Drawing.Point(595, 50);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(147, 41);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNuevo.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.LblCliente.Location = new System.Drawing.Point(12, 26);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(149, 26);
            this.LblCliente.TabIndex = 9;
            this.LblCliente.Text = "Lista de Clientes";
            // 
            // DgvPersonas
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvPersonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPersonas.BackgroundColor = System.Drawing.Color.White;
            this.DgvPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPersonas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvPersonas.ColumnHeadersHeight = 30;
            this.DgvPersonas.DoubleBuffered = true;
            this.DgvPersonas.EnableHeadersVisualStyles = false;
            this.DgvPersonas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DgvPersonas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.DgvPersonas.HeaderForeColor = System.Drawing.Color.White;
            this.DgvPersonas.Location = new System.Drawing.Point(17, 59);
            this.DgvPersonas.Name = "DgvPersonas";
            this.DgvPersonas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvPersonas.RowHeadersVisible = false;
            this.DgvPersonas.Size = new System.Drawing.Size(570, 327);
            this.DgvPersonas.TabIndex = 0;
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 451);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaClientes";
            this.Text = "ListaClientes";
            this.Load += new System.EventHandler(this.ListaClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomLabel LblCliente;
        private ns1.BunifuThinButton2 BtnNuevo;
        private ns1.BunifuCustomDataGrid DgvPersonas;
    }
}