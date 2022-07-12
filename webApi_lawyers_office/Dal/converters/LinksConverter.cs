using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.models;
using EntitiesDTO;

namespace Dal.converters
{
    public class LinksConverter
    {
        public static LinksDto toDto(Link obj)
        {
            return new LinksDto { Id = obj.Id, LinkName = obj.LinkName, SiteAddress = obj.SiteAddress };
        }
        public static Link toDal(LinksDto obj)
        {
            return new Link { Id = obj.Id, LinkName = obj.LinkName, SiteAddress = obj.SiteAddress };
        }
        public static List<LinksDto> toDtoList(List<Link> objList)
        {
            List<LinksDto> l = new List<LinksDto>();
            foreach (Link item in objList)
            {
                l.Add(toDto(item));
            }
            return l;
        }
        public static List<Link> toDalList(List<LinksDto> objList)
        {
            List<Link> l = new List<Link>();
            foreach (LinksDto item in objList)
            {
                l.Add(toDal(item));
            }
            return l;
        }
    }
}
