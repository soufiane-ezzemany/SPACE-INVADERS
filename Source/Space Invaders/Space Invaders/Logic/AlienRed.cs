using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    /// <summary>
    /// Classe Alien Rouge
    /// </summary>
    /// <author> MESROUK Ismaïl et EZZEMANY Soufiane</author>
    public class AlienRed : Alien, IAnimable
    {
        private TimeSpan timeToShoot;
        private Canvas canvas;
        /// <summary>
        /// Constructeur de Alien Red
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="canvas"></param>
        /// <param name="game"></param>
        /// <param name="spriteName"></param>
        /// <author>MESROUK Ismaïl</author>
        public AlienRed(double x, double y, Canvas canvas, Game game) : base(x, y, canvas, game, "Aliens/alienr.png")
        {
            this.canvas = canvas;
            Random r = new Random();
            this.timeToShoot = new TimeSpan(0, 0, r.Next(3, 15));
        }

        /// <author>MESROUK Ismaïl</author>
        public override string TypeName => "AlienRed";

        public override int Damage => 30;

        public void Animate(TimeSpan dt)
        {
            timeToShoot = timeToShoot - dt;
            if (timeToShoot.TotalMilliseconds < 0)
            {
                // Tir de missile
                MissileAlien b = new MissileAlien(this.Left + 20, this.Bottom + 5, canvas, this.Game, "redLaser.png", 11);
                Game.AddItem(b);
                // Réinitialisation intervalle de temps
                Random r = new Random();
                int ms = r.Next(3000, 15000);
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
