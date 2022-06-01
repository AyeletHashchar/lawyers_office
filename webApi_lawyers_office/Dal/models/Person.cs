using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.models
{
    public partial class Person
    {
        public Person()
        {
            BagsToPeople = new HashSet<BagsToPerson>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string SecondPhone { get; set; }
        public string Email { get; set; }
        public string Tz { get; set; }
        public string LivingAddress { get; set; }

        public virtual ICollection<BagsToPerson> BagsToPeople { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
