using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NewMotivationHR.DB;

namespace NewMotivationHR.PL.User
{
    public partial class FrmLogin : Form
    {
        DB.User user = new DB.User();
        DAL.DAL<DB.User> dal = new DAL.DAL<DB.User>();
        public FrmLogin()
        {
            InitializeComponent();
            userBindingSource.DataSource = new DB.User();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
               // checkDefualt();
               // splashScreenManager1.ShowWaitForm();
                user = userBindingSource.Current as DB.User;
                var CurruntUser = dal.Find(u => u.UserName == user.UserName & u.PassWord == user.PassWord);
                if (CurruntUser != null)
                {
                    Program.UserNow = CurruntUser;
                    Program.LogInUser = true;
                    Close();

                }
                else
                {
                    XtraMessageBox.Show(/*BranchIDTextEdit.EditValue.ToString() + User.UserName.ToString() + User.UserPassword.ToString() +*/ "       اسم المستخدم او كلمة المرور غير صحيحة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
