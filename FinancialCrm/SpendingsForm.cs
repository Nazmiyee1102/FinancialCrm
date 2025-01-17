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
    public partial class SpendingsForm : Form
    {
        public SpendingsForm()
        {
            InitializeComponent();
        }


        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FormClean()
        {
            txt_id.Clear();
            txt_Title.Clear();
            txt_Amount.Clear();
        }


        private void SpendingsForm_Load(object sender, EventArgs e)
        {
            cmb_Category.DataSource = db.Categories.ToList();
            cmb_Category.DisplayMember = "CategoryName";

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string title = txt_Title.Text;
            int amount = Convert.ToInt32(txt_Amount.Text);
            int categoryId = (cmb_Category.SelectedItem as Categories).CategoryId;
            dateTimePicker1.Value = DateTime.Now;

            Spendings spendings = new Spendings
            {
                SpendingTitle = title,
                SpendingAmount = amount,
                CategoryId = categoryId,
                SpendingDate = dateTimePicker1.Value
            };

            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Harcama Eklendi!", "Harcama İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
            FormClean();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            var spendings = db.Spendings.Find(id);
            spendings.SpendingTitle = txt_Title.Text;
            spendings.SpendingAmount = int.Parse(txt_Amount.Text);
            spendings.CategoryId = (cmb_Category.SelectedItem as Categories).CategoryId;
            spendings.SpendingDate = dateTimePicker1.Value;
            db.SaveChanges();
            MessageBox.Show("Harcama Güncellendi", "Güncelleme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
            FormClean();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            var spendings = db.Spendings.Find(id);
            db.Spendings.Remove(spendings);
            db.SaveChanges();
            MessageBox.Show("Harcama Silindi", "Silme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
            FormClean();
        }
        private void btn_BankProcesses_Click_1(object sender, EventArgs e)
        {
            BankProcessForm bankProcessForm = new BankProcessForm();
            bankProcessForm.Show();
            this.Hide();
        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void btn_BanksForm_Click_1(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btn_Billing_Click_1(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
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
    }
}
