using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NewMotivationHR.DAL;
using NewMotivationHR.DAL.Model;
using NewMotivationHR.DB;
using NewMotivationHR.DB.Enume;
using NewMotivationHR.PL.food;
using NewMotivationHR.PL.Transportation;
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
using NewMotivationHR.Report;

namespace NewMotivationHR.PL.SalaryForms
{
    public partial class frmMonth : Form
    {
        EmpModel model;

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
            if (txt_year.Text != "")
            {
                if (Convert.ToInt32(txt_year.Text) >= 2021)
                {
                    if (btn_Save.Text == "حفظ")
                    {
                        // var repData = model.EmployeeSalaries.Where(x => x.MonthOfAcount.ToString() == MonthOfAcountImageComboBoxEdit.Text && x.DateOfEnteriy.Year.ToString() == txt_year.Text).Include("Employee").ToList();
                        //  if(repData!=null)
                        //{
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

                            sal.getdata();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                        sal.getdata();
                    }
                    else if (btn_Save.Text == "حفظ الكشف")
                    {
                        DAL<Employee> dal = new DAL<Employee>();
                        DAL<DB.Transportation> dal2 = new DAL<DB.Transportation>();
                        frmTransportation transportation = new frmTransportation();

                        try
                        {
                            var employeesList = GetEmployees();
                            var TransList = new List<DB.Transportation>();
                            EmpModel model = new EmpModel();
                            Month month = (Month)Enum.Parse(typeof(Month), MonthOfAcountImageComboBoxEdit.Text);

                            foreach (var item in employeesList)
                            {
                                TransList.Add(new DB.Transportation
                                {
                                    Employee_id = item.ID,
                                    Transportation_befor = item.Transportation,
                                    EarningWork = item.Transportation * 15 / 100,
                                    Discount = item.Transportation * 15 / 100,
                                    NetSalary = item.Transportation * 85 / 100,
                                    AbsenceDays = 0,
                                    MonthOfAcount = month
                                    // Month = Convert.ToDateTime(dateEdit1.Text)
                                }); ;
                                item.Transportations = TransList;
                            }

                            foreach (var iteme in TransList)
                            {
                                try
                                {
                                    model.Transportations.Add(iteme);
                                    model.SaveChanges();
                                    transportation.getdata();
                                    transportation.gridControl1.DataSource = dal2.ListData();

                                }
                                catch (Exception exception)
                                {
                                    ProjectData.SetProjectError(exception);
                                    Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                                    ProjectData.ClearProjectError();
                                }
                                transportation.gridControl1.DataSource = dal2.ListData();
                                transportation.getdata();
                                this.Close();
                            }

                            transportation.getdata();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                        transportation.getdata();
                    }
                    else if (btn_Save.Text == "حفظ كشف التغذيه")
                    {
                        DAL<Employee> dal = new DAL<Employee>();
                        DAL<Food> food = new DAL<Food>();
                        frmfood frmfood = new frmfood();

                        try
                        {
                            var employeesList = GetEmployees();
                            var foodList = new List<Food>();
                            EmpModel model = new EmpModel();
                            Month month = (Month)Enum.Parse(typeof(Month), MonthOfAcountImageComboBoxEdit.Text);

                            foreach (var item in employeesList)
                            {
                                foodList.Add(new Food
                                {
                                    Employee_id = item.ID,
                                    Food_ = item.Food_,
                                    EarningWork = item.Food_ * 15 / 100,

                                    NetFood = item.Food_ * 85 / 100,

                                    MonthOfAcount = month
                                    // Month = Convert.ToDateTime(dateEdit1.Text)
                                }); ;
                                // item. = TransList;
                            }

                            foreach (var iteme in foodList)
                            {
                                try
                                {
                                    model.Foods.Add(iteme);
                                    model.SaveChanges();
                                    frmfood.getdata();
                                    frmfood.gridControl1.DataSource = food.ListData();

                                }
                                catch (Exception exception)
                                {
                                    ProjectData.SetProjectError(exception);
                                    Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                                    ProjectData.ClearProjectError();
                                }
                                frmfood.gridControl1.DataSource = food.ListData();
                                frmfood.getdata();
                                this.Close();
                            }

                            frmfood.getdata();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                        frmfood.getdata();
                    }
                    else if (btn_Save.Text == "طباعة كشف المواصلات")
                    {
                        frmMonth fm = new frmMonth();
                        EmpModel model = new EmpModel();
                        var month = MonthOfAcountImageComboBoxEdit.Text;
                        var repData = model.Transportations.Where(x => x.MonthOfAcount.ToString() == month && x.DateOfEnteriy.Year.ToString() == txt_year.Text).Include("Employee").ToList();
                        if (repData != null)
                        {

                            trans_Report2 motivation_Report = new trans_Report2();
                            //  Bank_Report motivation_Report = new Bank_Report();
                            motivation_Report.DataSource = repData.ToList();
                            motivation_Report.ShowPreviewDialog();
                        }
                    }

                    else if (btn_Save.Text == "طباعة1")
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
                    else if(btn_Save.Text == "طباعة")
                    {
                        frmMonth fm = new frmMonth();
                        EmpModel model = new EmpModel();
                        Bank_Report motivation_Report = new Bank_Report();
                        var month = MonthOfAcountImageComboBoxEdit.Text;
                        var repData2 = model.Employees.ToListAsync().Result;
                        List<Employee> employees = new List<Employee>();
                       
                        foreach (var item in repData2)
                        {
                            employees.Add(new Employee
                            {
                                Emp_ID = item.Emp_ID,
                                Name = item.Name,
                                Salary = item.Salary,
                                TBSalaries = item.TBSalaries.Where(x => x.MonthOfAcount.ToString() == month && x.DateOfEnteriy.Year.ToString() == txt_year.Text).ToList(),
                                Foods = item.Foods.Where(x => x.MonthOfAcount.ToString() == month && x.DateOfEnteriy.Year.ToString() == txt_year.Text).ToList(),
                                Transportations = item.Transportations.Where(x => x.MonthOfAcount.ToString() == month && x.DateOfEnteriy.Year.ToString() == txt_year.Text).ToList(),
                                Rewards = item.Rewards
                                
                            });
                           
                           
                        }

                        //var repData = model.EmployeeSalaries.Where(x => x.MonthOfAcount.ToString() == month&&x.DateOfEnteriy.Year.ToString()==txt_year.Text).Include("Employee").ToList();
                        if (employees != null)
                        {
                            //  var repData1 = model.ToList();
                            //.Where(x => x.MonthOfAcount.ToString() == month && x.DateOfEnteriy.Year.ToString() == txt_year.Text).Include("Employee").ToList();

                            // Motivation_Report2 motivation_Report = new Motivation_Report2();
                            // Motivation_Report_Bank motivation_Report = new Motivation_Report_Bank();

                           
                            motivation_Report.DataSource = employees;
                            motivation_Report.ShowPreviewDialog();
                        }
                    }
                    else if (btn_Save.Text == "طباعة2")
                    {
                        frmMonth fm = new frmMonth();
                        EmpModel model = new EmpModel();
                        var month = MonthOfAcountImageComboBoxEdit.Text;
                        var repData = model.Transportations.Where(x => x.MonthOfAcount.ToString() == month && x.DateOfEnteriy.Year.ToString() == txt_year.Text).Include("Employee").ToList();
                        if (repData != null)
                        {

                            Transport_Report motivation_Report = new Transport_Report();
                            //  Bank_Report motivation_Report = new Bank_Report();
                            motivation_Report.DataSource = repData.ToList();
                            motivation_Report.ShowPreviewDialog();
                        }
                    }
                    else if (btn_Save.Text == "طباعة3")
                    {
                        frmMonth fm = new frmMonth();
                        EmpModel model = new EmpModel();
                        var month = MonthOfAcountImageComboBoxEdit.Text;
                        var repData = model.Foods.Where(x => x.MonthOfAcount.ToString() == month && x.DateOfEnteriy.Year.ToString() == txt_year.Text).Include("Employee").ToList();
                        if (repData != null)
                        {

                            FoodReport motivation_Report = new FoodReport();
                            //  Bank_Report motivation_Report = new Bank_Report();
                            motivation_Report.DataSource = repData.ToList();
                            motivation_Report.ShowPreviewDialog();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("تاكد من سنة الاحتساب");
                }
            }
            else
            {
                MessageBox.Show("يجب ادخال سنة الاحتساب");
            }


        }


        private void btn_bank_print_Click(object sender, EventArgs e)
        {
          
        }
    }
}
