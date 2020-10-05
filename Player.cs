using System;
using System.Collections.Generic;
using System.Text;

namespace TPShyFuMyServer
{
    public class Player
    {

        public int GameReceive { get; set; }


        public static int? GamePlay(int element)
            {
                switch (element)
                {
                    case 1/*"feuille"*/: break;
                    case 2/*"Pierre"*/: break;
                    case 3/*"Ciseux"*/: break;
                    
                    default: return null;
                }

            return element;
            }
        
    }
}
