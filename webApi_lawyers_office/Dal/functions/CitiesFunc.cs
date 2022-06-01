using Dal.converters;
using Dal.interfaces;
using Dal.models;
using EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.functions
{
    public class CitiesFunc : Icities
    {
        Layers_OfficeContext db;
        public CitiesFunc(Layers_OfficeContext _db)
        {
            db = _db;
        }
        public List<CitiesDto> GetAll()
        {
            return CitiesConverter.toDtoList(db.Cities.ToList());
        }

        public CitiesDto GetById(int id)
        {
            return CitiesConverter.toDto(db.Cities.First(c=>c.Id==id));
        }

        public City post(CitiesDto c)
        {
            try
            {
                City newCity = db.Cities.Add(CitiesConverter.toDal(c)).Entity;
                db.SaveChanges();
                return newCity;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
