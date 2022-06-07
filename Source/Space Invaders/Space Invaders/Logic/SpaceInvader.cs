using Space_Invaders.View;
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
        public SpaceInvader(Canvas canvas) : base(canvas, "Sprites", "Sounds")
        {

        }
        /// <summary>
        /// Initialise les items
        /// </summary>
        /// <author> Soufiane Ezzemany et Ismail MESROUK</author>
        protected override void InitItems()
        {
            double y = 500;
            double x = 500;
            Player spaceship = new Player(x, y, Canvas, this);
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
            GameLooseWindow looseWindow = new GameLooseWindow();
            looseWindow.Show();
        }

        /// <summary>
        /// Gère quand on gagne
        /// </summary>
        /// <author> Soufiane Ezzemany </author>
        protected override void RunWhenWin()
        {
            GameWinWindow gamewin = new GameWinWindow();
            gamewin.Show();
        }
    }
}
