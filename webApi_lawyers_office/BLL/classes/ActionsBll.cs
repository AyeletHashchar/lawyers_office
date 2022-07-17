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

    public class ActionsBll : IactionsBll
    {  
        public Iactions dal;
        public ActionsBll(Iactions _dal)
        {
            dal = _dal;
        }

        public List<ActionsDto> GetAll()
        {
            return dal.GetAll();
        }

        public ActionsDto GetById(int id)
        {
            return dal.GetById(id);
        }

        public ActionsDto post(ActionsDto obj)
        {
            return dal.post(obj);
        }

        public ActionsDto put(ActionsDto obj)
        {
            return dal.put(obj);
        }   

        public ActionsDto delete(int id)
        {
            return dal.delete(id);
        }
    }
}
