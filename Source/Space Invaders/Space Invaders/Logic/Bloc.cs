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
        public Bloc(double x, double y, Canvas canvas, Game game) : base(x, y, canvas, game, "Blocks/block1.png")
        {
        }

        public override string TypeName => throw new NotImplementedException();

        /// <summary>
        /// Gére la Collision
        /// </summary>
        /// <author>Soufiane EZZEMANY</author>
        public override void CollideEffect(GameItem other)
        {
            //à implemeter quand tous les deplacement seront gérés
        }
    }
}
