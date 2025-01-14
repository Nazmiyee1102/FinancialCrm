using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace FinancialCrm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {



        }


        private bool IsPasswordValid(string password)  //şifre doğrulama
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*?&#]{8,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);

        }

        private bool IsUserNameValid(string userName)  //kullanıcı adı doğrulama
        {
            string pattern = @"^[a-zA-Z0-9_.]{5,15}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(userName);
        }

       
        private bool VerifyPassword(string userName, string inputPassword)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=LoginFormDb;Trusted_Connection=True;";
            string query1 = "SELECT Password FROM Tbl_Login WHERE Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query1, connection);
                command.Parameters.AddWithValue("@Password", inputPassword);

                connection.Open();
                string hashedPassword = command.ExecuteScalar()?.ToString();
                connection.Close();
                return false;

            }
            
        }
        
        private bool VerifyUsername(string userName1, string inputUserName1)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=LoginFormDb;Trusted_Connection=True;";
            string query = "SELECT UserName FROM Tbl_Login WHERE UserName = @UserName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", inputUserName1);
                connection.Open();
                string userName2 = command.ExecuteScalar()?.ToString();
                connection.Close();
                return userName1 == inputUserName1;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            

            string password = txt_Password.Text;
            string userName = txt_Username.Text;

            // Kullanıcı adı ve şifre geçerliliği kontrolü
            if (!IsPasswordValid(password) || !IsUserNameValid(userName))
            {
                MessageBox.Show("Şifre veya Kullanıcı Adı geçerli değil. Gereklilikler :\n" +
                    "- Şifre : \n" +
                    "- En az 8 karakter, \n" +
                    "- En az bir büyük harf, \n" +
                    "- En az bir küçük harf, \n" +
                    "- En az bir rakam, \n" +
                    "- En az bir özel karakter içermelidir. \n\n" +
                    "- Kullanıcı Adı : \n" +
                    "- En az 5, en fazla 15 karakter \n" +
                    "- Sadece harfler, sayılar, alt çizgi ve noktadan oluşabilir, \n",
                    "Dikkat!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz.");
            }
            else
            {
                bool isUserValid = VerifyUsername(userName, password);
                bool isPasswordValid = VerifyPassword(userName, password);

               
                    MessageBox.Show("Giriş Başarılı!");

                    FrmDashboard frmDashboard = new FrmDashboard();
                    frmDashboard.Show();

                    // Mevcut formu gizle
                    this.Hide();
               
            }
        }
        
        

        private void pct_Visible_Click(object sender, EventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar)
            {
                // Şifreyi görünür yap
                txt_Password.UseSystemPasswordChar = false;
                pct_Visible.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\visibility.png");
            }
            else
            {
                // Şifreyi gizle
                txt_Password.UseSystemPasswordChar = true;
                pct_Visible.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\visibility_off.png");
            }

        }
    }
}

