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
    public partial class frmlogin : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmlogin()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));   // Design Form
            #endregion

        }
        Timer t1= new Timer();  
        Timer t2 = new Timer(); 
        Timer t3 = new Timer(); 
        UserBLL Ubll = new UserBLL();  
        List<string> usernames = new List<string>();    
        RegisterAdmin r = new RegisterAdmin();
        LoginUC l = new LoginUC(); 
        public void LoadLoginForm()
        {
            t3.Enabled = true;
            t3.Interval = 1;
            t3.Tick += Timer3_Tick;
            t3.Start();
        }
        bool _IsRegistered;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            lblLoad.Visible = true;
            t1.Enabled = true;
            t1.Interval = 15;
            t1.Tick += Timer_Tick;
            t1.Start();
            this.Controls.Add(r);
            this.Controls["RegisterAdmin"].Location = new Point(233,547);
            this.Controls.Add(l);
            this.Controls["LoginUC"].Location = new Point(233, 547);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBarX1.Value>=100) 
            { 
                t1.Stop();  
                progressBarX1.Visible = false;
                lblLoad.Visible=false;
                lblWelcome.Visible = true;
                t2.Enabled = true;
                t2.Interval = 1;
                t2.Tick += Timer2_Tick;
                t2.Start();
            }
            else if(progressBarX1.Value==50)               
            {
                _IsRegistered = Ubll.IsRegistered();
                progressBarX1.Value++;
            }
            else
            {
                progressBarX1.Value++;
            }
        }
        int y = 214;
        int y2 = 8;
        int y3 = 8;
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (lblWelcome.Location.Y >= 45)
            {
                y = y - 15;
                y2 = y2 - -8;
                lblWelcome.Location = new Point(340, y);
                if (_IsRegistered)
                {
                    this.Controls["LoginUC"].Location = new Point(273, y);
                }
                else
                {
                    this.Controls["RegisterAdmin"].Location = new Point(233, y2);
                }

            }
            else
            {
                t2.Stop();
                btnInsert.Visible = true;
            }
        }
        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (this.Controls["LoginUC"].Location.Y >= 100)
            {
                y3 = y3 - 15;
                this.Controls["LoginUC"].Location = new Point(273, y);
            }
            else
            {
                t3.Stop();
            }                                
        }
    }
}
