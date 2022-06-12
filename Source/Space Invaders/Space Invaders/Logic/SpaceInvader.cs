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
        public static int numInvaders = 36;
        public int score = 0;
        private Canvas canvas;
        private Storage store;
        private Invaders invaders;
        public int Score { get => score; set => score = value; }
        public Invaders Invaders { get => invaders; set => invaders = value; }
        
        public GamePageWindow GameWindow { get => gameWindow; set => gameWindow = value; }
        public SpaceInvader(Canvas canvas, GamePageWindow gameWindow) : base(canvas, "Sprites", "Sounds")
        {
            this.gameWindow = gameWindow;
            this.canvas = canvas;
            store = new Storage();
            
        }
        /// <summary>
        /// Initialise les items
        /// </summary>
        /// <author> Soufiane Ezzemany et Ismail MESROUK</author>
        protected override void InitItems()
        {
            double y = 580;
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
            object volume = Storage.Recup("VolumeFile");
            if (volume != null)
            {
                this.BackgroundVolume = (double)volume;
            }
            //Initialiser le sauvegarde de score
            object scoreInfo = Storage.Recup("ScoreFile");
            if(scoreInfo == null)
            {
                Storage.Sauve("ScoreFile", 0);
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
        /// Initialisation des aliens
        /// </summary>
        /// <author>Ismail MESROUK</author>
        /*private void AddAliens()
        {
            for(int i=1; i <= 12; i++)
            {
                AddItem(new AlienRed(30 +i*80, 160, Canvas, this));
                AddItem(new AlienBlue(30+ i*80, 215, Canvas, this));
                AddItem(new AlienGreen(30+ i*80, 270, Canvas, this));
            }
        }*/

        /// <summary>
        /// Gére quand on perd
        /// </summary>
        /// <author> Soufiane Ezzemany </author>
        protected override void RunWhenLoose()
        {   
            object scoreInfo = Storage.Recup("ScoreFile");
            if ((int)scoreInfo < Score)
            {
                Storage.Sauve("ScoreFile",score);
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
            object scoreInfo = Storage.Recup("ScoreFile");
            if ((int)scoreInfo < score)
            {
                Storage.Sauve("ScoreFile", score);
            }

            //afficher la page ge gagne
            GameWinWindow gamewin = new GameWinWindow(score);
            gamewin.Show();
            //fermer la page de jeu
            gameWindow.Close();
        }
    }
}
