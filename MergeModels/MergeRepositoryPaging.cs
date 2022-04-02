using System.Collections.Generic;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeRepositoryPaging
    {
        public long RepositoryId { get; set; }
        public string Title { get; set; }
        public string PublishDate { get; set; }
        public string RefCollectionName { get; set; }
        public string CollName { get; set; }
        public List<string> AuthorName { get; set; }
    }
}
