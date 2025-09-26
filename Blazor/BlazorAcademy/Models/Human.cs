using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
	public class Human
	{
		[Required]
		public string last_name { get; set; }
		[Required]
		public string first_name { get; set; }
		public string? middle_name { get; set; }
		[Required]
		DateTime birtDate { get; set; }
		[EmailAddress]
		public string? email { get; set; }
		[Phone]
		public string? phone { get; set; }

		public byte[]? photo { get; set; }
		

	}
}
