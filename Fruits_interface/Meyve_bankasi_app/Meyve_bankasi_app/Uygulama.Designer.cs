namespace Meyve_bankasi_app
{
    partial class Uygulama
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Employee_update = new System.Windows.Forms.Button();
            this.btn_tp1_Clean = new System.Windows.Forms.Button();
            this.txt_Employee_Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Employee_eject = new System.Windows.Forms.Button();
            this.txt_employee_salary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_employee_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Employee_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployee_name_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Employee_add = new System.Windows.Forms.Button();
            this.dgv_Employees = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_fruits_eject = new System.Windows.Forms.Button();
            this.btn_fruits_quality_check = new System.Windows.Forms.Button();
            this.dgv_fruits = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_fruits_purchase_price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fruits_amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_quality = new System.Windows.Forms.ComboBox();
            this.btn_fruits_add = new System.Windows.Forms.Button();
            this.btn_Seller_update = new System.Windows.Forms.Button();
            this.btn_tp3_clean = new System.Windows.Forms.Button();
            this.txt_Seller_Id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Seller_eject = new System.Windows.Forms.Button();
            this.txt_Seller_Phone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Seller_Mail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Seller_name_surname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Seller_add = new System.Windows.Forms.Button();
            this.dgv_seller = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employees)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fruits)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seller)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 531);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Employee_update);
            this.tabPage1.Controls.Add(this.btn_tp1_Clean);
            this.tabPage1.Controls.Add(this.txt_Employee_Id);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btn_Employee_eject);
            this.tabPage1.Controls.Add(this.txt_employee_salary);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_employee_phone);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_Employee_email);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtEmployee_name_surname);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_Employee_add);
            this.tabPage1.Controls.Add(this.dgv_Employees);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1059, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Çalışan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Employee_update
            // 
            this.btn_Employee_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Employee_update.Location = new System.Drawing.Point(222, 314);
            this.btn_Employee_update.Name = "btn_Employee_update";
            this.btn_Employee_update.Size = new System.Drawing.Size(88, 44);
            this.btn_Employee_update.TabIndex = 14;
            this.btn_Employee_update.Text = "Çalışan Güncelle";
            this.btn_Employee_update.UseVisualStyleBackColor = false;
            this.btn_Employee_update.Click += new System.EventHandler(this.btn_Employee_update_Click);
            // 
            // btn_tp1_Clean
            // 
            this.btn_tp1_Clean.BackColor = System.Drawing.Color.Silver;
            this.btn_tp1_Clean.Location = new System.Drawing.Point(22, 438);
            this.btn_tp1_Clean.Name = "btn_tp1_Clean";
            this.btn_tp1_Clean.Size = new System.Drawing.Size(88, 44);
            this.btn_tp1_Clean.TabIndex = 13;
            this.btn_tp1_Clean.Text = "Temizle";
            this.btn_tp1_Clean.UseVisualStyleBackColor = false;
            this.btn_tp1_Clean.Click += new System.EventHandler(this.btn_tp1_Clean_Click);
            // 
            // txt_Employee_Id
            // 
            this.txt_Employee_Id.Location = new System.Drawing.Point(141, 102);
            this.txt_Employee_Id.Name = "txt_Employee_Id";
            this.txt_Employee_Id.Size = new System.Drawing.Size(169, 22);
            this.txt_Employee_Id.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tc Kimlik No:";
            // 
            // btn_Employee_eject
            // 
            this.btn_Employee_eject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Employee_eject.Location = new System.Drawing.Point(128, 314);
            this.btn_Employee_eject.Name = "btn_Employee_eject";
            this.btn_Employee_eject.Size = new System.Drawing.Size(88, 44);
            this.btn_Employee_eject.TabIndex = 10;
            this.btn_Employee_eject.Text = "Çalışan çıkar";
            this.btn_Employee_eject.UseVisualStyleBackColor = false;
            this.btn_Employee_eject.Click += new System.EventHandler(this.btn_Employee_eject_Click);
            // 
            // txt_employee_salary
            // 
            this.txt_employee_salary.Location = new System.Drawing.Point(141, 262);
            this.txt_employee_salary.Name = "txt_employee_salary";
            this.txt_employee_salary.Size = new System.Drawing.Size(169, 22);
            this.txt_employee_salary.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maaş:";
            // 
            // txt_employee_phone
            // 
            this.txt_employee_phone.Location = new System.Drawing.Point(141, 201);
            this.txt_employee_phone.Name = "txt_employee_phone";
            this.txt_employee_phone.Size = new System.Drawing.Size(169, 22);
            this.txt_employee_phone.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon:";
            // 
            // txt_Employee_email
            // 
            this.txt_Employee_email.Location = new System.Drawing.Point(141, 149);
            this.txt_Employee_email.Name = "txt_Employee_email";
            this.txt_Employee_email.Size = new System.Drawing.Size(169, 22);
            this.txt_Employee_email.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // txtEmployee_name_surname
            // 
            this.txtEmployee_name_surname.Location = new System.Drawing.Point(141, 52);
            this.txtEmployee_name_surname.Name = "txtEmployee_name_surname";
            this.txtEmployee_name_surname.Size = new System.Drawing.Size(169, 22);
            this.txtEmployee_name_surname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad:";
            // 
            // btn_Employee_add
            // 
            this.btn_Employee_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Employee_add.Location = new System.Drawing.Point(34, 314);
            this.btn_Employee_add.Name = "btn_Employee_add";
            this.btn_Employee_add.Size = new System.Drawing.Size(88, 44);
            this.btn_Employee_add.TabIndex = 1;
            this.btn_Employee_add.Text = "Çalışan ekle";
            this.btn_Employee_add.UseVisualStyleBackColor = false;
            this.btn_Employee_add.Click += new System.EventHandler(this.btn_Employee_add_Click);
            // 
            // dgv_Employees
            // 
            this.dgv_Employees.AllowUserToAddRows = false;
            this.dgv_Employees.AllowUserToDeleteRows = false;
            this.dgv_Employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employees.Location = new System.Drawing.Point(408, 6);
            this.dgv_Employees.Name = "dgv_Employees";
            this.dgv_Employees.ReadOnly = true;
            this.dgv_Employees.RowHeadersWidth = 51;
            this.dgv_Employees.RowTemplate.Height = 24;
            this.dgv_Employees.Size = new System.Drawing.Size(648, 490);
            this.dgv_Employees.TabIndex = 0;
            this.dgv_Employees.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Employees_CellEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_fruits_eject);
            this.tabPage2.Controls.Add(this.btn_fruits_quality_check);
            this.tabPage2.Controls.Add(this.dgv_fruits);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1059, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Meyve";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_fruits_eject
            // 
            this.btn_fruits_eject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_fruits_eject.Location = new System.Drawing.Point(3, 22);
            this.btn_fruits_eject.Name = "btn_fruits_eject";
            this.btn_fruits_eject.Size = new System.Drawing.Size(333, 44);
            this.btn_fruits_eject.TabIndex = 31;
            this.btn_fruits_eject.Text = "Meyve Çıkar";
            this.btn_fruits_eject.UseVisualStyleBackColor = false;
            this.btn_fruits_eject.Click += new System.EventHandler(this.btn_fruits_eject_Click);
            // 
            // btn_fruits_quality_check
            // 
            this.btn_fruits_quality_check.BackColor = System.Drawing.Color.Blue;
            this.btn_fruits_quality_check.Location = new System.Drawing.Point(720, 22);
            this.btn_fruits_quality_check.Name = "btn_fruits_quality_check";
            this.btn_fruits_quality_check.Size = new System.Drawing.Size(333, 44);
            this.btn_fruits_quality_check.TabIndex = 30;
            this.btn_fruits_quality_check.Text = "Meyve Kontrol";
            this.btn_fruits_quality_check.UseVisualStyleBackColor = false;
            this.btn_fruits_quality_check.Click += new System.EventHandler(this.btn_fruits_quality_check_Click);
            // 
            // dgv_fruits
            // 
            this.dgv_fruits.AllowUserToAddRows = false;
            this.dgv_fruits.AllowUserToDeleteRows = false;
            this.dgv_fruits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fruits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fruits.Location = new System.Drawing.Point(6, 72);
            this.dgv_fruits.Name = "dgv_fruits";
            this.dgv_fruits.ReadOnly = true;
            this.dgv_fruits.RowHeadersWidth = 51;
            this.dgv_fruits.RowTemplate.Height = 24;
            this.dgv_fruits.Size = new System.Drawing.Size(1047, 421);
            this.dgv_fruits.TabIndex = 15;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txt_fruits_purchase_price);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txt_fruits_amount);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cmb_quality);
            this.tabPage3.Controls.Add(this.btn_fruits_add);
            this.tabPage3.Controls.Add(this.btn_Seller_update);
            this.tabPage3.Controls.Add(this.btn_tp3_clean);
            this.tabPage3.Controls.Add(this.txt_Seller_Id);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.btn_Seller_eject);
            this.tabPage3.Controls.Add(this.txt_Seller_Phone);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txt_Seller_Mail);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txt_Seller_name_surname);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.btn_Seller_add);
            this.tabPage3.Controls.Add(this.dgv_seller);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1059, 502);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Satıcı";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Tl";
            // 
            // txt_fruits_purchase_price
            // 
            this.txt_fruits_purchase_price.Location = new System.Drawing.Point(158, 438);
            this.txt_fruits_purchase_price.Name = "txt_fruits_purchase_price";
            this.txt_fruits_purchase_price.Size = new System.Drawing.Size(144, 22);
            this.txt_fruits_purchase_price.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "kg";
            // 
            // txt_fruits_amount
            // 
            this.txt_fruits_amount.Location = new System.Drawing.Point(158, 369);
            this.txt_fruits_amount.Name = "txt_fruits_amount";
            this.txt_fruits_amount.Size = new System.Drawing.Size(144, 22);
            this.txt_fruits_amount.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Miktar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Kalite";
            // 
            // cmb_quality
            // 
            this.cmb_quality.FormattingEnabled = true;
            this.cmb_quality.Items.AddRange(new object[] {
            "Cherry 1",
            "Cherry 2",
            "Cherry Rainier",
            "Cherry Wax Black",
            "Cherry Wax Red",
            "Cherry Wax Yellow"});
            this.cmb_quality.Location = new System.Drawing.Point(158, 301);
            this.cmb_quality.Name = "cmb_quality";
            this.cmb_quality.Size = new System.Drawing.Size(144, 24);
            this.cmb_quality.TabIndex = 31;
            // 
            // btn_fruits_add
            // 
            this.btn_fruits_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_fruits_add.Location = new System.Drawing.Point(29, 290);
            this.btn_fruits_add.Name = "btn_fruits_add";
            this.btn_fruits_add.Size = new System.Drawing.Size(88, 44);
            this.btn_fruits_add.TabIndex = 30;
            this.btn_fruits_add.Text = "Meyve Ekle";
            this.btn_fruits_add.UseVisualStyleBackColor = false;
            this.btn_fruits_add.Click += new System.EventHandler(this.btn_fruits_add_Click);
            // 
            // btn_Seller_update
            // 
            this.btn_Seller_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Seller_update.Location = new System.Drawing.Point(214, 195);
            this.btn_Seller_update.Name = "btn_Seller_update";
            this.btn_Seller_update.Size = new System.Drawing.Size(88, 44);
            this.btn_Seller_update.TabIndex = 29;
            this.btn_Seller_update.Text = "Satıcı Güncelle";
            this.btn_Seller_update.UseVisualStyleBackColor = false;
            this.btn_Seller_update.Click += new System.EventHandler(this.btn_Seller_update_Click);
            // 
            // btn_tp3_clean
            // 
            this.btn_tp3_clean.BackColor = System.Drawing.Color.Silver;
            this.btn_tp3_clean.Location = new System.Drawing.Point(14, 438);
            this.btn_tp3_clean.Name = "btn_tp3_clean";
            this.btn_tp3_clean.Size = new System.Drawing.Size(88, 44);
            this.btn_tp3_clean.TabIndex = 28;
            this.btn_tp3_clean.Text = "Temizle";
            this.btn_tp3_clean.UseVisualStyleBackColor = false;
            this.btn_tp3_clean.Click += new System.EventHandler(this.btn_tp3_clean_Click);
            // 
            // txt_Seller_Id
            // 
            this.txt_Seller_Id.Location = new System.Drawing.Point(133, 56);
            this.txt_Seller_Id.Name = "txt_Seller_Id";
            this.txt_Seller_Id.Size = new System.Drawing.Size(169, 22);
            this.txt_Seller_Id.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tc Kimlik No:";
            // 
            // btn_Seller_eject
            // 
            this.btn_Seller_eject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Seller_eject.Location = new System.Drawing.Point(120, 195);
            this.btn_Seller_eject.Name = "btn_Seller_eject";
            this.btn_Seller_eject.Size = new System.Drawing.Size(88, 44);
            this.btn_Seller_eject.TabIndex = 25;
            this.btn_Seller_eject.Text = "Satıcı Çıkar";
            this.btn_Seller_eject.UseVisualStyleBackColor = false;
            this.btn_Seller_eject.Click += new System.EventHandler(this.btn_Seller_eject_Click);
            // 
            // txt_Seller_Phone
            // 
            this.txt_Seller_Phone.Location = new System.Drawing.Point(133, 155);
            this.txt_Seller_Phone.Name = "txt_Seller_Phone";
            this.txt_Seller_Phone.Size = new System.Drawing.Size(169, 22);
            this.txt_Seller_Phone.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Telefon:";
            // 
            // txt_Seller_Mail
            // 
            this.txt_Seller_Mail.Location = new System.Drawing.Point(133, 103);
            this.txt_Seller_Mail.Name = "txt_Seller_Mail";
            this.txt_Seller_Mail.Size = new System.Drawing.Size(169, 22);
            this.txt_Seller_Mail.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 19;
            this.label14.Text = "Email:";
            // 
            // txt_Seller_name_surname
            // 
            this.txt_Seller_name_surname.Location = new System.Drawing.Point(133, 6);
            this.txt_Seller_name_surname.Name = "txt_Seller_name_surname";
            this.txt_Seller_name_surname.Size = new System.Drawing.Size(169, 22);
            this.txt_Seller_name_surname.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "Ad Soyad:";
            // 
            // btn_Seller_add
            // 
            this.btn_Seller_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Seller_add.Location = new System.Drawing.Point(29, 195);
            this.btn_Seller_add.Name = "btn_Seller_add";
            this.btn_Seller_add.Size = new System.Drawing.Size(88, 44);
            this.btn_Seller_add.TabIndex = 16;
            this.btn_Seller_add.Text = "Satıcı Ekle";
            this.btn_Seller_add.UseVisualStyleBackColor = false;
            this.btn_Seller_add.Click += new System.EventHandler(this.btn_Seller_add_Click);
            // 
            // dgv_seller
            // 
            this.dgv_seller.AllowUserToAddRows = false;
            this.dgv_seller.AllowUserToDeleteRows = false;
            this.dgv_seller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_seller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_seller.Location = new System.Drawing.Point(400, 6);
            this.dgv_seller.Name = "dgv_seller";
            this.dgv_seller.ReadOnly = true;
            this.dgv_seller.RowHeadersWidth = 51;
            this.dgv_seller.RowTemplate.Height = 24;
            this.dgv_seller.Size = new System.Drawing.Size(648, 490);
            this.dgv_seller.TabIndex = 15;
            this.dgv_seller.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_seller_CellEnter);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(12, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(88, 44);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Uygulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1083, 581);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.tabControl1);
            this.Name = "Uygulama";
            this.Text = "Meyve Bankası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employees)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fruits)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_Employees;
        private System.Windows.Forms.TextBox txtEmployee_name_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Employee_add;
        private System.Windows.Forms.TextBox txt_employee_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Employee_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_employee_salary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Employee_eject;
        private System.Windows.Forms.TextBox txt_Employee_Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_tp1_Clean;
        private System.Windows.Forms.Button btn_Employee_update;
        private System.Windows.Forms.DataGridView dgv_fruits;
        private System.Windows.Forms.Button btn_fruits_quality_check;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Seller_update;
        private System.Windows.Forms.Button btn_tp3_clean;
        private System.Windows.Forms.TextBox txt_Seller_Id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Seller_eject;
        private System.Windows.Forms.TextBox txt_Seller_Phone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Seller_Mail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Seller_name_surname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Seller_add;
        private System.Windows.Forms.DataGridView dgv_seller;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_fruits_eject;
        private System.Windows.Forms.Button btn_fruits_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_quality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fruits_amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_fruits_purchase_price;
        private System.Windows.Forms.Label label10;
    }
}

