using EmployeeManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string JobDetails { get; set; }
        public string ImagePath { get; set; }
        public string CvPath { get; set; }

        public Employee(string name, string surname, DateTime dateOfBirth, string jobDetails, Gender gender)
        {
            Id = VirtualDatabase.EmployeeIdentity;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            JobDetails = jobDetails;
            Gender = gender;

            VirtualDatabase.EmployeeIdentity += 1;
        }
    }
}
