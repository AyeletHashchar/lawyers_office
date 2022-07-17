using Dal.converters;
using Dal.interfaces;
using Dal.models;
using EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.functions
{
    public class PaymentsFunc : Ipayments
    {
        Layers_OfficeContext db;
        public PaymentsFunc(Layers_OfficeContext _db)
        {
            db = _db;
        }
        public List<PaymentsDto> GetAll()
        {
            return PaymentsConverter.toDtoList(db.Payments.ToList());
        }

        public PaymentsDto GetById(int id)
        {
            try
            {
                return PaymentsConverter.toDto(db.Payments.First(p => p.Id == id));
            }
            catch
            {
                return null;
            }
        }

        public PaymentsDto post(PaymentsDto p)
        {
            try
            {
                Payment newPayment = db.Payments.Add(PaymentsConverter.toDal(p)).Entity;
                db.SaveChanges();
                return PaymentsConverter.toDto(newPayment);
            }
            catch
            {
                throw;
            }
        }

        public PaymentsDto put(PaymentsDto obj)
        {
            try
            {
                Payment objToUpdate = db.Payments.First(item => item.Id == obj.Id);

                objToUpdate.PaySum = obj.PaySum;
                objToUpdate.SumOff = obj.SumOff;
                objToUpdate.PaymentName = obj.PaymentName;
                objToUpdate.WhoToPay = obj.WhoToPay;
                objToUpdate.Discription = obj.Discription;
                objToUpdate.FinalSum = obj.FinalSum;

                db.SaveChanges();
                return PaymentsConverter.toDto(objToUpdate);
            }
            catch
            {
                throw;
            }
        }

        public PaymentsDto delete(int id)
        {
            try
            {
                Payment objToRemove = db.Payments.First(item => item.Id == id);
                db.Payments.Remove(objToRemove);
                db.SaveChanges();
                return PaymentsConverter.toDto(objToRemove);
            }
            catch
            {
                throw;
            }
        }
    }
}
