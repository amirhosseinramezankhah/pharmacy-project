using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using BE;
using BLL;

namespace pharmacy_project_PL
{
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
        }
        UserBLL Ubll = new UserBLL();   
        MsgBox msg = new MsgBox();  
        User u = new User();    
        DashbordBLL dbll= new DashbordBLL(); 
        private void btnInsert_Click(object sender, EventArgs e)
        {
            u = Ubll.Login(txtUserName.Text, txtPassword.Text);
            if (u!=null)
            {
                msg.MyShowDialog("خوش آمدید","برای ورود به نرم افزار روی تایید کلیک کنید", "", false, false);

                MainWindow w = (MainWindow)System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault();
                w.LoggedInUser = u;
                w.Refreshpage();
                ((frmlogin)System.Windows.Forms.Application.OpenForms["frmlogin"]).Close();
            }
            else
            {
                msg.MyShowDialog("اخطار","نام کاربری یا کلمه عبور اشتباه است","",false,true);
            }
            
        }
    }
}
