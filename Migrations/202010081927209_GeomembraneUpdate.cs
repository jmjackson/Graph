namespace Mine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GeomembraneUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GeoMembranes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeamingDate = c.DateTime(nullable: false),
                        SeamNo = c.String(),
                        SeamTime = c.DateTime(nullable: false),
                        WedgeTemp = c.Double(nullable: false),
                        WedgeSpeed = c.Double(nullable: false),
                        SeamLength = c.Double(nullable: false),
                        CarryOver = c.Double(nullable: false),
                        Destructive = c.String(),
                        RemarksDestructive = c.String(),
                        ProjectDevId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProjectDevs", t => t.ProjectDevId, cascadeDelete: true)
                .Index(t => t.ProjectDevId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GeoMembranes", "ProjectDevId", "dbo.ProjectDevs");
            DropIndex("dbo.GeoMembranes", new[] { "ProjectDevId" });
            DropTable("dbo.GeoMembranes");
        }
    }
}
