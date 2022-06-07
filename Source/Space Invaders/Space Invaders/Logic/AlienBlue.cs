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
    public class AlienBlue : Alien
    {
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
        }

        public override string TypeName => "AlienBlue";

        /// <summary>
        /// Gestion des collisions
        /// </summary>
        /// <param name="other"></param>
        /// <author> Mesrouk Ismaïl</author>
        public override void CollideEffect(GameItem other)
        {

        }
    }
}
