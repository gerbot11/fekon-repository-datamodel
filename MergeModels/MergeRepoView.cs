using fekon_repository_datamodel.Models;
using System.Collections.Generic;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeRepoView
    {
        public Repository repository { get; set; }
        public IEnumerable<FileDetail> fileDetails { get; set; }
        public IEnumerable<Author> authors { get; set; }
        public string RefCollName { get; set; }
        public string CollDName { get; set; }
    }
}
