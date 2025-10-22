using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Xml.Linq;
using BE;
using BLL;
using HandyControl.Tools;

namespace pharmacy_project_PL
{
    public partial class frmReminders : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmReminders(User user)
        {
            InitializeComponent();
            _user = user;
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public User _user;
        ReminderBLL Rbll = new ReminderBLL();  
        UserBLL Ubll = new UserBLL(); 
        User u = new User();
        MsgBox msg = new MsgBox();
        void FillDatagrid()
        {
            dgvReminder.DataSource = null;
            dgvReminder.DataSource = Rbll.Read();
            dgvReminder.Columns["id"].Visible = false;  
            
        }
        void clearTxtbox()
        {
            txtSerchUser_Name.Text = "";
            txtTitile.Text = "";
            RTBReminderinfo.Text = "";
            dateTimeInput1.Text = "";
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Reminder r = new Reminder();
            r.Title= txtTitile.Text;
            r.ReminderInfo = RTBReminderinfo.Text; 
            r.RegDate = DateTime.Now;   
            r.RemindDate = dateTimeInput1.Value;
            if(btnInsert.ButtonText=="ثبت یادآور")
            {
                //MessageBox.Show(Rbll.Create(r, u));
                msg.MyShowDialog("ثبت", Rbll.Create(r,u), "", false, false);
            }
            else
            {
                //MessageBox.Show(Rbll.Update(r, id));
                msg.MyShowDialog("ویرایش", Rbll.Update(r, id), "", false, false);
                btnInsert.ButtonText ="ثبت یادآور";
            }
            int count = Rbll.UpdateReminderCount(_user.id);
            label7.Text = count.ToString();
            FillDatagrid();
            clearTxtbox();
        }

        private void frmReminders_Load(object sender, EventArgs e)
        {
           AutoCompleteStringCollection names = new AutoCompleteStringCollection();
           foreach(var item in Ubll.ReadUserNames())
            {
                names.Add(item);
            }
            txtSerchUser_Name.AutoCompleteCustomSource = names;
            int count = Rbll.UpdateReminderCount(_user.id);
            label7.Text = count.ToString();
            FillDatagrid();
        }

        private void PBInsertUserName_Click(object sender, EventArgs e)
        {
            txtSerchUser_Name.Enabled = false;  
            u= Ubll.ReadU(txtSerchUser_Name.Text);  
        }
        int id= 0;  
        private void dgvReminder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position.X,Cursor.Position.Y);
            id = Convert.ToInt32(dgvReminder.Rows[dgvReminder.CurrentRow.Index].Cells["id"].Value.ToString());
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reminder r = Rbll.Read(id);
            txtTitile.Text = r.Title;
            RTBReminderinfo.Text = r.ReminderInfo;
            dateTimeInput1.Text = r.RemindDate.ToString();
            btnInsert.ButtonText = "ویرایش اطلاعات";
            FillDatagrid();
        }
        

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = msg.MyShowDialog("اخطار", "آیا می خواهید یادآور مورد نظر را پاک کنید؟", "", true, false);
            if (dr == DialogResult.Yes)
            {
                msg.MyShowDialog("حذف", Rbll.Delete(id), "", false, false);


            }
            FillDatagrid();
        }

        private void txtSerch_TextChanged(object sender, EventArgs e)
        {
            {
                dgvReminder.DataSource = null;
                dgvReminder.DataSource = Rbll.Read(txtSerch.Text);
                dgvReminder.Columns["id"].Visible = false;
            }
        }

        private void انجامشدToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Rbll.Done(id);
        }
    }
}
