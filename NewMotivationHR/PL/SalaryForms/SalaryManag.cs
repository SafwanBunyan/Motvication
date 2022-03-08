using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NewMotivationHR.DAL;
using NewMotivationHR.DAL.Model;
using NewMotivationHR.DB;
using NewMotivationHR.DB.Enume;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewMotivationHR.PL.SalaryForms
{
    public partial class SalaryManag : Form
    {
        DAL<DB.Employee> dal = new DAL<DB.Employee>();
        DAL<DB.EmployeeSalary> dal2 = new DAL<DB.EmployeeSalary>();
        Employee employee = new Employee();
        EmpModel model = new EmpModel();
        EmployeeSalary salary;
  

        public void getdata()
        {
            employeeSalaryBindingSource1.DataSource = model.EmployeeSalaries.Include("Employee").ToList();

            Employee_idLookUpEdit.Properties.DataSource = model.Employees.Select(t => new { t.ID, t.Name }).ToList();
            Employee_idLookUpEdit.Properties.DisplayMember = "Name";
            Employee_idLookUpEdit.Properties.ValueMember = "ID";
        }

        private int TotalRate()
        {
            return Convert.ToInt32( TotalRatioTextEdit.EditValue = ((Convert.ToInt32(FollowTaskTextEdit.EditValue) + Convert.ToInt32(PerformanceTextEdit.EditValue) + Convert.ToInt32(AdministrativeTextEdit.EditValue) + Convert.ToInt32(AbilityPlanTextEdit.EditValue) + Convert.ToInt32(WorkAccuracyTextEdit.EditValue)).ToString()));
        }
        private void TotalSalary()
        {
            try
            {
                if ( !string.IsNullOrEmpty(FollowTaskTextEdit.EditValue.ToString()) 
                    &!string.IsNullOrEmpty(PerformanceTextEdit.EditValue.ToString())
                    &!string.IsNullOrEmpty(AdministrativeTextEdit.EditValue.ToString())
                    &!string.IsNullOrEmpty(AbilityPlanTextEdit.EditValue.ToString())
                    &!string.IsNullOrEmpty(WorkAccuracyTextEdit.EditValue.ToString()))
                {
                    int value = Convert.ToInt32(Employee_idLookUpEdit.EditValue);
                    var salary = model.Employees.Where(t => t.ID == value).FirstOrDefault().Salary;
                    AdministrativeTextEdit.EditValue = (20 - (((Convert.ToInt32(AbsenceDaysTextEdit.EditValue)) * 2) + ((Convert.ToInt32(VacationDaysTextEdit.EditValue)) * 1))).ToString();
                    //TotalRate();
                    
                    TotalRatioTextEdit.EditValue = (Convert.ToInt32(FollowTaskTextEdit.EditValue) + Convert.ToInt32(PerformanceTextEdit.EditValue) + Convert.ToInt32(AdministrativeTextEdit.EditValue) + Convert.ToInt32(AbilityPlanTextEdit.EditValue) + Convert.ToInt32(WorkAccuracyTextEdit.EditValue)).ToString();
                    var erning = salary - (salary - (Convert.ToInt32(TotalRatioTextEdit.EditValue) * salary / 100));
                    SalaryEvaluationTextEdit.EditValue = erning;
                    EarningWorkTextEdit.EditValue = erning * 15 / 100;
                    DiscountTextEdit.EditValue = (Convert.ToInt32(EarningWorkTextEdit.EditValue) + Convert.ToInt32(DonateTextEdit.EditValue)).ToString();
                    NetSalaryTextEdit.EditValue = (Convert.ToInt32(SalaryEvaluationTextEdit.EditValue) - Convert.ToInt32(DiscountTextEdit.EditValue)).ToString();
                }
            }
            catch (Exception exception)
            {

               ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();
            }
        }


        private EmployeeSalary Add_Salary( )
        {
            TotalSalary();
            EmployeeSalary salary = new EmployeeSalary();
            // salary= employeeSalaryBindingSource.Current as EmployeeSalary;
            salary.Employee_id = Convert.ToInt32(Employee_idLookUpEdit.EditValue);
            salary.FollowTask = Convert.ToInt32(FollowTaskTextEdit.EditValue);
            salary.WorkAccuracy = Convert.ToInt32(WorkAccuracyTextEdit.EditValue);
            salary.Performance = Convert.ToInt32(PerformanceTextEdit.EditValue);
            salary.AbilityPlan = Convert.ToInt32(AbilityPlanTextEdit.EditValue);
            salary.AbsenceDays = Convert.ToInt32(AbsenceDaysTextEdit.EditValue);
            salary.VacationDays = Convert.ToInt32(VacationDaysTextEdit.EditValue);
            salary.Administrative = Convert.ToInt32(AdministrativeTextEdit.EditValue);
            salary.SalaryEvaluation = Convert.ToInt32(SalaryEvaluationTextEdit.EditValue);
            salary.TotalRatio = Convert.ToInt32(TotalRatioTextEdit.EditValue);
            salary.EarningWork= Convert.ToInt32(EarningWorkTextEdit.EditValue);
            salary.NetSalary = Convert.ToInt32(NetSalaryTextEdit.EditValue);
            salary.MonthOfAcount = (Month)Enum.Parse(typeof(Month), MonthOfAcountImageComboBoxEdit.Text, true);
            
            salary.Discount = Convert.ToInt32(DiscountTextEdit.EditValue);
            salary.Donate = Convert.ToInt32(DonateTextEdit.EditValue);

            return salary;
        }

        public SalaryManag()
        {
            InitializeComponent();
            getdata();
            btn_delet.Visible = false;
            btn_edit.Visible = false;
            btn_save.Visible = false;
            btn_new.Visible = true;
            btn_print.Visible = true;
            btn_Genrat_Salary.Visible = true;
        }

        private void btn_Genrat_Salary_Click(object sender, EventArgs e)
        {
            frmMonth month = new frmMonth();
            month.txt_year.Visible = false;
            
            month.ShowDialog();
            getdata();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            
            employeeSalaryBindingSource.DataSource = new EmployeeSalary();
           employeeBindingSource.DataSource = new Employee();
            btn_delet.Visible = false;
            btn_save.Visible = true;
            btn_edit.Visible = false;
            btn_new.Visible = false;
            btn_print.Visible = false;
            btn_Genrat_Salary.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // TotalSalary();
            //  salary = employeeSalaryBindingSource.Current as EmployeeSalary;
            //  salary.TotalRatio = TotalRate();

            EmployeeSalary salary = Add_Salary();
            //salary = Add_Salary();
            model.EmployeeSalaries.Add(salary);
                model.SaveChanges();
                // Refresh();
                employeeSalaryBindingSource.Clear();

            btn_delet.Visible = false;
            btn_edit.Visible = false;
            btn_save.Visible = false;
            btn_new.Visible = true;
            btn_print.Visible = true;
            btn_Genrat_Salary.Visible = true;
            getdata();
        }

        private void Employee_idLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            var netsalary = NetSalaryTextEdit.EditValue;
            if(!string.IsNullOrEmpty(netsalary.ToString()))
            //if (Convert.ToInt32( ) != 0|| NetSalaryTextEdit.EditValue !=null)
            {
                if (!string.IsNullOrEmpty(Employee_idLookUpEdit.EditValue.ToString()) && Convert.ToInt32(Employee_idLookUpEdit.EditValue) > 0)
                {

                    TotalSalary();

                }
            }
        }

      

        //private void gridControl1_Click(object sender, EventArgs e)
        //{
        //    //
        //}

        private void gridControl1_DoubleClick_1(object sender, EventArgs e)
        {
            Employee_idLookUpEdit.ReadOnly = true;
            salary = gridView1.GetFocusedRow() as EmployeeSalary;
            employeeSalaryBindingSource.DataSource = salary;
            btn_delet.Visible = true;
            btn_edit.Visible = true;
            btn_save.Visible = false;
            btn_new.Visible = false;
            btn_print.Visible = false;
            btn_Genrat_Salary.Visible = false;
        }

        private void SalaryManag_Load(object sender, EventArgs e)
        {
            getdata();
            btn_delet.Visible = false;
            btn_edit.Visible = false;
            btn_save.Visible = false;
            btn_new.Visible = true;
            btn_print.Visible = true;
            btn_Genrat_Salary.Visible = true;
        }

        private void AbsenceDaysTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            //AdministrativeTextEdit.EditValue =( 20-(((Convert.ToInt32(AbsenceDaysTextEdit.EditValue)) *2)+((Convert.ToInt32(VacationDaysTextEdit.EditValue)) *1))).ToString();
            //TotalRatioTextEdit.EditValue = ((Convert.ToInt32(FollowTaskTextEdit.EditValue) + Convert.ToInt32(PerformanceTextEdit.EditValue) + Convert.ToInt32(AdministrativeTextEdit.EditValue) + Convert.ToInt32(AbilityPlanTextEdit.EditValue) + Convert.ToInt32(WorkAccuracyTextEdit.EditValue)).ToString());

        }

        private void PerformanceTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Employee_idLookUpEdit.EditValue.ToString()))
            {
                TotalSalary();
            }

           //TotalRate();
          
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {


            //EmployeeSalary salary =Add_Salary();
            var sal = employeeSalaryBindingSource.Current as EmployeeSalary;
            //  salary.TotalRatio = TotalRate();
            model.EmployeeSalaries.AddOrUpdate(sal);
            model.SaveChanges();
            // Refresh();
            employeeSalaryBindingSource.Clear();

            btn_delet.Visible = false;
            btn_edit.Visible = false;
            btn_save.Visible = false;
            btn_new.Visible = true;
            btn_print.Visible = true;
            btn_Genrat_Salary.Visible = true;
            getdata();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            frmMonth fm = new frmMonth();
            fm.btn_Save.Text = "طباعة";
            fm.txt_year.Visible = true;
            fm.btn_bank_print.Visible = true;
            fm.ShowDialog();
        }
    }
}
