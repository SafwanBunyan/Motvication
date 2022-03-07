using NewMotivationHR.DAL;
using NewMotivationHR.DAL.Model;
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
        public EmployeeManeg()
        {
            InitializeComponent();
            refresh();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = new DB.Employee();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (EmpModel model = new EmpModel())
            {
                employee = employeeBindingSource.Current as DB.Employee;
                model.Employees.Add(employee);
                model.SaveChanges();
                Refresh();
                employeeBindingSource.Clear();
                refresh();
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

                // getData();
                //employee = employeeBindingSource.Current as Employee;

                Model.Employees.Remove(Model.Employees.Single(x => x.ID == employee.ID));
                Model.SaveChanges();
                Refresh();
                employeeBindingSource.Clear();
                refresh();
            }
        }
    }
}
