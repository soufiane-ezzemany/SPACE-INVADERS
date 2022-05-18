using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace Space_Invaders.Logic
{
    public class Player : GameItem, IAnimable, IKeyboardInteract
    {
        public override string TypeName => "SPACESHIP";

        public Player(double x, double y, Canvas c, Game g)
            : base(x, y, c, g, "/Decor/spaceship.png")
        {
            
        }

        public override void CollideEffect(GameItem other)
        {
            throw new NotImplementedException();
        }

        public void Animate(TimeSpan dt)
        {
            throw new NotImplementedException();
        }

        public void KeyUp(Key key)
        {
            throw new NotImplementedException();
        }

        public void KeyDown(Key key)
        {
            throw new NotImplementedException();
        }
    }
}
