﻿using Dal.models;
using EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.interfaces
{
    public interface Icities
    {
        public List<CitiesDto> GetAll();
        public CitiesDto GetById(int id);
        public CitiesDto post(CitiesDto obj);
        public CitiesDto put(CitiesDto obj);
        public CitiesDto delete(int id);

    }
}
