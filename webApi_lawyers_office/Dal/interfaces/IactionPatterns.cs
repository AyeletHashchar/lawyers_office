using Dal.models;
using EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.interfaces
{
    public interface IactionPatterns
    {
        public List<ActionPatternsDto> GetAll();
        public ActionPatternsDto GetById(int id);
        public ActionPatternsDto post(ActionPatternsDto obj);
        public ActionPatternsDto put(ActionPatternsDto obj);
        public ActionPatternsDto delete(int id);

    }
}
