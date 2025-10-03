using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public partial class JobPost
{
    public Guid Id { get; set; }

    public string JobTitle { get; set; } = null!;

    public string JobSummary { get; set; } = null!;

	[ForeignKey(nameof(Location))]
	public Guid LocationId { get; set; }

	 
	public string Company { get; set; }


	[ForeignKey(nameof(JobCategory))]
	public Guid CategoryId { get; set; }


	[ForeignKey(nameof(Industry))]
	public Guid IndustryId { get; set; }

  
    public DateTime PostedDate { get; set; }

    public virtual Location Location { get; set; } = null!;
	public virtual Industry Industry { get; set; } = null!;
 	public virtual JobCategory JobCategory { get;set; } = null!;

   
}
