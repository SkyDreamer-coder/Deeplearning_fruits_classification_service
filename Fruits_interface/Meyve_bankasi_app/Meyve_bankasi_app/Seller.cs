using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Meyve_bankasi_app
{
    internal class Seller:Iperson
    {

        private int _seller_id;
        private string _seller_name_surname;
        private string _mail;
        private string _phone;

        SqlConnection connection = new SqlConnection(Uygulama.con);
        public Seller(int seller_id, string seller_name_surname, string mail, string phone)
        {
            _seller_id = seller_id;
            _seller_name_surname = seller_name_surname;
            _mail = mail;
            _phone = phone;
        }

        public void add() 
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into seller (seller_id,name_surname,email,phone,entry_date,update_date) values (@id,@name,@mail,@phone,@entry,@update)",connection);
                cmd.Parameters.AddWithValue("@id", _seller_id);
                cmd.Parameters.AddWithValue("@name", _seller_name_surname);
                cmd.Parameters.AddWithValue("@mail", _mail);
                cmd.Parameters.AddWithValue("@phone", _phone);
                cmd.Parameters.AddWithValue("@entry", DateTime.Now);
                cmd.Parameters.AddWithValue("@update", DateTime.Now);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("yeni bir satıcı eklendi ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("sistemde böyle bir kullanıcı zaten var veya bir hata meydana geldi " + ex);
            }
        }
        public void delete()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from seller where seller_id=@id", connection);
                command.Parameters.AddWithValue("@id", _seller_id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("ilgili satıcı işten çıkarıldı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("bir hata meydana geldi " + ex);
            }
        }
        public void update()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update seller set name_surname=@name,email=@mail,phone=@phone,update_date=@date where seller_id=@id", connection);
                command.Parameters.AddWithValue("@id", _seller_id);
                command.Parameters.AddWithValue("@name", _seller_name_surname);
                command.Parameters.AddWithValue("@mail", _mail);
                command.Parameters.AddWithValue("@phone", _phone);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("ilgili satıcı bilgileri güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("id değiştirilemez veya bir hata meydana geldi " );
            }
        }
    }
}
