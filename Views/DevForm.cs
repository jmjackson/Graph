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
                DGVDev.Columns["DevTime"].DataPropertyName = "DevTimeadmin";
                DGVDev.DataSource = prodev;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var prodev = new ProjectDev()
            {
                Inspector = TxtInspector.Text,
                Location = TxtLocation.Text,
                ProjectId = Convert.ToInt32(CbProject.SelectedValue),
                DevTime=Convert.ToDateTime(DateDev.Text)
            };

            db.ProjectDevs.Add(prodev);
            db.SaveChanges();

            DevForm_Load(sender,e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
