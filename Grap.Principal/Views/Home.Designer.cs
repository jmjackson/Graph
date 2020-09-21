namespace Grap.Principal.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblWelcome = new ns1.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnOther = new FontAwesome.Sharp.IconButton();
            this.BtnConfig = new FontAwesome.Sharp.IconButton();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.BtnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BtnOut = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.BtnOut);
            this.panel1.Controls.Add(this.LblWelcome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnOther);
            this.panel1.Controls.Add(this.BtnConfig);
            this.panel1.Controls.Add(this.BtnClientes);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 527);
            this.panel1.TabIndex = 0;
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.ForeColor = System.Drawing.Color.White;
            this.LblWelcome.Location = new System.Drawing.Point(53, 109);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(87, 21);
            this.LblWelcome.TabIndex = 2;
            this.LblWelcome.Text = "Bienvenido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnOther
            // 
            this.BtnOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.BtnOther.FlatAppearance.BorderSize = 0;
            this.BtnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOther.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOther.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOther.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.BtnOther.IconColor = System.Drawing.Color.White;
            this.BtnOther.IconSize = 18;
            this.BtnOther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther.Location = new System.Drawing.Point(0, 280);
            this.BtnOther.Name = "BtnOther";
            this.BtnOther.Rotation = 0D;
            this.BtnOther.Size = new System.Drawing.Size(196, 35);
            this.BtnOther.TabIndex = 0;
            this.BtnOther.Text = "Otros";
            this.BtnOther.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOther.UseVisualStyleBackColor = false;
            this.BtnOther.Click += new System.EventHandler(this.BtnOther_Click);
            // 
            // BtnConfig
            // 
            this.BtnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConfig.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.BtnConfig.IconColor = System.Drawing.Color.White;
            this.BtnConfig.IconSize = 18;
            this.BtnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfig.Location = new System.Drawing.Point(0, 239);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Rotation = 0D;
            this.BtnConfig.Size = new System.Drawing.Size(196, 35);
            this.BtnConfig.TabIndex = 0;
            this.BtnConfig.Text = "Configuración";
            this.BtnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfig.UseVisualStyleBackColor = false;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
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
            this.BtnClientes.Location = new System.Drawing.Point(0, 198);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Rotation = 0D;
            this.BtnClientes.Size = new System.Drawing.Size(196, 35);
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
            this.BtnDashboard.Location = new System.Drawing.Point(3, 157);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Rotation = 0D;
            this.BtnDashboard.Size = new System.Drawing.Size(196, 35);
            this.BtnDashboard.TabIndex = 0;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 37);
            this.panel2.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(199, 37);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(776, 490);
            this.panelContenedor.TabIndex = 2;
            // 
            // BtnOut
            // 
            this.BtnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.BtnOut.FlatAppearance.BorderSize = 0;
            this.BtnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOut.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnOut.IconColor = System.Drawing.Color.White;
            this.BtnOut.IconSize = 18;
            this.BtnOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOut.Location = new System.Drawing.Point(-3, 321);
            this.BtnOut.Name = "BtnOut";
            this.BtnOut.Rotation = 0D;
            this.BtnOut.Size = new System.Drawing.Size(196, 35);
            this.BtnOut.TabIndex = 3;
            this.BtnOut.Text = "Cerrar Sesión";
            this.BtnOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOut.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 527);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnDashboard;
        private FontAwesome.Sharp.IconButton BtnOther;
        private FontAwesome.Sharp.IconButton BtnConfig;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuCustomLabel LblWelcome;
        private FontAwesome.Sharp.IconButton BtnOut;
    }
}