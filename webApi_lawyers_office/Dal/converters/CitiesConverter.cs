using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.models;
using EntitiesDTO;

namespace Dal.converters
{
    public class CitiesConverter
    {
        public static CitiesDto toDto(City c)
        {
            return new CitiesDto { Id=c.Id, CityName=c.CityName };
        }
        public static  City toDal(CitiesDto c)
        {
            return new City { Id = c.Id, CityName = c.CityName };
        }
        public static List<CitiesDto> toDtoList(List<City> c)
        {
            List<CitiesDto> l = new List<CitiesDto>();
            foreach (City item in c)
            {
                l.Add(toDto(item));
            }
            return l;
        }
        public static List<City> toDalList(List<CitiesDto> c)
        {
            List<City> l = new List<City>();
            foreach (CitiesDto item in c)
            {
                l.Add(toDal(item));
            }
            return l;
        }
    }
}
