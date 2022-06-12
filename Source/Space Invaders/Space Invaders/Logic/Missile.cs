using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{   
    /// <summary>
    /// Classe missille du joueur
    /// </summary>
    /// <author>Soufiane EZZEMANY</author>
    public class Missile : GameItem, IAnimable
    {
        private double vitesse = 15;
        private SpaceInvader jeu;
        public Missile(double x, double y, Canvas canvas, Game game, SpaceInvader jeu) : base(x, y, canvas, game, "laser1.png")
        {
            this.jeu = jeu;
        }

        public override string TypeName => "MISSIILE"; 
        
        /// <summary>
        /// gestion de la collision
        /// </summary>
        /// <author>Ismail Mesrouk et Soufiane EZZEMANY</author>
        public override void CollideEffect(GameItem other)
        {   
            if(jeu.NumInvaders >= 1)
            {
                if (other.TypeName == "AlienRed" || (other.TypeName == "AlienBlue") || (other.TypeName == "AlienGreen"))
                {
                    Game.RemoveItem(other);
                    jeu.Invaders.Aliens.Remove((Alien)other);
                    Game.RemoveItem(this);
                    Alien a = (Alien)other;
                    jeu.Score += a.Damage ;
                    jeu.NumInvaders--;
                    this.jeu.GameWindow.ScoreL.Content = jeu.Score.ToString();
                }
                else if (other.TypeName == "UFO")
                {
                    Game.RemoveItem(other);
                    Game.RemoveItem(this);
                    UFO a = (UFO)other;
                    jeu.Score += a.Damage;
                    this.jeu.GameWindow.ScoreL.Content = jeu.Score.ToString();
                }
            }
            else
            {
                PlaySound("Win.wav");
                this.Game.Win();
            }          
        }

        /// <summary>
        /// Animation pour le lancement du missille
        /// </summary>
        /// <author>Soufiane EZZEMANY</author>
        public void Animate(TimeSpan dt)
        {
            if (this.Top <= 0)
            {
                Game.RemoveItem(this);
            }

            MoveDA(this.vitesse , -90);
        }
    }
}
