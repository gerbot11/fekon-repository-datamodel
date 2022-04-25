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
        public IEnumerable<KeywordsGrouping> Keywords { get; set; }
    }

    public class KeywordsGrouping
    {
        public string KeywordName { get; set; }
        public string KeywordCode { get; set; }
        public int Count { get; set; }
    }
}
