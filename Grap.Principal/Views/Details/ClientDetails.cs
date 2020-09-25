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

namespace Grap.Principal.Views.Details
{
    public partial class ClientDetails : Form
    {
        int clientId = 0;
        readonly DataBaseContext db = new DataBaseContext();
        public ClientDetails(int id)
        {
            InitializeComponent();
            clientId = id;
        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {
           var client= db.Clients.Find(clientId);
            TxtCode.Text = client.Code;
            TxtItem.Text = client.Id.ToString();
            TxtName.Text = client.Name;

            //tabla Projects
            var lp = db.Projects.ToList();

            DGVProject.AutoGenerateColumns = false;
            DGVProject.Columns["Id"].DataPropertyName = "Id";
            DGVProject.Columns["ProjectName"].DataPropertyName = "ProjectName";
            DGVProject.Columns["ProjectNo"].DataPropertyName = "ProjectNo";
            DGVProject.Columns["Contractor"].DataPropertyName = "Contractor";
            DGVProject.Columns["Supplier"].DataPropertyName = "Supplier";
            DGVProject.Columns["LeachPad"].DataPropertyName = "LeachPad";
            DGVProject.Columns["Operator"].DataPropertyName = "Operator";
            DGVProject.Columns["MachineNo"].DataPropertyName = "MachineNo";
            DGVProject.Columns["ClientId"].DataPropertyName = "ClientId";
            DGVProject.DataSource = lp;

        }

        private void BunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
