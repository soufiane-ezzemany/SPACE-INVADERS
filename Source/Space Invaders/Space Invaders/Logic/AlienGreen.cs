using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    /// <summary>
    /// Classe pour les Aliens Verts
    /// </summary>
    /// <AUTHOR>John Gaudry</AUTHOR>
    class AlienGreen : Alien
    {
        /// <summary>
        /// Constructeur d'Alien Verts
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="canvas"></param>
        /// <param name="game"></param>
        /// <param name="spriteName"></param>
        public AlienGreen(double x, double y, Canvas canvas, Game game, string spriteName = "") : base(x, y, canvas, game, spriteName)
        {

        }

        ///<Author>Gaudry John</Author>
        public override string TypeName => "AlienGreen";

        /// <summary>
        /// Gestion de collision
        /// </summary>
        /// <param name="other"></param>
        /// <author> John Jaudry </author>
        public override void CollideEffect(GameItem other)
        {
            throw new NotImplementedException();
        }
    }
}
