using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{

    /// <summary>
    /// Classe Alien pour ennemie
    /// </summary>
    /// <author> John Gaudry et Soufiane Ezzemany</author>
    abstract public class Alien : GameItem, IAnimable
    {
        private Canvas canvas;
        private double angle = 0;
        /// <summary>
        /// Constructeur Alien hérité de GameItem
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="canvas"></param>
        /// <param name="game"></param>
        /// <param name="spriteName"></param>
        /// <author> Gaudry John</author>
        protected Alien(double x, double y, Canvas canvas, Game game, string spriteName) : base(x, y, canvas, game, spriteName)
        {

        }

        /// <summary>
        /// Mouvemet des Aliens
        /// </summary>
        /// <param name="dt"></param>
        /// <author>John Gaudry</author>
        public void Animate(TimeSpan dt)
        {
            Random r = new Random();
            int rdm = r.Next(1, 11);

            if(rdm == 6)
            {
                MissileAlien m = new MissileAlien(this.Left + 20, this.Bottom + 5, canvas, this.Game);
                Game.AddItem(m);
            }

            if (Left < 0)
            {
                angle = 0;
                Left = 0;
                MoveXY(0, 5);
                // Rebondir();
            }
            else if (Right > 1200)
            {
                angle = -180;
                Right = 1200;
                MoveXY(0, 5);
            }

            MoveDA(5, angle);

        }


    }
}
