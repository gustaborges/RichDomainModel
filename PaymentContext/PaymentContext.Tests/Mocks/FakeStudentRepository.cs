using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;
using PaymentContext.Tests.Mocks.Errors;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentRepository
    {


        public void CreateSubscription(Student student)
        {

        }

        public bool DocumentExists(string document)
        {
            if(ForcedError == EStudentRepositoryError.DocumentExists)
                return true;
            return false;
        }

        public bool EmailExists(string email)
        {
            if(ForcedError == EStudentRepositoryError.EmailExists)
                return true;
            return false;
        }

        public EStudentRepositoryError ForcedError { get; set; } = EStudentRepositoryError.None;
    }
}