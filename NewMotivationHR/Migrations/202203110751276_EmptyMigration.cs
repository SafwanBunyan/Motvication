namespace NewMotivationHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transportations", "Transportation_befor", c => c.Int(nullable: false));
            AddColumn("dbo.Transportations", "Penalties", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transportations", "Penalties");
            DropColumn("dbo.Transportations", "Transportation_befor");
        }
    }
}
