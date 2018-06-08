using System;

namespace RepositoryPattern.Domain
{
    internal static class Get
    {
        internal static void Student(ITransactionManager mgr)
        {
            var student = mgr.CreateRepository<Student>();

            var result = student.Get(); //  GET ALL
            foreach (var item in result)
            {
                Console.WriteLine($" #{item.StudentId} {item.FirstName} {item.LastName} {item.DateOfBirth.Value.ToString()}");
            }
        }
    }
}
