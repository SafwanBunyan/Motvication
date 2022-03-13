namespace NewMotivationHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_food_to_Model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Employee_id = c.Int(nullable: false),
                        MonthOfAcount = c.Int(nullable: false),
                        Food_ = c.Int(nullable: false),
                        EarningWork = c.Int(nullable: false),
                        NetFood = c.Int(nullable: false),
                        DateOfEnteriy = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.Employee_id, cascadeDelete: true)
                .Index(t => t.Employee_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "Employee_id", "dbo.Employees");
            DropIndex("dbo.Foods", new[] { "Employee_id" });
            DropTable("dbo.Foods");
        }
    }
}
