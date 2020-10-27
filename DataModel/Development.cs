using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine.DataModel
{
    public class Development
    {
        [Key]
        public int Id { get; set; }
        public DateTime DeploymentDate { get; set; }
        public int? PanelNo { get; set; }
        public double RollNo { get; set; }
        public int? Lenght { get; set; }
        public decimal? Width { get; set; }
        public string Thickness { get; set; }
        public decimal? Area { get; set; }
        public string Remarks { get; set; }
        public int ProjectDevId { get; set; }
        [ForeignKey("ProjectDevId")]
        public ProjectDev ProjectDev { get; set; }
    }
}
