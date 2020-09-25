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

namespace Grap.Principal.Views.Modal
{
    public partial class ModalEditar : Form
    {
        readonly DataBaseContext db = new DataBaseContext();
        int clienteId = 0;
        public ModalEditar( int id)
        {
            InitializeComponent();
            clienteId = id;
            FillData(id);
        }

        private void FillData(int id)
        {
            var client = db.Clients.Find(id);
            TxtCode.Text = client.Code;
            TxtName.Text = client.Code;
            TxtImage.Text = client.Code;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var clientdb = db.Clients.Find(clienteId);
            clientdb.Code = TxtCode.Text;
            clientdb.Name = TxtName.Text;
            clientdb.Image = TxtImage.Text;
            db.SaveChanges();
            this.Close();

        }
    }
}
