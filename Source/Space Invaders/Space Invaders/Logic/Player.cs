using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace Space_Invaders.Logic
{
    /// <summary>
    /// Classe pour le joueur
    /// </summary>
    /// <author>Soufiane EZZEMANY</author>
    public class Player : GameItem, IAnimable, IKeyboardInteract
    {
        private int live = 3;

        public override string TypeName => "SPACESHIP";


        public Player(double x, double y, Canvas c, Game g)
            : base(x, y, c, g, "Decor/spaceship.png")
        {
            
        }

        /// <summary>
        /// Gérer les collisions
        /// </summary>
        /// <param name="other"></param>
        /// <author> Soufiane Ezzemany</author>
        public override void CollideEffect(GameItem other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gérer les animations
        /// </summary>
        /// <param name="dt"></param>
        /// <author> Soufiane Ezzemany</author>

        public void Animate(TimeSpan dt)
        {
            
        }

        /// <summary>
        /// Gérer le deplacement du joueur
        /// </summary>
        /// <param name="key"></param>
        /// <author>Soufiane EZZEMANY</author>
        public void KeyUp(Key key)
        {
            this.Orientation = 0;
        }

        /// <summary>
        /// Gérer le déplacement du joueur
        /// </summary>
        /// <param name="key"></param>
        /// <author> John Gaudry et Soufiane Ezzemany</author>
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
