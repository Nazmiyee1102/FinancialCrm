namespace FinancialCrm
{
    partial class UsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Users = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btn_BankProcesses = new System.Windows.Forms.Button();
            this.btn_Billing = new System.Windows.Forms.Button();
            this.btn_BanksForm = new System.Windows.Forms.Button();
            this.btn_Categories = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_Users);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.btn_BankProcesses);
            this.panel1.Controls.Add(this.btn_Billing);
            this.panel1.Controls.Add(this.btn_BanksForm);
            this.panel1.Controls.Add(this.btn_Categories);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 604);
            this.panel1.TabIndex = 3;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(702, 279);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(240, 45);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Yenile";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(458, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txt_userName
            // 
            this.txt_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.txt_userName.Location = new System.Drawing.Point(702, 151);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(240, 45);
            this.txt_userName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(492, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni Şifre  :";
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.txt_newPassword.Location = new System.Drawing.Point(702, 215);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.Size = new System.Drawing.Size(240, 45);
            this.txt_newPassword.TabIndex = 6;
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Logout.Location = new System.Drawing.Point(21, 454);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(207, 40);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Çıkış Yap";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Users
            // 
            this.btn_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Users.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Users.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Users.Location = new System.Drawing.Point(21, 219);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Size = new System.Drawing.Size(207, 40);
            this.btn_Users.TabIndex = 2;
            this.btn_Users.Text = "Harcamalar";
            this.btn_Users.UseVisualStyleBackColor = true;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Dashboard.Location = new System.Drawing.Point(21, 398);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(207, 40);
            this.btn_Dashboard.TabIndex = 3;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btn_BankProcesses
            // 
            this.btn_BankProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BankProcesses.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_BankProcesses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BankProcesses.Location = new System.Drawing.Point(21, 337);
            this.btn_BankProcesses.Name = "btn_BankProcesses";
            this.btn_BankProcesses.Size = new System.Drawing.Size(207, 40);
            this.btn_BankProcesses.TabIndex = 4;
            this.btn_BankProcesses.Text = "Banka Hareketleri";
            this.btn_BankProcesses.UseVisualStyleBackColor = true;
            this.btn_BankProcesses.Click += new System.EventHandler(this.btn_BankProcesses_Click);
            // 
            // btn_Billing
            // 
            this.btn_Billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Billing.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Billing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Billing.Location = new System.Drawing.Point(21, 283);
            this.btn_Billing.Name = "btn_Billing";
            this.btn_Billing.Size = new System.Drawing.Size(207, 40);
            this.btn_Billing.TabIndex = 5;
            this.btn_Billing.Text = "Faturalar";
            this.btn_Billing.UseVisualStyleBackColor = true;
            this.btn_Billing.Click += new System.EventHandler(this.btn_Billing_Click);
            // 
            // btn_BanksForm
            // 
            this.btn_BanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BanksForm.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_BanksForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BanksForm.Location = new System.Drawing.Point(21, 161);
            this.btn_BanksForm.Name = "btn_BanksForm";
            this.btn_BanksForm.Size = new System.Drawing.Size(207, 40);
            this.btn_BanksForm.TabIndex = 6;
            this.btn_BanksForm.Text = "Bankalar";
            this.btn_BanksForm.UseVisualStyleBackColor = true;
            this.btn_BanksForm.Click += new System.EventHandler(this.btn_BanksForm_Click);
            // 
            // btn_Categories
            // 
            this.btn_Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Categories.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Categories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Categories.Location = new System.Drawing.Point(21, 106);
            this.btn_Categories.Name = "btn_Categories";
            this.btn_Categories.Size = new System.Drawing.Size(207, 40);
            this.btn_Categories.TabIndex = 7;
            this.btn_Categories.Text = "Kategoriler";
            this.btn_Categories.UseVisualStyleBackColor = true;
            this.btn_Categories.Click += new System.EventHandler(this.btn_Categories_Click_1);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1134, 584);
            this.Controls.Add(this.txt_newPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ayarları";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_newPassword;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_BankProcesses;
        private System.Windows.Forms.Button btn_Billing;
        private System.Windows.Forms.Button btn_BanksForm;
        private System.Windows.Forms.Button btn_Categories;
    }
}