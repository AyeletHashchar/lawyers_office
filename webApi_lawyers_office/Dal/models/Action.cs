using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.models
{
    public partial class Action
    {
        public Action()
        {
            ActionsToBags = new HashSet<ActionsToBag>();
        }

        public int Id { get; set; }
        public int? ActionPatternId { get; set; }
        public string Comments { get; set; }
        public DateTime? DeadLine { get; set; }
        public string ActionState { get; set; }
        public int? ActionFileId { get; set; }
        public int ActionPriority { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual File ActionFile { get; set; }
        public virtual ActionPattern ActionPattern { get; set; }
        public virtual ICollection<ActionsToBag> ActionsToBags { get; set; }
    }
}
