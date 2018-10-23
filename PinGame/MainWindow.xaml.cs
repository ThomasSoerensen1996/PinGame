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
        private int row3 = 5;
        private int row4 = 7;
    
        public MainWindow()
        {
            InitializeComponent();
            row1Textblock.Text = "" + row1;
            row2Textblock.Text = "" + row2;
            row3Textblock.Text = "" + row3;
            row4Textblock.Text = "" + row4;
        }

        private void Row1_Click(object sender, RoutedEventArgs e)
        {
            row1--;
            row1Textblock.Text = ""+row1;
        }

        private void Row2_Click(object sender, RoutedEventArgs e)
        {
            row2--;
            row2Textblock.Text = "" + row2;
        }

        private void Row3_Click(object sender, RoutedEventArgs e)
        {
            row3--;
            row3Textblock.Text = "" + row3;
        }

        private void Row4_Click(object sender, RoutedEventArgs e)
        {
            row4--;
            row4Textblock.Text = "" + row4;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
