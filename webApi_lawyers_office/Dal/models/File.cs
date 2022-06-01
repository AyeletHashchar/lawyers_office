using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.models
{
    public partial class File
    {
        public File()
        {
            Actions = new HashSet<Action>();
        }

        public int Id { get; set; }
        public string FileDir { get; set; }
        public int BagId { get; set; }
        public int FilePatternId { get; set; }

        public virtual Bag Bag { get; set; }
        public virtual FilePattern FilePattern { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
    }
}
