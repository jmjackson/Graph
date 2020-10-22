﻿using Mine.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Mine.Views
{
    public partial class EditDevForm : MetroFramework.Forms.MetroForm
    {
        readonly int pdId;
        readonly GraphDbContext db = new GraphDbContext();
        public EditDevForm(int id)
        {
            InitializeComponent();
            pdId = id;
        }

        private void EditDevForm_Load(object sender, EventArgs e)
        {
            var pdev = db.ProjectDevs.Find(pdId);
            TxtId.Text = pdev.Id.ToString();
            TxtInspector.Text = pdev.Inspector;
            TxtLocation.Text = pdev.Location;
            TxtMachineNo.Text = pdev.MachineNo;
            TxtOperator.Text = pdev.Operator;
            TxtProject.Text = pdev.ProjectId.ToString();
            DateInspection.Value = pdev.DevTime;
        }

       

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(TxtId.Text);
                var pdev = db.ProjectDevs.Find(id);
                pdev.DevTime = Convert.ToDateTime(DateInspection.Text);
                pdev.Inspector = TxtInspector.Text;
                pdev.Location = TxtLocation.Text;
                pdev.MachineNo = TxtMachineNo.Text;
                pdev.Operator = TxtOperator.Text;
                db.SaveChanges();
                this.Close();
            }
            catch (Exception)
            {

                
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}