using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    public class MissileAlien : GameItem, IAnimable
    {
        private double vitesse = 10;
        public MissileAlien(double x, double y, Canvas canvas, Game game) : base(x, y, canvas, game, "missileAlien.png")
        {

        }

        public override string TypeName => "MISSIILEALIEN";

        /// <summary>
        /// gestion de la collision
        /// </summary>
        /// <author>Ismail Mesrouk</author>
        public override void CollideEffect(GameItem other)
        {
            if (other.TypeName == "Player")
            {
                
                Game.RemoveItem(this);
            }
   
        }

        /// <summary>
        /// Animation pour le lancement du missille
        /// </summary>
        /// <author>Ismail Mesrouk</author>
        public void Animate(TimeSpan dt)
        {
            if (this.Bottom >= 750)
            {
                Game.RemoveItem(this);
            }

            MoveDA(this.vitesse, 90);
        }
    }
}

