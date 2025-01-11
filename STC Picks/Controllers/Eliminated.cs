namespace STC_Picks.Controllers
{
    public class Eliminated
    {
        public string[] EliminatedPlayers = new string[] {
            "H. Rune [15]",
            "D. Thiem",
            "S. Wawrinka",
            "N. Jarry [26]",
            "D. Shapovalov",
            "K. Khachanov [23]",
            "F. Auger-Aliassime [19]",
            "A. Tabilo [22]",
            "S. Tsitsipas [11]",
            "S. Baez [21]",
            "F. Cerundolo [29]",
            "S. Stephens",
            "M. Sakkari [9]",
            "B. Andreescu",
            "L. Fernandez [23]",
            "J. Ostapenko [10]",
            "C. Garcia [28]",
            "D. Collins [11]",
            "B. Krejcikova [8]",
            "A. Anisimova",
            "A. Fils [24]",
            "S. Korda [16]",
            "H. Hurkacz [7]",
            "N. Osaka",
            "M. Andreeva [21]",
            "E. Rybakina [4]",
            "D. Kasatkina [12]",
            "U. Humbert [17]",
            "N. Djokovic [2]",
            "C. Alcaraz [3]",
            "E. Alexandrova [29]",
            "Y. Putinseva [30]",
            "M. Keys [14]",
            "V. Azarenka [20]",
            "M. Kostyuk [19]",
            "E. Svitolina [27]",
            "L. Musetti [18]",
            "B. Shelton [13]",
            "J. Lehecka [32]",
            "K. Boulter [31]",
            "M. Berrettini",
            "J. Cristian",
            "C. Eubanks",
            "D. Schwartzman",
            "E. Andreeva",
            "G. Monfils",
            "R. Safiullin",
            "T. Townsend",
            "A. Kalinskaya [15]",
            "C. Ruud [8]",
            "A. Rublev [6]",
            "D. Evans",
            "M. Arnaldi [30]",
            "L. Samsonova [16]",
            "D. Schnaider [18]",
            "J. Paolini [5]",
            "C. Wozniacki",
            "D. Vekic [24]",
            "C. Gauff [3]",
            "E. Mertens [33]",
            "A. Popyrin [28]"
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
