using IUTGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace PetitJeu
{
    class ObjScore : IUTGame.GameItem
    {
        private int score;
        public ObjScore(int score, double x, double y, Canvas c, Game g)
            :base(x,y,c,g)
        {
            this.score = score;
        }

        public int Score
        {
            get { return score; }
            set
            {
                score = Math.Min(10,value);
            }
        }
        
        public override string TypeName => "score";

        public override bool IsCollide(GameItem other)
        {
            return false;
        }
        public override void CollideEffect(GameItem other)
        {
            
        }

        
    }
}
