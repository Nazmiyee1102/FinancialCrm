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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FormClean()
        {
            txt_id.Clear();
            txt_Name.Clear();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;

            Categories categories = new Categories
            {
                CategoryName = name,
            };
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi!", "Kategori İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
            FormClean();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            var categories = db.Categories.Find(id);
            db.Categories.Remove(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi", "Silme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
            FormClean();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            var categories = db.Categories.Find(id);
            categories.CategoryId = int.Parse(txt_id.Text);
            categories.CategoryName = txt_Name.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi", "Güncelleme İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
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

        private void btn_BankProcesses_Click(object sender, EventArgs e)
        {
            BankProcessForm frmBankProcess = new BankProcessForm();
            frmBankProcess.Show();
            this.Hide();
        }

        private void btn_Users_Click_1(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }
    }
}
