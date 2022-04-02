using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class FileDetail
    {
        public FileDetail()
        {
            DownloadStatistics = new HashSet<DownloadStatistic>();
            FileMonitoringResults = new HashSet<FileMonitoringResult>();
        }

        public long FileDetailId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
        public long? RepositoryId { get; set; }
        public string FileSize { get; set; }
        public string FileExt { get; set; }
        public string OriginFileName { get; set; }

        public virtual Repository Repository { get; set; }
        public virtual ICollection<DownloadStatistic> DownloadStatistics { get; set; }
        public virtual ICollection<FileMonitoringResult> FileMonitoringResults { get; set; }
    }
}
