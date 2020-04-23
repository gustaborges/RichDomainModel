namespace PaymentContext.Domain.ValueObjects
{
    public class Email
    {

        public Email(string address)
        {
            this.Address = address;
        }
        
        public string Address { get; set; }
    }
}