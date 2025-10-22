using BE;
using BLL;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pharmacy_project_PL
{
    public partial class frmProductManagment : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmProductManagment()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion

        }
         ProductBLL bll = new ProductBLL();
        MsgBox msg = new MsgBox();  
        void FillDatagrid()
        {
            DgvProduct.DataSource = null;
            DgvProduct.DataSource = bll.Read();
            DgvProduct.Columns["id"].Visible = false;
        }
        void clearTxtbox()
        {
            TxtNameProduct.Text = "";
            TxtPriceProduct.Text = "";
            txtStock.Text = "";
            TxtSerche.Text = "";
        }

        int id = 0;
        private bool decimalEntered;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Name = TxtNameProduct.Text;
            p.Price = Convert.ToDouble(TxtPriceProduct.Text);
            p.Stock = Convert.ToInt16(txtStock.Text);
            p.RegDate = DateTime.Now;
            if (btnInsert.ButtonText == "ثبت اطلاعات")
            {
                //MessageBox.Show(bll.Create(p));
                msg.MyShowDialog("ثبت",bll.Create(p), "", false, false);
            }
            else
            {
                //MessageBox.Show(bll.Update(p,id));
                msg.MyShowDialog("ویرایش",bll.Update(p, id), "", false, false);
                btnInsert.ButtonText = "ثبت اطلاعات";
            }
            int count = bll.UpdateProductCount();
            lblCountCustomer.Text = count.ToString();
            FillDatagrid();
            clearTxtbox();

        }

        private void TxtNameProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtPriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtPriceProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtPriceProduct.Text.Length > 0)
                {
                    TxtPriceProduct.TextChanged -= TxtPriceProduct_TextChanged;
                    TxtPriceProduct.Text = TxtPriceProduct.Text.Replace(",", "");
                    TxtPriceProduct.Text = String.Format("{0:N0}", long.Parse(TxtPriceProduct.Text));
                    TxtPriceProduct.TextChanged += TxtPriceProduct_TextChanged;
                    TxtPriceProduct.SelectionStart = TxtPriceProduct.Text.Length;
                }
            }
            catch { }
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p = bll.Read(id);
            TxtNameProduct.Text = p.Name;
            TxtPriceProduct.Text = Convert.ToString(p.Price);
            txtStock.Text = Convert.ToString(p.Stock);
            btnInsert.ButtonText = "ویرایش اطلاعات";
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = msg.MyShowDialog("اخطار", "آیا می خواهید محصول مورد نظر را پاک کنید؟", "", true, false);
            if (dr == DialogResult.Yes)
            {
              msg.MyShowDialog("حذف",bll.Delete(id),"",false,false); 
            }
            FillDatagrid();
        }

        private void DgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            id = Convert.ToInt32(DgvProduct.Rows[DgvProduct.CurrentRow.Index].Cells["id"].Value.ToString());
        }

        private void TxtSerche_TextChanged(object sender, EventArgs e)
        {
            DgvProduct.DataSource = null;
            DgvProduct.DataSource = bll.Read(TxtSerche.Text);
            DgvProduct.Columns["id"].Visible = false;
        }

        private void frmProductManagment_Load(object sender, EventArgs e)
        {
            int count = bll.UpdateProductCount();
            lblCountCustomer.Text = count.ToString();
            FillDatagrid();
        }

        
    }
}
