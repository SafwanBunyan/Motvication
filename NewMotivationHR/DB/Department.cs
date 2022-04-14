using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMotivationHR.DB
{
    public class Department
    {
        public int ID { get; set; }
        [Display(Name = "اسم الادارة")]
        public String Name { get; set; }

        [Display(Name = "الادارة العليا")]
        public int ParentId { get; set; }

        [Display(Name = "رئيسي ")]
        public bool IsMain { get; set; } 
        
        [Display(Name = "الوصف ")]
        public String Description { get; set; }
 
    }
}
