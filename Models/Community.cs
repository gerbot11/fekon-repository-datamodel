using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class Community
    {
        public Community()
        {
            CollectionDs = new HashSet<CollectionD>();
            Repositories = new HashSet<Repository>();
        }

        public long CommunityId { get; set; }
        public string CommunityName { get; set; }
        public string CommunityCode { get; set; }

        public virtual ICollection<CollectionD> CollectionDs { get; set; }
        public virtual ICollection<Repository> Repositories { get; set; }
    }
}
