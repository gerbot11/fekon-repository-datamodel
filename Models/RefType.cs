using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class RefType
    {
        public long RefTypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeCode { get; set; }
    }
}
