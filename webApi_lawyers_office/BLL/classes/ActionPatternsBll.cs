using BLL.interfaces;
using Dal.interfaces;
using Dal.models;
using EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.classes
{

    public class ActionPatternsBll : IactionPatternsBll
    {  
        public IactionPatterns dal;
        public ActionPatternsBll(IactionPatterns _dal)
        {
            dal = _dal;
        }

        public List<ActionPatternsDto> GetAll()
        {
            return dal.GetAll();
        }

        public ActionPatternsDto GetById(int id)
        {
            return dal.GetById(id);
        }

        public ActionPatternsDto post(ActionPatternsDto obj)
        {
            return dal.post(obj);
        }

        public ActionPatternsDto put(ActionPatternsDto obj)
        {
            return dal.put(obj);
        }   

        public ActionPatternsDto delete(int id)
        {
            return dal.delete(id);
        }
    }
}
