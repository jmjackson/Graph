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
    public partial class EditProject : Form
    {
        readonly int idP;
        readonly GraphDbContext db = new GraphDbContext();
        public EditProject(int pId)
        {
            InitializeComponent();
            idP = pId;
        }

        private void EditProject_Load(object sender, EventArgs e)
        {
            var project = db.Projects.Find(idP);
            TxtClientId.Text = project.Id.ToString();
            TxtContractor.Text = project.Contractor;
            TxtGeosynthetic.Text = project.GeoSynthetic;
            TxtProjecNo.Text = project.ProjectNo;
            TxtProject.Text = project.PName;
            TxtSupplier.Text = project.Supplier;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var project = db.Projects.Find(idP);
                project.Contractor = TxtContractor.Text;
                project.GeoSynthetic = TxtGeosynthetic.Text;
                project.PName = TxtProject.Text;
                project.ProjectNo = TxtProjecNo.Text;
                project.Supplier = TxtSupplier.Text;
                db.SaveChanges();
                this.Close();

            }
            catch (Exception ex)
            {

                
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
