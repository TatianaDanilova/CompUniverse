﻿using System;
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
    /// Логика взаимодействия для MotherBoard.xaml
    /// </summary>
    public partial class MotherBoard : Window
    {
        public MotherBoard()
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
