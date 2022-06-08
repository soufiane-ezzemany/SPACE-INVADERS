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
using System.Windows.Shapes;

namespace Space_Invaders.View
{
    /// <summary>
    /// Logique d'interaction pour PauseGameWindow.xaml
    /// </summary>
    public partial class PauseGameWindow : Window
    {
        SpaceInvader jeu;
        public PauseGameWindow(SpaceInvader jeu)
        {
            InitializeComponent();
            this.jeu = jeu;
            DataContext = this.jeu;
        }
        /// <summary>
        /// Retour au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <author> John Gaudry</author>
        private void Menu(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// Pour continuer le jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <author>Soufiane EZZEMANY</author>
        private void Retour(object sender, RoutedEventArgs e)
        {
            jeu.Resume();
            this.Close();
        }
    }
}
