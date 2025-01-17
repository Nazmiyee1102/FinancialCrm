using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lbl_TotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastTransfer = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lbl_LastTransfer.Text = lastTransfer.ToString() + " ₺";

            //chart 1 kodları
            var bankData = db.Banks.Select(x => new 
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            }

            //chart 2 kodları
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
                chart2.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            }
        }


        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1)
            {
                var electricBill = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lbl_BillTitle.Text = "Elektrik Faturası";
                lbl_BillAmount.Text = electricBill.ToString() + " ₺";
            }

            if (count % 4 == 2)
            {
                var gasBill = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lbl_BillTitle.Text = "Doğalgaz Faturası";
                lbl_BillAmount.Text = gasBill.ToString() + " ₺";
            }

            if (count % 4 == 3)
            {
                var waterBill = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lbl_BillTitle.Text = "Su Faturası";
                lbl_BillAmount.Text = waterBill.ToString() + " ₺";
            }

            if (count % 4 == 0)
            {
                var internetBill = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lbl_BillTitle.Text = "İnternet Faturası";
                lbl_BillAmount.Text = internetBill.ToString() + " ₺";
            }
        }

       
        private void btn_Logout_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            FrmDashboard frmDashboard = new FrmDashboard();
            this.Hide();
        }

        private void btn_Banks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();

        }
        private void btn_Categories_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.Show();
            this.Hide();
        }

        private void btn_BanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btn_Spending_Click(object sender, EventArgs e)
        {
            SpendingsForm frm = new SpendingsForm();
            frm.Show();
            this.Hide();
        }

        private void btn_Billing_Click_1(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btn_BankProcesses_Click(object sender, EventArgs e)
        {
            BankProcessForm frm = new BankProcessForm();
            frm.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click_1(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm();
            frm.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }
    }
}
