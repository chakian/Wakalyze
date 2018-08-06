using System;

namespace Wakalyze.Entity
{
    public class User
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
}
