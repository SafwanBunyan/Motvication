using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NewMotivationHR.DAL.Model;
using NewMotivationHR.DB;
using NewMotivationHR.DB.Enume;
using NewMotivationHR.PL.SalaryForms;
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

namespace NewMotivationHR.PL.food
{
    public partial class frmfood : Form
    {
        EmpModel model = new EmpModel();
        DAL.DAL<Transportation.frmTransportation> dal;
        DB.Food food;
        void refresh()
        {
            try
            {
                gridControl1.DataSource = dal.ListData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void getdata()
        {
            foodBindingSource1.DataSource = model.Foods.Include("Employee").ToList();

            Employee_idLookUpEdit.Properties.DataSource = model.Employees.Select(t => new { t.ID, t.Name }).ToList();
            Employee_idLookUpEdit.Properties.DisplayMember = "Name";
            Employee_idLookUpEdit.Properties.ValueMember = "ID";
        }

        private void TotalFood()
        {
            try
            {
                if (!string.IsNullOrEmpty(EarningWorkTextEdit.EditValue.ToString()) &
                    !string.IsNullOrEmpty(Employee_idLookUpEdit.EditValue.ToString()))

                {
                    int value = Convert.ToInt32(Employee_idLookUpEdit.EditValue);
                    if (value > 0)
                    {
                        var food = model.Employees.Where(t => t.ID == value).FirstOrDefault().Food_;
                        Food_TextEdit.EditValue = food.ToString();
                        //  AdministrativeTextEdit.EditValue = (20 - (((Convert.ToInt32(AbsenceDaysTextEdit.EditValue)) * 2) + ((Convert.ToInt32(VacationDaysTextEdit.EditValue)) * 1))).ToString();
                        //TotalRate();

                        //   TotalRatioTextEdit.EditValue = (Convert.ToInt32(FollowTaskTextEdit.EditValue) + Convert.ToInt32(PerformanceTextEdit.EditValue) + Convert.ToInt32(AdministrativeTextEdit.EditValue) + Convert.ToInt32(AbilityPlanTextEdit.EditValue) + Convert.ToInt32(WorkAccuracyTextEdit.EditValue)).ToString();
                        // var erning = trans - (trans - (Convert.ToInt32(TotalRatioTextEdit.EditValue) * salary / 100));
                        //  SalaryEvaluationTextEdit.EditValue = erning;
                        EarningWorkTextEdit.EditValue = Convert.ToInt32(Food_TextEdit.EditValue) * 15 / 100;
                        NetFoodTextEdit.EditValue = (Convert.ToInt32(Food_TextEdit.EditValue) - Convert.ToInt32(EarningWorkTextEdit.EditValue)).ToString();
                    }
                }
            }
            catch (Exception exception)
            {

                ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();
            }
        }

        private Food Add_food()
        {
            TotalFood();
            Food food = new Food();
            // salary= employeeSalaryBindingSource.Current as EmployeeSalary;
            food.Employee_id = Convert.ToInt32(Employee_idLookUpEdit.EditValue);

           
            food.Food_ = Convert.ToInt32(Food_TextEdit.EditValue);
            food.NetFood = Convert.ToInt32(NetFoodTextEdit.EditValue);
            food.MonthOfAcount = (Month)Enum.Parse(typeof(Month), MonthOfAcountImageComboBoxEdit.Text, true);
            food.EarningWork = Convert.ToInt32(EarningWorkTextEdit.EditValue);
          

            return food;
        }

        public frmfood()
        {
            InitializeComponent();
            getdata();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
             foodBindingSource.DataSource = new DB.Food();
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
           Food food = Add_food();
            //salary = Add_Salary();
            model.Foods.Add(food);
            model.SaveChanges();
            Refresh();
            foodBindingSource.Clear();

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
            var netsalary = NetFoodTextEdit.EditValue;
            if (netsalary!=null)
            //if (Convert.ToInt32( ) != 0|| NetSalaryTextEdit.EditValue !=null)
            {
                if (Employee_idLookUpEdit.EditValue !=null)
                {

                    TotalFood();

                }
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var food = foodBindingSource.Current as Food;
            //  salary.TotalRatio = TotalRate();
            model.Foods.AddOrUpdate(food);
            model.SaveChanges();
            // Refresh();
            foodBindingSource.Clear();

            btn_delet.Visible = false;
            btn_edit.Visible = false;
            btn_save.Visible = false;
            btn_new.Visible = true;
            btn_print.Visible = true;
            btn_Genrat_Salary.Visible = true;
            getdata();
        }

        private void btn_Genrat_Salary_Click(object sender, EventArgs e)
        {
            frmMonth month = new frmMonth();
            month.txt_year.Visible = false;
            month.btn_Save.Text = "حفظ كشف التغذيه";
            month.ShowDialog();
            getdata();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Employee_idLookUpEdit.ReadOnly = true;
            food = gridView1.GetFocusedRow() as Food;
            foodBindingSource.DataSource = food;
            btn_delet.Visible = true;
            btn_edit.Visible = true;
            btn_save.Visible = false;
            btn_new.Visible = false;
            btn_print.Visible = false;
            btn_Genrat_Salary.Visible = false;
        }
    }
}
