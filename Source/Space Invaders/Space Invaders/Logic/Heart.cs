using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    class Heart : GameItem
    {
        public Heart(double x, double y, Canvas canvas, Game game, string spriteName = "Hearts/heart3.png") : base(x, y, canvas, game, spriteName)
        {
            this.ChangeScale(0.7, 0.7);
        }

        public override string TypeName => "HEART";

        public override void CollideEffect(GameItem other)
        {
            
        }

        public void ChangeStatus(int n)
        {
            string spriteName = "Hearts/heart" + (n).ToString() + ".png";
            ChangeSprite(spriteName);
        }
    }
}
