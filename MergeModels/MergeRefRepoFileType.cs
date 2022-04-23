using fekon_repository_datamodel.Models;
using System.Collections.Generic;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeRefRepoFileType
    {
        public IEnumerable<RefRepositoryFileType> PagingData { get; set; }
        public RefRepositoryFileType CreateModel { get; set; }
        public RefRepositoryFileType EditModel { get; set; }
    }
}
