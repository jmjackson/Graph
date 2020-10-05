namespace Mine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OpAndDevelop : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Developments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeploymentDate = c.DateTime(nullable: false),
                        PanelNo = c.Int(nullable: false),
                        RollNo = c.Double(nullable: false),
                        Lenght = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Thickness = c.String(),
                        Area = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remarks = c.String(),
                        ProjectDevId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProjectDevs", t => t.ProjectDevId, cascadeDelete: true)
                .Index(t => t.ProjectDevId);
            
            CreateTable(
                "dbo.ProjectDevs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Inspector = c.String(),
                        Location = c.String(),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Developments", "ProjectDevId", "dbo.ProjectDevs");
            DropForeignKey("dbo.ProjectDevs", "ProjectId", "dbo.Projects");
            DropIndex("dbo.ProjectDevs", new[] { "ProjectId" });
            DropIndex("dbo.Developments", new[] { "ProjectDevId" });
            DropTable("dbo.ProjectDevs");
            DropTable("dbo.Developments");
        }
    }
}
