using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMotivationHR.DB
{
  public class User
    {

        public int ID { get; set; }

        [Display(Name = " الاسم الكامل")]
        public string Name { get; set; }

        [Display(Name = " اسم المستخدم")]
        public string UserName { get; set; }

        //[Display(Name = "العنوان")]
        //public string Address { get; set; }

        [Display(Name = "الايميل")]
        public string Email { get; set; }

        [Display(Name = "كلمة المرور")]
        public string PassWord { get; set; }

        //[Display(Name = "نوع المستخدم "), DefaultValue(2)]
        //public UserType type { get; set; }

        [Display(Name = "تاريخ الاظافة")]
        public DateTime CreatingDate { get; set; } = DateTime.Now;
    }
}
