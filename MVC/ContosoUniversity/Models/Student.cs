using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string LastName { get; set; }
		public string FirsttName { get; set; }
		public DateTime EnrollnetDate { get; set; }
		//Navigation properties:
		public ICollection<Enrollment> Enrollments { get; set; }
	}
}
