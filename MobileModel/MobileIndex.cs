using fekon_repository_datamodel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fekon_repository_datamodel.MobileModel
{
    public class MobileIndex
    {
        public long RepositoryId { get; set; }
        public string Title { get; set; }
        public IEnumerable<int> Stat { get; set; }
        public IEnumerable<string> AuthorName { get; set; }
    }
}
