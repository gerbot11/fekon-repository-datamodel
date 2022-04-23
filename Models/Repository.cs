using System;
using System.Collections.Generic;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class Repository
    {
        public Repository()
        {
            FileDetails = new HashSet<FileDetail>();
            RepoStatistics = new HashSet<RepoStatistic>();
            RepositoryDs = new HashSet<RepositoryD>();
            RepositoryKeywords = new HashSet<RepositoryKeyword>();
        }

        public long RepositoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string Language { get; set; }
        public long? Publisher { get; set; }
        public DateTime? UploadDate { get; set; }
        public long? RefCollectionId { get; set; }
        public long? CollectionDid { get; set; }
        public long? CommunitiyId { get; set; }
        public string UsrCreate { get; set; }

        public virtual CollectionD CollectionD { get; set; }
        public virtual Community Communitiy { get; set; }
        public virtual Publisher PublisherNavigation { get; set; }
        public virtual RefCollection RefCollection { get; set; }
        public virtual ICollection<FileDetail> FileDetails { get; set; }
        public virtual ICollection<RepoStatistic> RepoStatistics { get; set; }
        public virtual ICollection<RepositoryD> RepositoryDs { get; set; }
        public virtual ICollection<RepositoryKeyword> RepositoryKeywords { get; set; }
    }
}
