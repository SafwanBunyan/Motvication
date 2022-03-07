using DevExpress.XtraReports.UI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NewMotivationHR.DAL;
using NewMotivationHR.DAL.Model;
using NewMotivationHR.DB;
using NewMotivationHR.DB.Enume;
using NewMotivationHR.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewMotivationHR.PL.SalaryForms
{
    public partial class frmMonth : Form
    {

       
        private List<Employee> GetEmployees()
        {
            DAL<Employee> dal = new DAL<Employee>();
            return dal.ListData();

        }
        public frmMonth()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (btn_Save.Text == "حفظ")
            {
                DAL<Employee> dal = new DAL<Employee>();
                DAL<EmployeeSalary> dal2 = new DAL<EmployeeSalary>();
                SalaryManag sal = new SalaryManag();

                try
                {
                    var employeesList = GetEmployees();
                    var Salarylist = new List<EmployeeSalary>();
                    EmpModel model = new EmpModel();
                    Month month = (Month)Enum.Parse(typeof(Month), MonthOfAcountImageComboBoxEdit.Text);

                    foreach (var item in employeesList)
                    {
                        Salarylist.Add(new EmployeeSalary
                        {
                            Employee_id = item.ID,
                            SalaryEvaluation = item.Salary,
                            EarningWork = item.Salary * 15 / 100,
                            TotalRatio = 100,
                            Donate = 0,
                            Discount = item.Salary * 15 / 100,
                            NetSalary = item.Salary * 85 / 100,
                            FollowTask = 20,
                            AbilityPlan = 20,
                            Performance = 20,
                            WorkAccuracy = 20,
                            VacationDays = 0,
                            AbsenceDays = 0,
                            Administrative = 20,
                            MonthOfAcount = month
                            // Month = Convert.ToDateTime(dateEdit1.Text)
                        }); ;
                        item.TBSalaries = Salarylist;
                    }

                    foreach (var iteme in Salarylist)
                    {
                        try
                        {
                            model.EmployeeSalaries.AddOrUpdate(iteme);
                            model.SaveChanges();
                            sal.getdata();
                            sal.gridControl1.DataSource = dal2.ListData();

                        }
                        catch (Exception exception)
                        {
                            ProjectData.SetProjectError(exception);
                            Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                            ProjectData.ClearProjectError();
                        }
                        sal.gridControl1.DataSource = dal2.ListData();
                        sal.getdata();
                        this.Close();
                    }
                  


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else if (btn_Save.Text == "طباعة")
            {
                frmMonth fm = new frmMonth();
                EmpModel model = new EmpModel();
                var month = MonthOfAcountImageComboBoxEdit.Text;
                var repData = model.EmployeeSalaries.Where(x => x.MonthOfAcount.ToString() == month && x.DateOfEnteriy.Year.ToString() == txt_year.Text).Include("Employee").ToList();
                if (repData != null)
                {
                    
                    Motivation_Report2 motivation_Report = new Motivation_Report2();
                  //  Bank_Report motivation_Report = new Bank_Report();
                    motivation_Report.DataSource = repData.ToList();
                    motivation_Report.ShowPreviewDialog();
                }
            }
        }

        private void btn_bank_print_Click(object sender, EventArgs e)
        {
            frmMonth fm = new frmMonth();
            EmpModel model = new EmpModel();
            var month = MonthOfAcountImageComboBoxEdit.Text;
            var repData = model.EmployeeSalaries.Where(x => x.MonthOfAcount.ToString() == month&&x.DateOfEnteriy.Year.ToString()==txt_year.Text).Include("Employee").ToList();
            if (repData != null)
            {

                // Motivation_Report2 motivation_Report = new Motivation_Report2();
                Motivation_Report_Bank motivation_Report = new Motivation_Report_Bank();
                motivation_Report.DataSource = repData.ToList();
                motivation_Report.ShowPreviewDialog();
            }
        }
    }
}
