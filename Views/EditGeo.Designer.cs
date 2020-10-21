namespace Mine.Views
{
    partial class EditGeo
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
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtSeamNo = new System.Windows.Forms.TextBox();
            this.TxtSeamTime = new System.Windows.Forms.TextBox();
            this.TxtCarryOver = new System.Windows.Forms.TextBox();
            this.TxtDestructive = new System.Windows.Forms.TextBox();
            this.TxtRemark = new System.Windows.Forms.TextBox();
            this.TxtTemp = new System.Windows.Forms.TextBox();
            this.TxtSpeed = new System.Windows.Forms.TextBox();
            this.TxtSeamLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSave.IconColor = System.Drawing.Color.White;
            this.BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSave.IconSize = 48;
            this.BtnSave.Location = new System.Drawing.Point(167, 472);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Rotation = 0D;
            this.BtnSave.Size = new System.Drawing.Size(118, 37);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCancel.IconColor = System.Drawing.Color.White;
            this.BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancel.IconSize = 48;
            this.BtnCancel.Location = new System.Drawing.Point(313, 472);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Rotation = 0D;
            this.BtnCancel.Size = new System.Drawing.Size(118, 37);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(38, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(26, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(313, 157);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Temp";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(38, 303);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Carry Over";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(313, 88);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Seam No";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(38, 232);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Speed";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(313, 303);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(95, 25);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Destructive";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(38, 157);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(96, 25);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Seam Time";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(313, 231);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(111, 25);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Seam Length";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(38, 381);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(176, 25);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Remarks / Destructive";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(38, 116);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(247, 33);
            this.TxtId.TabIndex = 3;
            // 
            // TxtSeamNo
            // 
            this.TxtSeamNo.Location = new System.Drawing.Point(313, 116);
            this.TxtSeamNo.Name = "TxtSeamNo";
            this.TxtSeamNo.Size = new System.Drawing.Size(247, 33);
            this.TxtSeamNo.TabIndex = 3;
            // 
            // TxtSeamTime
            // 
            this.TxtSeamTime.Location = new System.Drawing.Point(38, 185);
            this.TxtSeamTime.Name = "TxtSeamTime";
            this.TxtSeamTime.Size = new System.Drawing.Size(247, 33);
            this.TxtSeamTime.TabIndex = 3;
            // 
            // TxtCarryOver
            // 
            this.TxtCarryOver.Location = new System.Drawing.Point(38, 331);
            this.TxtCarryOver.Name = "TxtCarryOver";
            this.TxtCarryOver.Size = new System.Drawing.Size(247, 33);
            this.TxtCarryOver.TabIndex = 3;
            // 
            // TxtDestructive
            // 
            this.TxtDestructive.Location = new System.Drawing.Point(313, 331);
            this.TxtDestructive.Name = "TxtDestructive";
            this.TxtDestructive.Size = new System.Drawing.Size(247, 33);
            this.TxtDestructive.TabIndex = 3;
            // 
            // TxtRemark
            // 
            this.TxtRemark.Location = new System.Drawing.Point(38, 418);
            this.TxtRemark.Name = "TxtRemark";
            this.TxtRemark.Size = new System.Drawing.Size(522, 33);
            this.TxtRemark.TabIndex = 3;
            // 
            // TxtTemp
            // 
            this.TxtTemp.Location = new System.Drawing.Point(313, 185);
            this.TxtTemp.Name = "TxtTemp";
            this.TxtTemp.Size = new System.Drawing.Size(247, 33);
            this.TxtTemp.TabIndex = 3;
            // 
            // TxtSpeed
            // 
            this.TxtSpeed.Location = new System.Drawing.Point(38, 259);
            this.TxtSpeed.Name = "TxtSpeed";
            this.TxtSpeed.Size = new System.Drawing.Size(247, 33);
            this.TxtSpeed.TabIndex = 3;
            // 
            // TxtSeamLength
            // 
            this.TxtSeamLength.Location = new System.Drawing.Point(313, 259);
            this.TxtSeamLength.Name = "TxtSeamLength";
            this.TxtSeamLength.Size = new System.Drawing.Size(247, 33);
            this.TxtSeamLength.TabIndex = 3;
            // 
            // EditGeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 540);
            this.Controls.Add(this.TxtSeamLength);
            this.Controls.Add(this.TxtRemark);
            this.Controls.Add(this.TxtSeamTime);
            this.Controls.Add(this.TxtSpeed);
            this.Controls.Add(this.TxtDestructive);
            this.Controls.Add(this.TxtTemp);
            this.Controls.Add(this.TxtSeamNo);
            this.Controls.Add(this.TxtCarryOver);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "EditGeo";
            this.Padding = new System.Windows.Forms.Padding(33, 115, 33, 38);
            this.Text = "Update Seaming";
            this.Load += new System.EventHandler(this.EditGeo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnSave;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtSeamNo;
        private System.Windows.Forms.TextBox TxtSeamTime;
        private System.Windows.Forms.TextBox TxtCarryOver;
        private System.Windows.Forms.TextBox TxtDestructive;
        private System.Windows.Forms.TextBox TxtRemark;
        private System.Windows.Forms.TextBox TxtTemp;
        private System.Windows.Forms.TextBox TxtSpeed;
        private System.Windows.Forms.TextBox TxtSeamLength;
    }
}