using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDTO
{
    public class ActionPatternsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public int? FilePatternId { get; set; }
        public int? LinkId { get; set; }
        public int? PaymentId { get; set; }
        public int Level { get; set; }
        public Status WhomFor { get; set; }
        public int? WaitingForActionPatternId { get; set; }
    }
}
