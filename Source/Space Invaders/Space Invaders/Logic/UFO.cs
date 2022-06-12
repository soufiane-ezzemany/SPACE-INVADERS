﻿using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    public class UFO : GameItem, IAnimable
    {
        private Canvas canvas;
        private Game game;
        

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
        /// 
        /// </summary>
        /// <param name="dt"></param>
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