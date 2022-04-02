using fekon_repository_datamodel.Models;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeCollData
    {
        public RefCollection RefCollection { get; set; }
        public SearchPaging<RefCollection> PagingRefCollection { get; set; }
    }
}
    