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
            
            //Creation d'une page pour le jeu
            gamePage = new GamePage();
            //Initialisation du jeu
            jeu = new SpaceInvader(gamePage.Canvas);
            //Lancer le jeu
            jeu.Run();

        } 
        /// <summary>
        /// Lancer le jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <author>Soufiane EZZEMANY</author>

        private void PlayGame(object sender, RoutedEventArgs e)
        {
            //Utilisation d'un systeme de navigation de Page    
            this.NavigationService.Navigate(gamePage);
        }
        /// <summary>
        /// Pour fermer le jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <author> Ismaïl Mesrouk </author>
        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
