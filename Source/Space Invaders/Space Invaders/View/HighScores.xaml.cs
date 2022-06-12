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
    /// Logique d'interaction pour HighScores.xaml
    /// </summary>
    public partial class HighScores : Window
    {
        public HighScores()
        {
            InitializeComponent();
            mots.Items.Add("hola");
            mots.Items.Add("kali");
            mots.Items.Add("tora");
            mots.Items.Add("bora");
        }
    }
}
