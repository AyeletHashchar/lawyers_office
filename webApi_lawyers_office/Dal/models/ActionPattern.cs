using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.models
{
    public partial class ActionPattern
    {
        public ActionPattern()
        {
            Actions = new HashSet<Action>();
            InverseWaitingForPattern = new HashSet<ActionPattern>();
        }

        public int Id { get; set; }
        public string ActionPatternName { get; set; }
        public string Discription { get; set; }
        public int? FilePatternId { get; set; }
        public int? LinkId { get; set; }
        public int? PaymentId { get; set; }
        public int ActionLevel { get; set; }
        public string WhomFor { get; set; }
        public int? WaitingForPatternId { get; set; }

        public virtual FilePattern FilePattern { get; set; }
        public virtual Link Link { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ActionPattern WaitingForPattern { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
        public virtual ICollection<ActionPattern> InverseWaitingForPattern { get; set; }
    }
}
