using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDTO
{
    public class ActionsDto
    {
        public int Id { get; set; }
        public int? ActionPatternId { get; set; }
        public string Comments { get; set; }
        public DateTime? DeadLine { get; set; }
        public string ActionState { get; set; }
        public int? ActionFileId { get; set; }
        public int ActionPriority { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
