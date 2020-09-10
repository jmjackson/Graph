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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnprod_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            //PBSlider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            //PBSlider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            AbrirFormEnPanel(new Cliente());

        }
    }
}
