using Mine.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine.Views
{
    public partial class EditClient : Form
    {
        readonly int cId;
        readonly GraphDbContext db = new GraphDbContext();
        
        public EditClient(int id)
        {
            
            InitializeComponent();
            
            cId = id;
        }

        private void EditClient_Load(object sender, EventArgs e)
        {

            var cdb = db.Clients.Find(cId);
            TxtId.Text = cdb.Id.ToString();
            TxtCode.Text = cdb.Code;
            TxtName.Text = cdb.Name;
            if (File.Exists(cdb.Image))
            {
                PbClient.Image = new Bitmap(cdb.Image);
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var cldb=db.Clients.Find(id);

            cldb.Name = TxtName.Text;
            cldb.Code = TxtCode.Text;
            db.SaveChanges();
            
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
