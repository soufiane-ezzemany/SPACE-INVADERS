using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{

    /// <summary>
    /// Classe Alien pour ennemie
    /// </summary>
    /// <author> John Gaudry et Soufiane Ezzemany</author>
    abstract public class Alien : GameItem
    {
        
        public abstract int Damage { get; }
        /// <summary>
        /// Constructeur Alien hérité de GameItem
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="canvas"></param>
        /// <param name="game"></param>
        /// <param name="spriteName"></param>
        /// <author> Gaudry John et Soufiane Ezzemany et Ismaïl Mesrouk</author>
        public Alien(double x, double y, Canvas canvas, Game game, string spriteName) : base(x, y, canvas, game, spriteName)
        {   
            
            //Initialisation aléatoire de l'intervalle avant de tirer

        }

        /// <summary>
        /// Mouvemet des Aliens
        /// </summary>
        /// <param name="dt"></param>
        /// <author>John Gaudry</author>
        public abstract void Move(double d);
        public abstract void MoveDown();

    }
}
