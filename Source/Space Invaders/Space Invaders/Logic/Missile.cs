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
        private double vitesse = 150;
        public Missile(double x, double y, Canvas canvas, Game game ) : base(x, y, canvas, game, "missile.png")
        {
        }

        public override string TypeName => "MISIILE";
        
        /// <summary>
        /// gestion de la collision
        /// </summary>
        /// <author>Soufiane EZZEMANY</author>
        public override void CollideEffect(GameItem other)
        {
            
        }

        /// <summary>
        /// Animation pour le lancement du missille
        /// </summary>
        /// <author>Soufiane EZZEMANY</author>
        public void Animate(TimeSpan dt)
        {
            if (Bottom > GameHeight)
            {
                Game.RemoveItem(this);
            }

            MoveDA(this.vitesse * dt.TotalSeconds, -90);
        }
    }
}
