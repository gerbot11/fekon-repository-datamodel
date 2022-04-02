using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class RepoStatistic
    {
        public long RepoStatisticId { get; set; }
        public long LinkHitCount { get; set; }
        public long DownloadCount { get; set; }
        public long RepositoryId { get; set; }

        public virtual Repository Repository { get; set; }
    }
}
