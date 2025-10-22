using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;



namespace pharmacy_project_PL
{
    public partial class frmUser : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmUser()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void FillDatagrid()
        {
            DgvUser.DataSource = null;
            DgvUser.DataSource = bll.Read();
            DgvUser.Columns["id"].Visible = false;
            DgvUser.Columns["نام و نام خانوادگی"].Width = 100;
            DgvUser.Columns["تاریخ ثبت"].Width = 120;
        }
        void clearTxtbox()
        {
            txtName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPasswordCheked.Text = "";
            PBImage.Image = Properties.Resources.Icn1004943www_tiktarh_com_;


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
        MsgBox msg = new MsgBox();
        UserGroupBLL ugBLL = new UserGroupBLL();
        OpenFileDialog ofd = new OpenFileDialog();
        Image pic;
        
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
                File.Copy(picPath, path + PicName,true);
            }
            catch (Exception e)
            {
                MessageBox.Show("سیستم قادر به ذخیره عکس نمی باشد"+ e.Message);
                
            }
            return path + PicName;
        }
        UserBLL bll = new UserBLL();
        
        private void PBImage_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG(*.JPG)|*.JPG";
            ofd.Title = "تصویر کاربر را انتخاب کنید";
            if (ofd.ShowDialog()== DialogResult.OK)
            {
               pic = Image.FromFile(ofd.FileName);
               PBImage.Image = pic; 
               PBImage.SizeMode =PictureBoxSizeMode.StretchImage;   
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            User u = new User();    
            u.Name = txtName.Text;
            u.UserName = txtUserName.Text;
            UserGroup ug = ugBLL.ReadBySingelTitle(comboBox1.Text);
            u.UserGroup = ug;   
            u.RegDate = DateTime.Now;   
            
            
            if (txtPassword.Text == txtPasswordCheked.Text)
            {
                u.Password = txtPasswordCheked.Text;    
            }
            else
            {
                MessageBox.Show("تکرار رمز عبور درست وارد نشده است");
            }
            u.Pic = Savepic(txtUserName.Text);
            if (btnInsert.ButtonText == "ثبت اطلاعات")
            { 
                msg.MyShowDialog("ثبت",bll.Create(u,ug), "", false, false);
            }
            else
            {
                msg.MyShowDialog("ویرایش",bll.Update(u, id), "", false, false);
                btnInsert.ButtonText = "ثبت اطلاعات";
            }
            FillDatagrid();
            clearTxtbox();
            comboBox1.Text = "";

        }
        int id = 0;
        private void frmUser_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ugBLL.ListReadUGTitle();
            comboBox1.DisplayMember = "Title";
            FillDatagrid();
        }

        private void DgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            id = Convert.ToInt32(DgvUser.Rows[DgvUser.CurrentRow.Index].Cells["id"].Value.ToString());
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User u = bll.Read(id);
            txtName.Text = u.Name;
            txtUserName.Text = u.UserName;
            PBImage.Image = Image.FromFile(u.Pic);
            PBImage.SizeMode = PictureBoxSizeMode.StretchImage;
            btnInsert.ButtonText = "ویرایش اطلاعات";
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = msg.MyShowDialog("اخطار", "آیا می خواهید کاربر مورد نظر را پاک کنید؟", "", true, false);
            if (dr == DialogResult.Yes)
            {
                msg.MyShowDialog("حذف", bll.Delete(id), "", false, false);
            }
            FillDatagrid();
        }

        private void cbSlectAll_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSlectAll.Checked)
            {
                cbCustomer_Request.Checked = true;
                cbProduct_Request.Checked = true;
                cbInvoice_Request.Checked= true;
                cbActivity_Request.Checked = true;
                cbReminder_Requst.Checked = true;
                cbUsers_Requste.Checked = true;
                cbSms_Requset.Checked = true;
                cbReports_Requst.Checked= true;
                cbSetting_Requset.Checked= true;    
            }
            else
            {
                cbCustomer_Request.Checked = false;
                cbProduct_Request.Checked = false;
                cbInvoice_Request.Checked = false;
                cbActivity_Request.Checked = false;
                cbReminder_Requst.Checked = false;
                cbUsers_Requste.Checked = false;
                cbSms_Requset.Checked = false;
                cbReports_Requst.Checked = false;
                cbSetting_Requset.Checked = false;
            }
        }

        private void cbSelectAllAddInformations_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelectAllAddInformations.Checked)
            {
                cbCustomerAddInformation.Checked = true;
                cbProductAddInformation.Checked = true;
                cbInvoiceAdd.Checked = true;
                cbActivityAdd.Checked = true;
                cbReminderAdd.Checked = true;
                cbUsersAdd.Checked = true;
                cbSmsAdd.Checked = true;
                cbReportsAdd.Checked = true;
                cbSettingAdd.Checked = true;
            } 
            else 
            {
                cbCustomerAddInformation.Checked = false;
                cbProductAddInformation.Checked = false;
                cbInvoiceAdd.Checked = false;
                cbActivityAdd.Checked = false;
                cbReminderAdd.Checked = false;
                cbUsersAdd.Checked = false;
                cbSmsAdd.Checked = false;
                cbReportsAdd.Checked = false;
                cbSettingAdd.Checked = false;
            }

        }

        private void cbSelectAllUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelectAllUpdate.Checked)
            {
                cbCustomerUpdateInformation.Checked = true;
                cbProductUpdate.Checked = true;
                cbInvoiceUpdate.Checked = true;
                cbActivityUpdate.Checked = true;
                cbReminderUpdate.Checked = true;
                cbUsersUpdate.Checked = true;
                cbSmsUpdate.Checked = true;
                cbReportsUpdate.Checked = true;
                cbSettingUpdate.Checked = true;
            }
            else
            {
                cbCustomerUpdateInformation.Checked = false;
                cbProductUpdate.Checked = false;
                cbInvoiceUpdate.Checked = false;
                cbActivityUpdate.Checked = false;
                cbReminderUpdate.Checked = false;
                cbUsersUpdate.Checked = false;
                cbSmsUpdate.Checked = false;
                cbReportsUpdate.Checked = false;
                cbSettingUpdate.Checked = false;
            }
        }

        private void cbSelectallDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelectallDelete.Checked)
            {
                cbCustomerDeleteInformation.Checked = true;
                cbProductDelete.Checked = true;
                cbInvoiceDelete.Checked = true;
                cbActivityDelete.Checked = true;
                cbReminderDelete.Checked = true;
                cbUsersDelete.Checked = true;
                cbSmsDelete.Checked = true;
                cbReportsDelete.Checked = true;
                cbSettingDelete.Checked = true;
            }
            else
            {
                cbCustomerDeleteInformation.Checked = false;
                cbProductDelete.Checked = false;
                cbInvoiceDelete.Checked = false;
                cbActivityDelete.Checked = false;
                cbReminderDelete.Checked = false;
                cbUsersDelete.Checked = false;
                cbSmsDelete.Checked = false;
                cbReportsDelete.Checked = false;
                cbSettingDelete.Checked = false;
            }
        }

        private void SelectAllcb_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllcb.Checked)
            {
                cbSlectAll.Checked = true;
                cbSelectAllAddInformations.Checked = true;
                cbSelectAllUpdate.Checked = true;
                cbSelectallDelete.Checked = true;
            }
            else
            {
                cbSlectAll.Checked = false;
                cbSelectAllAddInformations.Checked = false;
                cbSelectAllUpdate.Checked = false;
                cbSelectallDelete.Checked = false;
            }
        }

        private void btnCreateGropUser_Click(object sender, EventArgs e)
        {
            UserGroup ug = new UserGroup(); 
            ug.Title = txtNameUserGroup.Text;
            ug.userAccessRoles.Add(FillAccessRole(SectionCustomer.Text, cbCustomer_Request.Checked, cbCustomerAddInformation.Checked, cbCustomerUpdateInformation.Checked, cbCustomerDeleteInformation.Checked));
            ug.userAccessRoles.Add(FillAccessRole(SectionProduct.Text, cbProduct_Request.Checked, cbProductAddInformation.Checked, cbProductUpdate.Checked, cbProductDelete.Checked));
            ug.userAccessRoles.Add(FillAccessRole(SectionInvoice.Text, cbInvoice_Request.Checked, cbInvoiceAdd.Checked,cbInvoiceUpdate.Checked,cbInvoiceDelete.Checked));
            ug.userAccessRoles.Add(FillAccessRole(SectionActivitys.Text,cbActivity_Request.Checked,cbActivityAdd.Checked,cbActivityUpdate.Checked,cbActivityDelete.Checked));
            ug.userAccessRoles.Add(FillAccessRole(SectionReminder.Text,cbReminder_Requst.Checked,cbReminderAdd.Checked,cbReminderUpdate.Checked,cbReminderDelete.Checked));
            ug.userAccessRoles.Add(FillAccessRole(SectionUser.Text,cbUsers_Requste.Checked,cbUsersAdd.Checked,cbUsersUpdate.Checked,cbUsersDelete.Checked));
            ug.userAccessRoles.Add(FillAccessRole(SectionSms.Text, cbSms_Requset.Checked, cbSmsAdd.Checked,cbSmsUpdate.Checked,cbSmsDelete.Checked));
            ug.userAccessRoles.Add(FillAccessRole(SectionReport.Text,cbReports_Requst.Checked,cbReportsAdd.Checked,cbReportsUpdate.Checked,cbReportsDelete.Checked));
            ug.userAccessRoles.Add(FillAccessRole(Sectionsetting.Text, cbSetting_Requset.Checked,cbSettingAdd.Checked,cbSettingUpdate.Checked,cbSettingDelete.Checked));
            msg.MyShowDialog("نتیجه ثبت اطلاعات",ugBLL.Create(ug), "", false, false);
            txtNameUserGroup.Text = "";
            

        }

        
    }
}
