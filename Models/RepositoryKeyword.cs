using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class RepositoryKeyword
    {
        public long RepositoryKeywordId { get; set; }
        public long? RepostioryId { get; set; }

        public virtual Repository Repostiory { get; set; }
    }
}
