using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.models
{
    public partial class Bag
    {
        public Bag()
        {
            ActionsToBags = new HashSet<ActionsToBag>();
            BagsToPeople = new HashSet<BagsToPerson>();
            Files = new HashSet<File>();
        }

        public int Id { get; set; }
        public int BagName { get; set; }
        public DateTime? DateClose { get; set; }
        public int BagState { get; set; }
        public DateTime LastOpen { get; set; }
        public int AssetId { get; set; }
        public DateTime ModificationTime { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual ICollection<ActionsToBag> ActionsToBags { get; set; }
        public virtual ICollection<BagsToPerson> BagsToPeople { get; set; }
        public virtual ICollection<File> Files { get; set; }
    }
}
