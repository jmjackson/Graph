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

namespace Mine.Modal
{
    public partial class ModalInsp : Form
    {
        int pdId;
        GraphDbContext db = new GraphDbContext();
        public ModalInsp(int Id)
        {
            InitializeComponent();
            pdId = Id;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var pd = db.ProjectDevs.Find(pdId);
            pd.InspectorDev = TxtInspection.Text;
            pd.LocationDev = TxtLocation.Text;
            db.SaveChanges();
            this.Close();
        }
    }
}
