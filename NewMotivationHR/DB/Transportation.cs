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

        [Display(Name = "عدد ايام الغياب")]
        [DefaultValue(0)]
        public int AbsenceDays { get; set; } = 0;

        [Display(Name = "التاريخ")]
        public DateTime DateOfEnteriy { get; set; } = DateTime.Now;

        [Display(Name = "الاستقطاعات")]
        public int Discount
        {
            get
            {
                return EarningWork + Penalties;
            }
        }
       

        [Display(Name = "كسب عمل")]
        [ReadOnly(true)]
        public int EarningWork
        {
            get
            {
                return (Transportation_befor - Penalties) * 15 / 100;
            }
        }

        public Employee Employee { get; set; }

        [Display(Name = "اسم الموظف")]
        [ForeignKey("Employee")]
        public int Employee_id { get; set; }
        public int ID { get; set; }

        [Display(Name = "شهر الاحتساب")]
        public Month MonthOfAcount { get; set; }

        [Display(Name = "الصافي")]
        public int NetSalary
        {
            get
            {
                return Transportation_befor - Discount;
            }
        }
        [Display(Name = "الجزائات")]
        public int Penalties
        {
            get
            {
                return (Transportation_befor / 21) * AbsenceDays;
            }
        }
        [Display(Name = "بدل مواصلات")]
        public int Transportation_befor { get; set; }
    }
}
