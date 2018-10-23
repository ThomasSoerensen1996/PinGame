using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PinGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int row1 = 1;
        private int row2 = 3;

    
        public MainWindow()
        {
            InitializeComponent();
            row1Textblock.Text = "" + row1;
        }

        private void Row1_Click(object sender, RoutedEventArgs e)
        {
            row1--;
            row1Textblock.Text = ""+row1;
        }

        private void Row2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Row3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Row4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
