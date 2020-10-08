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
            this.BntAdd = new FontAwesome.Sharp.IconButton();
            this.BntSave = new FontAwesome.Sharp.IconButton();
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
            // BntAdd
            // 
            this.BntAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BntAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BntAdd.IconColor = System.Drawing.Color.Black;
            this.BntAdd.IconSize = 16;
            this.BntAdd.Location = new System.Drawing.Point(702, 98);
            this.BntAdd.Name = "BntAdd";
            this.BntAdd.Rotation = 0D;
            this.BntAdd.Size = new System.Drawing.Size(75, 23);
            this.BntAdd.TabIndex = 3;
            this.BntAdd.Text = "Add";
            this.BntAdd.UseVisualStyleBackColor = true;
            // 
            // BntSave
            // 
            this.BntSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BntSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BntSave.IconColor = System.Drawing.Color.Black;
            this.BntSave.IconSize = 16;
            this.BntSave.Location = new System.Drawing.Point(702, 127);
            this.BntSave.Name = "BntSave";
            this.BntSave.Rotation = 0D;
            this.BntSave.Size = new System.Drawing.Size(75, 23);
            this.BntSave.TabIndex = 4;
            this.BntSave.Text = "Save";
            this.BntSave.UseVisualStyleBackColor = true;
            this.BntSave.Click += new System.EventHandler(this.BntSave_Click);
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
            this.Controls.Add(this.BntSave);
            this.Controls.Add(this.BntAdd);
            this.Controls.Add(this.PbLienzo);
            this.Name = "Dibujo";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Dibujo";
            ((System.ComponentModel.ISupportInitialize)(this.PbLienzo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLienzo;
        private FontAwesome.Sharp.IconButton BntAdd;
        private FontAwesome.Sharp.IconButton BntSave;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}