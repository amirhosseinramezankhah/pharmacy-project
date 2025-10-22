using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_project_PL
{
    public partial class frmSetting : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmSetting()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion

        }
        void FillDatagrid()
        {
            dgvActivityCategory.DataSource = null;
            dgvActivityCategory.DataSource = bll.Read();
            dgvActivityCategory.Columns["id"].Visible = false;
        }
        ActivityCategoryBLL bll = new ActivityCategoryBLL();
        MsgBox msg = new MsgBox();  
        private void btnInsert_Click(object sender, EventArgs e)
        {
            ActivityCategory a = new ActivityCategory();
            a.CategoryName = txtCategoryNane.Text;
            msg.MyShowDialog("",bll.Create(a),"",false,false);
            FillDatagrid();
            txtCategoryNane.Text = "";
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            FillDatagrid();
        }
    }
}
