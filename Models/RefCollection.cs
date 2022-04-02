using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class RefCollection
    {
        public RefCollection()
        {
            CollectionDs = new HashSet<CollectionD>();
            Repositories = new HashSet<Repository>();
        }

        public long RefCollectionId { get; set; }
        public string CollName { get; set; }
        public string CollCode { get; set; }

        public virtual ICollection<CollectionD> CollectionDs { get; set; }
        public virtual ICollection<Repository> Repositories { get; set; }
    }
}
