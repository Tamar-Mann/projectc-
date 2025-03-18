using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
	public class Teacher
	{
		//???האם מאגר כיתות
		[Key]
        public string TeacherId { get; set; }

        public string Name { get; set; }
         
        public DateOnly DateOfBirth { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Class>? Classes{ get; set; }
    }
}
