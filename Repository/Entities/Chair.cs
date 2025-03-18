using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
	public class Chair
	{
        //במורות מאגר כיתות?
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }

        [ForeignKey("ClassId")]
        public Class Class { get; set; }
        public string? StudentId { get; set; }
        
		[ForeignKey("StudentId")]
		public Student? CurrentStudent { get; set; }
        
        //ICollection ??

        public virtual ICollection<Student>? HistorySeats { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public bool IsNearTheDoor { get; set; }

		public bool IsNearTheWindow { get; set; }

    }
}
