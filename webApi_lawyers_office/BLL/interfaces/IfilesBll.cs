using Dal.models;
using EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IfilesBll
    {
        public List<FilesDto> GetAll();
        public FilesDto GetById(int id);
        public FilesDto post(FilesDto obj);
        public FilesDto put(FilesDto obj);
        public FilesDto delete(int id);

    }
}
