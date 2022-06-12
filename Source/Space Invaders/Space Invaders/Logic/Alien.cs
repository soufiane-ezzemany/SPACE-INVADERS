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
        private TimeSpan timeToShoot;
        public abstract int Damage { get; }
        /// <summary>
        /// Constructeur Alien hérité de GameItem
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="canvas"></param>
        /// <param name="game"></param>
        /// <param name="spriteName"></param>
        /// <author> Gaudry John et Soufiane Ezzemany et Ismaïl Mesrouk</author>
        public Alien(double x, double y, Canvas canvas, Game game, string spriteName) : base(x, y, canvas, game, spriteName)
        {   
            this.canvas = canvas;
            //Initialisation aléatoire de l'intervalle avant de tirer
            Random r = new Random();
            this.timeToShoot = new TimeSpan(0, 0, r.Next(3,15));
        }

        /// <summary>
        /// Mouvemet des Aliens
        /// </summary>
        /// <param name="dt"></param>
        /// <author>John Gaudry</author>
        public void Animate(TimeSpan dt)
        {
            timeToShoot = timeToShoot - dt;
            if (timeToShoot.TotalMilliseconds < 0)
            {
                // Tir de missile
                MissileAlien b = new MissileAlien(this.Left + 20, this.Bottom + 5, canvas, this.Game);
                Game.AddItem(b);
                // Réinitialisation intervalle de temps
                Random r = new Random();
                int ms = r.Next(5000, 20000);
                timeToShoot = new TimeSpan(0, 0, 0, 0, ms);
            }

            /*if (Left < 0)
            {
                angle = 0;
                Left = 0;
                //MoveXY(0, 5);
            }
            else if (Right > 1200)
            {
                angle = -180;
                Right = 1200;
                //MoveXY(0, 5);
            }

            MoveDA(5, angle);*/

        }

        public override void CollideEffect(GameItem other)
        {
            /*if (other.TypeName == this.TypeName)
            {
                if (angle == 0)
                {
                    angle = -180;
                }
                else
                {
                    angle = 0;
                }
            }*/
        }

        public void Move(double d)
        {
            MoveDA(5, d);
        }

    }
}
