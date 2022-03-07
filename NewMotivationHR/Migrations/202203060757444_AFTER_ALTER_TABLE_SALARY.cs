﻿namespace NewMotivationHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AFTER_ALTER_TABLE_SALARY : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeSalaries", "FollowTask", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeSalaries", "AbilityPlan", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeSalaries", "WorkAccuracy", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeSalaries", "Performance", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeSalaries", "Administrative", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeSalaries", "Administrative", c => c.Int());
            AlterColumn("dbo.EmployeeSalaries", "Performance", c => c.Int());
            AlterColumn("dbo.EmployeeSalaries", "WorkAccuracy", c => c.Int());
            AlterColumn("dbo.EmployeeSalaries", "AbilityPlan", c => c.Int());
            AlterColumn("dbo.EmployeeSalaries", "FollowTask", c => c.Int());
        }
    }
}
