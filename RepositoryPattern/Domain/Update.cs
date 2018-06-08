using System;

namespace RepositoryPattern.Domain
{
    class Update
    {
        internal static void Student(ITransactionManager mgr)
        {
            var student = mgr.CreateRepository<Student>();
            var ajeet = student.GetById(1); // GetById
            ajeet.LastName = "Tiwari";
            student.Update(ajeet); //Update
            ajeet = student.GetById(1);
            Console.WriteLine($"{ajeet.LastName}");
        }
    }
}
