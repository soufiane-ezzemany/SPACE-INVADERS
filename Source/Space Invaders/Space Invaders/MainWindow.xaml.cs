using Space_Invaders.Logic;
using Space_Invaders.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Space_Invaders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SpaceInvader jeu;
        private GamePageWindow gamePage;
        public MainWindow()
        {
            InitializeComponent();

            //Creation d'une page pour le jeu
            gamePage = new GamePageWindow();
            //Initialisation du jeu
            jeu = new SpaceInvader(gamePage.Canvas);
            jeu.PlayBackgroundMusic("opening.mp3");
            this.highscoreLabel.Content = "highscore : " + SpaceInvader.score;
            DataContext = jeu;
        }
        /// <summary>
        /// Lancer le jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <author>Soufiane EZZEMANY</author>
        private void PlayGame(object sender, RoutedEventArgs e)
        {
            //Lancer le jeu
            jeu.Run();
            gamePage.Show();
            
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
