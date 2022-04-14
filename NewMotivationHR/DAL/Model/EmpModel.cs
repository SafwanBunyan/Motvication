namespace NewMotivationHR.DAL.Model
{
    using NewMotivationHR.DB;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EmpModel : DbContext
    {
        // Your context has been configured to use a 'EmpModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'NewMotivationHR.DAL.Model.EmpModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EmpModel' 
        // connection string in the application configuration file.
        public EmpModel()
            : base("name=EmpModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeSalary> EmployeeSalaries { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Transportation> Transportations { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Reward> Rewards { get; set; }
        public virtual DbSet<Department> Departments { get; set; }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}