using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document
    {
        public Document(string number)
        {
            this.Number = number;

        }
        public string Number { get; private set; }
        public EDocumentType Type { get; set; }

    }
}