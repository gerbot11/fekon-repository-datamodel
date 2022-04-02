using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class FileMonitoringResult
    {
        public long FileMonitoringResultId { get; set; }
        public long? FileMonitoringHistId { get; set; }
        public long? FileDetailId { get; set; }
        public string StatusFile { get; set; }

        public virtual FileDetail FileDetail { get; set; }
        public virtual FileMonitoringHist FileMonitoringHist { get; set; }
    }
}
