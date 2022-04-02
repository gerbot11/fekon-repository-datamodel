using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class CollectionD
    {
        public CollectionD()
        {
            CollectionDlists = new HashSet<CollectionDlist>();
            Repositories = new HashSet<Repository>();
        }

        public long CollectionDid { get; set; }
        public string CollectionDname { get; set; }
        public long CommunityId { get; set; }
        public long? RefCollectionId { get; set; }

        public virtual Community Community { get; set; }
        public virtual RefCollection RefCollection { get; set; }
        public virtual ICollection<CollectionDlist> CollectionDlists { get; set; }
        public virtual ICollection<Repository> Repositories { get; set; }
    }
}
