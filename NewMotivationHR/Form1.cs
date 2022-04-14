using NewMotivationHR.PL.Department;
using NewMotivationHR.PL.food;
using NewMotivationHR.PL.Rewards;
using NewMotivationHR.PL.SalaryForms;
using NewMotivationHR.PL.Transportation;
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmTransportation salary = new frmTransportation();
            salary.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmfood frmfood = new frmfood();
            frmfood.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmReward frm = new frmReward();
            frm.ShowDialog();
        }

        private void btn_BankReport_Click(object sender, EventArgs e)
        {
            frmMonth fm = new frmMonth();
            fm.btn_Save.Text = "طباعة";
            fm.txt_year.Visible = true;
            fm.btn_bank_print.Visible = true;
            fm.ShowDialog();
        }

        private void btn_trasportReport_Click(object sender, EventArgs e)
        {
            frmMonth fm = new frmMonth();
            fm.btn_Save.Text = "طباعة2";
            fm.txt_year.Visible = true;
            fm.btn_bank_print.Visible = true;
            fm.ShowDialog();
        }

        private void btn_MotivationReport_Click(object sender, EventArgs e)
        {
            frmMonth fm = new frmMonth();
            fm.btn_Save.Text = "طباعة1";
            fm.txt_year.Visible = true;
            fm.btn_bank_print.Visible = true;
            fm.ShowDialog();
        }

        private void btn_FoodReport_Click(object sender, EventArgs e)
        {
            frmMonth fm = new frmMonth();
            fm.btn_Save.Text = "طباعة3";
            fm.txt_year.Visible = true;
            fm.btn_bank_print.Visible = true;
            fm.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
           DepartmentForm department = new DepartmentForm();
            department.ShowDialog();
        }
    }
}
