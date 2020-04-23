using System;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        public string Number { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; } // Proprietário do pagamento
        public string Document { get; set; }
        public string Address { get; set; }
    }

    public class BoletoPayment : Payment
    {

    }

    public class CreditCardPayment : Payment
    {

    }

    public class PayPalPayment : Payment
    {

    }
}