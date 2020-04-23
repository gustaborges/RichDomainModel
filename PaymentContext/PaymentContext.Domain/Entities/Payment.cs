using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        protected Payment(string number, DateTime paidDate, DateTime expiredDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpiredDate = expiredDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;
        }

        public string Number { get; set; } // 8-9 dígitos
        public DateTime PaidDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; } // Proprietário do pagamento
        public Document Document { get; set; }
        public Address Address { get; set; }
        public Email Email { get; set; }

    }

}