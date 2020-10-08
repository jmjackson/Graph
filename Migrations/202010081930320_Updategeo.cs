namespace Mine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updategeo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GeoMembranes", "SeamTime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GeoMembranes", "SeamTime", c => c.DateTime(nullable: false));
        }
    }
}
