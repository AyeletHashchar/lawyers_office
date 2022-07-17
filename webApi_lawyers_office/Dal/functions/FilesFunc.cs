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
    public class FilesFunc : Ifiles
    {
        Layers_OfficeContext db;
        public FilesFunc(Layers_OfficeContext _db)
        {
            db = _db;
        }

        public List<FilesDto> GetAll()
        {
            return FilesConverter.toDtoList(db.Files.ToList());
        }

        public FilesDto GetById(int id)
        {
            try
            {
                return FilesConverter.toDto(db.Files.First(obj => obj.Id == id));
            }
            catch
            {
                return null;
            }
        }

        public FilesDto post(FilesDto obj)
        {
            try
            {
                File newObj = db.Files.Add(FilesConverter.toDal(obj)).Entity;
                db.SaveChanges();
                return FilesConverter.toDto(newObj);
            }
            catch
            {
                throw;
            }

        }

        public FilesDto put(FilesDto obj)
        {
            try
            {
                File objToUpdate = db.Files.First(item=> item.Id== item.Id);

                objToUpdate.FileDir = obj.FileDirection;
                objToUpdate.BagId = obj.BagId;
                objToUpdate.FilePatternId = obj.FilePatternId;

                db.SaveChanges();
                return FilesConverter.toDto(objToUpdate);
            }
            catch
            {
                throw;
            }
        }

        public FilesDto delete(int id)
        {
            try
            {
                File objToRemove = db.Files.First(item=> item.Id==id);
                db.Files.Remove(objToRemove);
                db.SaveChanges();
                return FilesConverter.toDto(objToRemove);
            }
            catch
            {
                throw;
            }
        }
    }
}
