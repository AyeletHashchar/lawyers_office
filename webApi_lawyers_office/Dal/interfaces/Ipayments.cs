using Dal.models;
using EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.interfaces
{
    public interface Ipayments
    {
        public List<PaymentsDto> GetAll();
        public PaymentsDto GetById(int id);
        public PaymentsDto post(PaymentsDto obj);
        public PaymentsDto put(PaymentsDto obj);
        public PaymentsDto delete(int id);
    }
}
