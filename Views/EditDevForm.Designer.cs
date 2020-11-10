namespace Mine.Views
{
    partial class EditDevForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDevForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.TxtOperator = new System.Windows.Forms.TextBox();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.TxtInspector = new System.Windows.Forms.TextBox();
            this.TxtMachineNo = new System.Windows.Forms.TextBox();
            this.TxtProject = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.DateInspection = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(412, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Project";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(412, 288);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Machine No";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(51, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(26, 25);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Id";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(52, 197);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 25);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Location";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(52, 288);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 25);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Operator";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(412, 197);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(81, 25);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Inspector";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSave.IconColor = System.Drawing.Color.Black;
            this.BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSave.IconSize = 48;
            this.BtnSave.Location = new System.Drawing.Point(185, 418);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Rotation = 0D;
            this.BtnSave.Size = new System.Drawing.Size(164, 52);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(51)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCancel.IconColor = System.Drawing.Color.Black;
            this.BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancel.IconSize = 48;
            this.BtnCancel.Location = new System.Drawing.Point(412, 418);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Rotation = 0D;
            this.BtnCancel.Size = new System.Drawing.Size(174, 52);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtOperator
            // 
            this.TxtOperator.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOperator.Location = new System.Drawing.Point(54, 339);
            this.TxtOperator.Name = "TxtOperator";
            this.TxtOperator.Size = new System.Drawing.Size(296, 33);
            this.TxtOperator.TabIndex = 3;
            // 
            // TxtLocation
            // 
            this.TxtLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLocation.Location = new System.Drawing.Point(52, 240);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(297, 33);
            this.TxtLocation.TabIndex = 3;
            // 
            // TxtInspector
            // 
            this.TxtInspector.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInspector.Location = new System.Drawing.Point(412, 240);
            this.TxtInspector.Name = "TxtInspector";
            this.TxtInspector.Size = new System.Drawing.Size(324, 33);
            this.TxtInspector.TabIndex = 3;
            // 
            // TxtMachineNo
            // 
            this.TxtMachineNo.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMachineNo.Location = new System.Drawing.Point(412, 339);
            this.TxtMachineNo.Name = "TxtMachineNo";
            this.TxtMachineNo.Size = new System.Drawing.Size(324, 33);
            this.TxtMachineNo.TabIndex = 3;
            // 
            // TxtProject
            // 
            this.TxtProject.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProject.Location = new System.Drawing.Point(412, 147);
            this.TxtProject.Name = "TxtProject";
            this.TxtProject.ReadOnly = true;
            this.TxtProject.Size = new System.Drawing.Size(324, 33);
            this.TxtProject.TabIndex = 4;
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(52, 147);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(297, 33);
            this.TxtId.TabIndex = 5;
            // 
            // DateInspection
            // 
            this.DateInspection.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInspection.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.DateInspection.Location = new System.Drawing.Point(227, 59);
            this.DateInspection.MinimumSize = new System.Drawing.Size(0, 35);
            this.DateInspection.Name = "DateInspection";
            this.DateInspection.Size = new System.Drawing.Size(508, 35);
            this.DateInspection.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(115, 69);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 25);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Date";
            // 
            // BtnClose
            // 
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
            this.BtnClose.Location = new System.Drawing.Point(845, 9);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(45, 39);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edit Inspection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(524, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "label1";
            // 
            // EditDevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.DateInspection);
            this.Controls.Add(this.TxtProject);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtMachineNo);
            this.Controls.Add(this.TxtInspector);
            this.Controls.Add(this.TxtLocation);
            this.Controls.Add(this.TxtOperator);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDevForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Inspection";
            this.Load += new System.EventHandler(this.EditDevForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private FontAwesome.Sharp.IconButton BtnSave;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private System.Windows.Forms.TextBox TxtOperator;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.TextBox TxtInspector;
        private System.Windows.Forms.TextBox TxtMachineNo;
        private System.Windows.Forms.TextBox TxtProject;
        private System.Windows.Forms.TextBox TxtId;
        private MetroFramework.Controls.MetroDateTime DateInspection;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}