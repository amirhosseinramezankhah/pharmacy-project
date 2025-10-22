using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;
using System.Windows.Media.Effects;
using BE;
using BLL;

namespace pharmacy_project_PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            frmlogin f = new frmlogin();
            InitializeComponent();
            OpenWinForme(f);
        }
        public User LoggedInUser = new User();
        DashbordBLL dbll = new DashbordBLL();   
        UserBLL Ubll = new UserBLL();
        MsgBox m = new MsgBox();
        void OpenWinForme(Form f)
        {
            BlurEffect bme = new BlurEffect();
            this.Effect = bme;
            bme.Radius = 15;
            f.ShowDialog();
            Effect = null;

        }

        void OpenWinForm(Form f)
        {
            Window g = this.FindName("Main") as Window;
            BlurBitmapEffect blurBitmapEffect = new BlurBitmapEffect();
            blurBitmapEffect.Radius = 20;
            g.BitmapEffect = blurBitmapEffect;
            f.ShowDialog();
            blurBitmapEffect.Radius = 0;
            g.BitmapEffect = blurBitmapEffect;
        }
        public void Refreshpage() 
        { 
            txtUserName.Text = LoggedInUser.UserName;
            txtname.Text = LoggedInUser.Name;
            txtReminderCount.Text = dbll.UserRemindersCount(LoggedInUser);
            int a = 0;
            foreach (var item in dbll.GetUserReminders(LoggedInUser))
            {
                if (a < 4)
                { 
                   ReminderUC r = new ReminderUC();
                    r.ReminderTitleTxt.Text =item.Title;
                    r.ReminderinfoTxt.Text = item.ReminderInfo;
                   Grid.SetRow(r, 8 + a);
                   Grid.SetColumnSpan(r, 12);
                   MainGrid.Children.Add(r);
                   a++;

                }
               
            }
               
        }


        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Ubll.Access(LoggedInUser, "بخش مشتریان", 1))
            {
                frmCustomers f = new frmCustomers();
                OpenWinForm(f);
                Refreshpage();
            }
            else
            {
                m.MyShowDialog("محدودیت دسترسی", "اجازه ورود به این بخش را ندارید", "", false, true);
            }

        }

        private void Rectangle_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            frmProductManagment f = new frmProductManagment();
            OpenWinForm(f);
           
        }

        private void Rectangle_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            frmListInvoice f = new frmListInvoice();
            f.LoggedUser = LoggedInUser;
            OpenWinForm(f);
            
        }

        private void Rectangle_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            frmActivitys f = new frmActivitys();
            OpenWinForm(f);
            
        }

        private void Rectangle_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            frmReminders f = new frmReminders(LoggedInUser);
            OpenWinForm(f);
            Refreshpage();
        }

        private void Rectangle_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            frmUser f = new frmUser();
            OpenWinForm(f);
            
        }

        private void Rectangle_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            frmSMSPanel f = new frmSMSPanel();
            OpenWinForm(f);
            
        }

        private void Rectangle_MouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            frmReport f = new frmReport();  
            OpenWinForm(f); 
        }

        private void Rectangle_MouseLeftButtonDown_8(object sender, MouseButtonEventArgs e)
        {
            frmSetting f = new frmSetting();
            OpenWinForm(f);
            

        }
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MsgBox m = new MsgBox();
            m.MyShowDialog("اطلاعات ثبت شد", "ثبت اطلاعات کاربر انجام شد", "", false, true);

        }
        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            MsgBox m = new MsgBox();
            DialogResult dr = m.MyShowDialog("اخطار", "آیا می خواهید از سیستم خارج شوید؟", "", true, false);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        
    }
}
