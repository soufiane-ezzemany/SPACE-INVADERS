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
        public AlienGreen(double x, double y, Canvas canvas, Game game) : base(x, y, canvas, game, "Aliens/alienv.png")
        {

        }

        ///<Author>Gaudry John</Author>
        public override string TypeName => "AlienGreen";

 
    }
}
