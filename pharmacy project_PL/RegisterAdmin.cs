using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using System.IO;
using Microsoft.Win32;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using System.Windows.Interop;
using System.Management;

namespace pharmacy_project_PL
{
    public partial class RegisterAdmin : UserControl
    {
        public RegisterAdmin()
        {
            InitializeComponent();
        }
        MsgBox msg = new MsgBox();   
        Timer t1 = new Timer(); 
        void SwitchPanels()
        {
            Enabled = true;
            t1.Interval = 15;
            t1.Tick += Timer_Tick;
            t1.Start();
        }
       
        UserAccessRole FillAccessRole(string Section, bool CanEntetr, bool CanAddInformation, bool canUpdate, bool CanDelete)
        {
            UserAccessRole ua = new UserAccessRole();
            ua.Section = Section;
            ua.CanEnter = CanEntetr;
            ua.CanAddInformation = CanAddInformation;
            ua.CanUpdate = canUpdate;
            ua.CanDelete = CanDelete;
            return ua;
        }
        UserGroupBLL UGbll = new UserGroupBLL();
        void CreateAdminGroup()
        {
            UserGroup ug = new UserGroup();
            ug.Title = "مدیریت";
            ug.userAccessRoles.Add(FillAccessRole("بخش مشتریان",true,true,true,true));
            ug.userAccessRoles.Add(FillAccessRole("بخش کالاها", true, true, true,true));
            ug.userAccessRoles.Add(FillAccessRole("بخش فاکتورها", true, true, true,true));
            ug.userAccessRoles.Add(FillAccessRole("بخش فعالیت ها", true, true, true,true));
            ug.userAccessRoles.Add(FillAccessRole("بخش یادآورها", true, true, true,true));
            ug.userAccessRoles.Add(FillAccessRole("بخش کاربران", true, true, true,true));
            ug.userAccessRoles.Add(FillAccessRole("پنل پیامکی", true, true, true,true));
            ug.userAccessRoles.Add(FillAccessRole("بخش گزارشات", true, true, true,true));
            ug.userAccessRoles.Add(FillAccessRole("بخش تنظیمات", true, true, true,true));
            UGbll.Create(ug);
        }
        OpenFileDialog ofd = new OpenFileDialog();
        Image pic;
        UserBLL Ubll = new UserBLL();

       
        string Savepic(string UserName)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\UserPics\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string PicName = UserName + ".JPG";
            try
            {
                string picPath = ofd.FileName;
                File.Copy(picPath, path + PicName, true);
            }
            catch (Exception e)
            {
                MessageBox.Show("سیستم قادر به ذخیره عکس نمی باشد" + e.Message);

            }
            return path + PicName;
        }

        int y = 264;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (PLicense.Location.Y < 517)
            {
                y = y + 10;
                PLicense.Location = new Point(3, y);
            }
            else
            {
                t1.Stop();
                PRegister.Visible = true;
            }
        }
        //public string getCPUId()
        //{
        //    string cpuInfo = string.Empty;
        //    ManagementClass mc = new System.Management.ManagementClass("win32_processor");
        //    ManagementObjectCollection moc = mc.GetInstances();

        //    foreach (System.Management.ManagementObject mo in moc)
        //    {
        //        if (cpuInfo == "")
        //        {
        //            //Get only the first CPU's ID
        //            cpuInfo = mo.Properties["processorID"].Value.ToString();
        //            break;
        //        }
        //    }
        //    return cpuInfo;
        //}
        //private void RegisterAdmin_Load(object sender, EventArgs e)
        //{
        //    txtRegisterId.Text = getCPUId();
        //}

        private void xuiSuperButton2_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(txtRegisterId.Text);
            string productKey = txtLicenceCopy.Text;
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = "Personal accounting";
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }

                    km.SaveSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                    msg.MyShowDialog("تبریک میگویم", "نرم افزار با موفقیت فعال شد", "", false, false);
                    SwitchPanels();
                }
            }
            else
                msg.MyShowDialog("اخطار", "لایسنس وارد شده نادرست است", "", false, true);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            User u =new User();
            CreateAdminGroup();
            u.UserName =txtUserName.Text;
            u.Name = txtName.Text;
            if (txtPassword.Text == txtChekedPassword.Text)
            {
                u.Password = txtChekedPassword.Text;
            }else 
            {
                msg.MyShowDialog("اخطار", "کلمه عبور و تکرار آن مطابقت ندارد","",false,true);
            }                       
            u.RegDate = DateTime.Now;
            u.Pic = Savepic(txtName.Text);
            msg.MyShowDialog("ثبت نام",Ubll.Create(u,UGbll.ReadBySingelTitle("مدیریت")),"",false,false);
            this.Visible = false;
            ((frmlogin)(Application.OpenForms["frmlogin"])).LoadLoginForm();
        }

        private void brnPic_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG(*.JPG)|*.JPG";
            ofd.Title = "تصویر کاربر را انتخاب کنید";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic = Image.FromFile(ofd.FileName);
                
            }
        }
        //public string tst()
        //{
        //    try
        //    {
        //        txtRegisterId.Text = Environment.MachineName;
        //        return txtRegisterId.Text;
        //    }
        //    catch (Exception e)
        //    {
        //        return "خطا\n" + e.Message;
        //    }
        //}
        //private void RegisterAdmin_Load(object sender, EventArgs e)
        //{

        //    نرم افزار لایسنس کجاست؟



        //}

        //private void xuiSuperButton1_Click(object sender, EventArgs e)
        //{
        //    tst();
        //}
    }
}
