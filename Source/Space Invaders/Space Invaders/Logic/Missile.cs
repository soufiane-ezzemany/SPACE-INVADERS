using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{   
    /// <summary>
    /// Classe missille du joueur
    /// </summary>
    /// <author>Soufiane EZZEMANY</author>
    public class Missile : GameItem, IAnimable
    {
        private double vitesse = 15;

        public Missile(double x, double y, Canvas canvas, Game game ) : base(x, y, canvas, game, "missile.png")
        {

        }

        public override string TypeName => "MISSIILE"; 
        
        /// <summary>
        /// gestion de la collision
        /// </summary>
        /// <author>Ismail Mesrouk et Soufiane EZZEMANY</author>
        public override void CollideEffect(GameItem other)
        {   
            if(SpaceInvader.numInvaders >= 1)
            {
                if (other.TypeName == "AlienRed" || (other.TypeName == "AlienBlue") || (other.TypeName == "AlienGreen"))
                {
                    Game.RemoveItem(other);
                    Game.RemoveItem(this);
                    SpaceInvader.score += 10;
                    SpaceInvader.numInvaders--;
                }
            }
            else
            {
                this.Game.Win();
            }          
        }

        /// <summary>
        /// Animation pour le lancement du missille
        /// </summary>
        /// <author>Soufiane EZZEMANY</author>
        public void Animate(TimeSpan dt)
        {
            if (this.Top <= 0)
            {
                Game.RemoveItem(this);
            }

            MoveDA(this.vitesse , -90);
        }
    }
}
