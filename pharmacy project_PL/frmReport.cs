using BE;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace pharmacy_project_PL
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        UserBLL ubll = new UserBLL();
        CustomerBLL Cbll = new CustomerBLL();

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {

            if (RBCustomerList.Checked)
            {
                StiReport sti = new StiReport();
                sti.Load(@"G:\پروزه ها\pharmacy project\CustomerReport.mrt");
                sti.Render();
                sti.Show();
            }
            else if (RBActivitys.Checked)
            {
                StiReport sti = new StiReport();
                sti.Load(@"G:\پروزه ها\pharmacy project\ActivitiesReport.mrt");
                sti.Render();
                sti.Show();
            }
            else if (RbInvoicesOldWeek.Checked)
            {
                StiReport sti = new StiReport();
                sti.Load(@"G:\پروزه ها\pharmacy project\InvoiceReportWeekOld.mrt");
                sti.Render();
                sti.Show();
            }
            else if (RBListOldMonth.Checked)
            {
                StiReport sti = new StiReport();
                sti.Load(@"G:\پروزه ها\pharmacy project\InvoicesReportLastMonth.mrt");
                sti.Render();
                sti.Show();
            }
            else if (RBListOldYear.Checked)
            {
                StiReport sti = new StiReport();
                sti.Load(@"G:\پروزه ها\pharmacy project\InvoiceReportYearOld.mrt");
                sti.Render();
                sti.Show();
            }


        }

        private void btnShowReportResultDisigning_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            if (RBSellsUser.Checked)
            {

                foreach (var item in ubll.ReadInvoicesList())
                {
                    int x = 0;
                    foreach (var i in item.Invoices)
                    {
                        if (i.RegDate.Date > dateTimeInput1.Value.Date && i.RegDate.Date < dateTimeInput2.Value.Date)
                        {
                            x++;
                        }
                    }
                    chart1.Series["Series1"].Points.AddXY(item.Name, x);
                }
            }
            if (radioButton6.Checked)
            {
                List<Customer> cust = new List<Customer>();
                Customer c = new Customer();
                cust.Add(c);
                DateTime fromdate = dateTimeInput2.Value.Date;
                DateTime todate = dateTimeInput1.Value.Date;
                chart1.Series["Series1"].Points.AddXY(" تعداد مشتریان ثبت نام شده از تاریخ " + fromdate.ToString() + " تا تاریخ " + todate.ToString(), Cbll.CustomerCount(fromdate, todate));
            }
            if (radioButton7.Checked)
            {
                foreach (var pointdata in ChartViewModel.GetChartDataForUserActivities(ubll.ReadActivity(), dateTimeInput1.Value, dateTimeInput2.Value))
                {
                    chart1.Series["Series1"].Points.AddXY(pointdata.name, pointdata.count);
                }
            }
        }
        
        private void btnPrintReportDate_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                StiReport sti = new StiReport();
                sti.Load(@"G:\پروزه ها\pharmacy project\CustomerReport.mrt");
                sti.Render();
                sti.Show();
            }
            else if (radioButton7.Checked)
            {
                StiReport sti = new StiReport();
                sti.Load(@"G:\پروزه ها\pharmacy project\ActivitysUserReport.mrt");
                sti.Render();
                sti.Show();
            }
            else if (RBSellsUser.Checked)
            {
                StiReport sti = new StiReport();
                sti.Load(@"G:\پروزه ها\pharmacy project\UserSell.mrt");
                sti.Render();
                sti.Show();
            }
        }
    }
}
