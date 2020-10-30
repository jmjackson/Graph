namespace Mine.Views
{
    partial class AddDevForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDevForm));
            this.CbClients = new MetroFramework.Controls.MetroComboBox();
            this.CbProject = new MetroFramework.Controls.MetroComboBox();
            this.TxtInspector = new System.Windows.Forms.TextBox();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.TxtOperator = new System.Windows.Forms.TextBox();
            this.TxtMachine = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.DateInspection = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // CbClients
            // 
            this.CbClients.FormattingEnabled = true;
            this.CbClients.ItemHeight = 23;
            this.CbClients.Location = new System.Drawing.Point(67, 196);
            this.CbClients.Name = "CbClients";
            this.CbClients.Size = new System.Drawing.Size(275, 29);
            this.CbClients.TabIndex = 0;
            this.CbClients.UseSelectable = true;
            this.CbClients.SelectedIndexChanged += new System.EventHandler(this.CbClients_SelectedIndexChanged);
            // 
            // CbProject
            // 
            this.CbProject.FormattingEnabled = true;
            this.CbProject.ItemHeight = 23;
            this.CbProject.Location = new System.Drawing.Point(388, 196);
            this.CbProject.Name = "CbProject";
            this.CbProject.Size = new System.Drawing.Size(275, 29);
            this.CbProject.TabIndex = 0;
            this.CbProject.UseSelectable = true;
            // 
            // TxtInspector
            // 
            this.TxtInspector.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInspector.Location = new System.Drawing.Point(69, 306);
            this.TxtInspector.Name = "TxtInspector";
            this.TxtInspector.Size = new System.Drawing.Size(275, 33);
            this.TxtInspector.TabIndex = 1;
            // 
            // TxtLocation
            // 
            this.TxtLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLocation.Location = new System.Drawing.Point(390, 306);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(275, 33);
            this.TxtLocation.TabIndex = 1;
            // 
            // TxtOperator
            // 
            this.TxtOperator.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOperator.Location = new System.Drawing.Point(69, 408);
            this.TxtOperator.Name = "TxtOperator";
            this.TxtOperator.Size = new System.Drawing.Size(275, 33);
            this.TxtOperator.TabIndex = 1;
            // 
            // TxtMachine
            // 
            this.TxtMachine.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMachine.Location = new System.Drawing.Point(390, 408);
            this.TxtMachine.Name = "TxtMachine";
            this.TxtMachine.Size = new System.Drawing.Size(275, 33);
            this.TxtMachine.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(390, 153);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Project";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(69, 153);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Client";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(68, 249);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Inspector";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(390, 363);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Machine";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(388, 253);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Location";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(69, 363);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 25);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Operator";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCancel.IconColor = System.Drawing.Color.Black;
            this.BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancel.IconSize = 16;
            this.BtnCancel.Location = new System.Drawing.Point(388, 472);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Rotation = 0D;
            this.BtnCancel.Size = new System.Drawing.Size(149, 52);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSave.IconColor = System.Drawing.Color.Black;
            this.BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSave.IconSize = 16;
            this.BtnSave.Location = new System.Drawing.Point(202, 472);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Rotation = 0D;
            this.BtnSave.Size = new System.Drawing.Size(140, 52);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DateInspection
            // 
            this.DateInspection.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.DateInspection.Location = new System.Drawing.Point(297, 82);
            this.DateInspection.MinimumSize = new System.Drawing.Size(0, 35);
            this.DateInspection.Name = "DateInspection";
            this.DateInspection.Size = new System.Drawing.Size(368, 35);
            this.DateInspection.TabIndex = 4;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(188, 92);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(47, 25);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Date";
            // 
            // AddDevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 569);
            this.Controls.Add(this.DateInspection);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtMachine);
            this.Controls.Add(this.TxtOperator);
            this.Controls.Add(this.TxtLocation);
            this.Controls.Add(this.TxtInspector);
            this.Controls.Add(this.CbProject);
            this.Controls.Add(this.CbClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDevForm";
            this.Text = "Add Inspection";
            this.Load += new System.EventHandler(this.AddDevForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox CbClients;
        private MetroFramework.Controls.MetroComboBox CbProject;
        private System.Windows.Forms.TextBox TxtInspector;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.TextBox TxtOperator;
        private System.Windows.Forms.TextBox TxtMachine;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private FontAwesome.Sharp.IconButton BtnSave;
        private MetroFramework.Controls.MetroDateTime DateInspection;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}