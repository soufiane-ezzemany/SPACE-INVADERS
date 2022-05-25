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
            PlaySound("laser-sound.mp3");
        }

        public override string TypeName => "MISSIILE";
        
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
            if (this.Top <= 0)
            {
                Game.RemoveItem(this);
            }

            MoveDA(this.vitesse , -90);
        }
    }
}
