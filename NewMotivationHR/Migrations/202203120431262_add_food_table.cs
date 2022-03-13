namespace NewMotivationHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_food_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Food_", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Food_");
        }
    }
}
