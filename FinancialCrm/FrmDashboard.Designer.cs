namespace FinancialCrm
{
    partial class FrmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.lbl_LastTransfer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_BillAmount = new System.Windows.Forms.Label();
            this.lbl_BillTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_TotalBalance = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Users = new System.Windows.Forms.Button();
            this.btn_BankProcesses = new System.Windows.Forms.Button();
            this.btn_Billing = new System.Windows.Forms.Button();
            this.btn_Spending = new System.Windows.Forms.Button();
            this.btn_BanksForm = new System.Windows.Forms.Button();
            this.btn_Categories = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_LastTransfer
            // 
            this.lbl_LastTransfer.AutoSize = true;
            this.lbl_LastTransfer.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_LastTransfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_LastTransfer.Location = new System.Drawing.Point(37, 45);
            this.lbl_LastTransfer.Name = "lbl_LastTransfer";
            this.lbl_LastTransfer.Size = new System.Drawing.Size(122, 49);
            this.lbl_LastTransfer.TabIndex = 3;
            this.lbl_LastTransfer.Text = "0.00 ₺";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gelen Son Havale";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.lbl_LastTransfer);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(760, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(209, 141);
            this.panel5.TabIndex = 8;
            // 
            // lbl_BillAmount
            // 
            this.lbl_BillAmount.AutoSize = true;
            this.lbl_BillAmount.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_BillAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_BillAmount.Location = new System.Drawing.Point(31, 45);
            this.lbl_BillAmount.Name = "lbl_BillAmount";
            this.lbl_BillAmount.Size = new System.Drawing.Size(122, 49);
            this.lbl_BillAmount.TabIndex = 3;
            this.lbl_BillAmount.Text = "0.00 ₺";
            // 
            // lbl_BillTitle
            // 
            this.lbl_BillTitle.AutoSize = true;
            this.lbl_BillTitle.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_BillTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_BillTitle.Location = new System.Drawing.Point(3, 0);
            this.lbl_BillTitle.Name = "lbl_BillTitle";
            this.lbl_BillTitle.Size = new System.Drawing.Size(121, 24);
            this.lbl_BillTitle.TabIndex = 3;
            this.lbl_BillTitle.Text = "Fatura Başlığı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.panel4.Controls.Add(this.lbl_BillAmount);
            this.panel4.Controls.Add(this.lbl_BillTitle);
            this.panel4.Location = new System.Drawing.Point(516, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 141);
            this.panel4.TabIndex = 9;
            // 
            // lbl_TotalBalance
            // 
            this.lbl_TotalBalance.AutoSize = true;
            this.lbl_TotalBalance.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TotalBalance.Location = new System.Drawing.Point(29, 45);
            this.lbl_TotalBalance.Name = "lbl_TotalBalance";
            this.lbl_TotalBalance.Size = new System.Drawing.Size(122, 49);
            this.lbl_TotalBalance.TabIndex = 3;
            this.lbl_TotalBalance.Text = "0.00 ₺";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(143)))), ((int)(((byte)(179)))));
            this.panel3.Controls.Add(this.lbl_TotalBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(269, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 141);
            this.panel3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Bakiyem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard / Genel Bakış Formu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 36);
            this.panel2.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(632, 300);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Faturalar";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(337, 299);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(269, 212);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(337, 69);
            this.panel6.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bankalar ve Hesaplardaki Para Miktarlarına Aşağıdaki \r\nGrafikten Ulaşabilirsiniz " +
    "";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(632, 212);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(337, 69);
            this.panel7.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 34);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ödenen ve Ödenmesi Gereken Fatura Tutarlarına \r\nAşağıdaki Grafikten Ulaşabilirsin" +
    "iz";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(269, 300);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(337, 299);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(7)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_Users);
            this.panel1.Controls.Add(this.btn_BankProcesses);
            this.panel1.Controls.Add(this.btn_Billing);
            this.panel1.Controls.Add(this.btn_Spending);
            this.panel1.Controls.Add(this.btn_BanksForm);
            this.panel1.Controls.Add(this.btn_Categories);
            this.panel1.Location = new System.Drawing.Point(1, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 604);
            this.panel1.TabIndex = 13;
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Logout.Location = new System.Drawing.Point(11, 430);
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
            this.btn_Users.Location = new System.Drawing.Point(11, 368);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Size = new System.Drawing.Size(207, 40);
            this.btn_Users.TabIndex = 0;
            this.btn_Users.Text = "Ayarlar";
            this.btn_Users.UseVisualStyleBackColor = true;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
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
            // btn_Spending
            // 
            this.btn_Spending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Spending.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Spending.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Spending.Location = new System.Drawing.Point(11, 190);
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
            this.btn_BanksForm.Location = new System.Drawing.Point(11, 133);
            this.btn_BanksForm.Name = "btn_BanksForm";
            this.btn_BanksForm.Size = new System.Drawing.Size(207, 40);
            this.btn_BanksForm.TabIndex = 0;
            this.btn_BanksForm.Text = "Bankalar";
            this.btn_BanksForm.UseVisualStyleBackColor = true;
            this.btn_BanksForm.Click += new System.EventHandler(this.btn_BanksForm_Click);
            // 
            // btn_Categories
            // 
            this.btn_Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Categories.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Categories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Categories.Location = new System.Drawing.Point(11, 78);
            this.btn_Categories.Name = "btn_Categories";
            this.btn_Categories.Size = new System.Drawing.Size(207, 40);
            this.btn_Categories.TabIndex = 0;
            this.btn_Categories.Text = "Kategoriler";
            this.btn_Categories.UseVisualStyleBackColor = true;
            this.btn_Categories.Click += new System.EventHandler(this.btn_Categories_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Formu";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_LastTransfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_BillAmount;
        private System.Windows.Forms.Label lbl_BillTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_TotalBalance;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.Button btn_BankProcesses;
        private System.Windows.Forms.Button btn_Billing;
        private System.Windows.Forms.Button btn_Spending;
        private System.Windows.Forms.Button btn_BanksForm;
        private System.Windows.Forms.Button btn_Categories;
    }
}

