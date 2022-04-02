using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fekon_repository_datamodel.DashboardModels
{
    public class TotalRepositoryPerYearPublish
    {
        public int Year { get; set; }
        public string CollDataSet { get; set; }
        public int Value { get; set; }
        public int MinVal { get; set; }
        public int MaxVal { get; set; }
    }
}
