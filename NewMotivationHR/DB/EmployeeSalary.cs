using NewMotivationHR.DB.Enume;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMotivationHR.DB
{
   public class EmployeeSalary
    {
        //public EmployeeSalary()
        //{
        //   // this.SalaryEvaluation = Convert.ToInt32(salary.SalaryEvaluationTextEdit.Text);

        //}
        public int ID { get; set; }
        [Display(Name = "المتابعة للمهام", GroupName = "التقييم")]
        [DefaultValue(20)]
        public int FollowTask { get; set; } = 20;
        [Display(Name = "المقدرة على التخطيط", GroupName = "التقييم")]
        [DefaultValue(20)]
        public int AbilityPlan { get; set; } = 20;
        [Display(Name = "دقة العمل", GroupName = "التقييم")]
        [DefaultValue(20)]
        public int WorkAccuracy { get; set; } = 20;
        [Display(Name = "مبادرة تحسين الاداء", GroupName = "التقييم")]
        [DefaultValue(20)]
        public int Performance { get; set; } = 20;
        [Display(Name = "عدد ايام الاجازة", GroupName = "التقييم")]
        [DefaultValue(0)]
        public int VacationDays { get; set; } = 0;
        [Display(Name = "عدد ايام الغياب", GroupName = "التقييم")]
        [DefaultValue(0)]
        public int AbsenceDays { get; set; } = 0;

        [Display(Name = "الضبط الاداري", GroupName = "التقييم")]
        [DefaultValue(20)]
        public int Administrative { get; set; } = 20;
        [Display(Name = "الاجمالي", GroupName = "التقييم"),]
        public int TotalRatio { get; set; } 
        [Display(Name = "الحافز بعد التقييم")]
        public int SalaryEvaluation { get; set; } = 0;
        [Display(Name = "كسب عمل")]
        [ReadOnly(true)]
        public int EarningWork { get; set; } = 0;
        [Display(Name = "تبرع")]
        public int Donate { get; set; } = 0;
        [Display(Name = "الاستقطاعات")]
        public int Discount { get; set; } = 0;
        [Display(Name = "الصافي")]
        public int NetSalary { get; set; } = 0;
        [Display(Name = "التاريخ")]
        public DateTime DateOfEnteriy { get; set; } = DateTime.Now; 
        [Display(Name = "اسم الموظف")]

        [ForeignKey("Employee")]
        public int Employee_id { get; set; }
        [Display(Name = "شهر الاحتساب")]
        public Month MonthOfAcount { get; set; }
        public Employee Employee { get; set; }
    }
}
