using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
	public class Class
	{
		//האם כפל מבצעים?? רשימה של תלימידים??
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public string TeacherId { get; set; }
		[ForeignKey("TeacherId")]
		public Teacher Teacher { get; set; }

        public int CountOfStudents { get; set; }
		//טעינה עצילה?!
        public virtual ICollection<Chair>? Chairs { get; set; }
        public virtual ICollection<Student>? Students { get; set; }
		public virtual ICollection<Survey>? Surveys { get; set; }

	}
}
