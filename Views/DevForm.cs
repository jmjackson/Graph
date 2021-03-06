﻿using Mine.DataContext;
using Mine.DataModel;
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
using MetroFramework;

namespace Mine.Views
{
    public partial class DevForm : Form
    {
        readonly GraphDbContext db = new GraphDbContext();
        public DevForm()
        {
            InitializeComponent();
        }

        private void DevForm_Load(object sender, EventArgs e)
        {
            DGVFill();

        }

       
        public void DGVFill()
        {
            var prodev = db.ProjectDevs.ToList();
            if (prodev.Count >= 0)
            {
                DGVDev.AutoGenerateColumns = false;
                DGVDev.Columns["Id"].DataPropertyName = "Id";
                DGVDev.Columns["Project"].DataPropertyName = "ProjectId";
                DGVDev.Columns["DevTime"].DataPropertyName = "DevTime";
                DGVDev.Columns["Operator"].DataPropertyName = "Operator";
                DGVDev.Columns["MachineNo"].DataPropertyName = "MachineNo";
                DGVDev.DataSource = prodev;
            }
        }


        private void BtnDraw_Click(object sender, EventArgs e)
        {
            int pdId = Convert.ToInt32(DGVDev.CurrentRow.Cells[0].Value);
            Dibujo draw = new Dibujo(pdId);
            draw.Show();
        }


        private void BtnDeployment_Click(object sender, EventArgs e)
        {
            int pdId = Convert.ToInt32(DGVDev.CurrentRow.Cells[0].Value);
            DevelopmentForm df = new DevelopmentForm(pdId);
            df.Show();

        }

        private void BtnGeoMembrane_Click(object sender, EventArgs e)
        {
            int pdId = Convert.ToInt32(DGVDev.CurrentRow.Cells[0].Value);
            GeomembraneForm gm = new GeomembraneForm(pdId);
            gm.Show();
        }

        private void DevForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal p = new Principal();
            p.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                AddDevForm addDev = new AddDevForm();
                if (addDev.ShowDialog() == DialogResult.OK)
                {
                   MetroFramework.MetroMessageBox.Show(this,"Save Successfully","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    DevForm_Load(sender, e);
                    DGVDev.Refresh();
                }

                DevForm_Load(sender, e);
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, "Error " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int pdId = Convert.ToInt32(DGVDev.CurrentRow.Cells[0].Value);
            EditDevForm ed = new EditDevForm(pdId);
            if (ed.ShowDialog() == DialogResult.OK)
            {
                MetroFramework.MetroMessageBox.Show(this,"Update Successfully","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                DGVDev.Refresh();
            }
            DevForm_Load(sender,e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int pdId = Convert.ToInt32(DGVDev.CurrentRow.Cells[0].Value);
                var pd = db.ProjectDevs.Find(pdId);
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.ProjectDevs.Remove(pd);
                    db.SaveChanges();
                }
                MetroMessageBox.Show(this,"Delete Success ","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                DevForm_Load(sender, e);
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this,"An Error Ocurred "+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
