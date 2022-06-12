using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    public class Invaders : GameItem, IAnimable
    {
        private List<Alien> aliens;
        private Canvas canvas;
        private Game game;
        private bool moveRight = true;

        public List<Alien> Aliens { get => aliens; set => aliens = value; } 

        public override string TypeName => "";

        public Invaders(double x, double y, Canvas canvas, Game game, string spriteName = "") : base(x, y, canvas, game, spriteName)
        {
            this.canvas = canvas;
            this.game = game;
            aliens = new List<Alien>();
            InitializeAliens();
        }

        private void InitializeAliens()
        {
            for (int i = 1; i <= 12; i++)
            {
                aliens.Add(new AlienRed(30 + i * 80, 160, canvas, game));
                aliens.Add(new AlienBlue(30 + i * 80, 215, canvas, game));
                aliens.Add(new AlienGreen(30 + i * 80, 270, canvas, game));
            }
            DrawAliens();
        }

        private void DrawAliens()
        {
            foreach(Alien a in aliens)
            {
                game.AddItem(a);
            }
        }

        public void Animate(TimeSpan dt)
        {
            foreach (Alien alien in aliens)
            {
                if (moveRight)
                {
                    alien.Move(0);
                }
                else
                {
                    alien.Move(-180);
                }
            }

            ChangeDirection();
        }

        private void ChangeDirection()
        {
            foreach (Alien alien in aliens)
            {
                if (alien.Right > 1200)
                {
                    moveRight = false;
                    break;
                }
                else if (alien.Left < 0)
                {
                    moveRight = true;
                    break;
                }
            }
        }

        public override void CollideEffect(GameItem other)
        {
        }
    }
}
