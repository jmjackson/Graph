namespace Grap.Principal.Views.Modal
{
    partial class ModalDeployments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalDeployments));
            this.CbCliente = new System.Windows.Forms.ComboBox();
            this.LbCliente = new System.Windows.Forms.Label();
            this.LbProject = new System.Windows.Forms.Label();
            this.CbProyecto = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.LbFecha = new System.Windows.Forms.Label();
            this.DTPicker = new ns1.BunifuDatepicker();
            this.BtnClose = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // CbCliente
            // 
            this.CbCliente.BackColor = System.Drawing.Color.White;
            this.CbCliente.ForeColor = System.Drawing.Color.DimGray;
            this.CbCliente.FormattingEnabled = true;
            this.CbCliente.Location = new System.Drawing.Point(86, 48);
            this.CbCliente.Name = "CbCliente";
            this.CbCliente.Size = new System.Drawing.Size(309, 21);
            this.CbCliente.TabIndex = 0;
            this.CbCliente.Text = "Seleccionar una Cliente";
            this.CbCliente.SelectedIndexChanged += new System.EventHandler(this.CbCliente_SelectedIndexChanged);
            // 
            // LbCliente
            // 
            this.LbCliente.AutoSize = true;
            this.LbCliente.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.LbCliente.ForeColor = System.Drawing.Color.White;
            this.LbCliente.Location = new System.Drawing.Point(28, 48);
            this.LbCliente.Name = "LbCliente";
            this.LbCliente.Size = new System.Drawing.Size(47, 17);
            this.LbCliente.TabIndex = 1;
            this.LbCliente.Text = "Cliente";
            // 
            // LbProject
            // 
            this.LbProject.AutoSize = true;
            this.LbProject.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.LbProject.ForeColor = System.Drawing.Color.White;
            this.LbProject.Location = new System.Drawing.Point(19, 99);
            this.LbProject.Name = "LbProject";
            this.LbProject.Size = new System.Drawing.Size(56, 17);
            this.LbProject.TabIndex = 3;
            this.LbProject.Text = "Proyecto";
            // 
            // CbProyecto
            // 
            this.CbProyecto.BackColor = System.Drawing.Color.White;
            this.CbProyecto.ForeColor = System.Drawing.Color.DimGray;
            this.CbProyecto.FormattingEnabled = true;
            this.CbProyecto.Location = new System.Drawing.Point(86, 99);
            this.CbProyecto.Name = "CbProyecto";
            this.CbProyecto.Size = new System.Drawing.Size(309, 21);
            this.CbProyecto.TabIndex = 2;
            this.CbProyecto.Text = "Selecionar un Proyecto";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(253, 205);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(153, 205);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 5;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.LbFecha.ForeColor = System.Drawing.Color.White;
            this.LbFecha.Location = new System.Drawing.Point(34, 157);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(41, 17);
            this.LbFecha.TabIndex = 7;
            this.LbFecha.Text = "Fecha";
            // 
            // DTPicker
            // 
            this.DTPicker.BackColor = System.Drawing.Color.White;
            this.DTPicker.BorderRadius = 0;
            this.DTPicker.ForeColor = System.Drawing.Color.DimGray;
            this.DTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTPicker.FormatCustom = null;
            this.DTPicker.Location = new System.Drawing.Point(86, 149);
            this.DTPicker.Name = "DTPicker";
            this.DTPicker.Size = new System.Drawing.Size(309, 26);
            this.DTPicker.TabIndex = 8;
            this.DTPicker.Value = new System.DateTime(2020, 10, 1, 10, 12, 7, 4);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(158)))));
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(464, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(24, 24);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 9;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            // 
            // ModalDeployments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(64)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(489, 259);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.DTPicker);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LbProject);
            this.Controls.Add(this.CbProyecto);
            this.Controls.Add(this.LbCliente);
            this.Controls.Add(this.CbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalDeployments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModalDeployments";
            this.Load += new System.EventHandler(this.ModalDeployments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbCliente;
        private System.Windows.Forms.Label LbCliente;
        private System.Windows.Forms.Label LbProject;
        private System.Windows.Forms.ComboBox CbProyecto;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LbFecha;
        private ns1.BunifuDatepicker DTPicker;
        private ns1.BunifuImageButton BtnClose;
    }
}