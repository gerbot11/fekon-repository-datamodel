using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class RefEmployee
    {
        public long RefEmployeeId { get; set; }
        public string UserId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeNo { get; set; }
        public bool IsActive { get; set; }
        public string ProfilePicLoc { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
