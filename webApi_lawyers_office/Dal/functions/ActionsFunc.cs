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
    public class ActionsFunc : Iactions
    {
        Layers_OfficeContext db;
        public ActionsFunc(Layers_OfficeContext _db)
        {
            db = _db;
        }

        public List<ActionsDto> GetAll()
        {
            return ActionsConverter.toDtoList(db.Actions.ToList());
        }

        public ActionsDto GetById(int id)
        {
            try
            {
                return ActionsConverter.toDto(db.Actions.First(obj => obj.Id == id));
            }
            catch
            {
                return null;
            }
        }

        public ActionsDto post(ActionsDto obj)
        {
            try
            {
                models.Action newObj = db.Actions.Add(ActionsConverter.toDal(obj)).Entity;
                db.SaveChanges();
                return ActionsConverter.toDto(newObj);
            }
            catch
            {
                throw;
            }

        }

        public ActionsDto put(ActionsDto obj)
        {
            try
            {
                models.Action objToUpdate = db.Actions.First(item=> item.Id== item.Id);
                
                objToUpdate.Id = obj.Id;
                objToUpdate.ActionPatternId = obj.ActionPatternId;
                objToUpdate.Comments = obj.Comments;
                objToUpdate.DeadLine = obj.DeadLine;
                objToUpdate.ActionState = obj.ActionState;
                objToUpdate.ActionFileId = obj.ActionFileId;
                objToUpdate.ActionPriority = obj.ActionPriority;
                objToUpdate.CreatedDate = obj.CreatedDate;

                db.SaveChanges();
                return ActionsConverter.toDto(objToUpdate);
            }
            catch
            {
                throw;
            }
        }

        public ActionsDto delete(int id)
        {
            try
            {
                models.Action objToRemove = db.Actions.First(item=> item.Id==id);
                db.Actions.Remove(objToRemove);
                db.SaveChanges();
                return ActionsConverter.toDto(objToRemove);
            }
            catch
            {
                throw;
            }
        }
    }
}
