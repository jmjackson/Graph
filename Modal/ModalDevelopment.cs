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
using System.Data.Entity;

namespace Mine.Modal
{
    public partial class ModalDevelopment : MetroFramework.Forms.MetroForm
    {
        readonly GraphDbContext db = new GraphDbContext();
        public int ClientId { get; set; }
        public int ProjectId { get; set; }
        public ModalDevelopment()
        {
            InitializeComponent();
        }

        private void ModalDevelopment_Load(object sender, EventArgs e)
        {
            var cl = db.Clients.ToList();
            CBClient.ValueMember = "Id";
            CBClient.DisplayMember = "Name";
            CBClient.DataSource = cl;
        }

        

        private void CBClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(CBClient.SelectedValue);
            var pr = db.Projects.Include(a => a.Client).Where(a => a.ClientId == clientId).ToList();

            CBProject.ValueMember = "Id";
            CBProject.DisplayMember = "PName";
            CBProject.DataSource = pr;
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            ProjectId= Convert.ToInt32(CBProject.SelectedValue);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
