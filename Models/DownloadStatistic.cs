using System;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class DownloadStatistic
    {
        public long DownloadStatisticId { get; set; }
        public long FileDetailId { get; set; }
        public string UserId { get; set; }
        public DateTime DownloadDate { get; set; }
        public string ErrorMsg { get; set; }
        public bool DownloadStatus { get; set; }

        public virtual FileDetail FileDetail { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
