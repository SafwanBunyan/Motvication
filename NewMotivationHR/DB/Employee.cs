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
           // this.TBSalaries = new List<TBSalary>();
        }

        public int ID { get; set; }
        [Display(Name = "الاسم")]
        public String Name { get; set; }
        [Display(Name = "رقم الحساب")]
        public String Emp_ID { get; set; }
        [Display(Name = "الراتب")]
        public int Salary { get; set; }
       public virtual List<EmployeeSalary> TBSalaries { get; set; }
    }
}
