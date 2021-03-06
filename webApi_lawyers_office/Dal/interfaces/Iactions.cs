using Dal.models;
using EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.interfaces
{
    public interface Iactions
    {
        public List<ActionsDto> GetAll();
        public ActionsDto GetById(int id);
        public ActionsDto post(ActionsDto obj);
        public ActionsDto put(ActionsDto obj);
        public ActionsDto delete(int id);

    }
}
