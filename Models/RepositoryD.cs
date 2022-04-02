using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class RepositoryD
    {
        public long RepositoryDid { get; set; }
        public long RepositoryId { get; set; }
        public long AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Repository Repository { get; set; }
    }
}
