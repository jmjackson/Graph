using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Grap.Principal.Model;
using Grap.Principal.DataModel;

namespace Grap.Principal.Views
{
    public partial class ListaClientes : Form
    {
        readonly DataBaseContext db = new DataBaseContext();
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            new Registro().ShowDialog();
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            //dummy data
            var lc = db.Clients.ToList();

            //use binding source to hold dummy data
            BindingSource binding = new BindingSource();
            binding.DataSource = lc;

            //bind datagridview to binding source
            DgvPersonas.DataSource = binding;
        }
    }
}
