using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Domain.Enums;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student(
                new Name("Gustavo", "Carvalho"),
                new Document("12345678912", EDocumentType.CPF),
                new Email("gustavo@gb.com")
                );

            student.AddSubscription(subscription);
        }
    }
}


