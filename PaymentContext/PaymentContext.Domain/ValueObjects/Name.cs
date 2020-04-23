using System;
using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastname)
        {
            this.FirstName = firstName;
            this.Lastname = lastname;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(firstName, 3, "Name.FirstName", "Nome deve possuir pelo menos 3 caracteres.")
                .HasMinLen(lastname, 3, "Name.LastName", "Sobrenome deve possuir pelo menos 3 caracteres.")
                .HasMaxLen(firstName, 40, "Name.FirstName", "Nome deve possuir até 40 caracteres.")
            );
        }
        
        public string FirstName { get; private set; }
        public string Lastname { get; private set; }
    }
}