using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grap.Principal.Views
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            OpenPanelForm(new ListaClientes());
        }

        

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void OpenPanelForm(object childForm)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = childForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            OpenPanelForm(new Dashboard());
        }

       

        private void BtnOther_Click(object sender, EventArgs e)
        {
            OpenPanelForm(new Other());
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            OpenPanelForm(new Config());
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            
        }
    }
}
