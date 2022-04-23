using System;
using System.Collections.Generic;

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
        public bool DownloadStatus { get; set; }
        public string ErrorMsg { get; set; }
        public DateTime DateTimeAct { get; set; }
    }
}
