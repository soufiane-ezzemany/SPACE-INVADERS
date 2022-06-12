using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    class Heart : GameItem
    {
        /// <summary>
        /// Constructeur de la classe "Heart", il permet d'afficher via un sprite les vies restantes du joueurs
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="canvas"></param>
        /// <param name="game"></param>
        /// <param name="spriteName"></param>
        /// <author>John GAUDRY</author>
        public Heart(double x, double y, Canvas canvas, Game game, string spriteName = "Hearts/heart3.png") : base(x, y, canvas, game, spriteName)
        {
            this.ChangeScale(0.7, 0.7);
        }

        public override string TypeName => "HEART";

        public override void CollideEffect(GameItem other)
        {
            
        }
        /// <summary>
        /// change de sprite selon la vie
        /// </summary>
        /// <param name="n">nombre de vie</param>
        /// <author>John GAUDRY</author>
        public void ChangeStatus(int n)
        {
            string spriteName = "Hearts/heart" + (n).ToString() + ".png";
            ChangeSprite(spriteName);
        }
    }
}
