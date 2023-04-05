﻿namespace TestSchool.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int AddressId { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Address Address { get; set; }
    }
}
