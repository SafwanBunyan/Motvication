namespace NewMotivationHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_employeeSalary_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeSalaries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FollowTask = c.Int(nullable: false),
                        AbilityPlan = c.Int(nullable: false),
                        WorkAccuracy = c.Int(nullable: false),
                        Performance = c.Int(nullable: false),
                        VacationDays = c.Int(nullable: false),
                        AbsenceDays = c.Int(nullable: false),
                        Administrative = c.Int(nullable: false),
                        TotalRatio = c.Int(nullable: false),
                        SalaryEvaluation = c.Int(nullable: false),
                        EarningWork = c.Int(nullable: false),
                        Donate = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        NetSalary = c.Int(nullable: false),
                        DateOfEnteriy = c.DateTime(nullable: false),
                        Employee_id = c.Int(nullable: false),
                        MonthOfAcount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.Employee_id, cascadeDelete: true)
                .Index(t => t.Employee_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeSalaries", "Employee_id", "dbo.Employees");
            DropIndex("dbo.EmployeeSalaries", new[] { "Employee_id" });
            DropTable("dbo.EmployeeSalaries");
        }
    }
}
