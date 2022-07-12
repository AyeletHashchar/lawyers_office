using Dal.models;
using EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.converters
{
    public class FilePatternsConverter
    {
        public static FilePatternsDto toDto(FilePattern obj)
        {
            return new FilePatternsDto { Id = obj.Id, Title = obj.FilePatternName, Access = obj.Access };
        }
        public static FilePattern toDal(FilePatternsDto obj)
        {
            return new FilePattern { Id = obj.Id, FilePatternName = obj.Title, Access = obj.Access };
        }
        public static List<FilePatternsDto> toDtoList(List<FilePattern> objList)
        {
            List<FilePatternsDto> l = new List<FilePatternsDto>();
            foreach (FilePattern item in objList)
            {
                l.Add(toDto(item));
            }
            return l;
        }
        public static List<FilePattern> toDalList(List<FilePatternsDto> objList)
        {
            List<FilePattern> l = new List<FilePattern>();
            foreach (FilePatternsDto item in objList)
            {
                l.Add(toDal(item));
            }
            return l;
        }
    }
}
