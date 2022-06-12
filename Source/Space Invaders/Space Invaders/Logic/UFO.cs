using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    /// <summary>
    /// Classe UFO
    /// </summary>
    /// <author> MESROUK Ismaïl et EZZEMANY Soufiane</author>
    public class UFO : GameItem, IAnimable
    {
        private Canvas canvas;
        private Game game;

        /// <summary>
        /// Nombre de points que le joueur a en tuant l'UFO
        /// </summary>
        public int Damage { get => 60; }
        
        /// <summary>
        /// Constructeur de l'UFO
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="canvas"></param>
        /// <param name="game"></param>
        /// <author>Ismaïl MESROUK</author>
        public UFO(double x, double y, Canvas canvas, Game game) : base(x, y, canvas, game, "Aliens/ufo.png")
        {
            this.game = game;
            this.canvas = canvas;
        }

        public override string TypeName =>"UFO";

        /// <summary>
        /// Gère le mouvement de l'UFO se deplaçant vers la gauche
        /// </summary>
        /// <param name="dt"></param>
        /// <author>Ismaïl Mesrouk et Soufiane Ezzemany</author>
        public void Animate(TimeSpan dt)
        {
            PlaySound("passageUFO.mp3");
            if (this.Left < 0)
                this.game.RemoveItem(this);

                MoveDA(10, -180);
       
        }

        public override void CollideEffect(GameItem other)
        {
   
        }
    }
}
