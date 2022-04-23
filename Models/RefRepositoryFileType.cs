using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class RefRepositoryFileType
    {
        public RefRepositoryFileType()
        {
            FileDetails = new HashSet<FileDetail>();
        }

        public long RefRepositoryFileTypeId { get; set; }
        public string RepositoryFileTypeCode { get; set; }
        public string RepositoryFileTypeName { get; set; }

        public virtual ICollection<FileDetail> FileDetails { get; set; }
    }
}
