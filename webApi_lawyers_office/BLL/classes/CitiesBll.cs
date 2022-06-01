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

    public class CitiesBll : IcitiesBll
    {  
        public Icities dal;
        public CitiesBll(Icities _dal)
        {
            dal = _dal;
        }
        public List<CitiesDto> GetAll()
        {
            return dal.GetAll();
        }

        public CitiesDto GetById(int id)
        {
            return dal.GetById(id);
        }

        public City post(CitiesDto c)
        {
            return dal.post(c);
        }
    }
}
