using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Meyve_bankasi_app
{
    internal class Employee:Iperson
    {

        private string _name_surname;
        private int _id; 
        private string _mail;
        private string _phone;
        private int _salary;

        SqlConnection connection = new SqlConnection(Uygulama.con);
        public Employee(string name_surname, int id, string mail, string phone, int salary)
        {
            _name_surname = name_surname;
            _id= id;
            _mail = mail;
            _phone = phone;
            _salary = salary;
        }

        public void add()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into employees (employee_id,name_surname,email,phone,salary,entry_date) values (@id,@name,@email,@phone,@salary,@entrydate) ", connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@name", _name_surname);
                command.Parameters.AddWithValue("@email", _mail);
                command.Parameters.AddWithValue("@phone", _phone);
                command.Parameters.AddWithValue("@salary", _salary);
                command.Parameters.AddWithValue("@entrydate", DateTime.Now);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("yeni bir çalışan eklendi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("sistemde böyle bir kullanıcı zaten var veya bir hata meydana geldi"+ex.Message.ToString());
            }
        }

        public void delete()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from employees where employee_id=@id", connection);
                command.Parameters.AddWithValue("@id", _id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("ilgili çalışan işten çıkarıldı");
            }
            catch(Exception ex)
            {
                MessageBox.Show("bir hata meydana geldi " + ex.Message.ToString());
            }
        }

        public void update()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update employees set name_surname=@name,email=@email,phone=@phone,salary=@salary,update_date=@date where employee_id = @id", connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@name", _name_surname);
                command.Parameters.AddWithValue("@email", _mail);
                command.Parameters.AddWithValue("@phone", _phone);
                command.Parameters.AddWithValue("@salary", _salary);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("ilgil çalışan bilgileri güncellendi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("bir hata meydana geldi " + ex.Message.ToString());
            }
        }

       
    }
}
