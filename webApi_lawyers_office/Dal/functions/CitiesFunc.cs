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
            try
            {
                return CitiesConverter.toDto(db.Cities.First(obj => obj.Id == id));
            }
            catch
            {
                return null;
            }
        }

        public CitiesDto post(CitiesDto obj)
        {
            try
            {
                City newObj = db.Cities.Add(CitiesConverter.toDal(obj)).Entity;
                db.SaveChanges();
                return CitiesConverter.toDto(newObj);
            }
            catch
            {
                throw;
            }

        }

        public CitiesDto put(CitiesDto obj)
        {
            try
            {
                City objToUpdate = db.Cities.First(item=> item.Id== item.Id);
                objToUpdate.CityName = obj.CityName;
                db.SaveChanges();
                return CitiesConverter.toDto(objToUpdate);
            }
            catch
            {
                throw;
            }
        }

        public CitiesDto delete(int id)
        {
            try
            {
                City objToRemove = db.Cities.First(item=> item.Id==id);
                db.Cities.Remove(objToRemove);
                db.SaveChanges();
                return CitiesConverter.toDto(objToRemove);
            }
            catch
            {
                throw;
            }
        }
    }
}
