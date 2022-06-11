using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Space_Invaders.View
{
    /// <summary>
    /// Logique d'interaction pour GameWinWindow.xaml
    /// </summary>
    public partial class GameWinWindow : Window
    {
        public GameWinWindow(int score)
        {
            InitializeComponent();
            this.scoreLabel.Content = "Score : " + score.ToString();

        }

        private void Menu(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
