using Grap.Principal.Views.Modal;
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
            ListaClientes lc = new ListaClientes();
            lc.Show();
            this.Hide();
        }

        

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
       
       

        private void BtnOther_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            
        }

       

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterParent;
            }
            
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
             
        }

        private void BtnDeploy_Click(object sender, EventArgs e)
        {
            ModalDeployments md = new ModalDeployments();
            md.ShowDialog();
        }
    }
}
