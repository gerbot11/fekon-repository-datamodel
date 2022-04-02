using fekon_repository_datamodel.Models;
using System.Collections.Generic;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeRepoCreate
    {
        public Repository repository { get; set; }
        public ICollection<long> authorIds { get; set; }
        public ICollection<long> advisiorIds { get; set; }
        public List<string> langCode { get; set; }
        public List<string> fileStatus { get; set; }
    }
}
