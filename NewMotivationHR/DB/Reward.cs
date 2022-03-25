using NewMotivationHR.DB.Enume;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = NewMotivationHR.DB.Enume.Type;

namespace NewMotivationHR.DB
{
    public class Reward
    {
        public int ID { get; set; }

        [Display(Name = "اسم الموظف")]
        [ForeignKey("Employee")]
        public int Employee_id { get; set; }

        [Display(Name = "نوع المكافئة")]
        public Type Type { get; set; }

        [Display(Name = "المكافئة")]
        public int Reward_ { get; set; }

        [Display(Name = "كسب عمل")]
        [ReadOnly(true)]
        public int EarningWork
        {
            get
            {
                return (Reward_) * 15 / 100;
            }
        }
        [Display(Name = "الصافي")]
        public int NetReward
        {
            get
            {
                return (Reward_) -EarningWork;
            }
        }

        [Display(Name = "التاريخ")]
        public DateTime DateOfEnteriy { get; set; } = DateTime.Now;
      
        public Employee Employee { get; set; }
    }
}
