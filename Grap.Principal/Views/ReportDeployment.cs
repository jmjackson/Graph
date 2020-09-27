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

namespace Grap.Principal
{
    public partial class ReportDeployment : Form
    {
        readonly DataBaseContext dbase = new DataBaseContext();

        public ReportDeployment()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_Searcher_Click(object sender, EventArgs e)
        {

        }

       

        private void ReportDeployment_Load(object sender, EventArgs e)
        {
            //DGV data
            var Dp = dbase.Deployments.ToList();

            DGVDeployment.AutoGenerateColumns = false;

            DGVDeployment.Columns["DeploymentDate"].DataPropertyName = "DeploymentDate";
            DGVDeployment.Columns["PanelNo"].DataPropertyName = "PanelNo";
            DGVDeployment.Columns["RollNo"].DataPropertyName = "RollNo";
            DGVDeployment.Columns["Lenght"].DataPropertyName = "PanelLenght";
            DGVDeployment.Columns["Width"].DataPropertyName = "Width";
            DGVDeployment.Columns["Thickness"].DataPropertyName = "Thickness";
            DGVDeployment.Columns["Area"].DataPropertyName = "Area";
            DGVDeployment.Columns["Remarks"].DataPropertyName = "Remarks";

            DGVDeployment.DataSource = Dp;
        }

        private void DGVDeployment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
