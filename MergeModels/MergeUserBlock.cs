using fekon_repository_datamodel.Models;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeUserBlock
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public RefEmployee RefEmployee { get; set; }
    }
}
