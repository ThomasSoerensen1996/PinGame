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
        private bool isPlayer1 = false;
        private bool gameover = false;
    
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
            Row2.IsEnabled = false;
            Row3.IsEnabled = false;
            Row4.IsEnabled = false;
            if (row1 == 1)
            {
                row1--;
                row1Textblock.Text = "" + row1;
                Row1.IsEnabled = false;
            }
            Gameover();
            GameEnd();

        }

        private void Row2_Click(object sender, RoutedEventArgs e)
        {
            Row1.IsEnabled = false;
            Row3.IsEnabled = false;
            Row4.IsEnabled = false;
            if (row2 > 1)
            {
                row2--;
                row2Textblock.Text = "" + row2;
            }
            else if (row2 == 1)
            {
                row2--;
                row2Textblock.Text = "" + row2;
                Row2.IsEnabled = false;
            }
            Gameover();
            GameEnd();
        }

        private void Row3_Click(object sender, RoutedEventArgs e)
        {
            Row1.IsEnabled = false;
            Row2.IsEnabled = false;
            Row4.IsEnabled = false;
            if (row3 > 1)
            {
                row3--;
                row3Textblock.Text = "" + row3;
            }
            else if (row3 == 1)
            {
                row3--;
                row3Textblock.Text = "" + row3;
                Row3.IsEnabled = false;
            }
            Gameover();
            GameEnd();
        }

        private void Row4_Click(object sender, RoutedEventArgs e)
        {
            Row1.IsEnabled = false;
            Row2.IsEnabled = false;
            Row3.IsEnabled = false;
            if (row4 > 1)
            {
                row4--;
                row4Textblock.Text = "" + row4;
            }
            else if (row4 == 1)
            {
                row4--;
                row4Textblock.Text = "" + row4;
                Row4.IsEnabled = false;
            }
          
            Gameover();
            GameEnd();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isPlayer1)
            {
                PlayerBox.Text = "Player 1";
                isPlayer1 = false;
            }
            else
            {
                PlayerBox.Text = "Player 2";
                isPlayer1 = true;
            }

            if (row1 > 0)
            {
                Row1.IsEnabled = true;
            }

            if (row2 > 0)
            {
                Row2.IsEnabled = true;
            }
            if (row3 > 0)
            {
                Row3.IsEnabled = true;
            }
            if (row4 > 0)
            {
                Row4.IsEnabled = true;
            }
        }

        public void Gameover()
        {
            if (row1 + row2 + row3 + row4 == 1)
            {
                gameover = true;
            }
        }

        public void GameEnd()
        {
            if (gameover == true)
            {
                Row1.IsEnabled = false;
                Row2.IsEnabled = false;
                Row3.IsEnabled = false;
                Row4.IsEnabled = false;
                changePlayer.IsEnabled = false;
                if (isPlayer1)
                {
                    gameEndText.Text = "Game has ended Player 2 wins";
                }
                else 
                {
                    gameEndText.Text = "Game has ended Player 1 wins";
                }

            }
        }

        public void freeze()
        {

        }
    }
}