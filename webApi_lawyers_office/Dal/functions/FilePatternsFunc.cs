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
    public class FilePatternsFunc : IfilePatterns
    {
        Layers_OfficeContext db;
        public FilePatternsFunc(Layers_OfficeContext _db)
        {
            db = _db;
        }

        public List<FilePatternsDto> GetAll()
        {
            return FilePatternsConverter.toDtoList(db.FilePatterns.ToList());
        }

        public FilePatternsDto GetById(int id)
        {
            try
            {
                return FilePatternsConverter.toDto(db.FilePatterns.First(obj => obj.Id == id));
            }
            catch
            {
                return null;
            }
        }

        public FilePatternsDto post(FilePatternsDto obj)
        {
            try
            {
                FilePattern newObj = db.FilePatterns.Add(FilePatternsConverter.toDal(obj)).Entity;
                db.SaveChanges();
                return FilePatternsConverter.toDto(newObj);
            }
            catch
            {
                throw;
            }

        }

        public FilePatternsDto put(FilePatternsDto obj)
        {
            try
            {
                FilePattern objToUpdate = db.FilePatterns.First(item=> item.Id== item.Id);
                objToUpdate.FilePatternName = obj.Title;
                objToUpdate.Access = obj.Access;
                db.SaveChanges();
                return FilePatternsConverter.toDto(objToUpdate);
            }
            catch
            {
                throw;
            }
        }

        public FilePatternsDto delete(int id)
        {
            try
            {
                FilePattern objToRemove = db.FilePatterns.First(item=> item.Id==id);
                db.FilePatterns.Remove(objToRemove);
                db.SaveChanges();
                return FilePatternsConverter.toDto(objToRemove);
            }
            catch
            {
                throw;
            }
        }
    }
}
