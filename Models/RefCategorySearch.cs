using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class RefCategorySearch
    {
        public long RefCategorySearchId { get; set; }
        public string Property { get; set; }
        public string PropertyCategory { get; set; }
        public string CategoryName { get; set; }
    }
}
