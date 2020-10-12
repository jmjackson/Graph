using Mine.DataContext;
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
    public partial class DevForm : MetroFramework.Forms.MetroForm
    {
        readonly GraphDbContext db = new GraphDbContext();
        public DevForm()
        {
            InitializeComponent();
        }

        private void DevForm_Load(object sender, EventArgs e)
        {
            var cl = db.Clients.ToList();
            CbClient.ValueMember = "Id";
            CbClient.DisplayMember = "Name";
            CbClient.DataSource = cl;
        }

        private void CbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbClient.SelectedIndex>0)
            {
               int cId= Convert.ToInt32(CbClient.SelectedValue);
                var pro = db.Projects.Where(a => a.ClientId == cId).ToList();
                
                CbProject.ValueMember = "Id";
                CbProject.DisplayMember = "PName";
                CbProject.DataSource = pro;
            }
            DGVFill();
            
        }
        public void DGVFill()
        {
            var prodev = db.ProjectDevs.ToList();
            if (prodev.Count > 0)
            {
                DGVDev.AutoGenerateColumns = false;
                DGVDev.Columns["Id"].DataPropertyName = "Id";
                DGVDev.Columns["Project"].DataPropertyName = "ProjectId";
                DGVDev.Columns["Inspector"].DataPropertyName = "Inspector";
                DGVDev.Columns["Location"].DataPropertyName = "Location";
                DGVDev.Columns["DevTime"].DataPropertyName = "DevTime";
                DGVDev.DataSource = prodev;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var prodev = new ProjectDev()
                {
                    Inspector = TxtInspector.Text,
                    Location = TxtLocation.Text,
                    ProjectId = Convert.ToInt32(CbProject.SelectedValue),
                    DevTime = Convert.ToDateTime(DateDev.Text)
                };

                db.ProjectDevs.Add(prodev);
                db.SaveChanges();
                MetroMessageBox.Show(this, "Saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DevForm_Load(sender, e);
                TxtInspector.Text = string.Empty;
                TxtLocation.Text = string.Empty;
                
                
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, "Error "+ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
            int pdId= Convert.ToInt32(DGVDev.CurrentRow.Cells[0].Value);
            var pdev = db.ProjectDevs.Include(a => a.Project.Client).
                Include(a => a.Project).Where(a => a.Id == pdId)
                .FirstOrDefault();
            
            TxtInspector.Text = pdev.Inspector;
            TxtLocation.Text = pdev.Location;
            DateDev.Value =pdev.DevTime;
            TxtBoxId.Text = pdId.ToString();
            CbClient.Enabled = false;
            CbProject.Enabled = false;
            


        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            int pdId = Convert.ToInt32(DGVDev.CurrentRow.Cells[0].Value);
            Dibujo draw = new Dibujo(pdId);
            draw.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var pdId = Int32.Parse(TxtBoxId.Text);
                var pd = db.ProjectDevs.Find(pdId);
                pd.Inspector = TxtInspector.Text;
                pd.Location = TxtLocation.Text;
                pd.DevTime = Convert.ToDateTime(DateDev.Text);
                db.SaveChanges();
                MetroMessageBox.Show(this, "Update is successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                TxtInspector.Text = string.Empty;
                TxtLocation.Text = string.Empty;
                TxtBoxId.Text = string.Empty;
                CbClient.Enabled = true;
                CbProject.Enabled = true;
                DevForm_Load(sender, e);

            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, "Error "+ex.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
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
                DevForm_Load(sender, e);
            }
            catch (Exception)
            {

                throw;
            }
            
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
    }
}
