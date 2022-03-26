using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewMotivationHR.DAL;
using NewMotivationHR.DAL.Model;

namespace NewMotivationHR.DB
{
    public class EmployeeData
    {    DAL<Employee> dal = new DAL<Employee>();
        public static int GetDataById(int id)
        {
           // GetData(id);
            return 0;
        }

        private void GetData(int id)
        {
           // var salary = model.Employees.Where(q => q.ID == id).FirstOrDefault().Salary;
        }
    }
}
