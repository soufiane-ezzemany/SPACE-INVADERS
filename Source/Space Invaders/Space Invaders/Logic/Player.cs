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
            : base(x, y, c, g, "Decor/spaceship.png")
        {
            
        }

        public override void CollideEffect(GameItem other)
        {
            throw new NotImplementedException();
        }

        public void Animate(TimeSpan dt)
        {
            
        }

        public void KeyUp(Key key)
        {
            this.Orientation = 0;
        }

        public void KeyDown(Key key)
        {
            switch (key)
            {
                case Key.Left:
                    if (this.Left > 0)
                    {
                        MoveXY(-10, 0);
                        this.Orientation = -20;
                    }
                    break;
                case Key.Right:
                    if (this.Right < 1200)
                    {
                        MoveXY(10, 0);
                        this.Orientation = 20;
                    }
                    break;
            }

            
        }
    }
}
