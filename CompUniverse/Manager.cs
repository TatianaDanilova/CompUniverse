using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CompUniverse
{
    internal class Manager
    {
        string connectionString = "Data Source=DESKTOP-4HJV1J2;Initial Catalog=CompUniverse;Integrated Security=True";

        public void AddProduct(string product, int price)

        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("AddProduct", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@product", System.Data.SqlDbType.NVarChar, 100));
                    cmd.Parameters.Add(new SqlParameter("@price", System.Data.SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@id_user", System.Data.SqlDbType.Int));
                    cmd.Parameters["@product"].Value = product;
                    cmd.Parameters["@price"].Value = price;
                    cmd.Parameters["@id_user"].Value = AppSettings.UserId;

                    cmd.ExecuteNonQuery();
                }
                try
                {
                    MessageBox.Show("Вы успешно добавили товар в корзину");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");

                }
            }
        }
    }
}
