using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{   
    /// <summary>
    /// Classe missile des aliens
    /// </summary>
    /// <author>Ismail Mesrouk</author>
    public class MissileAlien : GameItem, IAnimable
    {
        private double vitesse;
        /// <summary>
        /// Constructeur de la classe MissileAlien, permet de changer les tires et la vitesse par rapport a l'Alien qui tire.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="canvas"></param>
        /// <param name="game"></param>
        /// <param name="spriteName"></param>
        /// <param name="vitesse"></param>
        /// <author>Ismail Mesrouk</author>
        public MissileAlien(double x, double y, Canvas canvas, Game game, string spriteName, double vitesse ) : base(x, y, canvas, game)
        {
            this.ChangeSprite(spriteName);
            this.vitesse = vitesse;
        }

        public override string TypeName => "MISSIILEALIEN";

        /// <summary>
        /// Gestion de la collision.
        /// </summary>
        /// <author>Ismail Mesrouk</author>
        public override void CollideEffect(GameItem other)
        {
            if (other.TypeName == "Player")
            {
                Game.RemoveItem(this);
            }
            else if (other.TypeName == "MISSIILE")
            {
                Game.RemoveItem(this);
                Game.RemoveItem(other);
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

