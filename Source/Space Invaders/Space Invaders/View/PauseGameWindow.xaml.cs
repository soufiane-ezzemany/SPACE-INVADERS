using Space_Invaders.Logic;
using Space_Invaders.Stockage;
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
        private SpaceInvader jeu;

        public PauseGameWindow(SpaceInvader jeu)
        {
            InitializeComponent();
            this.jeu = jeu;
            this.sliderVolume.Value = jeu.BackgroundVolume;

        }
        /// <summary>
        /// Retour au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <author> John Gaudry et Soufiane EZZEMANY</author>
        private void Menu(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
            jeu.GameWindow.Close();
            jeu.StopBackgroundMusic();
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

        private void SaveVolume(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.jeu.BackgroundVolume = sliderVolume.Value;
            Storage.Save("VolumeFile", this.jeu.BackgroundVolume);

        }
    }
}
