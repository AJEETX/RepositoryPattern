using RepositoryPattern.Domain;
using System;
namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mgr = Config.GetManager();
            Get.Student(mgr);
            Add.Student(mgr);
            Update.Student(mgr);
            Delete.Student(mgr);
            Console.ReadLine();
        }
 
    }
}
