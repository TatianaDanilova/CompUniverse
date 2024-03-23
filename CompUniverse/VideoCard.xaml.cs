using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace CompUniverse
{
    /// <summary>
    /// Логика взаимодействия для VideoCard.xaml
    /// </summary>
    public partial class VideoCard : Window
    {
        public int UserId { get; set; }
        string connectionString = "Data Source=DESKTOP-4HJV1J2;Initial Catalog=CompUniverse;Integrated Security=True";


        public VideoCard()
        {
            InitializeComponent();
        }

        

        private void ToProcessor(object sender, RoutedEventArgs e)
        {
            Processor processor= new Processor();
            processor.Show();
            this.Hide();
        }

        private void ToMotherBoard(object sender, RoutedEventArgs e)
        {
            MotherBoard board= new MotherBoard();
            board.Show();
            this.Hide();
        }

        private void ToMemory(object sender, RoutedEventArgs e)
        {
            Memory memory= new Memory();
            memory.Show();
            this.Hide();
        }

        private void ToDisk(object sender, RoutedEventArgs e)
        {
            Disk disk= new Disk();
            disk.Show();
            this.Hide();
        }

        private void ToCooling(object sender, RoutedEventArgs e)
        {
            Cooling cooling= new Cooling();
            cooling.Show();
            this.Hide();
        }

        private void VideoCard1ToOrder(object sender, RoutedEventArgs e)
        {
            Manager manager = new Manager();
            manager.AddProduct(VideoCard1Name.Text, Convert.ToInt32(VideoCard1Price.Text));
        }
        private void VideoCard2ToOrder(object sender, RoutedEventArgs e)
        {
            Manager manager = new Manager();
            manager.AddProduct(VideoCard2Name.Text, Convert.ToInt32(VideoCard2Price.Text));
        }
        private void VideoCard3ToOrder(object sender, RoutedEventArgs e)
        {
            Manager manager = new Manager();
            manager.AddProduct(VideoCard3Name.Text, Convert.ToInt32(VideoCard3Price.Text));
        }

        private void ToOrder(object sender, RoutedEventArgs e)
        {
            Order order= new Order();
            order.Show();
            this.Hide();
        }
    }
}
