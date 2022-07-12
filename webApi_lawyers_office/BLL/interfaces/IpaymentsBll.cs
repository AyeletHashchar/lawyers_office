using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.models;
using EntitiesDTO;

namespace BLL.interfaces
{
    public interface IpaymentsBll
    {
        public List<PaymentsDto> GetAll();
        public PaymentsDto GetById(int id);
        public PaymentsDto post(PaymentsDto obj);
        public PaymentsDto put(PaymentsDto obj);
        public PaymentsDto delete(int id);
    }
}
