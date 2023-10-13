using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Meyve_bankasi_app
{
    internal class Cherry:Ifruits
    {
        private int _seller_id;
        private double _amount;
        private double _purchase_price;
        private double _sale_price;
        private string _quality;

        SqlConnection connection = new SqlConnection(Uygulama.con);


        public Cherry(int seller_id,double amount, double purchase,string quality)
        {
            this._seller_id = seller_id;
            this._amount = amount;
            this._purchase_price = purchase;
            this._quality = quality;
            this._sale_price = saleCalculate(quality);
        }
        public Cherry() { }

        private double saleCalculate(string quality)
        {
            if (quality=="Cherry 1")
            {
                this._sale_price = this._purchase_price * 1.5;
            }
            else if(quality=="Cherry 2")
            {
                this._sale_price = this._purchase_price * 2;
            }
            else if(quality=="Cherry Rainier")
            {
                this._sale_price = this._purchase_price * 1.3;
            }
            else if (quality=="Cherry Wax Black")
            {
                this._sale_price = this._purchase_price * 0.7;
            }
            else if (quality == "Cherry Wax Black")
            {
                this._sale_price = this._purchase_price * 0.7;
            }
            else if (quality == "Cherry Wax Red")
            {
                this._sale_price = this._purchase_price * 2.5;
            }
            else if (quality == "Cherry Wax Yellow")
            {
                this._sale_price = this._purchase_price * 0.3;
            }
            return this._sale_price;
        }

        public void add()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("exec insert_cherry @id,@amount,@purchase,@sale,@quality", connection);
                command.Parameters.AddWithValue("@id", this._seller_id);
                command.Parameters.AddWithValue("@amount", this._amount);
                command.Parameters.AddWithValue("@purchase", this._purchase_price);
                command.Parameters.AddWithValue("@sale", this._sale_price);
                command.Parameters.AddWithValue("@quality", this._quality);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("yeni bir meyve eklendi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("bir hata meydana geldi " + ex.Message.ToString());
            }
        }
        public void delete(int id) 
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("exec delete_cherry @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("ilgili meyve silindi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("bir hata meydana geldi " + ex.Message.ToString());
            }
        }
        public void update(int id) 
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("exec update_cherry @id,@sel_id,@amount", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@sel_id", this._seller_id);
                command.Parameters.AddWithValue("@amount", this._amount);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("ilgili meyve güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("bir hata meydana geldi " + ex.Message.ToString());

            }
        }
    }
}
