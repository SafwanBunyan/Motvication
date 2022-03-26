namespace NewMotivationHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "EarningWork", c => c.Int(nullable: false));
            AddColumn("dbo.Foods", "NetFood", c => c.Int(nullable: false));
            AddColumn("dbo.Rewards", "EarningWork", c => c.Int(nullable: false));
            AddColumn("dbo.Rewards", "NetReward", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeSalaries", "Administrative", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeSalaries", "TotalRatio", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeSalaries", "SalaryEvaluation", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeSalaries", "EarningWork", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeSalaries", "Discount", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeSalaries", "NetSalary", c => c.Int(nullable: false));
            AddColumn("dbo.Transportations", "EarningWork", c => c.Int(nullable: false));
            AddColumn("dbo.Transportations", "Penalties", c => c.Int(nullable: false));
            AddColumn("dbo.Transportations", "Discount", c => c.Int(nullable: false));
            AddColumn("dbo.Transportations", "NetSalary", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transportations", "NetSalary");
            DropColumn("dbo.Transportations", "Discount");
            DropColumn("dbo.Transportations", "Penalties");
            DropColumn("dbo.Transportations", "EarningWork");
            DropColumn("dbo.EmployeeSalaries", "NetSalary");
            DropColumn("dbo.EmployeeSalaries", "Discount");
            DropColumn("dbo.EmployeeSalaries", "EarningWork");
            DropColumn("dbo.EmployeeSalaries", "SalaryEvaluation");
            DropColumn("dbo.EmployeeSalaries", "TotalRatio");
            DropColumn("dbo.EmployeeSalaries", "Administrative");
            DropColumn("dbo.Rewards", "NetReward");
            DropColumn("dbo.Rewards", "EarningWork");
            DropColumn("dbo.Foods", "NetFood");
            DropColumn("dbo.Foods", "EarningWork");
        }
    }
}
