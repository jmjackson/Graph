namespace Mine.Views
{
    partial class AddProject
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
            this.components = new System.ComponentModel.Container();
            this.TxtProject = new System.Windows.Forms.TextBox();
            this.TxtProjectNo = new System.Windows.Forms.TextBox();
            this.TxtContractor = new System.Windows.Forms.TextBox();
            this.TxtSupplier = new System.Windows.Forms.TextBox();
            this.TxtGeosynthetic = new System.Windows.Forms.TextBox();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.BElipse = new ns1.BunifuElipse(this.components);
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.DragControl = new ns1.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // TxtProject
            // 
            this.TxtProject.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProject.Location = new System.Drawing.Point(56, 117);
            this.TxtProject.Name = "TxtProject";
            this.TxtProject.Size = new System.Drawing.Size(274, 33);
            this.TxtProject.TabIndex = 0;
            // 
            // TxtProjectNo
            // 
            this.TxtProjectNo.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProjectNo.Location = new System.Drawing.Point(349, 117);
            this.TxtProjectNo.Name = "TxtProjectNo";
            this.TxtProjectNo.Size = new System.Drawing.Size(298, 33);
            this.TxtProjectNo.TabIndex = 1;
            // 
            // TxtContractor
            // 
            this.TxtContractor.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContractor.Location = new System.Drawing.Point(56, 209);
            this.TxtContractor.Name = "TxtContractor";
            this.TxtContractor.Size = new System.Drawing.Size(274, 33);
            this.TxtContractor.TabIndex = 2;
            // 
            // TxtSupplier
            // 
            this.TxtSupplier.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSupplier.Location = new System.Drawing.Point(349, 209);
            this.TxtSupplier.Name = "TxtSupplier";
            this.TxtSupplier.Size = new System.Drawing.Size(298, 33);
            this.TxtSupplier.TabIndex = 3;
            // 
            // TxtGeosynthetic
            // 
            this.TxtGeosynthetic.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGeosynthetic.Location = new System.Drawing.Point(56, 317);
            this.TxtGeosynthetic.Name = "TxtGeosynthetic";
            this.TxtGeosynthetic.Size = new System.Drawing.Size(287, 33);
            this.TxtGeosynthetic.TabIndex = 4;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnSave.IconColor = System.Drawing.Color.White;
            this.BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSave.IconSize = 25;
            this.BtnSave.Location = new System.Drawing.Point(187, 389);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Rotation = 0D;
            this.BtnSave.Size = new System.Drawing.Size(156, 44);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnCancel.IconColor = System.Drawing.Color.White;
            this.BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancel.IconSize = 25;
            this.BtnCancel.Location = new System.Drawing.Point(359, 389);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Rotation = 0D;
            this.BtnCancel.Size = new System.Drawing.Size(156, 44);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(56, 169);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Contractor";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(56, 70);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Project";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(349, 70);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Project No";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(56, 269);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(109, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Geosynthetic";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(349, 169);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(74, 25);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Supplier";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // BElipse
            // 
            this.BElipse.ElipseRadius = 5;
            this.BElipse.TargetControl = this;
            // 
            // BtnClose
            // 
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnClose.IconColor = System.Drawing.Color.Red;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnClose.IconSize = 36;
            this.BtnClose.Location = new System.Drawing.Point(643, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(31, 30);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(686, 456);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtGeosynthetic);
            this.Controls.Add(this.TxtSupplier);
            this.Controls.Add(this.TxtContractor);
            this.Controls.Add(this.TxtProjectNo);
            this.Controls.Add(this.TxtProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProject";
            this.Text = "Add Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtProject;
        private System.Windows.Forms.TextBox TxtProjectNo;
        private System.Windows.Forms.TextBox TxtContractor;
        private System.Windows.Forms.TextBox TxtSupplier;
        private System.Windows.Forms.TextBox TxtGeosynthetic;
        private FontAwesome.Sharp.IconButton BtnSave;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private ns1.BunifuElipse BElipse;
        private FontAwesome.Sharp.IconButton BtnClose;
        private ns1.BunifuDragControl DragControl;
    }
}