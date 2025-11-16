namespace STC_Picks.Controllers
{
    public class Eliminated
    {
        public string[] EliminatedPlayers = new string[] {
                        "D. Medvedev [13]",
                        "U. Humbert [22]",
                        "S. Korda",
                        "V. Mboko [22]",
                        "M. Keys [6]",
                        "C. Tauson [14]",
                        "G. Monfils",
                        "L. Sonego",
                        "D. Shnaider [20]",
                        "S. Kenin [26]",
                        "D. Collins",
                        "K. Boulter",
                        "V. Williams (W)",
                        "E. Svitolina [12]",
                        "C. Garcia",
                        "P. Kvitova",
                        "A. Pavlyuchenkova",
                        "J. Draper [5]",
                        "F. Cerundolo [19]",
                        "K. Khachanov [9]",
                        "H. Rune [11]",
                        "A. Davidovich Fokina [18]",
                        "C. Ruud [12]",
                        "B. Bencic [16]",
                        "L. Samsonova [17]",
                        "J. Ostapenko [25]",
                        "J. Mensik [16]",
                        "H. Medjedovic",
                        "J. Fonseca",
                        "D. Yastremska [30]",
                        "B. Nakashima [30]",
                        "I. Jovic",
                        "V. Golubic",
                        "O. Danilovic",
                        "J. Brooksby",
                        "M. Sherif",
                        "M. Arnaldi",
                        "M. Kecmanovic",
                        "R. Bautista Agut",
                        "C. Moutet",
                        "A. Ruzic",
                        "A. Michelsen [28]",
                        "T. Etcheverry",
                        "F. Tiafoe [17]",
                        "L. Darderi [32]",
                        "B. Shelton [6]",
                        "C. Norrie",
                        "E. Raducanu",
                        "J. Paolini [7]",
                        "E. Mertens [19]",
                        "V. Azarenka",
                        "E. Navarro [10]",
                        "L. Fernandez [31]",
                        "M. Andreeva [5]",
                        "D. Vekic",
                        "S. Tsitsipas [26]",
                        "G. Diallo [31]",
                        "M. Sakkari",
                        "J. Cristian",
                        "D. Kasatkina [15]",
                        "T. Paul [14]",
                        "A. Zverev [3]",
                        "K. Majchrzak",
                        "D. Shapovalov [27]",
                        "F. Cobolli [24]",
                        "T. Machac [21]",
                        "J. Struff",
                        "T. Townsend",
                        "E. Rybakina [9]",
                        "A. Kalinskaya [29]",
                        "M. Frech [29]",
                        "F. Cobolli [24]",
                        "A. Rublev [15]",
                        "L. Riedi",
                        "E. Alexandrova [13]",
                        "C. Gauff [3]",
                        "A. Bublik [23]",
                        "J. Munar",
                        "M. Kostyuk [27]",
                        "B. Haddad Maia [18]"
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
