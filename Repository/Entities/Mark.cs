using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
	public class Mark
	{
		[Key]
        public int Id { get; set; }

		public int SubjectId { get; set; }
		[ForeignKey("SubjectId")]	
		public Subject Subject { get; set; }

		public string StudentId { get; set; }
		[ForeignKey("StudentId")]
		public Student Student { get; set; }

        public int MarkPercent { get; set; }

        public DateOnly DateOfTest { get; set; }

    }
}
