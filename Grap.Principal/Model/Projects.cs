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
    [Table(Name = "Projects")]
    public class Projects
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int Id { get; set; }
        [Column(Name = "Name", DbType = "TEXT")]
        public string Name { get; set; }
        [Column(Name = "Number", DbType = "TEXT")]
        public string Number { get; set; }
        [Column(Name = "Contractor", DbType = "TEXT")]
        public string Contractor { get; set; }
        [Column(Name = "Supplier", DbType = "TEXT")]
        public string Supplier { get; set; }
        [Column(Name = "Geosynthetic", DbType = "TEXT")]
        public string Geosynthetic { get; set; }
        [Column(Name = "LeachPad", DbType = "TEXT")]
        public string LeachPad { get; set; }
        [Column(Name = "Operator", DbType = "TEXT")]
        public string Operator { get; set; }
        [Column(Name = "MachineNumber", DbType = "TEXT")]
        public string MachineNumber { get; set; }
        [Column(Name = "ClientId", DbType = "TEXT")]
        public int ClientId { get; set; }
        public Clients Client { get; set; }
    }
}
