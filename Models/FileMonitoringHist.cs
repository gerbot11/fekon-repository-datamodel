using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class FileMonitoringHist
    {
        public FileMonitoringHist()
        {
            FileMonitoringResults = new HashSet<FileMonitoringResult>();
        }

        public long FileMonitoringHistId { get; set; }
        public int TotalFile { get; set; }
        public int TotalSize { get; set; }
        public DateTime RunningDate { get; set; }
        public int RunningDuration { get; set; }
        public int TotalFileProblem { get; set; }

        public virtual ICollection<FileMonitoringResult> FileMonitoringResults { get; set; }
    }
}
