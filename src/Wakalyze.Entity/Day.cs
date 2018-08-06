using System;
using System.Collections.Generic;
using Wakalyze.Entity.Base;

namespace Wakalyze.Entity
{
    public class Day : BaseCommonArrays
    {
        public DateTime date { get; set; }
        public List<Project> projects { get; set; }
    }
}
