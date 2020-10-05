using Mine.Modal;
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
    public partial class Principal : MetroFramework.Forms.MetroForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            ClientForms c = new ClientForms();
            c.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TileClient_Click(object sender, EventArgs e)
        {
            ClientForms c = new ClientForms();
            c.Show();
        }

        private void TileProject_Click(object sender, EventArgs e)
        {
            ModalProject mp = new ModalProject();
            if (mp.ShowDialog()==DialogResult.Yes)
            {
                var clientId = mp.Cb;
                ProjectForm pf = new ProjectForm(clientId);
                pf.Show();
            }
        }

        private void TileDevelopment_Click(object sender, EventArgs e)
        {
            ModalDevelopment md = new ModalDevelopment();
            if (md.ShowDialog() == DialogResult.Yes)
            {
                int pId = md.ProjectId;
                DevelopmentForm df = new DevelopmentForm(pId);
                df.Show();
            }
        }
    }
}
