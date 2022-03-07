using NewMotivationHR.PL.SalaryForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewMotivationHR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.EmployeeForms.EmployeeManeg employee = new PL.EmployeeForms.EmployeeManeg();
            employee.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SalaryManag salary = new SalaryManag();
            salary.ShowDialog();
        }
    }
}
