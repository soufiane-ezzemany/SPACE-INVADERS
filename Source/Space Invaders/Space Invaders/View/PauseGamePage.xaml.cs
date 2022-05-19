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
    /// Logique d'interaction pour PauseGamePage.xaml
    /// </summary>
    /// <author>John Gaudry</author>
    public partial class PauseGamePage : Page
    {
        public PauseGamePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Retour au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <author> John Gaudry</author>
        private void Menu(object sender, RoutedEventArgs e)
        {
            while (this.NavigationService.CanGoBack)
            {
                this.NavigationService.RemoveBackEntry();
                this.NavigationService.GoBack();
            }
        }
    }
}
