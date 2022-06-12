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
        private int life = 3;
        private Canvas canvas;
        private List<Key> mouvements;
        private Heart heart;
        private SpaceInvader jeu;
        private TimeSpan Time;

        public override string TypeName => "PLAYER";
        /// <summary>
        /// Constructeur de la classe Player
        /// </summary>
        /// <param name="x">absisse</param>
        /// <param name="y">ordoné</param>
        /// <param name="c">La Canvas</param>
        /// <param name="g">Le jeu</param>
        /// <param name="jeu">Le jeu</param>
        /// <author>Soufiane EZZMEMANY</author>
        public Player(double x, double y, Canvas c, Game g, SpaceInvader jeu)
            : base(x, y, c, g, "Decor/wxcvbn.png")
        {
            this.jeu = jeu;
            mouvements = new List<Key>();
            heart = new Heart(75, 7, c, g);
            Game.AddItem(heart);
            Time = new TimeSpan(0,0,0);
            this.canvas = c;
        }

        /// <summary>
        /// Gérer les collisions
        /// </summary>
        /// <param name="other"></param>
        /// <author> Soufiane Ezzemany et John Gaudry</author>
        public override void CollideEffect(GameItem other)
        {
            if (other.TypeName == "MISSIILEALIEN")
            {
                if( life > 1 )
                {
                    PlaySound("Hit.mp3");
                    life--;
                    Game.RemoveItem(other);
                    heart.ChangeStatus(life);
                }
                else
                {
                    PlaySound("GameOver.mp3");
                    Game.Loose();
                }
                
            }            
        }

        /// <summary>
        /// Gérer les animations
        /// </summary>
        /// <param name="dt"></param>
        /// <author> Soufiane Ezzemany</author>
        public void Animate(TimeSpan dt)
        {   
            //En mets les deplacement ici pour avoir des deplacement plus fluides
            Time = Time - dt;
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
                        if (this.Right < GameWidth)
                        {
                            MovePlayer(10, 0);
                            this.Orientation = 20;
                        }
                        break;
                }
            }
            
        }

        /// <summary>
        /// Gérer le deplacement du joueur quand la touche et relasé
        /// </summary>
        /// <param name="key"></param>
        /// <author>Soufiane EZZEMANY</author>
        public void KeyUp(Key key)
        {
            if(mouvements.Contains(key))
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
            if (!mouvements.Contains(key))
                mouvements.Add(key);
            if (Time.TotalMilliseconds <= 0)
            {
                if (key == Key.Space)
                {   
                    //Lancer le son
                    PlaySound("shoot.mp3");
                    //Creation de missile et l'ajouter au jeu
                    Missile m = new Missile(this.Left + 55, this.Top, canvas, Game, this.jeu);
                    this.Game.AddItem(m);
                    //redefinire le timespan pour le prochaine tir
                    Time = new TimeSpan(0, 0, 0, 0, 350);
                }
            }
        }
    }
}
