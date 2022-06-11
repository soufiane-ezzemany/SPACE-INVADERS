using Space_Invaders.Logic;
using Space_Invaders.Stockage;
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
        
        public MainWindow()
        {
            InitializeComponent();

            object score = Storage.Recup("ScoreFile");
            if(score != null)
            {
                this.highscoreLabel.Content = "highscore : " + score.ToString();
            }
            else
            {
                this.highscoreLabel.Content = "highscore : " + "0";
            }
        }
        /// <summary>
        /// Lancer le jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <author>Soufiane EZZEMANY</author>
        private void PlayGame(object sender, RoutedEventArgs e)
        {
            GamePageWindow gamePage = new GamePageWindow();
            gamePage.Show();
            this.Close();
            
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

        private void Tutorial(object sender, RoutedEventArgs e)
        {
            Tutorial t = new Tutorial();
            t.Show();
        }
    }
}
