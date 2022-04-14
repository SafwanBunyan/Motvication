using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMotivationHR.DB
{
  public  class Employee
    {
        public Employee()
        {
            //this.TBSalaries = new List<EmployeeSalary>();
            //this.Transportations = new List<Transportation>();
            //this.Foods = new List<Food>();
            //this.Rewards = new List<Reward>();
        }

        public int ID { get; set; }
        [Display(Name = "الاسم")]
        public String Name { get; set; }

        [Display(Name = "الادارة او القسم")]
        public int? DepartmentId { get; set; }

        [Display(Name = "الادارة")]
        public Department department { get; set; }

        public string departmentName
        {
            get
            {
                return department != null ? department.Name : "لا يوجد";
            }
        }
        [Display(Name = "رقم الحساب")]
        public String Emp_ID { get; set; }
        [Display(Name = "الحافز")]
        public int Salary { get; set; }
        [Display(Name = "بدل مواصلات")]
        public int Transportation { get; set; }
        [Display(Name = " بدل تغذية")]
        public int Food_ { get; set; }


        public virtual List<EmployeeSalary> TBSalaries { get; set; }
        public virtual List<Transportation> Transportations { get; set; }
        public virtual List<Food> Foods { get; set; }
        public virtual List<Reward> Rewards { get; set; }
    }
}
