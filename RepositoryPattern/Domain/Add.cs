using System;

namespace RepositoryPattern.Domain
{
    internal static class Add
    {
        internal static void Student(ITransactionManager mgr)
        {
            var student = mgr.CreateRepository<Student>();
            var result = student.Get(); //  GET ALL
            foreach (var item in result)
            {
                Console.WriteLine($" #{item.StudentId} {item.FirstName} {item.LastName} {item.DateOfBirth.Value.ToString()}");
            }
            var newStudent = new Student
            {
                FirstName = "aby",
                LastName = "baby",
                DateOfBirth = DateTime.Now.AddYears(-15),
                DateOfRegistration = DateTime.Now.AddDays(-15),
                Address1 = "Address1",
                Address2 = "Address2",
                City = "City",
                Email = "aby@mail.com",
                Gender = "Male",
                PhoneNumber = "8989898989",
                State = "State",
                Zip = "2222"
            }; // ADD
            student.Add(newStudent);
            int count = mgr.Save();
            result = student.Get(); //  GET ALL
            foreach (var item in result)
            {
                Console.WriteLine($" #{item.StudentId} {item.FirstName} {item.LastName} {item.DateOfBirth.Value.ToString()}");
            }
        }
    }
}
