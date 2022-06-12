using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{   
    /// <summary>
    /// Classe contenant tous les enemis de jeueur
    /// </summary>
    /// <author>Soufiane EZZEMANY</author>
    public class Invaders : GameItem, IAnimable
    {  
        private List<Alien> aliens;
        private Canvas canvas;
        private Game game;
        private bool moveRight = true;
        private TimeSpan apparitionUFO;

        /// <summary>
        /// liste des aliens dans le jeu
        /// </summary>
        public List<Alien> Aliens { get => aliens; set => aliens = value; } 

        public override string TypeName => "";
        /// <summary>
        /// Constructeur de la classe Invaders permet de placer les aliens et un vesseau
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="canvas"></param>
        /// <param name="game"></param>
        /// <param name="spriteName"></param>
        /// <author>Soufiane EZZEMANY</author>
        public Invaders(double x, double y, Canvas canvas, Game game, string spriteName = "") : base(x, y, canvas, game, spriteName)
        {
            this.canvas = canvas;
            this.game = game;
            aliens = new List<Alien>();
            InitializeAliens();
            Random r = new Random();
            this.apparitionUFO = new TimeSpan(0, 0, 0, r.Next(10,25));
        }

        /// <summary>
        /// Initialise les aliens dans le jeu 
        /// </summary>
        /// <author>Soufiane EZZEMANY</author>
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

        /// <summary>
        /// Met les aliens dans le canvas de jeu
        /// </summary>
        private void DrawAliens()
        {
            foreach(Alien a in aliens)
            {
                game.AddItem(a);
            }
        }

        /// <summary>
        /// Gére tous les animations des ennemies et mouvements
        /// </summary>
        /// <param name="dt"></param>
        /// <author>Soufiane EZZEMANY</author>
        public void Animate(TimeSpan dt)
        {   
            //je deplace chaque alien soit à gauche soit à droite
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

            //si il change de direction le bloc va en bas
            if (this.ChangeDirection())
            {
                MoveAliensDown();
            }

            //s'il arrive à un certaine niveu de jeu 
            //ou il y a le joueur on perd
            if (this.ArrivedToEnd())
            {
                Game.Loose();
            }
            //Gerer l'apparition de l'Ufo
            apparitionUFO = apparitionUFO - dt;
            if (apparitionUFO.TotalSeconds < 0)
            {
                // Creation d'ufo
                UFO ufo = new UFO(GameWidth, 80, canvas, this.Game);
                Game.AddItem(ufo);
                // Réinitialisation intervalle de temps
                Random r = new Random();
                int s = r.Next(10, 25);
                apparitionUFO = new TimeSpan(0, 0, 0, s);
            }
        }

        /// <summary>
        /// Change la direction de bloc des aliens si on arrive dans les extremité
        /// </summary>
        /// <returns>booléen si le bloc change direction</returns>
        /// <author>Soufiane EZZEMANY</author>
        private bool ChangeDirection()
        {
            foreach (Alien alien in aliens)
            {
                if (alien.Right > 1200)
                {
                    moveRight = false;
                    return true;
                }
                else if (alien.Left < 0)
                {
                    moveRight = true;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Deplacer tous les alliens en bas de 3 px
        /// </summary>
        /// <author>Soufiane EZZEMANY</author>
        private void MoveAliensDown()
        {
            foreach (Alien alien in aliens)
            {
                alien.MoveDown();
            }
        }

        /// <summary>
        /// Verifier si le bloc est arrivé au niveau de joueur
        /// </summary>
        /// <returns></returns>
        public bool ArrivedToEnd()
        {
            foreach (Alien alien in aliens)
            {
                if (alien.Bottom >= 610)
                {
                    return true;
                }
            }

            return false;
        }
        public override void CollideEffect(GameItem other)
        {
        }
    }
}
