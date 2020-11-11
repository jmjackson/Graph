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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SeamingButton = new FontAwesome.Sharp.IconButton();
            this.DeployButton = new FontAwesome.Sharp.IconButton();
            this.PanelHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.label1);
            this.PanelHeader.Controls.Add(this.BtnClose);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1386, 52);
            this.PanelHeader.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BtnClose.Location = new System.Drawing.Point(1338, 9);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(39, 39);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Draw";
            // 
            // PanelLeft
            // 
            this.PanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelLeft.Location = new System.Drawing.Point(0, 52);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(190, 647);
            this.PanelLeft.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(1186, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 647);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(188, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 647);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.DeployButton);
            this.panel3.Controls.Add(this.SeamingButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 699);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1386, 89);
            this.panel3.TabIndex = 4;
            // 
            // SeamingButton
            // 
            this.SeamingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.SeamingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeamingButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SeamingButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeamingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SeamingButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SeamingButton.IconColor = System.Drawing.Color.Black;
            this.SeamingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SeamingButton.IconSize = 48;
            this.SeamingButton.Location = new System.Drawing.Point(280, 19);
            this.SeamingButton.Name = "SeamingButton";
            this.SeamingButton.Rotation = 0D;
            this.SeamingButton.Size = new System.Drawing.Size(153, 58);
            this.SeamingButton.TabIndex = 17;
            this.SeamingButton.Text = "Seaming";
            this.SeamingButton.UseVisualStyleBackColor = false;
            this.SeamingButton.Click += new System.EventHandler(this.SeamingButton_Click);
            // 
            // DeployButton
            // 
            this.DeployButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.DeployButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeployButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DeployButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeployButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeployButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DeployButton.IconColor = System.Drawing.Color.Black;
            this.DeployButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeployButton.IconSize = 48;
            this.DeployButton.Location = new System.Drawing.Point(464, 19);
            this.DeployButton.Name = "DeployButton";
            this.DeployButton.Rotation = 0D;
            this.DeployButton.Size = new System.Drawing.Size(153, 58);
            this.DeployButton.TabIndex = 17;
            this.DeployButton.Text = "Deployment";
            this.DeployButton.UseVisualStyleBackColor = false;
            this.DeployButton.Click += new System.EventHandler(this.DeployButton_Click);
            // 
            // Dibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dibujo";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dibujo_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton SeamingButton;
        private FontAwesome.Sharp.IconButton DeployButton;
    }
}