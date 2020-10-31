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
using System.IO;

namespace Mine.Views
{
    public partial class ProjectForm : Form
    {
        readonly int idClient=0;
        readonly GraphDbContext db = new GraphDbContext();
        public ProjectForm(int clientId)
        {
            InitializeComponent();
            idClient = clientId;
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            var client = db.Clients.Find(idClient);

            
            
            //PBLogo.Image = Image.FromFile(client.Image);

            var pr = db.Projects.Include(c => c.Client).Where(a=>a.ClientId==idClient).ToList();
            if (pr.Count>0)
            {
                DGVProject.AutoGenerateColumns = false;
                DGVProject.Columns["Id"].DataPropertyName = "Id";
                DGVProject.Columns["PName"].DataPropertyName = "PName";
                DGVProject.Columns["ProjectNo"].DataPropertyName = "ProjectNo";
                DGVProject.Columns["Contractor"].DataPropertyName = "Contractor";
                DGVProject.Columns["Supplier"].DataPropertyName = "Supplier";
                DGVProject.Columns["GeoSynthetic"].DataPropertyName = "GeoSynthetic";
                DGVProject.DataSource = pr;
            }

            LblRId.Text = client.Id.ToString();
            LblRCode.Text = client.Code;
            LblRCName.Text = client.Name;
            if (client.ImgCl!=null)
            {
                var bimg = Convert.ToBase64String(client.ImgCl);
                //var img = Image.FromStream();
                PBLogo.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(bimg)));          
            }
        }

      
        private void ProjectForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void BtnCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                AddProject ap = new AddProject(idClient);
                if (ap.ShowDialog() == DialogResult.Yes)
                {
                    ProjectForm_Load(sender, e);
                }

            }
            catch (Exception)
            {


            }
        }

      
        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                var cell = DGVProject.CurrentRow.Cells[0].Value;
                var cdb = db.Projects.Find(cell);

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.Projects.Remove(cdb);
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Deleted Successfully");
                    ProjectForm_Load(sender, e);
                }


            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Have a Error :" + ex.ToString(), "Info");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    