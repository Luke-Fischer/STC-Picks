﻿namespace STC_Picks.Controllers
{
    public class Eliminated
    {
        public string[] EliminatedPlayers = new string[1] {
            "placeholder"
        };
        public int IsEliminated(string name)
        {
            //Elim
            for(int i = 0; i < EliminatedPlayers.Length; i++)
            {
                if(name == EliminatedPlayers[i])
                {
                    return 1;
                }
            }
            //Not elim
            return 0;
        }
    }
}
