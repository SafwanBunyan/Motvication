using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ReportServer.ServiceModel.DataContracts;
using NewMotivationHR.DB.Enume;

namespace NewMotivationHR.DB
{
    public class EmployeesDTO 
    {
        public int ID { get; set; }
        [Display(Name = "الاسم")]
        public String Name { get; set; }

        public String section { get; set; }

        public String Emp_ID { get; set; }

        public String DateOfEnteriy { get; set; }

        public String MonthOfAcount { get; set; }

        public int Salary { get; set; }
        public double TBSalaries { get; set; }
        public double Transportations { get; set; }
        public double Foods { get; set; }
        public double Rewards { get; set; }
}
}
