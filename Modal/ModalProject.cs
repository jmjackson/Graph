using Mine.DataContext;
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

namespace Mine.Modal
{
    public partial class ModalProject : MetroFramework.Forms.MetroForm
    {
        public  int Cb { get; set; }
        public ModalProject()
        {
            InitializeComponent();
        }

        private void ModalProject_Load(object sender, EventArgs e)
        {
            GraphDbContext db = new GraphDbContext();
            var cl = db.Clients.ToList();
            CbClients.ValueMember = "Id";
            CbClients.DisplayMember = "Name";
            CbClients.DataSource = cl;
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            Cb = Convert.ToInt32(CbClients.SelectedValue);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
