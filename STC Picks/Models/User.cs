using System.ComponentModel.DataAnnotations;

namespace STC_Picks.Models
{
	public class User
	{
		[Key]
		public string fullName { get; set; }
		[Required]
		public string firstName { get; set; }
		[Required]
		public string lastName { get; set; }
		[Required]
		public string accessCode { get; set; }

		//User picks
		[Required]
		public string male1 { get; set; }
		[Required]
		public string male2 { get; set; }
		[Required]
		public string male3 { get; set; }
		[Required]
		public string male4 { get; set; }
		[Required]
		public string male5 { get; set; }
		[Required]
		public string male6 { get; set; }
		[Required]
		public string male7 { get; set; }
		[Required]
		public string male8 { get; set; }
		[Required]
		public string female1 { get; set; }
		[Required]
		public string female2 { get; set; }
		[Required]
		public string female3 { get; set; }
		[Required]
		public string female4 { get; set; }
		[Required]
		public string female5 { get; set; }
		[Required]
		public string female6 { get; set; }
		[Required]
		public string female7 { get; set; }
		[Required]
		public string female8 { get; set; }
	}
}
