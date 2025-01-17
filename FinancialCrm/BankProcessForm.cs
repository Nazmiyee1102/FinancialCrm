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
    public partial class BankProcessForm : Form
    {
        public BankProcessForm()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FormClean()
        {
            txt_id.Clear();
            txt_Description.Clear();
            txt_Amount.Clear();
        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.Show();
            this.Hide();
        }

        private void BankProcessForm_Load(object sender, EventArgs e)
        {
            cmb_Bank.DataSource = db.Banks.ToList();
            cmb_Bank.DisplayMember = "BankTitle";

            cmb_ProcessType.DataSource = db.BankProcesses.ToList();
            cmb_ProcessType.DisplayMember = "ProcessType";

            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string description = txt_Description.Text;
            int amount = Convert.ToInt32(txt_Amount.Text);
            int bankId = (cmb_Bank.SelectedItem as Banks).BankId;
            string processType = (cmb_ProcessType.SelectedItem as BankProcesses).ProcessType;
            dateTimePicker1.Value = DateTime.Now;

            BankProcesses processes = new BankProcesses
            {
                Description = description,
                Amount = amount,
                BankId = bankId,
                ProcessType = processType,
                ProcessDate = dateTimePicker1.Value
            };
            db.BankProcesses.Add(processes);
            db.SaveChanges();
            MessageBox.Show("İşlem Eklendi!", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
            FormClean();
        }

        private void txt_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            var processes = db.BankProcesses.Find(id);
            processes.BankProcessId = int.Parse(txt_id.Text);
            processes.Description = txt_Description.Text;
            processes.Amount = int.Parse(txt_Amount.Text);
            processes.BankId = (cmb_Bank.SelectedItem as Banks).BankId;
            processes.ProcessType = (cmb_ProcessType.SelectedItem as BankProcesses).ProcessType;
            processes.ProcessDate = dateTimePicker1.Value;
            db.SaveChanges();
            MessageBox.Show("İşlem Güncellendi", "Güncelleme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
            FormClean();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            var processes = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(processes);
            db.SaveChanges();
            MessageBox.Show("İşlem Silindi", "Silme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
            FormClean();
        }

        private void btn_BanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }
        private void btn_Billing_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }
        private void btn_Users_Click_1(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btn_Spending_Click_1(object sender, EventArgs e)
        {
            SpendingsForm frmSpendings = new SpendingsForm();
            frmSpendings.Show();
            this.Hide();
        }
    }
}
