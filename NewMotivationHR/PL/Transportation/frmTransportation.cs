using NewMotivationHR.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewMotivationHR.DB;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic;
using NewMotivationHR.DB.Enume;
using System.Data.Entity.Migrations;
using NewMotivationHR.PL.SalaryForms;

namespace NewMotivationHR.PL.Transportation
{
    public partial class frmTransportation : Form
    {
        EmpModel model = new EmpModel();
        DAL.DAL<Transportation.frmTransportation> dal;
        DB.Transportation transportation;
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

        private DB.Transportation Add_Transportation()
        {
            TotalSalary();
           DB.Transportation transportation = new DB.Transportation();
            // salary= employeeSalaryBindingSource.Current as EmployeeSalary;
            transportation.Employee_id = Convert.ToInt32(Employee_idLookUpEdit.EditValue);
        
            transportation.AbsenceDays = Convert.ToInt32(AbsenceDaysTextEdit.EditValue);
            transportation.Penalties = Convert.ToInt32(PenaltiesTextEdit.EditValue);
            transportation.Transportation_befor = Convert.ToInt32(Transportation_beforTextEdit.EditValue);
            transportation.NetSalary = Convert.ToInt32(NetSalaryTextEdit.EditValue);
            transportation.MonthOfAcount = (Month)Enum.Parse(typeof(Month), MonthOfAcountImageComboBoxEdit.Text, true);
            transportation.EarningWork = Convert.ToInt32(EarningWorkTextEdit.EditValue);
            transportation.Discount = Convert.ToInt32(DiscountTextEdit.EditValue);
        
            return transportation;
        }
        public void getdata()
        {
            transportationBindingSource1.DataSource = model.Transportations.Include("Employee").ToList();

            Employee_idLookUpEdit.Properties.DataSource = model.Employees.Select(t => new { t.ID, t.Name }).ToList();
            Employee_idLookUpEdit.Properties.DisplayMember = "Name";
            Employee_idLookUpEdit.Properties.ValueMember = "ID";
        }

        private void TotalSalary()
        {
            try
            {
                if (!string.IsNullOrEmpty(AbsenceDaysTextEdit.EditValue.ToString())
                    & !string.IsNullOrEmpty(EarningWorkTextEdit.EditValue.ToString()))
                  
                {
                    int value = Convert.ToInt32(Employee_idLookUpEdit.EditValue);
                    var trans = model.Employees.Where(t => t.ID == value).FirstOrDefault().Transportation;
                    Transportation_beforTextEdit.EditValue = trans.ToString();
                  //  AdministrativeTextEdit.EditValue = (20 - (((Convert.ToInt32(AbsenceDaysTextEdit.EditValue)) * 2) + ((Convert.ToInt32(VacationDaysTextEdit.EditValue)) * 1))).ToString();
                    //TotalRate();

                 //   TotalRatioTextEdit.EditValue = (Convert.ToInt32(FollowTaskTextEdit.EditValue) + Convert.ToInt32(PerformanceTextEdit.EditValue) + Convert.ToInt32(AdministrativeTextEdit.EditValue) + Convert.ToInt32(AbilityPlanTextEdit.EditValue) + Convert.ToInt32(WorkAccuracyTextEdit.EditValue)).ToString();
                   // var erning = trans - (trans - (Convert.ToInt32(TotalRatioTextEdit.EditValue) * salary / 100));
                  //  SalaryEvaluationTextEdit.EditValue = erning;
                    EarningWorkTextEdit.EditValue =(Convert.ToInt32( Transportation_beforTextEdit.EditValue)- Convert.ToInt32(PenaltiesTextEdit.EditValue) )* 15 / 100;
                    PenaltiesTextEdit.EditValue =(Convert.ToInt32(Transportation_beforTextEdit.EditValue)/21)*Convert.ToInt32( AbsenceDaysTextEdit.EditValue);
                    DiscountTextEdit.EditValue = (Convert.ToInt32(EarningWorkTextEdit.EditValue) + Convert.ToInt32(PenaltiesTextEdit.EditValue)).ToString();
                    NetSalaryTextEdit.EditValue = (Convert.ToInt32(Transportation_beforTextEdit.EditValue) - Convert.ToInt32(DiscountTextEdit.EditValue)).ToString();
                }
            }
            catch (Exception exception)
            {

                ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();
            }
        }
        public frmTransportation()
        {
            InitializeComponent();
            getdata();
        }
        

        private void btn_new_Click(object sender, EventArgs e)
        {
            transportationBindingSource.DataSource = new DB.Transportation();
            employeeBindingSource.DataSource = new Employee();
            btn_delet.Visible = false;
            btn_save.Visible = true;
            btn_edit.Visible = false;
            btn_new.Visible = false;
            btn_print.Visible = false;
            btn_Genrat_Salary.Visible = false;
        }

        private void Employee_idLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            var netsalary = NetSalaryTextEdit.EditValue;
            if (netsalary!=null)
            {
                if (!string.IsNullOrEmpty(Employee_idLookUpEdit.EditValue.ToString()) && Convert.ToInt32(Employee_idLookUpEdit.EditValue) > 0)
                {

                    TotalSalary();

                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DB.Transportation transportation= Add_Transportation();
            //salary = Add_Salary();
            model.Transportations.Add(transportation);
            model.SaveChanges();
            // Refresh();
            transportationBindingSource.Clear();

            btn_delet.Visible = false;
            btn_edit.Visible = false;
            btn_save.Visible = false;
            btn_new.Visible = true;
            btn_print.Visible = true;
            btn_Genrat_Salary.Visible = true;
            getdata();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        { //EmployeeSalary salary =Add_Salary();
            var trans = transportationBindingSource.Current as DB.Transportation;
            //  salary.TotalRatio = TotalRate();
            model.Transportations.AddOrUpdate(trans);
            model.SaveChanges();
            // Refresh();
            transportationBindingSource.Clear();

            btn_delet.Visible = false;
            btn_edit.Visible = false;
            btn_save.Visible = false;
            btn_new.Visible = true;
            btn_print.Visible = true;
            btn_Genrat_Salary.Visible = true;
            getdata();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {


            Employee_idLookUpEdit.ReadOnly = true;
            transportation = gridView1.GetFocusedRow() as DB.Transportation;
            transportationBindingSource.DataSource = transportation;
            btn_delet.Visible = true;
            btn_edit.Visible = true;
            btn_save.Visible = false;
            btn_new.Visible = false;
            btn_print.Visible = false;
            btn_Genrat_Salary.Visible = false;
        }

        private void btn_Genrat_Salary_Click(object sender, EventArgs e)
        {
            frmMonth month = new frmMonth();
            month.txt_year.Visible = false;
            month.btn_Save.Text = "حفظ الكشف";
            month.ShowDialog();
            getdata();
        }
    }
}
