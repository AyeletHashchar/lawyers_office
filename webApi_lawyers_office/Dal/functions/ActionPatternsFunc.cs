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
    public class ActionPatternsFunc : IactionPatterns
    {
        Layers_OfficeContext db;
        public ActionPatternsFunc(Layers_OfficeContext _db)
        {
            db = _db;
        }

        public List<ActionPatternsDto> GetAll()
        {
            return ActionPatternsConverter.toDtoList(db.ActionPatterns.ToList());
        }

        public ActionPatternsDto GetById(int id)
        {
            try
            {
                return ActionPatternsConverter.toDto(db.ActionPatterns.First(obj => obj.Id == id));
            }
            catch
            {
                return null;
            }
        }

        public ActionPatternsDto post(ActionPatternsDto obj)
        {
            try
            {
                ActionPattern newObj = db.ActionPatterns.Add(ActionPatternsConverter.toDal(obj)).Entity;
                db.SaveChanges();
                return ActionPatternsConverter.toDto(newObj);
            }
            catch
            {
                throw;
            }

        }

        public ActionPatternsDto put(ActionPatternsDto obj)
        {
            try
            {
                ActionPattern objToUpdate = db.ActionPatterns.First(item=> item.Id== item.Id);

                objToUpdate.ActionPatternName = obj.Title;
                objToUpdate.Discription = obj.Discription;
                objToUpdate.FilePatternId = obj.FilePatternId;
                objToUpdate.ActionLevel = obj.Level;
                objToUpdate.LinkId = obj.LinkId;
                objToUpdate.PaymentId = obj.PaymentId;
                objToUpdate.WaitingForPatternId = obj.WaitingForActionPatternId;
                objToUpdate.WhomFor = ActionPatternsConverter.toDal(obj).WhomFor;

                db.SaveChanges();
                return ActionPatternsConverter.toDto(objToUpdate);
            }
            catch
            {
                throw;
            }
        }

        public ActionPatternsDto delete(int id)
        {
            try
            {
                ActionPattern objToRemove = db.ActionPatterns.First(item=> item.Id==id);
                db.ActionPatterns.Remove(objToRemove);
                db.SaveChanges();
                return ActionPatternsConverter.toDto(objToRemove);
            }
            catch
            {
                throw;
            }
        }
    }
}
