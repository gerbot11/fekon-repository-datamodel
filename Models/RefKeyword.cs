using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class RefKeyword
    {
        public RefKeyword()
        {
            RepositoryKeywords = new HashSet<RepositoryKeyword>();
        }

        public long RefKeywordId { get; set; }
        public string KeywordName { get; set; }
        public string KeywordCode { get; set; }

        public virtual ICollection<RepositoryKeyword> RepositoryKeywords { get; set; }
    }
}
