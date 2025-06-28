namespace STC_Picks.Controllers
{
    public class Eliminated
    {
        public string[] EliminatedPlayers = new string[] {

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
