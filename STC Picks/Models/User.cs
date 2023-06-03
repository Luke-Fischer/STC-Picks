using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace STC_Picks.Models
{
	public class User
	{
		[Key]
		public string fullName { get; set; }
		[Required]
        [DisplayName("First Name")]
		public string firstName { get; set; }
		[Required]
        [DisplayName("Last Name")]
        public string lastName { get; set; }
		[Required]
        [DisplayName("Access Key")]
        public string accessCode { get; set; }

		//User picks
		[Required]
        [DisplayName("Men's Quarter 1")]
        public string male1 { get; set; }
		[Required]
        [DisplayName("Men's Quarter 2")]
        public string male2 { get; set; }
		[Required]
        [DisplayName("Men's Quarter 3")]
        public string male3 { get; set; }
		[Required]
        [DisplayName("Men's Quarter 4")]
        public string male4 { get; set; }
		[Required]
        [DisplayName("Men's Quarter 5")]
        public string male5 { get; set; }
		[Required]
        [DisplayName("Men's Quarter 6")]
        public string male6 { get; set; }
		[Required]
        [DisplayName("Men's Quarter 7")]
        public string male7 { get; set; }
		[Required]
        [DisplayName("Men's Quarter 8")]
        public string male8 { get; set; }
		[Required]
        [DisplayName("Women's Quarter 1")]
        public string female1 { get; set; }
		[Required]
        [DisplayName("Women's Quarter 2")]
        public string female2 { get; set; }
		[Required]
        [DisplayName("Women's Quarter 3")]
        public string female3 { get; set; }
		[Required]
        [DisplayName("Women's Quarter 4")]
        public string female4 { get; set; }
		[Required]
        [DisplayName("Women's Quarter 5")]
        public string female5 { get; set; }
		[Required]
        [DisplayName("Women's Quarter 6")]
        public string female6 { get; set; }
		[Required]
        [DisplayName("Women's Quarter 7")]
        public string female7 { get; set; }
		[Required]
        [DisplayName("Women's Quarter 8")]
        public string female8 { get; set; }
	}
}
