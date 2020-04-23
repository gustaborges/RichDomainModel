using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastname)
        {
            this.FirstName = firstName;
            this.Lastname = lastname;
        }
        
        public string FirstName { get; private set; }
        public string Lastname { get; private set; }
    }
}