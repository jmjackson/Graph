using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Grap.Principal.Model;
using Grap.Principal.DataModel;
using Grap.Principal.Views.Modal;
using Grap.Principal.Views.Details;
using Grap.Principal.Views.Create;
using System.Data.Entity.Infrastructure;

namespace Grap.Principal.Views.Details
{
    public partial class ClientDetails : Form
    {
        readonly int clientId = 0;
        readonly DataBaseContext db = new DataBaseContext();
        public ClientDetails(int id)
        {
            InitializeComponent();
            clientId = id;
        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {
            var client = db.Clients.Find(clientId);
            TxtCode.Text = client.Code;
            TxtItem.Text = client.Id.ToString();
            TxtName.Text = client.Name;
            if (client.Image != null)
            {
                PBImage.Image = new Bitmap(client.Image);
            }


            //tabla Projects
            var lp = db.Projects.Where(a => a.ClientId == clientId).ToList ();
            if (lp.Count > 0)
            {
                DGVProject.AutoGenerateColumns = false;
                DGVProject.Columns["Item"].DataPropertyName = "Id";
                DGVProject.Columns["ProjectName"].DataPropertyName = "ProjectName";
                DGVProject.Columns["ProjectNo"].DataPropertyName = "ProjectNo";
                DGVProject.Columns["Contractor"].DataPropertyName = "Contractor";
                DGVProject.Columns["Supplier"].DataPropertyName = "Supplier";
                DGVProject.Columns["Geosynthetic"].DataPropertyName = "Geosynthetic";
                DGVProject.Columns["LeachPad"].DataPropertyName = "LeachPad";
                DGVProject.Columns["Operator"].DataPropertyName = "Operator";
                DGVProject.Columns["MachineNo"].DataPropertyName = "MachineNo";
                DGVProject.DataSource = lp;
            }


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int id = clientId;
            CreateProject cp = new CreateProject(id);
            cp.ShowDialog();
            

        }

        private void BtnDeploy_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DGVProject.CurrentRow.Cells[0].Value);
            ReportDeployment dp = new ReportDeployment(id);
            dp.Show();

        }
    }
}
