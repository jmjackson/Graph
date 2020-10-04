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

namespace Mine.Views
{
    public partial class ProjectForm : MetroFramework.Forms.MetroForm
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

            TxtId.Text = client.Id.ToString();
            TxtName.Text = client.Name;
            TxtCode.Text = client.Code;
            PBLogo.Image = Image.FromFile(client.Image);

            var pr = db.Projects.Include(c => c.Client).Where(a=>a.ClientId==idClient).ToList();
            if (pr.Count>0)
            {
                DGVProject.AutoGenerateColumns = false;
                DGVProject.Columns["Id"].DataPropertyName = "Id";
                DGVProject.Columns["PName"].DataPropertyName = "PName";
                DGVProject.Columns["ProjectNo"].DataPropertyName = "ProjectNo";
                DGVProject.Columns["Contractor"].DataPropertyName = "Contractor";
                DGVProject.Columns["GeoSynthetic"].DataPropertyName = "Supplier";
                DGVProject.DataSource = pr;
            }
            

            


        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            TxtPid.Enabled = false;
            Project p = new Project()
            {
                PName=TxtPName.Text,
                ProjectNo=TxtPNumber.Text,
                Contractor=TxtContractor.Text,
                Supplier=TxtSupplier.Text,
                ClientId=idClient,
                GeoSynthetic=TxtGeosynthetic.Text,
            };

            db.Projects.Add(p);
            db.SaveChanges();
            MetroFramework.MetroMessageBox.Show(this, "Save Successfully");
            ProjectForm_Load(sender,e);
            TxtPName.Text = String.Empty;
            TxtPNumber.Text = String.Empty;
            TxtContractor.Text = String.Empty;
            TxtSupplier.Text = String.Empty;
            TxtGeosynthetic.Text = String.Empty;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var cell = DGVProject.CurrentRow.Cells[0].Value;
                var cdb = db.Projects.Find(cell);
                if (cdb!=null)
                {
                    TxtPid.Text = cdb.Id.ToString();
                    TxtPName.Text = cdb.PName;
                    TxtPNumber.Text = cdb.ProjectNo;
                    TxtContractor.Text = cdb.Contractor;
                    TxtSupplier.Text = cdb.Supplier;
                    TxtGeosynthetic.Text = cdb.GeoSynthetic;
                }
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this,"Ocurred and error "+ex.ToString(),"Info");
            }
        }
    }
}
    