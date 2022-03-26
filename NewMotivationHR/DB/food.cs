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
    public class Food
    {
        public int ID { get; set; }

        [Display(Name = "اسم الموظف")]
        [ForeignKey("Employee")]
        public int Employee_id { get; set; }

        [Display(Name = "شهر الاحتساب")]
        public Month MonthOfAcount { get; set; }
        [Display(Name = "التغذية")]
        public int Food_ { get; set; }

        [Display(Name = "كسب عمل")]
        [ReadOnly(true)]
        public int EarningWork { get; set; } = 0;

        [Display(Name = "الصافي")]
        public int NetFood { get; set; } = 0;

        [Display(Name = "التاريخ")]
        public DateTime DateOfEnteriy { get; set; } = DateTime.Now;
      
        public Employee Employee { get; set; }
    }
}
