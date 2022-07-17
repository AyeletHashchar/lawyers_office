using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDTO
{
    public class FilesDto
    {
        public int Id { get; set; }
        public string FileDirection { get; set; }
        public int BagId { get; set; }
        public int FilePatternId { get; set; }
    }
}
