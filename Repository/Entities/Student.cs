using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{

	public enum Levels
	{
		A,B, C, D, E
	}
	public class Student
	{
		[Key]
		//[DatabaseGenerated(DatabaseGeneratedOption.None)]

		//אוסף ציונים?
		public string StudentId { get; set; }
        public int ClassId { get; set; }
		[ForeignKey("ClassId")]
		public Class Class{ get; set; }
		//??
		public int? ChairId { get; set; }
		[ForeignKey("ChairId")]
		public Chair? CurrentChair { get; set; }
		

		public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Address { get; set; }
		public string Email { get; set; }
        public string Phone { get; set; }
        public Levels StatusSocial { get; set; }
		public Levels AttentionLevel { get; set; }

		//prefering for seats
		public virtual ICollection<Student>? FavoriteFriends{ get; set; }

		public virtual ICollection<Mark>? Marks { get; set; }

		public virtual ICollection<DailyAttendance>? DailyAttendances { get; set; }


	}
}
