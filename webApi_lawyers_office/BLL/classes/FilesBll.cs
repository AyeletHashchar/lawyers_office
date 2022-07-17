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

    public class FilesBll : IfilesBll
    {  
        public Ifiles dal;
        public FilesBll(Ifiles _dal)
        {
            dal = _dal;
        }

        public List<FilesDto> GetAll()
        {
            return dal.GetAll();
        }

        public FilesDto GetById(int id)
        {
            return dal.GetById(id);
        }

        public FilesDto post(FilesDto obj)
        {
            return dal.post(obj);
        }

        public FilesDto put(FilesDto obj)
        {
            return dal.put(obj);
        }   

        public FilesDto delete(int id)
        {
            return dal.delete(id);
        }
    }
}
