using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.models
{
    public partial class BagsToPerson
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string PersonType { get; set; }
        public int BagId { get; set; }

        public virtual Bag Bag { get; set; }
        public virtual Person Person { get; set; }
    }
}
