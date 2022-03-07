using Microsoft.VisualBasic.ApplicationServices;
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
using User = NewMotivationHR.DB.User;

namespace NewMotivationHR.PL
{
    public partial class frm_UserMange : Form
    {
        DB.User user = new DB.User();
        DAL<DB.User> dal = new DAL<DB.User>();


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
        public frm_UserMange()
        {
            InitializeComponent();
            refresh();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            userBindingSource.DataSource = new DB.User();
            refresh();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (EmpModel model = new EmpModel())
            {
                user = userBindingSource.Current as DB.User;
                model.Users.Add(user);
                model.SaveChanges();
                Refresh();
                userBindingSource.Clear();
                refresh();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            using (EmpModel model = new EmpModel())
            {
                user = userBindingSource.Current as DB.User;
                model.Users.AddOrUpdate(user);
                model.SaveChanges();
                Refresh();
                userBindingSource.Clear();
                refresh();
            }
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            using (EmpModel Model = new EmpModel())
            {

                // getData();
                //employee = employeeBindingSource.Current as Employee;

                Model.Users.Remove(Model.Users.Single(x => x.ID == user.ID));
                Model.SaveChanges();
                Refresh();
                userBindingSource.Clear();
                refresh();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            userBindingSource.DataSource = gridView1.GetFocusedRow() as DB.User;
            refresh();

        }
    }
}
