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
    public partial class AddProject : MetroFramework.Forms.MetroForm
    {
        readonly int idCl;
        readonly GraphDbContext db = new GraphDbContext();
        public AddProject(int clId)
        {
            InitializeComponent();
            idCl = clId;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var project = new Project()
                {
                    ClientId = idCl,
                    Contractor = TxtContractor.Text,
                    GeoSynthetic = TxtGeosynthetic.Text,
                    PName = TxtProject.Text,
                    ProjectNo = TxtProjectNo.Text,
                    Supplier = TxtSupplier.Text
                };

                db.Projects.Add(project);
                db.SaveChanges();
                
                this.Close();
            }
            catch (Exception ex)
            {

              
            }
            
        }
    }
}
