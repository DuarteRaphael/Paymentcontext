using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
    }
    public class BoletoPayment
    {

    }
    public class CreditCardPayment
    {

    }
    public class PayPalPayment
    {

    }
}
