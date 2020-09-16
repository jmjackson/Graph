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
    [Table(Name = "Clients")]
    public class Clients
    {
        [Column(Name = "Id", IsDbGenerated = true,IsPrimaryKey=true,DbType="INTEGER")]
        [Key]
        public int Id { get; set; }
        [Column(Name="Code",DbType ="TEXT")]
        public string Code { get; set; }
        [Column(Name ="Name",DbType ="TEXT")]
        public string Name { get; set; }
        [Column(Name="Image",DbType ="TEXT")]
        public string Image { get; set; }
    }
}
