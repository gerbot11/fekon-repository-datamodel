using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class DownloadStatistic
    {
        public long DownloadStatisticId { get; set; }
        public long FileDetailId { get; set; }
        public string UserId { get; set; }
        public DateTime DownloadDate { get; set; }

        public virtual FileDetail FileDetail { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
