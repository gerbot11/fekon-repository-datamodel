using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class CollectionDlist
    {
        public long CollectionDlistId { get; set; }
        public string CollectionDlistName { get; set; }
        public long CollectionDid { get; set; }

        public virtual CollectionD CollectionD { get; set; }
    }
}
