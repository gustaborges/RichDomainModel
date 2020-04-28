using System;
using System.Linq.Expressions;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Queries
{
    public static class StudentQueries
    {
        // Pode ser usado, por exemplo, no comando Where do Linq :)
        public static Expression<Func<Student, bool>> GetStudentInfo(string document)
        {
            return x => x.Document.Number == document;
        }
    }
}