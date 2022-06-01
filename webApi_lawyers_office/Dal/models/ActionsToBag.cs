using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.models
{
    public partial class ActionsToBag
    {
        public int Id { get; set; }
        public int? BagId { get; set; }
        public int? ActionId { get; set; }

        public virtual Action Action { get; set; }
        public virtual Bag Bag { get; set; }
    }
}
