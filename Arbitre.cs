using System;
using System.Collections.Generic;
using System.Text;

namespace TPShyFuMyServer
{
    public class Arbitre
    {
        


            public static string WhoWin(int playerAGameplay, int playerBGamplay)
            {

                if (playerAGameplay == 1 && playerBGamplay == 2 || playerAGameplay == 2 && playerBGamplay == 3 || playerAGameplay == 3 && playerBGamplay == 1)
                {
                    return "Player A Win";
                }
                else if (playerAGameplay == playerBGamplay)
                {
                    return "Deuce";

                }

                else
                {
                    return "Player B Win";
                }

            }
        
    }
}
