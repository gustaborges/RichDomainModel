using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var student = new Student(
                firstName: "Gustavo",
                lastname: "Carvalho",
                document: "12345678912",
                email: "gustavo@gb.com"
                );
            
            

        }
    }
}


