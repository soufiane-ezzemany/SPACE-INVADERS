using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    /// <summary>
    /// Classe pour les Aliens Verts
    /// </summary>
    /// <AUTHOR>John Gaudry</AUTHOR>
    class AlienGreen : Alien, IAnimable
    {
        private TimeSpan timeToShoot;
        private Canvas canvas;
        /// <summary>
        /// Constructeur d'Alien Verts
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="canvas"></param>
        /// <param name="game"></param>
        /// <param name="spriteName"></param>
        /// /// <AUTHOR>John Gaudry et Soufiane EZZEMANY</AUTHOR>
        public AlienGreen(double x, double y, Canvas canvas, Game game) : base(x, y, canvas, game, "Aliens/alienv.png")
        {
            this.canvas = canvas;
            Random r = new Random();
            this.timeToShoot = new TimeSpan(0, 0, r.Next(3, 15));

        }

        ///<Author>Gaudry John</Author>
        public override string TypeName => "AlienGreen";

        /// <summary>
        /// Score que le Player a lorsqu'il tue un AlienGreen
        /// </summary>
        public override int Damage => 10;

        /// <summary>
        /// Gère le tir et l'intervalle de temps entre chaque tir pour l'AlienGreen 
        /// </summary>
        /// <param name="dt"></param>
        /// <author>John Gaudry</author>
        public void Animate(TimeSpan dt)
        {
            timeToShoot = timeToShoot - dt;
            if (timeToShoot.TotalMilliseconds < 0)
            {
                // Tir de missile
                MissileAlien b = new MissileAlien(this.Left + 20, this.Bottom + 5, canvas, this.Game, "greenLaser.png", 8);
                Game.AddItem(b);
                // Réinitialisation intervalle de temps
                Random r = new Random();
                int ms = r.Next(5000, 15000);
                timeToShoot = new TimeSpan(0, 0, 0, 0, ms);
            }
        }

        public override void CollideEffect(GameItem other)
        {
        }

        public override void Move(double d)
        {
            MoveDA(4, d);
        }

        public override void MoveDown()
        {
            MoveXY(0, 3);
        }
    }
}
