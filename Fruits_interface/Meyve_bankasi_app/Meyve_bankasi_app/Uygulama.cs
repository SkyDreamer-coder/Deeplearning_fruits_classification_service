using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Meyve_bankasi_app
{
    public partial class Uygulama : Form
    {
        public Uygulama()
        {
            InitializeComponent();
            Database db = new Database("Data Source=HOPE;Initial Catalog=Fruits_app;Integrated Security=True");
            db.Connect();
        }

        #region clean buttons
        private void clean()
        {
            txtEmployee_name_surname.Clear();
            txt_Employee_Id.Clear();
            txt_Employee_email.Clear();
            txt_employee_phone.Clear();
            txt_employee_salary.Clear();

            txt_Seller_Id.Clear();
            txt_Seller_name_surname.Clear();
            txt_Seller_Mail.Clear();
            txt_Seller_Phone.Clear();
        }

        private void btn_tp3_clean_Click(object sender, EventArgs e)
        {
            clean();
        }
        private void btn_tp1_Clean_Click(object sender, EventArgs e)
        {
            clean();
        }

        #endregion

        #region dgv clicks
        private void dgv_Employees_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_Employee_Id.Text = dgv_Employees.CurrentRow.Cells[0].Value.ToString();
            txtEmployee_name_surname.Text = dgv_Employees.CurrentRow.Cells[1].Value.ToString();
            txt_Employee_email.Text = dgv_Employees.CurrentRow.Cells[2].Value.ToString();
            txt_employee_phone.Text = dgv_Employees.CurrentRow.Cells[3].Value.ToString();
            txt_employee_salary.Text = dgv_Employees.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgv_seller_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_Seller_name_surname.Text = dgv_seller.CurrentRow.Cells[1].Value.ToString();
            txt_Seller_Id.Text = dgv_seller.CurrentRow.Cells[0].Value.ToString();
            txt_Seller_Mail.Text = dgv_seller.CurrentRow.Cells[2].Value.ToString();
            txt_Seller_Phone.Text = dgv_seller.CurrentRow.Cells[3].Value.ToString();
        }

        #endregion

        public static string con = "Data Source=HOPE;Initial Catalog=Fruits_app;Integrated Security=True";
        SqlConnection connection = new SqlConnection(con);
        SqlDataAdapter da_emp, da_sel, da_fruit;
        Employee employee;
        Seller seller;
        Cherry cherry;

        #region get requests
        private void get()
        {
            connection.Open();
            da_emp = new SqlDataAdapter("select * from employees", connection);
            DataTable dataTable_emp = new DataTable();
            da_emp.Fill(dataTable_emp);
            dgv_Employees.DataSource = dataTable_emp;
            connection.Close();

            connection.Open();
            da_sel = new SqlDataAdapter("select * from seller", connection);
            DataTable dataTable_sel = new DataTable();
            da_sel.Fill(dataTable_sel);
            dgv_seller.DataSource = dataTable_sel;
            connection.Close();

            connection.Open();
            da_fruit = new SqlDataAdapter("select *from Cherries",connection);
            DataTable dataTable_fruit = new DataTable();
            da_fruit.Fill(dataTable_fruit);
            dgv_fruits.DataSource = dataTable_fruit;
            connection.Close();
        }

        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            get();
            clean();
        }

        private void btn_Employee_add_Click(object sender, EventArgs e)
        {
            try
            {
                employee = new Employee(txtEmployee_name_surname.Text, Convert.ToInt32(txt_Employee_Id.Text), txt_Employee_email.Text, txt_employee_phone.Text, Convert.ToInt32(txt_employee_salary.Text));
                employee.add();
                clean();
                get();
            }
            catch(Exception ex)
            {
                MessageBox.Show("lütfen bir değer seçiniz" + ex);
            }
            
        }

        private void btn_Employee_eject_Click(object sender, EventArgs e)
        {
            try
            {
                employee = new Employee(txtEmployee_name_surname.Text, Convert.ToInt32(txt_Employee_Id.Text), txt_Employee_email.Text, txt_employee_phone.Text, Convert.ToInt32(txt_employee_salary.Text));
                employee.delete();
                clean();
                get();
            }
            catch(Exception ex)
            {
                MessageBox.Show("lütfen bir değer seçiniz" + ex);
            }
            
        }

        
        private void btn_Employee_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Employee_Id.Text != dgv_Employees.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("id değiştirilemez");
                }
                else
                {
                    employee = new Employee(txtEmployee_name_surname.Text, Convert.ToInt32(txt_Employee_Id.Text), txt_Employee_email.Text, txt_employee_phone.Text, Convert.ToInt32(txt_employee_salary.Text));
                    employee.update();
                    clean();
                    get();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen bir değer seçiniz " + ex);
            }

        }

        private void btn_fruits_quality_check_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera();
            camera.Show();
            this.Hide();
        }

        private void btn_Seller_add_Click(object sender, EventArgs e)
        {
            try
            {
                seller = new Seller(Convert.ToInt32(txt_Seller_Id.Text), txt_Seller_name_surname.Text, txt_Seller_Mail.Text, txt_Seller_Phone.Text);
                seller.add();
                get();
            }
            catch(Exception ex)
            {
                MessageBox.Show("lütfen bir değer seçiniz " + ex);
            }
           
        }

        private void btn_Seller_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Seller_Id.Text != dgv_seller.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("id değiştirilemez");
                }
                else
                {
                    seller = new Seller(Convert.ToInt32(txt_Seller_Id.Text), txt_Seller_name_surname.Text, txt_Seller_Mail.Text, txt_Seller_Phone.Text);
                    seller.update();
                    get();
                    clean();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen bir değer seçiniz " + ex);
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_fruits_eject_Click(object sender, EventArgs e)
        {
            cherry = new Cherry();
            cherry.delete(Convert.ToInt32(dgv_fruits.CurrentRow.Cells[0].Value));
            get();
        }

        private void btn_fruits_add_Click(object sender, EventArgs e)
        {
            cherry = new Cherry(Convert.ToInt32(txt_Seller_Id.Text), Convert.ToDouble(txt_fruits_amount.Text), Convert.ToDouble(txt_fruits_purchase_price.Text), cmb_quality.Text);
            cherry.add();
        }

        private void btn_Seller_eject_Click(object sender, EventArgs e)
        {
            try
            {
                seller = new Seller(Convert.ToInt32(txt_Seller_Id.Text), txt_Seller_name_surname.Text, txt_Seller_Mail.Text, txt_Seller_Phone.Text);
                seller.delete();
                get();
                clean();
            }
            catch(Exception ex)
            {
                MessageBox.Show("lütfen bir değer seçiniz" + ex);
            }
            
        }
    }
}
