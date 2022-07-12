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

    public class FilePatternsBll : IfilePatternsBll
    {  
        public IfilePatterns dal;
        public FilePatternsBll(IfilePatterns _dal)
        {
            dal = _dal;
        }

        public List<FilePatternsDto> GetAll()
        {
            return dal.GetAll();
        }

        public FilePatternsDto GetById(int id)
        {
            return dal.GetById(id);
        }

        public FilePatternsDto post(FilePatternsDto obj)
        {
            return dal.post(obj);
        }

        public FilePatternsDto put(FilePatternsDto obj)
        {
            return dal.put(obj);
        }   

        public FilePatternsDto delete(int id)
        {
            return dal.delete(id);
        }
    }
}
