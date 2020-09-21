using Grap.Principal.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grap.Principal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ValidationLogin()
        {
            Home h = new Home();
            if (TxtUser.Text == "admin" && TxtPassword.Text == "123")
            {
                h.Show();
                this.Hide();
            }
            else
            {
                LblError.Text = "Contraseña o Password Incorrecto";
            }
        }

       

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            ValidationLogin();
        }

        private void BtnSignIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidationLogin();
            }
        }
    }
}
