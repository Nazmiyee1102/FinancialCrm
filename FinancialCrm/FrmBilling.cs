using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FormClean()
        {
            txt_id.Clear();
            txt_Title.Clear();
            txt_Amount.Clear();
            txt_Period.Clear();
        }
        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btn_NewBill_Click(object sender, EventArgs e)
        {
            string title = txt_Title.Text;
            decimal amount = Convert.ToDecimal(txt_Amount.Text);
            string period = txt_Period.Text;

            Bills bill = new Bills
            {
                BillTitle = title,
                BillAmount = amount,
                BillPeriod = period
            };
            db.Bills.Add(bill);
            db.SaveChanges();
            MessageBox.Show("Ödeme İşlemi Başarılı","Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
            FormClean();
        }

        private void btn_DeleteBill_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            var bill = db.Bills.Find(id);
            db.Bills.Remove(bill);
            db.SaveChanges();
            MessageBox.Show("Fatura Silme İşlemi Başarılı", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
            FormClean();
        }

        private void btn_UpdateBill_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            var bill = db.Bills.Find(id);
            bill.BillTitle = txt_Title.Text;
            bill.BillAmount = Convert.ToDecimal(txt_Amount.Text);
            bill.BillPeriod = txt_Period.Text;
            db.SaveChanges();
            MessageBox.Show("Fatura Güncelleme İşlemi Başarılı", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
            FormClean();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        private void btn_Categories_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.Show();
            this.Hide();
        }

        private void btn_Spending_Click(object sender, EventArgs e)
        {
            SpendingsForm frm = new SpendingsForm();
            frm.Show();
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
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btn_BanksForm_Click_1(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btn_Billing_Click_1(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm();
            frm.Show();
            this.Hide();
        }

        private void btn_Logout_Click_1(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }
    }
}
