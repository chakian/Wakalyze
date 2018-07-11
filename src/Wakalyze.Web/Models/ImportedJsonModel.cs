using System;
using System.Collections.Generic;

namespace Wakalyze.Web.Models
{
    public class ImportedJsonModel
    {
        public List<jDays> days { get; set; }
        public jRange range { get; set; }
        public jUser user { get; set; }

        public class jCommonArrays
        {
            public List<jDetailedBaseNode> categories { get; set; }
            public List<jDetailedBaseNode> dependencies { get; set; }
            public List<jDetailedBaseNode> editors { get; set; }
            public jBaseNode grand_total { get; set; }
            public List<jDetailedBaseNode> languages { get; set; }
            public List<jDetailedBaseNode> operating_systems { get; set; }
        }

        public class jBaseNode
        {
            public string digital { get; set; }

            public string hours { get; set; }
            public string minutes { get; set; }

            public string text { get; set; }

            public string total_seconds { get; set; }
        }
        public class jDetailedBaseNode : jBaseNode
        {
            public string name { get; set; }
            public string percent { get; set; }
            public string seconds { get; set; }
        }

        public class jDays : jCommonArrays
        {
            public DateTime date { get; set; }
            public List<jProjects> projects { get; set; }

            public class jProjects : jCommonArrays
            {
                public List<jDetailedBaseNode> branches { get; set; }
                public List<jDetailedBaseNode> entities { get; set; }
                public string name { get; set; }
                
            }
        }
        public class jUser
        {
            public DateTime created_at { get; set; }
            public string email { get; set; }
            public bool has_premium_features { get; set; }
            public string id { get; set; }
            public DateTime last_heartbeat { get; set; }
            public string last_plugin { get; set; }
            public string last_plugin_name { get; set; }
            public string last_project { get; set; }
            public string location { get; set; }
            public DateTime? modified_at { get; set; }
            public string photo { get; set; }
            public string plan { get; set; }
        }
        public class jRange
        {
            public long start { get; set; }
            public long end { get; set; }
        }
    }
}
