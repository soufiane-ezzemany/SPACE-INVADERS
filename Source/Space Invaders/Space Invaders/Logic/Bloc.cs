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
        int life;
        public Bloc(double x, double y, Canvas canvas, Game game) : base(x, y, canvas, game, "Blocks/block3.png")
        {
            life = 3;
        }

        public override string TypeName => "BLOC";

        /// <summary>
        /// Gére la Collision
        /// </summary>
        /// <author>Soufiane EZZEMANY</author>
        public override void CollideEffect(GameItem other)
        {   

            if (this.life > 1)
            {
                if (other.TypeName == "MISSIILE")
                {
                    string spriteName = "Blocks/block" + (life-1).ToString() +".png";
                    this.ChangeSprite(spriteName);
                    this.Game.RemoveItem(other);
                    this.life--;
                }
            }
            else
            {   
                if(other != null)
                {
                    this.Game.RemoveItem(other);
                }
                this.Game.RemoveItem(this);
            }
            
        }
    }
}
