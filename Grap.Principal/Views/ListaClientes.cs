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
using Grap.Principal.Views.Modal;
using Grap.Principal.Views.Details;

namespace Grap.Principal.Views
{
    public partial class ListaClientes : Form
    {
        readonly DataBaseContext db = new DataBaseContext();
        public ListaClientes()
        {
            InitializeComponent();

            
        }

        

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            //dummy data
            var lc = db.Clients.ToList();

            DGVClients.AutoGenerateColumns = false;
            DGVClients.Columns["Id"].DataPropertyName = "Id";
            DGVClients.Columns["Code"].DataPropertyName = "Code";
            DGVClients.Columns["CName"].DataPropertyName = "Name";
            DGVClients.DataSource = lc;
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            Registro r = new Registro(this);
            r.ShowDialog();
            UpdateForm();
        }

        private void UpdateForm()
        {
            var lc = db.Clients.ToList();

            DGVClients.AutoGenerateColumns = false;
            DGVClients.Columns["Id"].DataPropertyName = "Id";
            DGVClients.Columns["Code"].DataPropertyName = "Code";
            DGVClients.Columns["CName"].DataPropertyName = "Name";
            DGVClients.DataSource = lc;
        }

        private void ListaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home h = new Home();
            h.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ModalDelete md = new ModalDelete();
            if (md.ShowDialog() == DialogResult.OK)
            {
                var id = DGVClients.CurrentRow.Cells[0].Value;
                var cliente = db.Clients.Find(id);
                db.Clients.Remove(cliente);
                db.SaveChanges();
                UpdateForm();
            }
        }

        private void BtnDetalle_Click(object sender, EventArgs e)
        {
            var id =Convert.ToInt32(DGVClients.CurrentRow.Cells[0].Value);
            ClientDetails cd = new ClientDetails(id);
            cd.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //var id = Convert.ToInt32(DGVClients.CurrentRow.Cells[0].Value);
            //ModalEditar me = new ModalEditar(id);
            //me.ShowDialog();
            //UpdateForm();
            var id = Convert.ToInt32(DGVClients.CurrentRow.Cells[0].Value);
            ModalEditar me = new ModalEditar(id);
            if (me.ShowDialog() == DialogResult.OK)
            {
                me.ShowDialog();
                UpdateForm();
            }
        }

        private void DGVClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
