namespace FinancialCrm
{
    partial class SpendingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpendingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Users = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btn_BankProcesses = new System.Windows.Forms.Button();
            this.btn_Billing = new System.Windows.Forms.Button();
            this.btn_BanksForm = new System.Windows.Forms.Button();
            this.btn_Categories = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(84)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_Users);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.btn_BankProcesses);
            this.panel1.Controls.Add(this.btn_Billing);
            this.panel1.Controls.Add(this.btn_BanksForm);
            this.panel1.Controls.Add(this.btn_Categories);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 604);
            this.panel1.TabIndex = 14;
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
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
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
            this.btn_BankProcesses.Click += new System.EventHandler(this.btn_BankProcesses_Click_1);
            // 
            // btn_Billing
            // 
            this.btn_Billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Billing.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Billing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Billing.Location = new System.Drawing.Point(11, 249);
            this.btn_Billing.Name = "btn_Billing";
            this.btn_Billing.Size = new System.Drawing.Size(207, 40);
            this.btn_Billing.TabIndex = 0;
            this.btn_Billing.Text = "Faturalar";
            this.btn_Billing.UseVisualStyleBackColor = true;
            this.btn_Billing.Click += new System.EventHandler(this.btn_Billing_Click_1);
            // 
            // btn_BanksForm
            // 
            this.btn_BanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BanksForm.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_BanksForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BanksForm.Location = new System.Drawing.Point(11, 188);
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
            this.btn_Categories.Location = new System.Drawing.Point(11, 133);
            this.btn_Categories.Name = "btn_Categories";
            this.btn_Categories.Size = new System.Drawing.Size(207, 40);
            this.btn_Categories.TabIndex = 0;
            this.btn_Categories.Text = "Kategoriler";
            this.btn_Categories.UseVisualStyleBackColor = true;
            this.btn_Categories.Click += new System.EventHandler(this.btn_Categories_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(84)))), ((int)(((byte)(233)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(836, 351);
            this.dataGridView1.TabIndex = 31;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(84)))), ((int)(((byte)(233)))));
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(837, 178);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(171, 53);
            this.btn_Delete.TabIndex = 30;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(84)))), ((int)(((byte)(233)))));
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(930, 104);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(171, 53);
            this.btn_Update.TabIndex = 29;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(84)))), ((int)(((byte)(233)))));
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(739, 104);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(171, 53);
            this.btn_Add.TabIndex = 28;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_id.Location = new System.Drawing.Point(406, 92);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(289, 30);
            this.txt_id.TabIndex = 27;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Amount.Location = new System.Drawing.Point(406, 262);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(289, 30);
            this.txt_Amount.TabIndex = 26;
            this.txt_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amount_KeyPress);
            // 
            // cmb_Category
            // 
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(406, 194);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(289, 33);
            this.cmb_Category.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateTimePicker1.Location = new System.Drawing.Point(878, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(289, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(265, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Harcama Id :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(316, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Miktar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(285, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(725, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "İşlem Tarihi :";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(317, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Başlık :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial Black", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 85);
            this.label1.TabIndex = 15;
            this.label1.Text = "HARCAMALAR SAYFASI";
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Title.Location = new System.Drawing.Point(406, 144);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(289, 30);
            this.txt_Title.TabIndex = 27;
            // 
            // SpendingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(84)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1179, 675);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpendingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harcamalar";
            this.Load += new System.EventHandler(this.SpendingsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_BankProcesses;
        private System.Windows.Forms.Button btn_Billing;
        private System.Windows.Forms.Button btn_BanksForm;
        private System.Windows.Forms.Button btn_Categories;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Title;
    }
}