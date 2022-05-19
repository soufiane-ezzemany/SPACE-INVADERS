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
    public class AlienRed : Alien
    {
        /// <summary>
        /// Constructeur de Alien Red
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="canvas"></param>
        /// <param name="game"></param>
        /// <param name="spriteName"></param>
        /// <author>MESROUK Ismaïl</author>
        public AlienRed(double x, double y, Canvas canvas, Game game, string spriteName = "") : base(x, y, canvas, game, spriteName)
        {
        }

        /// <author>MESROUK Ismaïl</author>
        public override string TypeName => "AlienRed";

        /// <summary>
        /// Gestion des collisions
        /// </summary>
        /// <param name="other"></param>
        ///<author>MESROUK Ismaïl</author>
        public override void CollideEffect(GameItem other)
        {
            
        }
    }
}
