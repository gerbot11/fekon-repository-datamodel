using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Repositories = new HashSet<Repository>();
        }

        public long PublisherId { get; set; }
        public string PublisherName { get; set; }

        public virtual ICollection<Repository> Repositories { get; set; }
    }
}
