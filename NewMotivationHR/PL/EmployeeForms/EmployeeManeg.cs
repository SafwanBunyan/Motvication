using Microsoft.VisualBasic;
using NewMotivationHR.DAL;
using NewMotivationHR.DAL.Model;
using NewMotivationHR.DB;
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

namespace NewMotivationHR.PL.EmployeeForms
{
    public partial class EmployeeManeg : Form
    {
        DB.Employee employee = new DB.Employee();
        DAL<DB.Employee> dal = new DAL<DB.Employee>();
        DAL<DB.Department> dal2 = new DAL<DB.Department>();
        EmpModel model = new EmpModel();
        DB.Department department;

        void refresh()
        {
            try
            {
             gridControl1.DataSource = model.Employees.Include("Department").ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public EmployeeManeg()
        {
            InitializeComponent();
            refresh();
            getdata();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = new DB.Employee();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (EmpModel model = new EmpModel())
                {
                    employee = employeeBindingSource.Current as DB.Employee;
                    model.Employees.AddOrUpdate(employee);
                    model.SaveChanges();
                    Refresh();
                    employeeBindingSource.Clear();
                    refresh();
                }
            }
            catch (Exception exception)
            {
                //ProjectData.SetProjectError(exception);
                Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                //ProjectData.ClearProjectError();
                return;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = gridView1.GetFocusedRow() as DB.Employee;
           // refresh();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            using (EmpModel model = new EmpModel())
            {
                employee = employeeBindingSource.Current as DB.Employee;
                model.Employees.AddOrUpdate(employee);
                model.SaveChanges();
                Refresh();
                employeeBindingSource.Clear();
                refresh();
            }

        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            using (EmpModel Model = new EmpModel())
            {
                Model.Employees.Remove(Model.Employees.Single(x => x.ID == employee.ID));
                Model.SaveChanges();
                Refresh();
                employeeBindingSource.Clear();
                refresh();
            }
        }
        public void getdata()
        {
            departmentBindingSource.DataSource = model.Departments.ToList();
            //ItemForDepartmentId
            //ItemForDepartmentId.Properties = model.Departments.Select(t => new { t.ID, t.Name }).ToList();
            //departmentBindingSource.DisplayMember = "Name";
            //departmentBindingSource.Properties.ValueMember = "ID";
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void EmployeeManeg_Load(object sender, EventArgs e)
        {

        }
    }
}
