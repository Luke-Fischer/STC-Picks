namespace STC_Picks.Controllers
{
    public class Eliminated
    {
        public string[] EliminatedPlayers = new string[54] {
                    "M. Cilic",
                    "N. Jarry [18]",
                    "D. Shapovalov",
                    "L. Samsonova [13]",
                    "X. Wang [30]",
                    "M. Linette [20]",
                    "M. Bouzkova [31]",
                    "M. Vondrousova [7]",
                    "A. Potapova [23]",
                    "E. Alexandrova [17]",
                    "D. Vekic [21]",
                    "N. Osaka",
                    "A. Kalinina [24]",
                    "V. Kudermetova [15]",
                    "D. Thiem",
                    "M. Raonic",
                    "A. Bublik [31]",
                    "X. Wang",
                    "C. Giorgi",
                    "L. Zhu [29]",
                    "S. Cirstea [22]",
                    "R. Marino",
                    "K. Pliskova",
                    "O. Jabeur [6]",
                    "C. Wozniacki",
                    "J. Thompson",
                    "M. Sakkari [8]",
                    "L. Fernandez [32]",
                    "C. Garcia [16]",
                    "T. Tiafoe [17]",
                    "E. Mertens [25]",
                    "A. Pavlyuchenkova",
                    "L. Musetti [25]",
                    "D. Kasatkina [14]",
                    "J. Pegula [5]",
                    "H. Rune [8]",
                    "E. Rybakina [3]",
                    "B. Haddad Maia [10]",
                    "B. Shelton [16]",
                    "A. Blinkova",
                    "S. Stephens",
                    "I. Swiatek [1]",
                    "J. Ostapenko [11]",
                    "T. Paul [14]",
                    "F. Auger-Aliassime [27]",
                    "G. Dimitrov [13]",
                    "C. Ruud [11]",
                    "M. Andreeva",
                    "A. de Minaur [10]",
                    "K. Khachanov [15]",
                    "S. Tsitsipas [7]",
                    "A. Mannarino [20]",
                    "E. Svitolina [19]",
                    "V. Azarenka [18]"
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
