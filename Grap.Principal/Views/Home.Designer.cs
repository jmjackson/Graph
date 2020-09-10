﻿namespace Grap.Principal.Views
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnOtros = new FontAwesome.Sharp.IconButton();
            this.BtnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.BtnDashboard = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.BtnOtros);
            this.panel1.Controls.Add(this.PanelLogo);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.BtnConfiguracion);
            this.panel1.Controls.Add(this.BtnClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 527);
            this.panel1.TabIndex = 0;
            // 
            // BtnOtros
            // 
            this.BtnOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.BtnOtros.FlatAppearance.BorderSize = 0;
            this.BtnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOtros.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOtros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOtros.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.BtnOtros.IconColor = System.Drawing.Color.White;
            this.BtnOtros.IconSize = 18;
            this.BtnOtros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOtros.Location = new System.Drawing.Point(0, 250);
            this.BtnOtros.Name = "BtnOtros";
            this.BtnOtros.Rotation = 0D;
            this.BtnOtros.Size = new System.Drawing.Size(217, 35);
            this.BtnOtros.TabIndex = 0;
            this.BtnOtros.Text = "Otros";
            this.BtnOtros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOtros.UseVisualStyleBackColor = false;
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.BtnConfiguracion.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracion.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfiguracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.BtnConfiguracion.IconColor = System.Drawing.Color.White;
            this.BtnConfiguracion.IconSize = 18;
            this.BtnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracion.Location = new System.Drawing.Point(0, 209);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Rotation = 0D;
            this.BtnConfiguracion.Size = new System.Drawing.Size(217, 35);
            this.BtnConfiguracion.TabIndex = 0;
            this.BtnConfiguracion.Text = "Configuración";
            this.BtnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfiguracion.UseVisualStyleBackColor = false;
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnClientes.IconColor = System.Drawing.Color.White;
            this.BtnClientes.IconSize = 18;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 168);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Rotation = 0D;
            this.BtnClientes.Size = new System.Drawing.Size(217, 35);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDashboard.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.BtnDashboard.IconColor = System.Drawing.Color.White;
            this.BtnDashboard.IconSize = 18;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 127);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Rotation = 0D;
            this.BtnDashboard.Size = new System.Drawing.Size(217, 35);
            this.BtnDashboard.TabIndex = 0;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            // 
            // PanelLogo
            // 
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 121);
            this.PanelLogo.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 527);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnDashboard;
        private FontAwesome.Sharp.IconButton BtnOtros;
        private FontAwesome.Sharp.IconButton BtnConfiguracion;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private System.Windows.Forms.Panel PanelLogo;
    }
}