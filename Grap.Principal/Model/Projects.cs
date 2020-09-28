using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grap.Principal.Model
{
    [Table(Name = "Projects")]
    public class Projects
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int Id { get; set; }

        [Column(Name = "ProjectName", DbType = "VARCHAR")]
        public string ProjectName { get; set; }

        [Column(Name = "ProjectNo", DbType = "VARCHAR")]
        public string ProjectNo { get; set; }

        [Column(Name = "Contractor", DbType = "VARCHAR")]
        public string Contractor { get; set; }

        [Column(Name = "Supplier", DbType = "VARCHAR")]
        public string Supplier { get; set; }

        [Column(Name = "Geosynthetic", DbType = "VARCHAR")]
        public string Geosynthetic { get; set; }

        [Column(Name = "LeachPad", DbType = "VARCHAR")]
        public string LeachPad { get; set; }

        [Column(Name = "Operator", DbType = "TEXT")]
        public string Operator { get; set; }

        [Column(Name = "MachineNo", DbType = "TEXT")]
        public string MachineNo { get; set; }

        [Column(Name = "ClientId", DbType = "INTEGER")]
        public int ClientId { get; set; }
  
        public Clients Client { get; set; }
    }
}
