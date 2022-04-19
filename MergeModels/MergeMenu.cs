using fekon_repository_datamodel.Models;
using System.Collections.Generic;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeMenu
    {
        public IEnumerable<RefCollection> refCollections { get; set; }
        public IEnumerable<MergeAuthorGrouping> authors { get; set; }
        public IEnumerable<MergeAuthorGrouping> advisiors { get; set; }
        public Dictionary<string, int> year { get; set; }
    }
}
