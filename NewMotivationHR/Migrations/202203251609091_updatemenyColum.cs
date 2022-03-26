namespace NewMotivationHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemenyColum : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Foods", "EarningWork");
            DropColumn("dbo.Foods", "NetFood");
            DropColumn("dbo.Rewards", "EarningWork");
            DropColumn("dbo.Rewards", "NetReward");
            DropColumn("dbo.EmployeeSalaries", "Administrative");
            DropColumn("dbo.EmployeeSalaries", "TotalRatio");
            DropColumn("dbo.EmployeeSalaries", "SalaryEvaluation");
            DropColumn("dbo.EmployeeSalaries", "EarningWork");
            DropColumn("dbo.EmployeeSalaries", "Discount");
            DropColumn("dbo.EmployeeSalaries", "NetSalary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeSalaries", "NetSalary", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeSalaries", "Discount", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeSalaries", "EarningWork", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeSalaries", "SalaryEvaluation", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeSalaries", "TotalRatio", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeSalaries", "Administrative", c => c.Int(nullable: false));
            AddColumn("dbo.Rewards", "NetReward", c => c.Int(nullable: false));
            AddColumn("dbo.Rewards", "EarningWork", c => c.Int(nullable: false));
            AddColumn("dbo.Foods", "NetFood", c => c.Int(nullable: false));
            AddColumn("dbo.Foods", "EarningWork", c => c.Int(nullable: false));
        }
    }
}
