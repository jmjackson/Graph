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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LbCliente = new System.Windows.Forms.Label();
            this.LbProject = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.LbFecha = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Seleccionar una Cliente";
            // 
            // LbCliente
            // 
            this.LbCliente.AutoSize = true;
            this.LbCliente.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.LbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.LbCliente.Location = new System.Drawing.Point(86, 29);
            this.LbCliente.Name = "LbCliente";
            this.LbCliente.Size = new System.Drawing.Size(52, 17);
            this.LbCliente.TabIndex = 1;
            this.LbCliente.Text = "Clientes";
            // 
            // LbProject
            // 
            this.LbProject.AutoSize = true;
            this.LbProject.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.LbProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.LbProject.Location = new System.Drawing.Point(86, 80);
            this.LbProject.Name = "LbProject";
            this.LbProject.Size = new System.Drawing.Size(61, 17);
            this.LbProject.TabIndex = 3;
            this.LbProject.Text = "Proyectos";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "Selecionar un Proyecto";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(167, 189);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(71, 189);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 5;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = false;
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.LbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))));
            this.LbFecha.Location = new System.Drawing.Point(86, 133);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(41, 17);
            this.LbFecha.TabIndex = 7;
            this.LbFecha.Text = "Fecha";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(89, 154);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(137, 20);
            this.TxtFecha.TabIndex = 8;
            // 
            // ModalDeployments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 259);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LbProject);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.LbCliente);
            this.Controls.Add(this.comboBox1);
            this.Name = "ModalDeployments";
            this.Text = "ModalDeployments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LbCliente;
        private System.Windows.Forms.Label LbProject;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LbFecha;
        private System.Windows.Forms.TextBox TxtFecha;
    }
}