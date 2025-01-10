using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //banka bakiyeleri
            var ziraatBankasi = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var isBankasi = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakifBank = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();

            lbl_İsBankasi.Text = isBankasi.ToString() + " ₺";
            lbl_ZiraatBankasi.Text = ziraatBankasi.ToString() + " ₺";
            lbl_Vakifbank.Text = vakifBank.ToString() + " ₺";

            //banka hareketleri
            var bankProcesses1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lbl_BankProcess1.Text = $"{ bankProcesses1.Description} {bankProcesses1.Amount} {bankProcesses1.ProcessDate?.ToString("dd/MM/yyyy")}";

            var bankProcesses2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lbl_BankProcess2.Text = $"{bankProcesses2.Description} {bankProcesses2.Amount} {bankProcesses2.ProcessDate?.ToString("dd/MM/yyyy")}";

            var bankProcesses3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lbl_BankProcess3.Text = $"{bankProcesses3.Description} {bankProcesses3.Amount} {bankProcesses3.ProcessDate?.ToString("dd/MM/yyyy")}";

            var bankProcesses4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lbl_BankProcess4.Text = $"{bankProcesses4.Description} {bankProcesses4.Amount} {bankProcesses4.ProcessDate?.ToString("dd/MM/yyyy")}";

            var bankProcesses5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lbl_BankProcess5.Text = $"{bankProcesses5.Description} {bankProcesses5.Amount} {bankProcesses5.ProcessDate?.ToString("dd/MM/yyyy")}";

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmBanks_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }
    }
}
