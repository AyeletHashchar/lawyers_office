using System;
using System.Collections.Generic;
#nullable disable

namespace Dal.models
{
    public partial class Link
    {
        public Link()
        {
            ActionPatterns = new HashSet<ActionPattern>();
        }

        public int Id { get; set; }
        public string LinkName { get; set; }
        public string SiteAddress { get; set; }

        public virtual ICollection<ActionPattern> ActionPatterns { get; set; }
    }
}
