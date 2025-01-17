namespace FinancialCrm
{
    partial class FrmBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilling));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Period = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_UpdateBill = new System.Windows.Forms.Button();
            this.btn_NewBill = new System.Windows.Forms.Button();
            this.btn_DeleteBill = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Users = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btn_BankProcesses = new System.Windows.Forms.Button();
            this.btn_Spending = new System.Windows.Forms.Button();
            this.btn_BanksForm = new System.Windows.Forms.Button();
            this.btn_Categories = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Period);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_Amount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_Title);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_UpdateBill);
            this.panel2.Controls.Add(this.btn_NewBill);
            this.panel2.Controls.Add(this.btn_DeleteBill);
            this.panel2.Controls.Add(this.btn_list);
            this.panel2.Location = new System.Drawing.Point(256, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 240);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_Period
            // 
            this.txt_Period.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_Period.Location = new System.Drawing.Point(102, 146);
            this.txt_Period.Name = "txt_Period";
            this.txt_Period.Size = new System.Drawing.Size(385, 27);
            this.txt_Period.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Periyot :";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_Amount.Location = new System.Drawing.Point(102, 99);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(385, 27);
            this.txt_Amount.TabIndex = 1;
            this.txt_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar :";
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_Title.Location = new System.Drawing.Point(102, 53);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(385, 27);
            this.txt_Title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Başlık :";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_id.Location = new System.Drawing.Point(102, 14);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(385, 27);
            this.txt_id.TabIndex = 1;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödeme Id :";
            // 
            // btn_UpdateBill
            // 
            this.btn_UpdateBill.BackColor = System.Drawing.Color.Green;
            this.btn_UpdateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateBill.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_UpdateBill.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateBill.Location = new System.Drawing.Point(493, 128);
            this.btn_UpdateBill.Name = "btn_UpdateBill";
            this.btn_UpdateBill.Size = new System.Drawing.Size(284, 40);
            this.btn_UpdateBill.TabIndex = 0;
            this.btn_UpdateBill.Text = "Ödeme Güncelle";
            this.btn_UpdateBill.UseVisualStyleBackColor = false;
            this.btn_UpdateBill.Click += new System.EventHandler(this.btn_UpdateBill_Click);
            // 
            // btn_NewBill
            // 
            this.btn_NewBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_NewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewBill.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_NewBill.ForeColor = System.Drawing.Color.White;
            this.btn_NewBill.Location = new System.Drawing.Point(638, 36);
            this.btn_NewBill.Name = "btn_NewBill";
            this.btn_NewBill.Size = new System.Drawing.Size(139, 40);
            this.btn_NewBill.TabIndex = 0;
            this.btn_NewBill.Text = "Yeni Ödeme";
            this.btn_NewBill.UseVisualStyleBackColor = false;
            this.btn_NewBill.Click += new System.EventHandler(this.btn_NewBill_Click);
            // 
            // btn_DeleteBill
            // 
            this.btn_DeleteBill.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteBill.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteBill.ForeColor = System.Drawing.Color.Transparent;
            this.btn_DeleteBill.Location = new System.Drawing.Point(493, 82);
            this.btn_DeleteBill.Name = "btn_DeleteBill";
            this.btn_DeleteBill.Size = new System.Drawing.Size(284, 40);
            this.btn_DeleteBill.TabIndex = 0;
            this.btn_DeleteBill.Text = "Ödeme Sil";
            this.btn_DeleteBill.UseVisualStyleBackColor = false;
            this.btn_DeleteBill.Click += new System.EventHandler(this.btn_DeleteBill_Click);
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.Color.Purple;
            this.btn_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_list.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_list.ForeColor = System.Drawing.Color.White;
            this.btn_list.Location = new System.Drawing.Point(493, 36);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(139, 40);
            this.btn_list.TabIndex = 0;
            this.btn_list.Text = "Ödeme Listesi";
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(256, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 358);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(785, 358);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(172)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_Users);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.btn_BankProcesses);
            this.panel1.Controls.Add(this.btn_Spending);
            this.panel1.Controls.Add(this.btn_BanksForm);
            this.panel1.Controls.Add(this.btn_Categories);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 604);
            this.panel1.TabIndex = 7;
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Logout.Location = new System.Drawing.Point(11, 486);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(207, 40);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Çıkış Yap";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click_1);
            // 
            // btn_Users
            // 
            this.btn_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Users.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Users.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Users.Location = new System.Drawing.Point(11, 424);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Size = new System.Drawing.Size(207, 40);
            this.btn_Users.TabIndex = 0;
            this.btn_Users.Text = "Ayarlar";
            this.btn_Users.UseVisualStyleBackColor = true;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Dashboard.Location = new System.Drawing.Point(11, 368);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(207, 40);
            this.btn_Dashboard.TabIndex = 0;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click_1);
            // 
            // btn_BankProcesses
            // 
            this.btn_BankProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BankProcesses.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_BankProcesses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BankProcesses.Location = new System.Drawing.Point(11, 308);
            this.btn_BankProcesses.Name = "btn_BankProcesses";
            this.btn_BankProcesses.Size = new System.Drawing.Size(207, 40);
            this.btn_BankProcesses.TabIndex = 0;
            this.btn_BankProcesses.Text = "Banka Hareketleri";
            this.btn_BankProcesses.UseVisualStyleBackColor = true;
            this.btn_BankProcesses.Click += new System.EventHandler(this.btn_BankProcesses_Click);
            // 
            // btn_Spending
            // 
            this.btn_Spending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Spending.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Spending.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Spending.Location = new System.Drawing.Point(10, 246);
            this.btn_Spending.Name = "btn_Spending";
            this.btn_Spending.Size = new System.Drawing.Size(207, 40);
            this.btn_Spending.TabIndex = 0;
            this.btn_Spending.Text = "Harcamalar";
            this.btn_Spending.UseVisualStyleBackColor = true;
            this.btn_Spending.Click += new System.EventHandler(this.btn_Spending_Click);
            // 
            // btn_BanksForm
            // 
            this.btn_BanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BanksForm.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_BanksForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BanksForm.Location = new System.Drawing.Point(10, 189);
            this.btn_BanksForm.Name = "btn_BanksForm";
            this.btn_BanksForm.Size = new System.Drawing.Size(207, 40);
            this.btn_BanksForm.TabIndex = 0;
            this.btn_BanksForm.Text = "Bankalar";
            this.btn_BanksForm.UseVisualStyleBackColor = true;
            this.btn_BanksForm.Click += new System.EventHandler(this.btn_BanksForm_Click_1);
            // 
            // btn_Categories
            // 
            this.btn_Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Categories.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Categories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Categories.Location = new System.Drawing.Point(10, 134);
            this.btn_Categories.Name = "btn_Categories";
            this.btn_Categories.Size = new System.Drawing.Size(207, 40);
            this.btn_Categories.TabIndex = 0;
            this.btn_Categories.Text = "Kategoriler";
            this.btn_Categories.UseVisualStyleBackColor = true;
            this.btn_Categories.Click += new System.EventHandler(this.btn_Categories_Click);
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme & Fatura Formu";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Period;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_UpdateBill;
        private System.Windows.Forms.Button btn_NewBill;
        private System.Windows.Forms.Button btn_DeleteBill;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_BankProcesses;
        private System.Windows.Forms.Button btn_Spending;
        private System.Windows.Forms.Button btn_BanksForm;
        private System.Windows.Forms.Button btn_Categories;
    }
}