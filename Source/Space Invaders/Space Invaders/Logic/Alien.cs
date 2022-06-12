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
        }

        public override void CollideEffect(GameItem other)
        {
            
        }

        public void Move(double d)
        {
            MoveDA(4, d);
        }

        public void MoveDown()
        {
            MoveXY(0, 3);
        }

    }
}
