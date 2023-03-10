using Space_Invaders.Stockage;
using Space_Invaders.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Space_Invaders.Logic
{
    /// <summary>
    /// Classe Jeu
    /// </summary>
    /// <author> Soufiane Ezzemany</author>
    public class SpaceInvader : IUTGame.Game
    {
        private Player spaceship;
        private GamePageWindow gameWindow;
        public int numInvaders;
        public int score = 0;
        private Canvas canvas;
        private Storage store;
        private Invaders invaders;
        public int Score { get => score; set => score = value; }
        public Invaders Invaders { get => invaders; set => invaders = value; }
        
        public GamePageWindow GameWindow { get => gameWindow; set => gameWindow = value; }
        public int NumInvaders { get => numInvaders; set => numInvaders = value; }
        public SpaceInvader(Canvas canvas, GamePageWindow gameWindow) : base(canvas, "Sprites", "Sounds")
        {
            this.gameWindow = gameWindow;
            this.canvas = canvas;
            store = new Storage();
            numInvaders = 36;
        }
        /// <summary>
        /// Initialise les items
        /// </summary>
        /// <author> Soufiane Ezzemany et Ismail MESROUK</author>
        protected override void InitItems()
        {
            double y = 600;
            double x = 550;
            spaceship = new Player(x, y, this.canvas, this, this);
            AddItem(spaceship);
            //Ajout des blocs
            AddBlocs();
            this.invaders = new Invaders(100, 100, canvas, this);
            AddItem(invaders);
            //Ajout des aliens
            //AddAliens();
            //Lancer le son
            PlayBackgroundMusic("opening.mp3");
            //Initialiser le sauvegarde de son
            object volume = Storage.Charge("VolumeFile");
            if (volume != null)
            {
                this.BackgroundVolume = (double)volume;
            }
            //Initialiser le sauvegarde de score
            object scoreInfo = Storage.Charge("ScoreFile");
            if(scoreInfo == null)
            {
                Storage.Save("ScoreFile", 0);
            }
        }

        /// <summary>
        /// Initialisation Blocs
        /// </summary>
        /// <author>Ismail MESROUK</author>
        private void AddBlocs()
        {
            Bloc b = new Bloc(150, 510, Canvas, this);
            Bloc b1 = new Bloc(500, 510, Canvas, this);
            Bloc b2 = new Bloc(850, 510, Canvas, this);

            AddItem(b);
            AddItem(b1);
            AddItem(b2);
        }

        /// <summary>
        /// Gére quand on perd
        /// </summary>
        /// <author> Soufiane Ezzemany </author>
        protected override void RunWhenLoose()
        {   
            object scoreInfo = Storage.Charge("ScoreFile");
            if ((int)scoreInfo < Score)
            {
                Storage.Save("ScoreFile",score);
            }
            //afficher la fenetre de perte
            GameLooseWindow looseWindow = new GameLooseWindow(score);
            looseWindow.Show();
            //fermer la page de jeu
            gameWindow.Close();
        }

        /// <summary>
        /// Gère quand on gagne
        /// </summary>
        /// <author> Soufiane Ezzemany </author>
        protected override void RunWhenWin()
        {
            object scoreInfo = Storage.Charge("ScoreFile");
            if ((int)scoreInfo < score)
            {
                Storage.Save("ScoreFile", score);
            }

            //afficher la page ge gagne
            GameWinWindow gamewin = new GameWinWindow(score);
            gamewin.Show();
            //fermer la page de jeu
            gameWindow.Close();
        }
    }
}
