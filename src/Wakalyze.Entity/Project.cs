using System.Collections.Generic;
using Wakalyze.Entity.Base;

namespace Wakalyze.Entity
{
    public class Project : BaseCommonArrays
    {
        public List<BaseDetailedNode> branches { get; set; }
        public List<BaseDetailedNode> entities { get; set; }
        public string name { get; set; }
    }
}
