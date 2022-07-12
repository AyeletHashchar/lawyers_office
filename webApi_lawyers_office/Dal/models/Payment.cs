using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.models
{
    public partial class Payment
    {
        public Payment()
        {
            ActionPatterns = new HashSet<ActionPattern>();
        }

        public int Id { get; set; }
        public string PaymentName { get; set; }
        public string PaySum { get; set; }
        public string WhoToPay { get; set; }
        public string SumOff { get; set; }
        public string FinalSum { get; set; }
        public string Discription { get; set; }

        public virtual ICollection<ActionPattern>? ActionPatterns { get; set; }
    }
}
