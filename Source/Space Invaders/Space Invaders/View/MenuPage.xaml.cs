using Space_Invaders.Logic;
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
    /// Logique d'interaction pour MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {   
        private SpaceInvader jeu;
        private GamePage gamePage;
        public MenuPage()
        {
            InitializeComponent();
            gamePage = new GamePage();
            jeu = new SpaceInvader(gamePage.Canvas);

        }

        private void PlayGame(object sender, RoutedEventArgs e)
        {
                 
            this.NavigationService.Navigate(gamePage);
            jeu.Run();
        }
    }
}
