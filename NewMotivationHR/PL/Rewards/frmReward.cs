using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
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
using Type = NewMotivationHR.DB.Enume.Type;

namespace NewMotivationHR.PL.Rewards
{
    public partial class frmReward : Form
    {
        EmpModel model = new EmpModel();
        DAL.DAL<Reward> dal;
       Reward reward;
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
            rewardBindingSource1.DataSource = model.Rewards.Include("Employee").ToList();

            Employee_idLookUpEdit.Properties.DataSource = model.Employees.Select(t => new { t.ID, t.Name }).ToList();
            Employee_idLookUpEdit.Properties.DisplayMember = "Name";
            Employee_idLookUpEdit.Properties.ValueMember = "ID";
            //lkp.Properties.Columns[valueMember].Visible = false ; 

        }

        private void totalReward()
        {
            try
            {
                if (!string.IsNullOrEmpty(EarningWorkTextEdit.EditValue.ToString())
                &!string.IsNullOrEmpty(Reward_TextEdit.EditValue.ToString()))

                {
                   //int value = Convert.ToInt32(Employee_idLookUpEdit.EditValue);
                   //var food = model.Employees.Where(t => t.ID == value).FirstOrDefault().Food_;
                    //Food_TextEdit.EditValue = food.ToString();
                    //  AdministrativeTextEdit.EditValue = (20 - (((Convert.ToInt32(AbsenceDaysTextEdit.EditValue)) * 2) + ((Convert.ToInt32(VacationDaysTextEdit.EditValue)) * 1))).ToString();
                    //TotalRate();

                    //   TotalRatioTextEdit.EditValue = (Convert.ToInt32(FollowTaskTextEdit.EditValue) + Convert.ToInt32(PerformanceTextEdit.EditValue) + Convert.ToInt32(AdministrativeTextEdit.EditValue) + Convert.ToInt32(AbilityPlanTextEdit.EditValue) + Convert.ToInt32(WorkAccuracyTextEdit.EditValue)).ToString();
                    // var erning = trans - (trans - (Convert.ToInt32(TotalRatioTextEdit.EditValue) * salary / 100));
                    //  SalaryEvaluationTextEdit.EditValue = erning;
                    EarningWorkTextEdit.EditValue = Convert.ToInt32(Reward_TextEdit.EditValue) * 15 / 100;
                    NetRewardTextEdit.EditValue = (Convert.ToInt32(Reward_TextEdit.EditValue) - Convert.ToInt32(EarningWorkTextEdit.EditValue)).ToString();
                }
                else
                {
                    MessageBox.Show("pppppppppppppppppppp");
                }
            }
            catch (Exception exception)
            {

                ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();
            }
        }

        private Reward Add_Reward()
        {
            //totalReward();
             reward = new Reward();
            // salary= employeeSalaryBindingSource.Current as EmployeeSalary;
            var result = Employee_idLookUpEdit.EditValue;
            reward.Employee_id = Convert.ToInt32(result);

            reward.Type = (Type)Enum.Parse(typeof(Type), TypeImageComboBoxEdit.Text, true);
            reward.Reward_ = Convert.ToInt32(Reward_TextEdit.EditValue);
           //reward.NetReward= Convert.ToInt32(NetRewardTextEdit.EditValue);
           
           // reward.EarningWork = Convert.ToInt32(EarningWorkTextEdit.EditValue);


            return reward;
        }
        public frmReward()
        {
            InitializeComponent();
            getdata();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            rewardBindingSource.DataSource = new Reward();
            employeeBindingSource.DataSource = new Employee();
            btn_delet.Visible = false;
            btn_save.Visible = true;
            btn_edit.Visible = false;
            btn_new.Visible = false;
            btn_print.Visible = false;


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
             reward =Add_Reward();
            //salary = Add_Salary();
            model.Rewards.Add(reward);
            model.SaveChanges();
            Refresh();
            rewardBindingSource.Clear();

            btn_delet.Visible = false;
            btn_edit.Visible = false;
            btn_save.Visible = false;
            btn_new.Visible = true;
            btn_print.Visible = true;
         
            getdata();

        }
        private void Employee_idLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               //// var netsalary = NetRewardTextEdit.EditValue;
               // if (!string.IsNullOrEmpty(Employee_idLookUpEdit.Text))
               // //if (Convert.ToInt32( ) != 0|| NetSalaryTextEdit.EditValue !=null)
               // //{
               //     if (!string.IsNullOrEmpty(Employee_idLookUpEdit.EditValue.ToString()) && Convert.ToInt32(Employee_idLookUpEdit.EditValue) > 0)
               //     {

               //         totalReward();

               //     }
               // else
               //     {

               //         MessageBox.Show("ddddddddddddd");
               //     }
                //}
            }
            catch (Exception exception)
            {

                ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();
            }


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            reward = Add_Reward();
            //salary = Add_Salary();
            model.Rewards.AddOrUpdate(reward);
            model.SaveChanges();
            Refresh();
            rewardBindingSource.Clear();

            btn_delet.Visible = false;
            btn_edit.Visible = false;
            btn_save.Visible = false;
            btn_new.Visible = true;
            btn_print.Visible = true;
       
            getdata();
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
