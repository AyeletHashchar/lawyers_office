using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.models
{
    public partial class FilePattern
    {
        public FilePattern()
        {
            ActionPatterns = new HashSet<ActionPattern>();
            Files = new HashSet<File>();
        }

        public int Id { get; set; }
        public string FilePatternName { get; set; }
        public string Discription { get; set; }
        public int Access { get; set; }

        public virtual ICollection<ActionPattern> ActionPatterns { get; set; }
        public virtual ICollection<File> Files { get; set; }
    }
}
