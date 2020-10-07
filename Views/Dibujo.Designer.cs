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
            this.PbLienzo = new System.Windows.Forms.PictureBox();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PbLienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // PbLienzo
            // 
            this.PbLienzo.Location = new System.Drawing.Point(11, 63);
            this.PbLienzo.Name = "PbLienzo";
            this.PbLienzo.Size = new System.Drawing.Size(685, 364);
            this.PbLienzo.TabIndex = 0;
            this.PbLienzo.TabStop = false;
            this.PbLienzo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseClick);
            this.PbLienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseDown);
            this.PbLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseMove);
            this.PbLienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbLienzo_MouseUp);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAdd.IconColor = System.Drawing.Color.Black;
            this.BtnAdd.IconSize = 16;
            this.BtnAdd.Location = new System.Drawing.Point(702, 98);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Rotation = 0D;
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(702, 127);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Save";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 16;
            this.iconButton2.Location = new System.Drawing.Point(702, 156);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(75, 23);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.Text = "Add";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // Dibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.PbLienzo);
            this.Name = "Dibujo";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Dibujo";
            ((System.ComponentModel.ISupportInitialize)(this.PbLienzo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLienzo;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}