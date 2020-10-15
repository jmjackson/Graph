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
    public partial class AddDevForm : MetroFramework.Forms.MetroForm
    {
        readonly GraphDbContext db = new GraphDbContext();
        public AddDevForm()
        {
            InitializeComponent();
        }

        private void AddDevForm_Load(object sender, EventArgs e)
        {
            var cls = db.Clients.ToList();
            CbClients.DisplayMember = "Name";
            CbClients.ValueMember = "Id";
            CbClients.DataSource = cls;
        }
    }
}
