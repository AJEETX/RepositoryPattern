namespace RepositoryPattern
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Student
    {
        public long StudentId { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateOfBirth { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateOfRegistration { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string Gender { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }
    }
}
