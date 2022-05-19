using Space_Invaders.Logic;
using System;
using System.Windows.Controls;
using Xunit;
using IUTGame;

namespace Test_SpaceInvaders
{
    public class TestPlayer
    {   
        /// <summary>
        /// Test mouvement du joueur
        /// </summary>
        /// <author>Soufiane EZZEMANY</author>
        [Fact]
        public void TestMovement()
        {
            Canvas c = new Canvas();
            SpaceInvader s = new SpaceInvader(c);
            Player p = new Player(150, 150, c, s);
            p.MovePlayer(10,10);
            Assert.Equal(160, p.Left);
            Assert.Equal(160, p.Top);


        }
    }
}
