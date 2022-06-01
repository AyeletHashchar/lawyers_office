using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.models
{
    public partial class User
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string UserPassword { get; set; }
        public string UserType { get; set; }

        public virtual Person Person { get; set; }
    }
}
