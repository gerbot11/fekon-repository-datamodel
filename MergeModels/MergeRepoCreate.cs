using fekon_repository_datamodel.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeRepoCreate
    {
        public Repository repository { get; set; }
        public ICollection<long> authorIds { get; set; }
        public ICollection<long> advisiorIds { get; set; }
        public IEnumerable<CurrentFileInfo> CurrentFileInfos { get; set; }
        public List<RepoFile> repoFile { get; set; }
        public List<string> langCode { get; set; }
        public List<string> fileStatus { get; set; }
        
    }

    public class RepoFile
    {
        public string FileTypeName { get; set; }
        public string FileTypeCode { get; set; }
        public IFormFile FormFile { get; set; }
        public bool HasFile { get; set; }
    }

    public class CurrentFileInfo
    {
        public long FileDetailId { get; set; }
        public string FileName { get; set; }
        public string OriginalName { get; set; }
        public string FileType { get; set; }
        public string FileSize { get; set; }
        public string Path { get; set; }
        public string FileStatus { get; set; }
    }
}
