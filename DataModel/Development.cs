using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine.DataModel
{
    public class Development
    {
        [Key]
        public int Id { get; set; }
        public int MyProperty { get; set; }
    }
}
