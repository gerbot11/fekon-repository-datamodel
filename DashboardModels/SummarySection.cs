using System.Collections.Generic;

namespace fekon_repository_datamodel.DashboardModels
{
    public class SummarySection
    {
        public string TotalUser { get; set; }
        public string TotalAuthor { get; set; }
        public string TotalFileSize { get; set; }
        public string TotalRepository { get; set; }
        public string TotalDownload { get; set; }
        public string TotalViews { get; set; }
        public IEnumerable<SectionTopView> TopView { get; set; }
        public IEnumerable<SectionTopDownload> TopDownloads { get; set; }
    }

    public class SectionTopView
    {
        public string Title { get; set; }
        public decimal PrcntView { get; set; }
        public int TotalView { get; set; }
    }

    public class SectionTopDownload
    {
        public string Title { get; set; }
        public decimal PrcntDownload { get; set; }
        public int TotalDownload { get; set; }
    }
}
