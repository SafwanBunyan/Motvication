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
using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using NewMotivationHR.DAL;
using NewMotivationHR.DAL.Model;

namespace NewMotivationHR.PL.Department
{
    public partial class DepartmentForm : DevExpress.XtraEditors.XtraForm
    {
        DB.Department department = new DB.Department();
        DAL<DB.Department> dal = new DAL<DB.Department>();

        public DepartmentForm()
        {
            InitializeComponent();
            refresh();

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            departmentBindingSource.DataSource = new DB.Department();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (EmpModel model = new EmpModel())
                {
                    department = departmentBindingSource.Current as DB.Department;
                    model.Departments.Add(department);
                    model.SaveChanges();
                    Refresh();
                    departmentBindingSource.Clear();
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            using (EmpModel model = new EmpModel())
            {
                department = departmentBindingSource.Current as DB.Department;
                model.Departments.AddOrUpdate(department);
                model.SaveChanges();
                Refresh();
                departmentBindingSource.Clear();
                refresh();
            }
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            using (EmpModel Model = new EmpModel())
            {
                Model.Departments.Remove(Model.Departments.Single(x => x.ID == department.ID));
                Model.SaveChanges();
                Refresh();
                departmentBindingSource.Clear();
                refresh();
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();

        }
    }
}