using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Location
{
   
        public Guid Id { get; set; }

        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        // Optional fields if your schema includes them
        public string? Name { get; set; }
        public string? Discription { get; set; } // Keep this spelling if the DB column is like that

        // ✅ Navigation properties
        public virtual ICollection<JobProviderCompany> JobProviderCompanies { get; set; } = new List<JobProviderCompany>();

        // ✅ Fix: add this navigation property for your error
        public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
    }
