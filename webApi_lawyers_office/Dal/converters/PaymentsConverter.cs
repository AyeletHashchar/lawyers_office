using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.models;
using EntitiesDTO;

namespace Dal.converters
{
    public class PaymentsConverter
    {
        public static PaymentsDto toDto(Payment obj)
        {
            return new PaymentsDto { 
                Id= obj.Id,
                PaymentName = obj.PaymentName,
                //ActionPatterns = obj.ActionPatterns
                Discription=obj.Discription,
                FinalSum=obj.FinalSum,
                PaySum=obj.PaySum,
                SumOff=obj.SumOff,
                WhoToPay = obj.WhoToPay
            };
        }
        public static Payment toDal(PaymentsDto obj)
        {
            return new Payment
            {
                Id = obj.Id,
                PaymentName = obj.PaymentName,
                //ActionPatterns = obj.ActionPatterns
                Discription = obj.Discription,
                FinalSum = obj.FinalSum,
                PaySum = obj.PaySum,
                SumOff = obj.SumOff,
                WhoToPay = obj.WhoToPay
            };
        }

        public static List<PaymentsDto> toDtoList(List<Payment> objects)
        {
            List<PaymentsDto> l = new List<PaymentsDto>();
            foreach (Payment item in objects)
            {
                l.Add(toDto(item));
            }
            return l;
        }
        public static List<Payment> toDalList(List<PaymentsDto> objects)
        {
            List<Payment> l = new List<Payment>();
            foreach (PaymentsDto item in objects)
            {
                l.Add(toDal(item));
            }
            return l;
        }
    }
}
