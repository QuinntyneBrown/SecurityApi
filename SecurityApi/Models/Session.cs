using System;

namespace SecurityApi.Models
{
    public class Session : BaseEntity
    {
        public int? UserId { get; set; }
        public bool IsExpired { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Expires { get; set; }
    }
}
