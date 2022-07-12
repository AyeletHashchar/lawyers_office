using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDTO
{
    public class PaymentsDto
    {
        public int Id { get; set; }
        public string PaymentName { get; set; }
        public string PaySum { get; set; }
        public string? WhoToPay { get; set; }
        public string? SumOff { get; set; }
        public string FinalSum { get; set; }
        public string? Discription { get; set; }

        // public virtual List<ActionPatternDto> ActionPatterns { get; set; }
    }
}
