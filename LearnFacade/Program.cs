using LearnFacade.Classes;
using System;

namespace LearnFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            GameNextWord gameNextWord = new GameNextWord(player1,player2);
            GameMaster.GMCode(gameNextWord);
            
        }
    }
}
