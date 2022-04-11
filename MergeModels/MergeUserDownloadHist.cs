using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeUserDownloadHist
    {
        public DateTime DateActiivity { get; set; }
        public IEnumerable<DownloadActivityDetail> DownloadActivityDetails { get; set; }
    }

    public class DownloadActivityDetail
    {
        public string Action { get; set; }
        public string RepositoryTitle { get; set; }
        public string FileName { get; set; }
        public DateTime DateTimeAct { get; set; }
    }
}
