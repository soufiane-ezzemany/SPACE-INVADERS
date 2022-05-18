using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    public class SpaceInvader : IUTGame.Game
    {
        public SpaceInvader(Canvas canvas) : base(canvas, "Sprites", "Sounds")
        {

        }
        protected override void InitItems()
        {
            throw new NotImplementedException();
        }

        protected override void RunWhenLoose()
        {
            throw new NotImplementedException();
        }

        protected override void RunWhenWin()
        {
            throw new NotImplementedException();
        }
    }
}
