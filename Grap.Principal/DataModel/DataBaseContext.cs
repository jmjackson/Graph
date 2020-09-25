using Grap.Principal.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grap.Principal.DataModel
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext():base(new SQLiteConnection() { 
            ConnectionString=new SQLiteConnectionStringBuilder() {DataSource = "C:\\Database\\dbgraph.db",ForeignKeys=true }.
            ConnectionString},true)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Clients> Clients { get; set;  }

        public DbSet<Deployments> Deployments { get; set; }

    }
}
