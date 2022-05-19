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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Space_Invaders.View
{
    /// <summary>
    /// Logique d'interaction pour GamePage.xaml
    /// </summary>
    /// <author>Soufiane Ezzemany</author>
    public partial class GamePage : Page
    {
        public GamePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet l'ouverture via naviguation de la page Pause
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <author> John Gaudry </author>
        private void PauseSetting(object sender, RoutedEventArgs e)
        {
            PauseGamePage pause = new PauseGamePage();
            this.NavigationService.Navigate(pause);
        }
    }
}
