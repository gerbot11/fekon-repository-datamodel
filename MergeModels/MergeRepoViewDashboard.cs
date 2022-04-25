using fekon_repository_datamodel.Models;
using System.Collections.Generic;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeRepoViewDashboard
    {
        public Repository Repository { get; set; }
        public IEnumerable<string> Keywords { get; set; }
        public string UploadBy { get; set; }
    }
}
