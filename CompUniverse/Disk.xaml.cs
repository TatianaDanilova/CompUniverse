using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Disk.xaml
    /// </summary>
    public partial class Disk : Window
    {
        public Disk()
        {
            InitializeComponent();
        }

        private void ToVideoCard(object sender, RoutedEventArgs e)
        {
            VideoCard videocard = new VideoCard();
            videocard.Show();
            this.Hide();
        }

        private void ToProcessor(object sender, RoutedEventArgs e)
        {
            Processor processor = new Processor();
            processor.Show();
            this.Hide();
        }
        private void ToMotherBoard(object sender, RoutedEventArgs e)
        {
            MotherBoard board = new MotherBoard();
            board.Show();
            this.Hide();
        }
        private void ToMemory(object sender, RoutedEventArgs e)
        {
            Memory memory = new Memory();
            memory.Show();
            this.Hide();
        }

        private void ToCooling(object sender, RoutedEventArgs e)
        {
            Cooling cooling = new Cooling();
            cooling.Show();
            this.Hide();
        }

        private void Disk1ToOrder(object sender, RoutedEventArgs e)
        {
            Manager manager = new Manager();
            manager.AddProduct("WD_BLACK™ SN850X NVMe™ SSD", 16200);
        }
        private void Disk2ToOrder(object sender, RoutedEventArgs e)
        {
            Manager manager = new Manager();
            manager.AddProduct("Seagate FireCuda 530 SSD 2TB", 15100);
        }
        private void Disk3ToOrder(object sender, RoutedEventArgs e)
        {
            Manager manager = new Manager();
            manager.AddProduct("Samsung SSD 990 Pro NVMe M.2 1TB", 10000);
        }

        private void ToOrder(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }
    }
}
