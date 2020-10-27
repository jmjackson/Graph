namespace Mine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDevMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectDevs", "InspectorDev", c => c.String());
            AddColumn("dbo.ProjectDevs", "LocationDev", c => c.String());
            AddColumn("dbo.ProjectDevs", "ImageMap", c => c.String());
            AddColumn("dbo.ProjectDevs", "ImageDev", c => c.Binary());
            AddColumn("dbo.ProjectDevs", "InspectorGeo", c => c.String());
            AddColumn("dbo.ProjectDevs", "LocationGeo", c => c.String());
            DropColumn("dbo.ProjectDevs", "Inspector");
            DropColumn("dbo.ProjectDevs", "Location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProjectDevs", "Location", c => c.String());
            AddColumn("dbo.ProjectDevs", "Inspector", c => c.String());
            DropColumn("dbo.ProjectDevs", "LocationGeo");
            DropColumn("dbo.ProjectDevs", "InspectorGeo");
            DropColumn("dbo.ProjectDevs", "ImageDev");
            DropColumn("dbo.ProjectDevs", "ImageMap");
            DropColumn("dbo.ProjectDevs", "LocationDev");
            DropColumn("dbo.ProjectDevs", "InspectorDev");
        }
    }
}
