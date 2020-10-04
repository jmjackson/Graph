using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine.DataModel
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string PName { get; set; }
        public string ProjectNo { get; set; }
        public string Contractor { get; set; }
        public string Supplier { get; set; }
        public string GeoSynthetic { get; set; }
        public int ClientId { get; set; }
        
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
    }
}
