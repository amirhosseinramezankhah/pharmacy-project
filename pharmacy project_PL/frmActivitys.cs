using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BE;
using BLL;
using DevComponents.Editors.DateTimeAdv;
namespace pharmacy_project_PL
{
    public partial class frmActivitys : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmActivitys()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion

        }
        void FillDatagrid()
        {
            dgvActivty.DataSource = null;
            dgvActivty.DataSource = ABll.Read();
            dgvActivty.Columns["id"].Visible = false;
        }
        void clearTxtbox()
        {
            txtPhoneNumberSerching.Text = "";
            txtNameUserSerching.Text = "";
            txtNameAc.Text = "";
            txtTitleActivitys.Text = "";
            txtDescripstion.Text = "";
            txtDateTimeActivitys.Text = "";
        }
        Customer customer = new Customer();
        CustomerBLL CBll = new CustomerBLL();
        User user = new User();
        UserBLL UBll = new UserBLL();
        ActivityCategory activityCategory = new ActivityCategory();
        ActivityCategoryBLL AcBll = new ActivityCategoryBLL();
        ActivityBLL ABll = new ActivityBLL();
        ReminderBLL Rbll = new ReminderBLL();
        MsgBox msg = new MsgBox();  
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Activity a = new Activity();
            a.Title = txtTitleActivitys.Text;
            a.Info = txtDescripstion.Text;
            a.RegDate = DateTime.Now;
            msg.MyShowDialog("", ABll.Create(a, user, customer, activityCategory), "", false, false);
            if (cbActivity.Checked)
            {
                Reminder reminder = new Reminder();
                reminder.Title = txtNameAc.Text;
                reminder.ReminderInfo = txtDescripstion.Text;
                reminder.RegDate = DateTime.Now;
                reminder.RemindDate = txtDateTimeActivitys.Value.Date;
                msg.MyShowDialog("", Rbll.Create(r: reminder, u: user), "", false, false);
            }
            int count = ABll.UpdateActivitysCount();
            label7.Text = count.ToString();
            FillDatagrid();
            clearTxtbox();
        }

        private void frmActivitys_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection phone = new AutoCompleteStringCollection();
            foreach (var item in CBll.ReadPhoneNumbers()) 
            {
               phone.Add(item);
            }
            txtPhoneNumberSerching.AutoCompleteCustomSource = phone;                      
            AutoCompleteStringCollection names = new AutoCompleteStringCollection();
            foreach (var item in UBll.ReadUserNames())
            {
                names.Add(item);
            }
            txtNameUserSerching.AutoCompleteCustomSource = names;                        
            AutoCompleteStringCollection Acnames = new AutoCompleteStringCollection();
            foreach (var item in AcBll.ActivityCategoryReadUserNamesList())
            {
                Acnames.Add(item);
            }
            txtNameAc.AutoCompleteCustomSource = Acnames;
            int count = ABll.UpdateActivitysCount();
            label7.Text = count.ToString();
            FillDatagrid();
        }

        private void pbInsertCustomer_Click(object sender, EventArgs e)
        {
            customer = CBll.ReadByPhone(txtPhoneNumberSerching.Text);
            txtPhoneNumberSerching.Enabled = false;
        }

        private void pbInsertUser_Click(object sender, EventArgs e)
        {
            user = UBll.ReadN(txtNameUserSerching.Text);
            txtNameUserSerching.Enabled = false;
        }

        private void pbInsertActivitys_Click(object sender, EventArgs e)
        {
            activityCategory = AcBll.ReadByName(txtNameAc.Text);
            txtNameAc.Enabled = false;
        }
        int id = 0; 
        private void dgvActivty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position.X,Cursor.Position.Y); 
            id = Convert.ToInt32(dgvActivty.Rows[dgvActivty.CurrentRow.Index].Cells["id"].Value.ToString());
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msg.MyShowDialog("", ABll.Delete(id: id), "", false, false);
            FillDatagrid();
        }

        private void جزئیاتنمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
           msg.MyShowDialog("", ABll.ReadByInfo(id), "", false, false);
        }

        private void txtSerch_TextChanged(object sender, EventArgs e)
        {
            dgvActivty.DataSource = null;
            dgvActivty.DataSource = ABll.Read(txtSerch.Text);
            dgvActivty.Columns["id"].Visible = false;
        }

        
    }
}
