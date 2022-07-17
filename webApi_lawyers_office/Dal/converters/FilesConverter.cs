using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.models;
using EntitiesDTO;

namespace Dal.converters
{
    public class FilesConverter
    {
        public static FilesDto toDto(File obj)
        {
            return new FilesDto { Id = obj.Id, FileDirection = obj.FileDir, BagId = obj.BagId, FilePatternId = obj.FilePatternId };
        }
        public static  File toDal(FilesDto obj)
        {
            return new File { Id = obj.Id, FileDir = obj.FileDirection, FilePatternId = obj.FilePatternId, BagId = obj.BagId };
        }
        public static List<FilesDto> toDtoList(List<File> objList)
        {
            List<FilesDto> l = new List<FilesDto>();
            foreach (File item in objList)
            {
                l.Add(toDto(item));
            }
            return l;
        }
        public static List<File> toDalList(List<FilesDto> objList)
        {
            List<File> l = new List<File>();
            foreach (FilesDto item in objList)
            {
                l.Add(toDal(item));
            }
            return l;
        }
    }
}
