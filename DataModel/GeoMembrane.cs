using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine.DataModel
{
    public class GeoMembrane
    {
        [Key]
        public int Id { get; set; }
        public DateTime SeamingDate { get; set; }
        public string SeamNo { get; set; }
        public string SeamTime { get; set; }
        public double WedgeTemp { get; set; }
        public double WedgeSpeed { get; set; }
        public double SeamLength { get; set; }
        public double CarryOver { get; set; }
        public string Destructive { get; set; }
        public string RemarksDestructive { get; set; }
        public int ProjectDevId { get; set; }
        [ForeignKey("ProjectDevId")]
        public ProjectDev  ProjectDev { get; set; }
    }
}
