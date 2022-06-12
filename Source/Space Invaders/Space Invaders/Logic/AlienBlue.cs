using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    /// <summary>
    /// Classe Alien Bleu
    /// </summary>
    /// <author> Mesrouk Ismaïl</author>
    public class AlienBlue : Alien, IAnimable
    {   
        private TimeSpan timeToShoot;
        private Canvas canvas;
        /// <summary>
        /// Constructeur Alien Blue
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="canvas"></param>
        /// <param name="game"></param>
        /// <param name="spriteName"></param>
        public AlienBlue(double x, double y, Canvas canvas, Game game) : base(x, y, canvas, game, "Aliens/alienb.png")
        {
            this.canvas = canvas;
            Random r = new Random();
            this.timeToShoot = new TimeSpan(0, 0, r.Next(3, 15));
        }

        public override string TypeName => "AlienBlue";

        public override int Damage => 20;

        public void Animate(TimeSpan dt)
        {
            timeToShoot = timeToShoot - dt;
            if (timeToShoot.TotalMilliseconds < 0)
            {
                // Tir de missile
                MissileAlien b = new MissileAlien(this.Left + 20, this.Bottom + 5, canvas, this.Game, "blueLaser.png", 9);
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
