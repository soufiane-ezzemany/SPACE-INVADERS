using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{   
    /// <summary>
    /// Classe pour le bloc entre le vaisseau et les aliens
    /// </summary>
    /// <author>Soufiane EZZEMANY</author>
    public class Bloc : GameItem
    {
        private int life;
        public Bloc(double x, double y, Canvas canvas, Game game) : base(x, y, canvas, game, "Blocks/bloc9.png")
        {
            life = 9;
        }

        public override string TypeName => "BLOC";

        /// <summary>
        /// Gére la Collision
        /// </summary>
        /// <author>Soufiane EZZEMANY ET John GAUDRY</author>
        public override void CollideEffect(GameItem other)
        {   

            if (this.life > 1)
            {
                if (other.TypeName == "MISSIILE" || other.TypeName == "MISSIILEALIEN")
                {
                    string spriteName = "Blocks/bloc" + (life-1).ToString() +".png";
                    this.ChangeSprite(spriteName);
                    this.Game.RemoveItem(other);
                    this.life--;
                }
            }
            else
            {   
                if(other != null && other.TypeName != "PLAYER")
                {
                    this.Game.RemoveItem(other);
                }
                Game.RemoveItem(this);
            }
            
        }
    }
}
