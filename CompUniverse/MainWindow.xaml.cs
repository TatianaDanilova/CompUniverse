using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompUniverse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=DESKTOP-4HJV1J2;Initial Catalog=CompUniverse;Integrated Security=True";

        public int CheckLogin()
        {
            int idUser = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("CheckLogin", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@login_user", System.Data.SqlDbType.NVarChar, 100);
                command.Parameters.Add("@password_user", System.Data.SqlDbType.NVarChar, 100);
                command.Parameters.Add("@id_user", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.Parameters["@login_user"].Value = LoginTextBox.Text;
                command.Parameters["@password_user"].Value = PasswordBox.Password;

                connection.Open();
                command.ExecuteNonQuery();

                object idUserObj = command.Parameters["@id_user"].Value;
                if (idUserObj != DBNull.Value)
                {
                    idUser = Convert.ToInt32(idUserObj);
                }
            }
            return idUser;
        }


        private void RegestratoinButton_Click(object sender, RoutedEventArgs e)
        {
            int userId = CheckLogin();
            if (userId != 0)
            {
                MessageBox.Show("Вы уже зарегестрированы");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("AddUser", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@login_user", System.Data.SqlDbType.NVarChar, 100));
                        cmd.Parameters.Add(new SqlParameter("@password_user", System.Data.SqlDbType.NVarChar, 100));
                        cmd.Parameters["@login_user"].Value = LoginTextBox.Text;
                        cmd.Parameters["@password_user"].Value = PasswordBox.Password;

                        cmd.ExecuteNonQuery();
                    }
                    try
                    {
                        MessageBox.Show("Вы успешно зарегестрировались");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");

                    }   
                }
            }
            
        }

        private void EntrynButton_Click(object sender, RoutedEventArgs e)
        {
            int userId = CheckLogin();
            if (userId != 0)
            {
                AppSettings.UserId = userId;

                VideoCard videocard = new VideoCard();
                videocard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }


        }
    }
}
