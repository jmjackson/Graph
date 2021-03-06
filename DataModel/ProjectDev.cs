﻿using System;
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
        public string InspectorDev { get; set; }
        public DateTime DevTime { get; set; }
        public string LocationDev { get; set; }
        public string Operator { get; set; }
        public string MachineNo { get; set; }
        public string ImageMap { get; set; }
        public byte[] ImageDev { get; set; }
        public string InspectorGeo { get; set; }
        public string LocationGeo { get; set; }
        public int ProjectId { get; set; }        
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }

    }
}
