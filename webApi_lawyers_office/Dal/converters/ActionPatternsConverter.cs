using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.models;
using EntitiesDTO;

namespace Dal.converters
{
    public class ActionPatternsConverter
    {
        public static ActionPatternsDto toDto(ActionPattern obj)
        {
            Status status;
            switch (obj.WhomFor.ToLower())
            {
                case "seller": status = Status.SELLER;break;
                case "buyer": status = Status.BUYER; break;
                case "lawyer": status = Status.LAWYER; break;
                default: status = Status.LAWYER; break;
            }
            return new ActionPatternsDto { 
                Id = obj.Id,
                Title = obj.ActionPatternName,
                Discription=obj.Discription,
                FilePatternId = obj.FilePatternId,
                Level = obj.ActionLevel, 
                LinkId = obj.LinkId,
                PaymentId = obj.PaymentId,
                WaitingForActionPatternId = obj.WaitingForPatternId,
                WhomFor = status
            };
        }
        public static ActionPattern toDal(ActionPatternsDto obj)
        {
            return new ActionPattern {
                Id = obj.Id,
                ActionPatternName = obj.Title,
                Discription = obj.Discription,
                FilePatternId = obj.FilePatternId,
                ActionLevel = obj.Level,
                LinkId = obj.LinkId,
                PaymentId = obj.PaymentId,
                WaitingForPatternId = obj.WaitingForActionPatternId,
                WhomFor = obj.WhomFor.ToString()
            };
        }
        public static List<ActionPatternsDto> toDtoList(List<ActionPattern> objList)
        {
            List<ActionPatternsDto> l = new List<ActionPatternsDto>();
            foreach (ActionPattern item in objList)
            {
                l.Add(toDto(item));
            }
            return l;
        }
        public static List<ActionPattern> toDalList(List<ActionPatternsDto> objList)
        {
            List<ActionPattern> l = new List<ActionPattern>();
            foreach (ActionPatternsDto item in objList)
            {
                l.Add(toDal(item));
            }
            return l;
        }
    }
}
