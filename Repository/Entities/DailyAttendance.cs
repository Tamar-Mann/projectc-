using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entities
{
	public class DailyAttendance
	{
		//מפתח משולב?
		[Key]
        public int Id { get; set; }
		public string StudentId { get; set; }
		[ForeignKey("StudentId")]
		public Student Student { get; set; }

        public DateOnly DateOfDay { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }
    }
}
