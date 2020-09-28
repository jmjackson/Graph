using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grap.Principal.ViewModels
{
    public class ProjectViewModel
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }

        public string ProjectNo { get; set; }

        public string Contractor { get; set; }

        public string Supplier { get; set; }

        public string Geosynthetic { get; set; }

        public string LeachPad { get; set; }

        public string Operator { get; set; }

        public string MachineNo { get; set; }

        public int ClientId { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
