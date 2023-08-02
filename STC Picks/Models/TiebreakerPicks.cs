using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace STC_Picks.Models
{
    public class TiebreakerPicks
    {
        [DisplayName("Men's Semis 1")]
        public string MensSemiOne { get; set; }
        [DisplayName("Men's Semis 2")]
        public string MensSemiTwo { get; set; }
        [DisplayName("Men's Semis 3")]
        public string MensSemiThree { get; set; }
        [DisplayName("Men's Semis 4")]
        public string MensSemiFour { get; set; }
        [DisplayName("Women's Semis 1")]
        public string WomensSemiOne { get; set; }
        [DisplayName("Women's Semis 2")]
        public string WomensSemiTwo { get; set; }
        [DisplayName("Women's Semis 3")]
        public string WomensSemiThree { get; set; }
        [DisplayName("Women's Semis 4")]
        public string WomensSemiFour { get; set; }
    }
}
