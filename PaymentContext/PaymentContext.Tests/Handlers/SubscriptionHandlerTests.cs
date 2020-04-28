using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.Repositories;
using PaymentContext.Tests.Mocks;
using PaymentContext.Tests.Mocks.Errors;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        SubscriptionHandler handler;
        FakeStudentRepository fakeStudentRepository = new FakeStudentRepository();
        FakeEmailService fakeEmailService = new FakeEmailService();

        
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            fakeStudentRepository.ForcedError = EStudentRepositoryError.DocumentExists;
            handler = new SubscriptionHandler(fakeStudentRepository, fakeEmailService);
            var command = new CreateBoletoSubscriptionCommand();
            
            command.FirstName = "Bruce";
            command.Lastname = "Wayne";
            command.Document = "99999999999";
            command.Email = "wayne@bruce.com"; 
            
            command.BarCode = "123456789";
            command.BoletoNumber = "1234575489342";
            command.PaymentNumber = "123521";

            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 69.99M;
            command.TotalPaid = 69.99M;
            command.Payer = "WAYNE CORP."; 
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "wayneformal@bruce.com";

            command.Street = "Batman Street";
            command.Number = "1000";
            command.Neighborhood = "Coringa Neighborhood";
            command.City = "Gotham City";
            command.State = "GO";
            command.Country = "Batland";
            command.ZipCode = "19384637";

            handler.Handle(command);

            Assert.IsTrue(handler.Invalid);
        }
    }
}