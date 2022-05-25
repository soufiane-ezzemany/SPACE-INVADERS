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
        private Canvas canvas;
        private List<Key> mouvements;

        public override string TypeName => "SPACESHIP";


        public Player(double x, double y, Canvas c, Game g)
            : base(x, y, c, g, "Decor/spaceship.png")
        {
            this.canvas = c;
            mouvements = new List<Key>();
        }

        /// <summary>
        /// Gérer les collisions
        /// </summary>
        /// <param name="other"></param>
        /// <author> Soufiane Ezzemany</author>
        public override void CollideEffect(GameItem other)
        {
            //à implementer quand tous les dèplacements seront gérés
        }

        /// <summary>
        /// Gérer les animations
        /// </summary>
        /// <param name="dt"></param>
        /// <author> Soufiane Ezzemany</author>

        public void Animate(TimeSpan dt)
        {
            foreach(Key m in mouvements)
            {
                switch (m)
                {
                    case Key.Left:
                        if (this.Left > 0)
                        {
                            MovePlayer(-10, 0);
                            this.Orientation = -20;
                        }
                    break;
                    case Key.Right:
                        if (this.Right < 1200)
                        {
                            MovePlayer(10, 0);
                            this.Orientation = 20;
                        }
                    break;
                }
            }
            
        }

        /// <summary>
        /// Gérer le deplacement du joueur
        /// </summary>
        /// <param name="key"></param>
        /// <author>Soufiane EZZEMANY</author>
        public void KeyUp(Key key)
        {
            mouvements.Remove(key);
            this.Orientation = 0;
            
        }

        /// <summary>
        /// Pour deplace le joueur et avoir la possobilitéde l'utiliser en dehors
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <author>Soufiane EZZEMAY</author>
        public void MovePlayer(double x, double y)
        {
            this.MoveXY(x, y);
        }

        /// <summary>
        /// Gérer le déplacement du joueur
        /// </summary>
        /// <param name="key"></param>
        /// <author> John Gaudry et Soufiane Ezzemany</author>
        public void KeyDown(Key key)
        {
            mouvements.Add(key);
            
            switch (key)
            {   
                case Key.Space:
                    //TODO : Improvement lancement missile
                    Missile m = new Missile(this.Left + 90 , this.Top+ 40  , canvas, this.Game);
                    this.Game.AddItem(m);
                    m.Animate(new TimeSpan(0,0,0,1));
                    break;
            }

            
        }
    }
}
