namespace CarRentAdmin
{
    partial class MainAdmin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LbTransaksi = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LbEmployee = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LbMember = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnManUser = new System.Windows.Forms.Button();
            this.BtnManMobil = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.BtnManCustomer = new System.Windows.Forms.Button();
            this.BtnManIden = new System.Windows.Forms.Button();
            this.BtnOption = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customersTableAdapter1 = new CarRentAdmin.DBRentSystemDataSet1TableAdapters.customersTableAdapter();
            this.usersTableAdapter1 = new CarRentAdmin.DBRentSystemDataSet1TableAdapters.usersTableAdapter();
            this.transactionsTableAdapter1 = new CarRentAdmin.DBRentSystemDataSet1TableAdapters.transactionsTableAdapter();
            this.PanelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(267, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 16);
            this.panel4.TabIndex = 2;
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.Controls.Add(this.chart2);
            this.PanelDesktop.Controls.Add(this.panel7);
            this.PanelDesktop.Controls.Add(this.panel6);
            this.PanelDesktop.Controls.Add(this.panel5);
            this.PanelDesktop.Controls.Add(this.chart1);
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(267, 78);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(800, 476);
            this.PanelDesktop.TabIndex = 3;
            this.PanelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDesktop_Paint_1);
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(-290, -124);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PaleGreen;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.LbTransaksi);
            this.panel7.Location = new System.Drawing.Point(390, 29);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(149, 100);
            this.panel7.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transaksi";
            // 
            // LbTransaksi
            // 
            this.LbTransaksi.AutoSize = true;
            this.LbTransaksi.Location = new System.Drawing.Point(27, 18);
            this.LbTransaksi.Name = "LbTransaksi";
            this.LbTransaksi.Size = new System.Drawing.Size(86, 17);
            this.LbTransaksi.TabIndex = 2;
            this.LbTransaksi.Text = "LbTransaksi";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Khaki;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.LbEmployee);
            this.panel6.Location = new System.Drawing.Point(203, 29);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(149, 100);
            this.panel6.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Karyawan";
            // 
            // LbEmployee
            // 
            this.LbEmployee.AutoSize = true;
            this.LbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmployee.Location = new System.Drawing.Point(32, 18);
            this.LbEmployee.Name = "LbEmployee";
            this.LbEmployee.Size = new System.Drawing.Size(86, 17);
            this.LbEmployee.TabIndex = 1;
            this.LbEmployee.Text = "LbEmployee";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.LbMember);
            this.panel5.Location = new System.Drawing.Point(23, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 100);
            this.panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelanggan";
            // 
            // LbMember
            // 
            this.LbMember.AutoSize = true;
            this.LbMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMember.Location = new System.Drawing.Point(35, 18);
            this.LbMember.Name = "LbMember";
            this.LbMember.Size = new System.Drawing.Size(75, 17);
            this.LbMember.TabIndex = 0;
            this.LbMember.Text = "LbMember";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(23, 164);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(287, 239);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TbTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(267, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 62);
            this.panel3.TabIndex = 1;
            // 
            // TbTitle
            // 
            this.TbTitle.AutoSize = true;
            this.TbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTitle.Location = new System.Drawing.Point(16, 19);
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(76, 26);
            this.TbTitle.TabIndex = 4;
            this.TbTitle.Text = "LbTitle";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 118);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRATOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnManUser
            // 
            this.BtnManUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManUser.Location = new System.Drawing.Point(0, 118);
            this.BtnManUser.Name = "BtnManUser";
            this.BtnManUser.Size = new System.Drawing.Size(267, 41);
            this.BtnManUser.TabIndex = 1;
            this.BtnManUser.Text = "Manajemen User";
            this.BtnManUser.UseVisualStyleBackColor = true;
            this.BtnManUser.Click += new System.EventHandler(this.BtnManUser_Click);
            // 
            // BtnManMobil
            // 
            this.BtnManMobil.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManMobil.Location = new System.Drawing.Point(0, 159);
            this.BtnManMobil.Name = "BtnManMobil";
            this.BtnManMobil.Size = new System.Drawing.Size(267, 41);
            this.BtnManMobil.TabIndex = 2;
            this.BtnManMobil.Text = "Manajemen Mobil";
            this.BtnManMobil.UseVisualStyleBackColor = true;
            this.BtnManMobil.Click += new System.EventHandler(this.BtnManMobil_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHistory.Location = new System.Drawing.Point(0, 200);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(267, 41);
            this.BtnHistory.TabIndex = 3;
            this.BtnHistory.Text = "Riwayat Transaksi";
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // BtnManCustomer
            // 
            this.BtnManCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManCustomer.Location = new System.Drawing.Point(0, 241);
            this.BtnManCustomer.Name = "BtnManCustomer";
            this.BtnManCustomer.Size = new System.Drawing.Size(267, 41);
            this.BtnManCustomer.TabIndex = 4;
            this.BtnManCustomer.Text = "Manajemen Pelanggan";
            this.BtnManCustomer.UseVisualStyleBackColor = true;
            this.BtnManCustomer.Click += new System.EventHandler(this.BtnManCustomer_Click);
            // 
            // BtnManIden
            // 
            this.BtnManIden.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManIden.Location = new System.Drawing.Point(0, 282);
            this.BtnManIden.Name = "BtnManIden";
            this.BtnManIden.Size = new System.Drawing.Size(267, 41);
            this.BtnManIden.TabIndex = 5;
            this.BtnManIden.Text = "Manajemen Tipe Identitas";
            this.BtnManIden.UseVisualStyleBackColor = true;
            this.BtnManIden.Click += new System.EventHandler(this.BtnManIden_Click);
            // 
            // BtnOption
            // 
            this.BtnOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOption.Location = new System.Drawing.Point(0, 323);
            this.BtnOption.Name = "BtnOption";
            this.BtnOption.Size = new System.Drawing.Size(267, 41);
            this.BtnOption.TabIndex = 6;
            this.BtnOption.Text = "Pengaturan";
            this.BtnOption.UseVisualStyleBackColor = true;
            this.BtnOption.Click += new System.EventHandler(this.BtnOption_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogout.Location = new System.Drawing.Point(0, 364);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(267, 41);
            this.BtnLogout.TabIndex = 7;
            this.BtnLogout.Text = "Log Out";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnOption);
            this.panel1.Controls.Add(this.BtnManIden);
            this.panel1.Controls.Add(this.BtnManCustomer);
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Controls.Add(this.BtnManMobil);
            this.panel1.Controls.Add(this.BtnManUser);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 554);
            this.panel1.TabIndex = 0;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // transactionsTableAdapter1
            // 
            this.transactionsTableAdapter1.ClearBeforeFill = true;
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainAdmin";
            this.Text = "MainAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_close_click);
            this.Load += new System.EventHandler(this.MainAdmin_Load);
            this.PanelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbTransaksi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbEmployee;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbMember;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnManUser;
        private System.Windows.Forms.Button BtnManMobil;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.Button BtnManCustomer;
        private System.Windows.Forms.Button BtnManIden;
        private System.Windows.Forms.Button BtnOption;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Panel panel1;
        private DBRentSystemDataSet1TableAdapters.customersTableAdapter customersTableAdapter1;
        private DBRentSystemDataSet1TableAdapters.usersTableAdapter usersTableAdapter1;
        private DBRentSystemDataSet1TableAdapters.transactionsTableAdapter transactionsTableAdapter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label TbTitle;
    }
}