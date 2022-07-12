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

    public class LinksBll : IlinksBll
    {
        public Ilinks dal;
        public LinksBll(Ilinks _dal)
        {
            dal = _dal;
        }

        public List<LinksDto> GetAll()
        {
            return dal.GetAll();
        }

        public LinksDto GetById(int id)
        {
            return dal.GetById(id);
        }

        public LinksDto post(LinksDto obj)
        {
            return dal.post(obj);
        }

        public LinksDto put(LinksDto obj)
        {
            return dal.put(obj);
        }

        public LinksDto delete(int id)
        {
            return dal.delete(id);
        }
    }
}
