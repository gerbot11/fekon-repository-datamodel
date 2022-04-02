using fekon_repository_datamodel.Models;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeSubCollData
    {
        public CollectionD CollectionD { get; set; }
        public SearchPaging<CollectionD> PagingRefCollection { get; set; }
    }
}
