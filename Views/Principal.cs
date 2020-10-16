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
    public partial class Principal : Form
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
            this.Hide();
        }

        private void TileProject_Click(object sender, EventArgs e)
        {
            ModalProject mp = new ModalProject();
            
            if (mp.ShowDialog()==DialogResult.Yes)
            {
                var clientId = mp.Cb;
                ProjectForm pf = new ProjectForm(clientId);
                pf.Show();
                this.Hide();

            }
            else
            {
                
            }
            
        }

        

        private void TileInspection_Click(object sender, EventArgs e)
        {
            DevForm df = new DevForm();
            df.Show();
            this.Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
