using fekon_repository_datamodel.Models;
using System.Collections.Generic;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeRepoIndex
    {
        public IEnumerable<Repository> repositories { get; set; }
        //public IEnumerable<RefCollection> refCollections { get; set; }
        //public IEnumerable<CollectionD> collectionDs { get; set; }
        //public int countCollection { get; set; }
        //public IEnumerable<FileDetail> fileDetails { get; set; }
    }
}
