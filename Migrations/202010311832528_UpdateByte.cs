namespace Mine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateByte : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "ImgCl", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "ImgCl");
        }
    }
}
