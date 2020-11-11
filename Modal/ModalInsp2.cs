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
    public partial class ModalInsp2 : Form
    {
        int pdId;
        GraphDbContext db = new GraphDbContext();
        public ModalInsp2(int id)
        {
            InitializeComponent();
            pdId = id;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var pd = db.ProjectDevs.Find(pdId);
            pd.InspectorGeo = TxtInspector.Text;
            pd.LocationGeo = TxtLocation.Text;
            db.SaveChanges();
            this.Close();
        }
    }
}
