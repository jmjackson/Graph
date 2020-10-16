using Mine.DataContext;
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
    public partial class AddDevForm : MetroFramework.Forms.MetroForm
    {
        readonly GraphDbContext db = new GraphDbContext();
        public AddDevForm()
        {
            InitializeComponent();
        }

        private void AddDevForm_Load(object sender, EventArgs e)
        {
            var cls = db.Clients.ToList();
            CbClients.DisplayMember = "Name";
            CbClients.ValueMember = "Id";
            CbClients.DataSource = cls;
        }

        private void CbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clId = Convert.ToInt32(CbClients.SelectedValue);
            var projects = db.Projects.Where(a => a.ClientId == clId).ToList();

            CbProject.DisplayMember = "PName";
            CbProject.ValueMember = "Id";
            CbProject.DataSource = projects;
        }

    }
}
