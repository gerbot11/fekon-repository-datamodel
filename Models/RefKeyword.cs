using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class RefKeyword
    {
        public long RefKeywordId { get; set; }
        public string KeywordName { get; set; }
        public string KeywordCode { get; set; }
    }
}
