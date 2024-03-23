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
    /// Логика взаимодействия для Processor.xaml
    /// </summary>
    public partial class Processor : Window
    {
        public Processor()
        {
            InitializeComponent();
        }

        private void ToVideoCard(object sender, RoutedEventArgs e)
        {
            VideoCard videocard = new VideoCard();
            videocard.Show();
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

        private void ToCooling(object sender, RoutedEventArgs e)
        {
            Cooling cooling = new Cooling();
            cooling.Show();
            this.Hide();
        }
    }
}
