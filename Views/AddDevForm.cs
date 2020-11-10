using MetroFramework;
using Mine.DataContext;
using Mine.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine.Views
{
    public partial class AddDevForm : Form
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var insp = new ProjectDev()
                {
                    DevTime = DateInspection.Value,
                    MachineNo = TxtMachine.Text,
                    Operator = TxtOperator.Text,
                    ProjectId = Convert.ToInt32(CbProject.SelectedValue)
                };
                db.ProjectDevs.Add(insp);
                db.SaveChanges();
                this.Close();
                MetroMessageBox.Show(this, "Saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

               
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
