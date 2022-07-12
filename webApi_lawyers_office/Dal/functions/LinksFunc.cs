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
    public class LinksFunc : Ilinks
    {
        Layers_OfficeContext db;
        public LinksFunc(Layers_OfficeContext _db)
        {
            db = _db;
        }

        public List<LinksDto> GetAll()
        {
            return LinksConverter.toDtoList(db.Links.ToList());
        }

        public LinksDto GetById(int id)
        {
            try
            {
                return LinksConverter.toDto(db.Links.First(obj => obj.Id == id));
            }
            catch
            {
                return null;
            }
        }

        public LinksDto post(LinksDto obj)
        {
            try
            {
                Link newObj = db.Links.Add(LinksConverter.toDal(obj)).Entity;
                db.SaveChanges();
                return LinksConverter.toDto(newObj);
            }
            catch
            {
                throw;
            }

        }

        public LinksDto put(LinksDto obj)
        {
            try
            {
                Link objToUpdate = db.Links.First(item => item.Id == item.Id);

                objToUpdate.LinkName = obj.LinkName;
                objToUpdate.SiteAddress = obj.SiteAddress;

                db.SaveChanges();
                return LinksConverter.toDto(objToUpdate);
            }
            catch
            {
                throw;
            }
        }

        public LinksDto delete(int id)
        {
            try
            {
                Link objToRemove = db.Links.First(item => item.Id == id);
                db.Links.Remove(objToRemove);
                db.SaveChanges();
                return LinksConverter.toDto(objToRemove);
            }
            catch
            {
                throw;
            }
        }
    }
}
