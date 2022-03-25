namespace NewMotivationHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update3colum : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Transportations", "EarningWork");
            DropColumn("dbo.Transportations", "Penalties");
            DropColumn("dbo.Transportations", "Discount");
            DropColumn("dbo.Transportations", "NetSalary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transportations", "NetSalary", c => c.Int(nullable: false));
            AddColumn("dbo.Transportations", "Discount", c => c.Int(nullable: false));
            AddColumn("dbo.Transportations", "Penalties", c => c.Int(nullable: false));
            AddColumn("dbo.Transportations", "EarningWork", c => c.Int(nullable: false));
        }
    }
}
