using System.Collections.Generic;

namespace Wakalyze.Entity.Base
{
    public class BaseCommonArrays
    {
        public List<BaseDetailedNode> categories { get; set; }
        public List<BaseDetailedNode> dependencies { get; set; }
        public List<BaseDetailedNode> editors { get; set; }
        public BaseNode grand_total { get; set; }
        public List<BaseDetailedNode> languages { get; set; }
        public List<BaseDetailedNode> operating_systems { get; set; }
    }
}
