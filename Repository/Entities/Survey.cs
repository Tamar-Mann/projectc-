using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entities
{
	public class Survey
	{
        [Key]
        public int Id { get; set; }

		public int ClassId { get; set; }

		[ForeignKey("ClassId")]
		public Class Class { get; set; }

		public string QuestionContent { get; set; }

        public virtual  ICollection<SurveyAnswer>? Answers { get; set; }



    }
}
