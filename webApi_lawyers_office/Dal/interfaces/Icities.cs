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
        public City post(CitiesDto c);
    }
}