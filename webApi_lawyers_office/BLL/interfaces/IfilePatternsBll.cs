using Dal.models;
using EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IfilePatternsBll
    {
        public List<FilePatternsDto> GetAll();
        public FilePatternsDto GetById(int id);
        public FilePatternsDto post(FilePatternsDto obj);
        public FilePatternsDto put(FilePatternsDto obj);
        public FilePatternsDto delete(int id);

    }
}
