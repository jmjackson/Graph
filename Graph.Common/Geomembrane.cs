using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Common
{
    public class Geomembrane
    {
        public int Id { get; set; }
        public DateTime SeamingDate { get; set; }
        public int SeamNo { get; set; }
        public DateTime SeamTime { get; set; }
        public string WedgeTemp { get; set; }
        public string WedgeSpeed { get; set; }
        public double SeamLenght { get; set; }
        public double CarryOver { get; set; }
        public string Destructive { get; set; }
        public string RemarksDestructive { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }

    }
}
