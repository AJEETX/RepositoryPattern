using System.Linq;

namespace RepositoryPattern.Domain
{
    internal static class Delete
    {
        internal static void Student(ITransactionManager mgr)
        {
            var student = mgr.CreateRepository<Student>();

            var result = student.Get(); //  GET ALL

            student.Delete(result.Count() - 1); //DELETE
            int count=mgr.Save();
        }
        }
    }
