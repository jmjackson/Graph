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

namespace Grap.Principal.Views
{
    public partial class ListaClientes : Form
    {
        SQLiteController SQ = new SQLiteController();
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
            SQ.cargarPersonas(DgvPersonas);
        }
    }
}
