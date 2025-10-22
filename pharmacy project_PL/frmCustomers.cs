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
    public partial class frmCustomers : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmCustomers()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion

        }

        CustomerBLL bll = new CustomerBLL();
        MsgBox msg = new MsgBox();
        void FillDatagrid()
        {
            DgvCustomer.DataSource = null;
            DgvCustomer.DataSource = bll.Read();
            DgvCustomer.Columns["id"].Visible = false;
        }
        void clearTxtbox()
        {
            TxtName.Text = "";
            TxtPhon.Text = "";
            TxtSerche.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MainWindow w = (MainWindow)System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault();

            {
                Customer c = new Customer();
                c.Name = TxtName.Text;
                c.Phone = TxtPhon.Text;
                c.RegDate = DateTime.Now;
                if (btnInsert.ButtonText == "ثبت اطلاعات")
                {
                    if (Ubll.Access(w.LoggedInUser, "بخش مشتریان", 2))
                    {   //MessageBox.Show(bll.Create(c));
                        msg.MyShowDialog("ثبت", bll.Create(c), "", false, false);

                    }
                    else
                    {
                        msg.MyShowDialog("محدودیت دسترسی", "اجازه ورود به این بخش را ندارید", "", false, true);
                    }
                }

                else
                {
                    //MessageBox.Show(bll.Update(c, id));
                    msg.MyShowDialog("ویرایش", bll.Update(c, id), "", false, false);
                    btnInsert.ButtonText = "ثبت اطلاعات";
                }
                int count = bll.UpdateCustomerCount();
                lblCountCustomer.Text = count.ToString();
                FillDatagrid();
                clearTxtbox();
                               
            }
           
            

        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtPhon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtSerche_TextChanged(object sender, EventArgs e)
        {
            DgvCustomer.DataSource = null;
            DgvCustomer.DataSource = bll.Read(TxtSerche.Text);
            DgvCustomer.Columns["id"].Visible = false;
        }
       
        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer c = bll.Read(id);
            TxtName.Text = c.Name;
            TxtPhon.Text = c.Phone; 
            btnInsert.ButtonText = "ویرایش اطلاعات";
        }
        int id = 0; 
        UserBLL Ubll = new UserBLL();   
        private void DgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            id = Convert.ToInt32(DgvCustomer.Rows[DgvCustomer.CurrentRow.Index].Cells["id"].Value.ToString());
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = msg.MyShowDialog("اخطار","در صورت حدف مشتری تمام اطلاعات مربوط به آن مشتری حذف خواهد شد آیا قصد حذف مشتری را دارید؟","",true,false);  
            if (dr == DialogResult.Yes)
            {
              msg.MyShowDialog("حذف", bll.Delete(id),"",false,false);
            }
            FillDatagrid();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            FillDatagrid();
            int count = bll.UpdateCustomerCount();
            lblCountCustomer.Text = count.ToString();
        }
        
    }
}
