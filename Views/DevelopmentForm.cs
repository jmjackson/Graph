using Mine.DataContext;
using Mine.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine.Views
{
    public partial class DevelopmentForm : MetroFramework.Forms.MetroForm
    {
        int projectId;
        readonly GraphDbContext db = new GraphDbContext();
        public DevelopmentForm(int pId)
        {
            InitializeComponent();
            projectId = pId;
        }

        private void DevelopmentForm_Load(object sender, EventArgs e)
        {
            var pro = db.Projects.Include(a => a.Client).Where(a=>a.Id==projectId).FirstOrDefault();
            TxtClient.Text = pro.Client.Name;
            TxtContractor.Text = pro.Contractor;
            TxtGeoSynthetic.Text = pro.GeoSynthetic;
            TxtProject.Text = pro.PName;
            TxtProjectNo.Text = pro.ProjectNo;
            TxtSupplier.Text = pro.Supplier;
            PBPicture.Image = Image.FromFile(pro.Client.Image);
            
            
        }

        private void BtnSaveDev_Click(object sender, EventArgs e)
        {

        }
    }
}
