using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grap.Principal.Model
{
    [Table(Name = "Deployments")]
    public class Deployments
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int Id { get; set; }
        
        [Column(Name = "DeploymentDate", DbType = "TEXT")]
        public string DeploymentDate { get; set; }
        
        [Column(Name = "PanelNo", DbType = "TEXT")]
        public string PanelNo { get; set; }

        [Column(Name = "RollNo", DbType = "TEXT")]
        public string RollNo { get; set; }

        [Column(Name = "PanelLength", DbType = "NUMERIC")]
        public double PanelLenght { get; set; }

        [Column(Name = "Width", DbType = "NUMERIC")]
        public double Width { get; set; }

        [Column(Name = "Thickness", DbType = "TEXT")]
        public string Thickness { get; set; }

        [Column(Name = "Area", DbType = "NUMERIC")]
        public double Area { get; set; }

        [Column(Name = "Remarks", DbType = "TEXT")]
        public string Remarks { get; set; }
    }
}
