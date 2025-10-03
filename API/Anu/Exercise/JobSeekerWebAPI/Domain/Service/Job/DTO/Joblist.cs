using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Job.DTO
{
	public class Joblist
	{
		public Guid Id { get; set; }

		public string JobTitle { get; set; } = null!;

		public string JobSummary { get; set; } = null!;

        public string Company { get; set; }

        public string LocationName { get; set; }
		public string IndustryName { get; set; }
		public string JobCategoryName { get; set; }

	 

		public DateTime PostedDate { get; set; }

	}
}
