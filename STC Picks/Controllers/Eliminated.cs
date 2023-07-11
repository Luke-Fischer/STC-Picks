namespace STC_Picks.Controllers
{
    public class Eliminated
    {
        public string[] EliminatedPlayers = new string[46] {
            "L. SAMSONOVA (15)",
            "N. KYRGIOS (30)",
            "F. AUGER-ALIASSIME (11)",
            "Q. ZHENG (24)",
            "C. GAUFF (7)",
            "D. EVANS (27)",
            "M. SAKKARI (8)",
            "R. BAUTISTA AGUT (20)",
            "B. CORIC (13)",
            "D. THIEM",
            "S. KORDA (22)",
            "D. SCHWARTZMAN",
            "KA. PLISKOVA (18)",
            "R. MARINO",
            "B. KREJCIKOVA (10)",
            "V. KUDERMETOVA (12)",
            "K. MUCHOVA (16)",
            "T. GRIEKSPOOR (28)",
            "L. FERNANDEZ",
            "C. RUUD (4)",
            "F. CERUNDOLO (18)",
            "M. RAONIC",
            "S. STEPHENS",
            "J. OSTAPENKO (17)",
            "D. STRICKER",
            "T. FRITZ (9)",
            "A. MURRAY",
            "A. MANNARINO",
            "C. NORRIE (12)",
            "L. MUSETTI (14)",
            "A. DE MINAUR (15)",
            "D. VEKIC (20)",
            "D. KASATKINA (11)",
            "D. GOFFIN",
            "B. ANDREESCU",
            "F. TIAFOE (10)",
            "B. D. SHAPOVALOV (26)",
            "A. BUBLIK (23)",
            "B. BENCIC (14)",
            "C. GARCIA (5)",
            "V. AZARENKA (19)",
            "S. TSITSIPAS (5)",
            "B. HADDAD MAIA (13)",
            "M. ANDREEVA",
            "P. KVITOVA (9)",
            "G. DIMITROV (21)"
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
