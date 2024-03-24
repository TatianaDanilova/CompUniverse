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
    /// Логика взаимодействия для Cooling.xaml
    /// </summary>
    public partial class Cooling : Window
    {
        public Cooling()
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

        private void ToDisk(object sender, RoutedEventArgs e)
        {
            Disk disk = new Disk();
            disk.Show();
            this.Hide();
        }
        private void Cooling1ToOrder(object sender, RoutedEventArgs e)
        {
            Manager manager = new Manager();
            manager.AddProduct("be quiet! Dark Rock 4 135mm", 65500);
        }
        private void Cooling2ToOrder(object sender, RoutedEventArgs e)
        {
            Manager manager = new Manager();
            manager.AddProduct("be quiet! Pure Rock 2 FX schwarz", 4200);
        }
        private void Cooling3ToOrder(object sender, RoutedEventArgs e)
        {
            Manager manager = new Manager();
            manager.AddProduct("Enermax ETS-F40-ARGB F40 ARGB Edition", 4000);
        }

        private void ToOrder(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }
    }
}
