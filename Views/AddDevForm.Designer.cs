﻿namespace Mine.Views
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
            this.TxtOperator = new System.Windows.Forms.TextBox();
            this.TxtMachine = new System.Windows.Forms.TextBox();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.DateInspection = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbClients
            // 
            this.CbClients.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CbClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CbClients.FormattingEnabled = true;
            this.CbClients.ItemHeight = 29;
            this.CbClients.Location = new System.Drawing.Point(68, 211);
            this.CbClients.Name = "CbClients";
            this.CbClients.Size = new System.Drawing.Size(321, 35);
            this.CbClients.TabIndex = 1;
            this.CbClients.UseCustomBackColor = true;
            this.CbClients.UseCustomForeColor = true;
            this.CbClients.UseSelectable = true;
            this.CbClients.SelectedIndexChanged += new System.EventHandler(this.CbClients_SelectedIndexChanged);
            // 
            // CbProject
            // 
            this.CbProject.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CbProject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CbProject.FormattingEnabled = true;
            this.CbProject.ItemHeight = 29;
            this.CbProject.Location = new System.Drawing.Point(437, 211);
            this.CbProject.Name = "CbProject";
            this.CbProject.Size = new System.Drawing.Size(321, 35);
            this.CbProject.TabIndex = 2;
            this.CbProject.UseCustomBackColor = true;
            this.CbProject.UseCustomForeColor = true;
            this.CbProject.UseSelectable = true;
            // 
            // TxtOperator
            // 
            this.TxtOperator.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOperator.Location = new System.Drawing.Point(68, 344);
            this.TxtOperator.Name = "TxtOperator";
            this.TxtOperator.Size = new System.Drawing.Size(321, 35);
            this.TxtOperator.TabIndex = 3;
            // 
            // TxtMachine
            // 
            this.TxtMachine.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMachine.Location = new System.Drawing.Point(439, 344);
            this.TxtMachine.Name = "TxtMachine";
            this.TxtMachine.Size = new System.Drawing.Size(319, 35);
            this.TxtMachine.TabIndex = 4;
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
            this.BtnCancel.Location = new System.Drawing.Point(437, 460);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Rotation = 0D;
            this.BtnCancel.Size = new System.Drawing.Size(169, 62);
            this.BtnCancel.TabIndex = 6;
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
            this.BtnSave.Location = new System.Drawing.Point(229, 460);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Rotation = 0D;
            this.BtnSave.Size = new System.Drawing.Size(160, 62);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DateInspection
            // 
            this.DateInspection.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInspection.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight;
            this.DateInspection.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DateInspection.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.DateInspection.Location = new System.Drawing.Point(297, 82);
            this.DateInspection.MinimumSize = new System.Drawing.Size(0, 35);
            this.DateInspection.Name = "DateInspection";
            this.DateInspection.Size = new System.Drawing.Size(393, 35);
            this.DateInspection.TabIndex = 0;
            this.DateInspection.UseCustomBackColor = true;
            this.DateInspection.UseCustomForeColor = true;
            this.DateInspection.UseStyleColors = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Inspection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Project";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "Operator";
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
            this.BtnClose.Location = new System.Drawing.Point(849, 9);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(39, 39);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Machine";
            // 
            // AddDevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 569);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateInspection);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxtMachine);
            this.Controls.Add(this.TxtOperator);
            this.Controls.Add(this.CbProject);
            this.Controls.Add(this.CbClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDevForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Inspection";
            this.Load += new System.EventHandler(this.AddDevForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox CbClients;
        private MetroFramework.Controls.MetroComboBox CbProject;
        private System.Windows.Forms.TextBox TxtOperator;
        private System.Windows.Forms.TextBox TxtMachine;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private FontAwesome.Sharp.IconButton BtnSave;
        private MetroFramework.Controls.MetroDateTime DateInspection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Label label5;
    }
}