using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Windows.Shapes;

namespace CompUniverse
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        string connectionString = "Data Source=DESKTOP-4HJV1J2;Initial Catalog=CompUniverse;Integrated Security=True";

        public Order()
        {
            InitializeComponent();
            LoadOrderDetails();
        }
        private void LoadOrderDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("GetOrderDetails", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_user", System.Data.SqlDbType.Int));
                    cmd.Parameters["@id_user"].Value = AppSettings.UserId;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    OrderDetailsGrid.ItemsSource = dataTable.DefaultView;
                    cmd.ExecuteNonQuery();
                }
            }
        }

            private void ToVideoCardClick(object sender, RoutedEventArgs e)
        {
            VideoCard videoCard = new VideoCard();
            videoCard.Show();
            this.Hide();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            string caption = "";
            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show("Вы уверены в том, что хотите выйти?", caption, buttons, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();

            }
        }
    }
}
