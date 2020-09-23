using Grap.Principal.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grap.Principal.Views.Details
{
    public partial class ClientDetails : Form
    {
        int clientId = 0;
        DataBaseContext db = new DataBaseContext();
        public ClientDetails(int id)
        {
            InitializeComponent();
            clientId = id;
        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {
           var client= db.Clients.Find(clientId);
            TxtCode.Text = client.Code;
            TxtItem.Text = client.Id.ToString();
            TxtName.Text = client.Name;

        }
    }
}
