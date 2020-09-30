using Grap.Principal.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grap.Principal.Views.Modal
{
    public partial class ModalDeployments : Form
    {
        readonly DataBaseContext db = new DataBaseContext();
        //arreglo global de elementos
        int[] ids;
        public ModalDeployments()
        {
            InitializeComponent();
        }

        private void ModalDeployments_Load(object sender, EventArgs e)
        {
            //dummy data
            var lc = db.Clients.ToList();
            ids = new int[lc.Count];
            int contador = 0;
            foreach (var lcbox in lc)
            {
                ids[contador] = int.Parse(lcbox.Id.ToString());
                contador++;
                CbCliente.Items.Add(lcbox.Name);
            }
        }
        public void MostrarCombobox(string cmd, ComboBox cbx)
        {
            var lc = db.Clients.ToList();

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

        }

        private void CbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Resetar combobox
            CbProyecto.Items.Clear();
            //dummy data
            int id = ids[CbCliente.SelectedIndex];
            var lp = db.Projects.Where(s=> s.ClientId==id).ToList();
            foreach (var lpbox in lp)
            {
                CbProyecto.Items.Add(lpbox.ProjectName);
            }
        }
    }
}
