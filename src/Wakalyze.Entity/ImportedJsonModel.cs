using System.Collections.Generic;

namespace Wakalyze.Entity
{
    public class ImportedJsonModel
    {
        public List<Day> days { get; set; }
        public Range range { get; set; }
        public User user { get; set; }
    }
}
