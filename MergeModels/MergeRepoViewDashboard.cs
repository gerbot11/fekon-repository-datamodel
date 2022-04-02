using fekon_repository_datamodel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fekon_repository_datamodel.MergeModels
{
    public class MergeRepoViewDashboard
    {
        public Repository Repository { get; set; }
        public string UploadBy { get; set; }
    }
}
