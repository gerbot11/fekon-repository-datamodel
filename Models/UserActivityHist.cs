using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class UserActivityHist
    {
        public long UserActivityHistId { get; set; }
        public string UserId { get; set; }
        public DateTime ActivityTime { get; set; }
        public string ActivityDesc { get; set; }
        public string ActivityAction { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
