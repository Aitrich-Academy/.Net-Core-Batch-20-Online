using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EmailVerification
    {

        public Guid Id { get; set; }

        // FK to JobProviderCompany
        public Guid JobProviderId { get; set; }
        public virtual JobProviderCompany JobProvider { get; set; } = null!;

        public string OTP { get; set; } = null!;
        public DateTime ExpiryTime { get; set; }
        public bool IsVerified { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    
}
}