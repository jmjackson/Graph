using Mine.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine.DataContext
{
    public class GraphDbContext:DbContext
    {
        public GraphDbContext():base("name=con")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectDev> ProjectDevs { get; set; }
        public DbSet<Development> Developments { get; set; }
        public DbSet<GeoMembrane> GeoMembranes { get; set; }
    }
}
