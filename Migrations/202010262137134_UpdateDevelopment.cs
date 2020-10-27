namespace Mine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDevelopment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Developments", "PanelNo", c => c.Int());
            AlterColumn("dbo.Developments", "Lenght", c => c.Int());
            AlterColumn("dbo.Developments", "Width", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Developments", "Area", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Developments", "Area", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Developments", "Width", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Developments", "Lenght", c => c.Int(nullable: false));
            AlterColumn("dbo.Developments", "PanelNo", c => c.Int(nullable: false));
        }
    }
}
