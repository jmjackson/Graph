using Mine.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnAccess_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text=="admin" && TxtPassword.Text=="123")
            {
                Principal p = new Principal();
                p.Show();
                this.Hide();
            }
            else
            {
                LblError.Text= "User and Password  incorrect";
            }
        }
    }
}
