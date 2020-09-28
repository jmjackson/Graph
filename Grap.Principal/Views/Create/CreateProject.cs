using Grap.Principal.DataModel;
using Grap.Principal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grap.Principal.Views.Create
{
    public partial class CreateProject : Form
    {
        readonly DataBaseContext db = new DataBaseContext();

        readonly int clientId = 0;
        public CreateProject(int id)
        {
            InitializeComponent();
            clientId = id;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Projects p = new Projects()
            {
                ClientId=clientId,
                Contractor=TxtContractor.Text,
                Geosynthetic = TxtGeoSynthetic.Text,
                LeachPad = TxtLeachPad.Text,
                MachineNo = TxtMachine.Text,
                Operator = TxtOperator.Text,
                ProjectName = TxtPName.Text,
                ProjectNo = TxtProject.Text,
                Supplier=TxtSupplier.Text,
            };

            db.Projects.Add(p);
            db.SaveChanges();
            this.Close();
        }
    }
}
