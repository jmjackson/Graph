using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine.DataModel
{
   public class ProjectDev
    {
        [Key]
        public int Id { get; set; }
        public string Inspector { get; set; }
        public DateTime DevTime { get; set; }
        public string Location { get; set; }
        public int ProjectId { get; set; }        
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }

    }
}
