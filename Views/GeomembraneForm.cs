﻿using Mine.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Mine.DataModel;

namespace Mine.Views
{
    public partial class GeomembraneForm : MetroFramework.Forms.MetroForm
    {
        readonly GraphDbContext db = new GraphDbContext();
        int pdId = 0;
        public GeomembraneForm(int dev)
        {
            InitializeComponent();
            pdId = dev;
        }

        private void GeomembraneForm_Load(object sender, EventArgs e)
        {
            var pdev = db.ProjectDevs.Include(a => a.Project.Client).Include(a => a.Project).Where(a => a.Id == pdId).FirstOrDefault();
            MetroClient.Text = pdev.Project.Client.Name;
            MetroProject.Text = pdev.Project.PName;
            MetroProjectNo.Text = pdev.Project.ProjectNo;
            MetroContractor.Text = pdev.Project.Contractor;
            MetroSupplier.Text = pdev.Project.Supplier;
            MetroGeosynthetic.Text = pdev.Project.GeoSynthetic;
            PbLogo.Image = Image.FromFile(pdev.Project.Client.Image);
            DateDev.Value = pdev.DevTime;

            DGVFill();
        }

        private void DGVFill()
        {
            var gms = db.GeoMembranes.ToList();
            if (gms.Count>0)
            {
                DGVGeo.AutoGenerateColumns = false;
                DGVGeo.Columns["Id"].DataPropertyName = "Id";
                DGVGeo.Columns["SeamingDate"].DataPropertyName = "SeamingDate";
                DGVGeo.Columns["SeamNo"].DataPropertyName = "SeamNo";
                DGVGeo.Columns["SeamTime"].DataPropertyName = "SeamTime";
                DGVGeo.Columns["WedgeTemp"].DataPropertyName = "WedgeTemp";
                DGVGeo.Columns["WedgeSpeed"].DataPropertyName = "WedgeSpeed";
                DGVGeo.Columns["SeamLength"].DataPropertyName = "SeamLength";
                DGVGeo.Columns["CarryOver"].DataPropertyName = "CarryOver";
                DGVGeo.Columns["Destructive"].DataPropertyName = "Destructive";
                DGVGeo.Columns["RemarksDestructive"].DataPropertyName = "RemarksDestructive";
                DGVGeo.DataSource = gms;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GeoMembrane gm = new GeoMembrane()
            {
                ProjectDevId=pdId,
                SeamingDate=Convert.ToDateTime(DateDev.Text),
                SeamNo=TxtSeamNo.Text,
                SeamTime=TxtSeamTime.Text,
                WedgeTemp=Convert.ToDouble(TxtTemp.Text),
                WedgeSpeed=Convert.ToDouble(TxtSpeed.Text),
                SeamLength=Convert.ToDouble(TxtSeamLength.Text),
                CarryOver=Convert.ToDouble(TxtCarryOver.Text),
                Destructive=TxtDestructive.Text,
                RemarksDestructive=TxtRemarks.Text
            };

            db.GeoMembranes.Add(gm);
            db.SaveChanges();
            GeomembraneForm_Load(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int gId = Convert.ToInt32(DGVGeo.CurrentRow.Cells[0].Value);
            var geo = db.GeoMembranes.Find(gId);
            TxtGeoId.Text= geo.Id.ToString();
            TxtSeamNo.Text = geo.SeamNo.ToString();
            TxtSeamTime.Text = geo.SeamTime;
            TxtTemp.Text = geo.WedgeTemp.ToString();
            TxtSpeed.Text = geo.WedgeSpeed.ToString();
            TxtSeamLength.Text = geo.SeamLength.ToString();
            TxtCarryOver.Text = geo.CarryOver.ToString();
            TxtDestructive.Text = geo.Destructive;
            TxtRemarks.Text = geo.RemarksDestructive; 

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int pdId = Convert.ToInt32(DGVGeo.CurrentRow.Cells[0].Value);
            var geo=db.GeoMembranes.Find(pdId);
            db.GeoMembranes.Remove(geo);
            db.SaveChanges();
            GeomembraneForm_Load(sender,e);



        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var id=Convert.ToInt32(TxtGeoId.Text);
            var geo = db.GeoMembranes.Find(id);
            geo.Destructive = TxtDestructive.Text;
            geo.RemarksDestructive = TxtRemarks.Text;
            geo.SeamLength = Convert.ToDouble(TxtSeamLength.Text);
            geo.SeamNo = TxtSeamNo.Text;
            geo.SeamTime = TxtSeamTime.Text;
            geo.WedgeSpeed = Convert.ToDouble(TxtSpeed.Text);
            geo.WedgeTemp = Convert.ToDouble(TxtTemp.Text);
            db.SaveChanges();
            GeomembraneForm_Load(sender, e) ;
        }
    }
}