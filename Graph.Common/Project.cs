using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Common
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Contractor { get; set; }
        public string Supplier { get; set; }
        public string Geosynthetic { get; set; }
        public string LeachPad { get; set; }
        public string Operator { get; set; }
        public string MachineNumber { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
