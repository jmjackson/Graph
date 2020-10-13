namespace Mine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyReport : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Developments", "Lenght", c => c.Int(nullable: false));
            AlterColumn("dbo.GeoMembranes", "WedgeTemp", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GeoMembranes", "WedgeTemp", c => c.Double(nullable: false));
            AlterColumn("dbo.Developments", "Lenght", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
