using Space_Invaders.Logic;
using System.Windows.Controls;
using Xunit;
using System.Threading.Tasks;
using System.Threading;

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
            var tcs = new TaskCompletionSource<object>();

            var thread = new Thread(() =>
            {
                Canvas c = new Canvas();
                SpaceInvader s = new SpaceInvader(c, new Space_Invaders.View.GamePageWindow);
                Player p = new Player(150, 150, c, s, s);
                p.MovePlayer(10, 10);
                Assert.Equal(160, p.Left);
                Assert.Equal(160, p.Top);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            


        }
    }
}
