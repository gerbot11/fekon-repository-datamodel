using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class Author
    {
        public Author()
        {
            RepositoryDs = new HashSet<RepositoryD>();
        }

        public long AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IsAdvisor { get; set; }
        public string AuthorNo { get; set; }

        public virtual ICollection<RepositoryD> RepositoryDs { get; set; }
    }
}
