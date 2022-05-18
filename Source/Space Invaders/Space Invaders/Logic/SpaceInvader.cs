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
            double y = 500;
            double x = 500;
            Player spaceship = new Player(x, y, Canvas, this);
            AddItem(spaceship);
            PlayBackgroundMusic("opening.mp3");
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
