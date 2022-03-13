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
    public class Transportation
    {
        public int ID { get; set; }

        [Display(Name = "اسم الموظف")]
        [ForeignKey("Employee")]
        public int Employee_id { get; set; }

        [Display(Name = "شهر الاحتساب")]
        public Month MonthOfAcount { get; set; }
        [Display(Name = "بدل مواصلات")]
        public int Transportation_befor { get; set; }

        [Display(Name = "كسب عمل")]
        [ReadOnly(true)]
        public int EarningWork { get; set; } = 0;

        [Display(Name = "عدد ايام الغياب")]
        [DefaultValue(0)]
        public int AbsenceDays { get; set; } = 0;
        [Display(Name = "الجزائات")]
        public int Penalties { get; set; } = 0;

        [Display(Name = "الاستقطاعات")]
        public int Discount { get; set; } = 0;

        [Display(Name = "الصافي")]
        public int NetSalary { get; set; } = 0;

        [Display(Name = "التاريخ")]
        public DateTime DateOfEnteriy { get; set; } = DateTime.Now;
      
        public Employee Employee { get; set; }
    }
}
