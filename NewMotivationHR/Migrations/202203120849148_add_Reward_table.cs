namespace NewMotivationHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Reward_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rewards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Employee_id = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Reward_ = c.Int(nullable: false),
                        EarningWork = c.Int(nullable: false),
                        NetReward = c.Int(nullable: false),
                        DateOfEnteriy = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.Employee_id, cascadeDelete: true)
                .Index(t => t.Employee_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rewards", "Employee_id", "dbo.Employees");
            DropIndex("dbo.Rewards", new[] { "Employee_id" });
            DropTable("dbo.Rewards");
        }
    }
}
