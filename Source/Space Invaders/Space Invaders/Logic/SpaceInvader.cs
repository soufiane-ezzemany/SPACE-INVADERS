﻿using Space_Invaders.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    /// <summary>
    /// Classe Jeu
    /// </summary>
    /// <author> Soufiane Ezzemany</author>
    public class SpaceInvader : IUTGame.Game
    {
        private Player spaceship;
        private GamePageWindow gameWindow;
        public static int numInvaders = 36;
        public static int score = 0;
        public SpaceInvader(Canvas canvas, GamePageWindow gameWindow) : base(canvas, "Sprites", "Sounds")
        {
            this.gameWindow = gameWindow;
        }
        /// <summary>
        /// Initialise les items
        /// </summary>
        /// <author> Soufiane Ezzemany et Ismail MESROUK</author>
        protected override void InitItems()
        {
            double y = 500;
            double x = 500;
            spaceship = new Player(x, y, Canvas, this);
            AddItem(spaceship);
            //Ajout des blocs
            AddBlocs();
            //Ajout des aliens
            AddAliens();
        }

        /// <summary>
        /// Initialisation Blocs
        /// </summary>
        /// <author>Ismail MESROUK</author>
        private void AddBlocs()
        {
            Bloc b = new Bloc(150, 460, Canvas, this);
            Bloc b1 = new Bloc(500, 460, Canvas, this);
            Bloc b2 = new Bloc(850, 460, Canvas, this);

            AddItem(b);
            AddItem(b1);
            AddItem(b2);
        }

        /// <summary>
        /// Initialisation des aliens
        /// </summary>
        /// <author>Ismail MESROUK</author>
        private void AddAliens()
        {
            for(int i=1; i <= 12; i++)
            {
                AddItem(new AlienRed(30 +i*80, 110, Canvas, this));
                AddItem(new AlienBlue(30+ i*80, 165, Canvas, this));
                AddItem(new AlienGreen(30+ i*80, 220, Canvas, this));
            }
        }

        /// <summary>
        /// Gére quand on perd
        /// </summary>
        /// <author> Soufiane Ezzemany </author>
        protected override void RunWhenLoose()
        {       
            //afficher la fenetre de perte
            GameLooseWindow looseWindow = new GameLooseWindow(score);
            looseWindow.Show();
            //fermer la page de jeu
            gameWindow.Close();
        }

        /// <summary>
        /// Gère quand on gagne
        /// </summary>
        /// <author> Soufiane Ezzemany </author>
        protected override void RunWhenWin()
        {   
            //afficher la page ge gagne
            GameWinWindow gamewin = new GameWinWindow(score);
            gamewin.Show();
            //fermer la page de jeu
            gameWindow.Close();
        }
    }
}
