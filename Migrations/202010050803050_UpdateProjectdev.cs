namespace Mine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProjectdev : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectDevs", "DevTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectDevs", "DevTime");
        }
    }
}
