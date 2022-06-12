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
        /// <summary>
        /// Le degat de chaque alien
        /// </summary>
        /// <author>Soufiane EZZMANY</author>
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
        }

        /// <summary>
        /// Permet le mouvement des aliens de droite a gauche
        /// </summary>
        /// <param name="d"></param>
        /// <authore>Soufiane EZZEMNY</authore>
        public abstract void Move(double d);
        /// <summary>
        /// Permet le mouvement des aliens pour la descente sur les extrémités du jeu
        /// </summary>
        /// <author>Soufiane EZZEMANY</author>
        public abstract void MoveDown();

    }
}
