using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Common
{
    public class Deployments
    {
        public int Id { get; set; }
        public DateTime DeploymentDate { get; set; }
        public string PanelNumber { get; set; }
        public string RollNo { get; set; }
        public double PanelLength { get; set; }
        public double Width { get; set; }
        public string Thikness { get; set; }
        public double Area { get; set; }
        public string Remarks { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }

    }
}
