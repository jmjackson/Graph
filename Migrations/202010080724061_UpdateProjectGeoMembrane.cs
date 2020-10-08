namespace Mine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProjectGeoMembrane : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectDevs", "Operator", c => c.String());
            AddColumn("dbo.ProjectDevs", "MachineNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectDevs", "MachineNo");
            DropColumn("dbo.ProjectDevs", "Operator");
        }
    }
}
