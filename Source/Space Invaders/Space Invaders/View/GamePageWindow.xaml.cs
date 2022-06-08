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
    /// Logique d'interaction pour GamePageWindow.xaml
    /// </summary>
    public partial class GamePageWindow : Window
    {
        public GamePageWindow()
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
            PauseGameWindow pause = new PauseGameWindow();
            pause.Show();
        }
    }
}
