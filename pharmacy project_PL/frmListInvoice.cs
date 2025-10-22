using DevComponents.AdvTree;
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
using System.Windows.Interop;
using Stimulsoft.Report;
using System.Windows.Controls;

namespace pharmacy_project_PL
{
    public partial class frmListInvoice : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmListInvoice()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion

        }
        public User LoggedUser;
        CustomerBLL Cbll = new CustomerBLL();
        Customer c = new Customer();
        ProductBLL Pbll = new ProductBLL();
        List<Product> products = new List<Product>();
        private Product SelectedProduct = new Product();
        Product p = new Product();
        MsgBox msg = new MsgBox();
        InvoiceBLL ibll = new InvoiceBLL();
        bool SaveState = false;// false = Create | true = Update
        void FilldgvProduct1()
        {
            DgvProduct1.DataSource = null;
            DgvProduct1.DataSource = products.ToList();
            DgvProduct1.Columns["id"].Visible = false;
            DgvProduct1.Columns["Stock"].Visible = false;
            DgvProduct1.Columns["DeleteStatus"].Visible = false;
            DgvProduct1.Columns["RegDate"].Visible = false;
            DgvProduct1.Columns["SumPrice"].Visible = false;
            DgvProduct1.Columns["Customer"].Visible = false;
            DgvProduct1.Columns["Name"].HeaderText = "نام محصول";
            DgvProduct1.Columns["Price"].HeaderText = "قیمت محصول";

        }
        void FillDatagrid()
        {
            DgvProduct2.DataSource = null;
            DgvProduct2.DataSource = ibll.Read();
            DgvProduct2.Columns["id"].Visible = false;

        }

        bool valid()
        {
            bool isvalid = true;
            if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("لطفا شماره تماس فرد را انتخاب کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                isvalid = false;
            }
            else if (txtNameProduct.Text == "")
            {
                MessageBox.Show("لطفا نام کالای خریداری شده را انتخاب کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameProduct.Focus();
                isvalid = false;
            }
            return isvalid;
        }

        private void xuiSuperButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListInvoice_Load(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Now.Date.ToString("yyyy/MM/dd");
            AutoCompleteStringCollection phone = new AutoCompleteStringCollection();
            foreach (var item in Cbll.ReadPhoneNumbers())
            {

                phone.Add(item);
            }
            txtPhoneNumber.AutoCompleteCustomSource = phone;
            AutoCompleteStringCollection Names = new AutoCompleteStringCollection();
            foreach (var item in Pbll.ReadByName())
            {
                Names.Add(item);
            }
            txtNameProduct.AutoCompleteCustomSource = Names;
            int count = ibll.UpdateInvoiceCount();
            lblCountInvoices.Text = count.ToString();
            FillDatagrid();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            c = Cbll.ReadByPhone(txtPhoneNumber.Text);
            txtPhoneNumber.Enabled = false;
            lblName.Text = c.Name;
            lblPhoneNumber.Text = c.Phone;
        }
        private void CheckPayment()
        {
            listNameAndPrice.Items.Clear();
            foreach (Product product in products)
            {
                string s = product.Name + " به ارزش " + product.Price.ToString("N0") + "تومان";
                listNameAndPrice.Items.Add(s);
                double sum = 0;
                foreach (var item in products)
                {
                    sum = sum + item.Price;
                }
                lblSumPrice.Text = sum.ToString("N0");
                lblPayable.Text = (sum - Convert.ToDouble(txtCut.Text)).ToString("N0");
            }
        }
        private void btnInsertIsList_Click(object sender, EventArgs e)
        {
            p = Pbll.ReadByNameList(txtNameProduct.Text);
            products.Add(p);
            FilldgvProduct1();
            string s = p.Name + " به ارزش " + p.Price.ToString("N0") + "تومان";
            listNameAndPrice.Items.Add(s);
            CheckPayment();
        }

        private void txtNameProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCut_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnInsertAndPrint_Click_1(object sender, EventArgs e)
        {
            if (valid())
            {
                Invoice invoice = new Invoice();
                invoice.RegDate = DateTime.Now;
                if (cbIsCheckedOut.Checked)
                {
                    invoice.IsCheckedOut = true;
                    invoice.CheckoutDate = DateTime.Now;
                }
                else
                {
                    invoice.IsCheckedOut = false;
                }
                Invoice i = new Invoice();
                i.RegDate = DateTime.Now;
                if (cbIsCheckedOut.Checked)
                {
                    i.IsCheckedOut = true;
                    i.CheckoutDate = DateTime.Now;
                }
                else
                {
                    i.IsCheckedOut = false;
                }
                DialogResult res = MessageBox.Show("از ثبت/ویرایش فاکتور اطمینان دارید", "اطلاعیه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    i.User = LoggedUser;
                    if (!SaveState)
                        ibll.Create(i, c, products);
                    else
                    {
                        i.Customer = c;
                        ibll.Update(i, id, products);//TODO Change Update Code
                        SaveState = false;
                    }
                    StiReport sti = new StiReport();
                    sti.Load(@"G:\پروزه ها\pharmacy project\Report.mrt");
                    sti.Dictionary.Variables["InvoiceNum"].Value = ibll.ReadInvoiceNum();
                    sti.Dictionary.Variables["Date"].Value = lblDatetime.Text;
                    sti.Dictionary.Variables["CustomerName"].Value = lblName.Text;
                    sti.Dictionary.Variables["CustomerPhone"].Value = lblPhoneNumber.Text;
                    sti.RegBusinessObject("Product", products);
                    sti.Render();
                    sti.Show();
                    int count = ibll.UpdateInvoiceCount();
                    lblCountInvoices.Text = count.ToString();
                    FillDatagrid();
                }

            }
        }
        int id = 0;

        private void DgvProduct2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(DgvProduct2.Rows[DgvProduct2.CurrentRow.Index].Cells["id"].Value.ToString());
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آیا میخواهید فاکتور را حذف کنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ibll.Delete(id);
            }
            FillDatagrid();
        }

        private void پرداختشدToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("تسویه حساب انجام شده ؟", "ثبت حساب ها", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                ibll.Done(id);
            }
            FillDatagrid();
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice OldInvoiceData = ibll.ReadFullInvoice(id);
            products.Clear();
            products = OldInvoiceData.Products.ToList();
            FilldgvProduct1();
            txtPhoneNumber.Text = OldInvoiceData.Customer.Phone;
            CheckPayment();
            c = OldInvoiceData.Customer;
            lblName.Text = c.Name;
            lblPhoneNumber.Text = c.Phone;
            //txtPhoneNumber.Text = DgvProduct2.CurrentRow.Cells["شماره تماس"].Value.ToString();
            //txtPhoneNumber.Enabled = false;
            //txtNameProduct.Text = DgvProduct2.CurrentRow.Cells["نام کالا"].Value.ToString();
            SaveState = true;//Go For Update
            btnInsertAndPrint.ButtonText = "ویرایش اطلاعات";
        }


        private void txtSercheNamefactor_TextChanged_1(object sender, EventArgs e)
        {
            DgvProduct2.DataSource = null;
            DgvProduct2.DataSource = ibll.Read(txtSercheNamefactor.Text);
            DgvProduct2.Columns["id"].Visible = false;
        }

        private void DgvProduct1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProduct = Convert.ToInt32(DgvProduct1.Rows[e.RowIndex].Cells["id"].Value);
            SelectedProduct = products.First(i => i.id == idProduct);
            contextMenuStrip2.Show(Cursor.Position);
        }

        private void حذفمحصولازلیستفاکتورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products.Remove(SelectedProduct);
            CheckPayment();
            FilldgvProduct1();
        }
    }
}
