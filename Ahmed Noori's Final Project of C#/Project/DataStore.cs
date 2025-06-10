using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    public static class DataStore
    {
        public static List<Student> Students { get; } = new List<Student>
        {
            new Student { Name = "Ahmed", Age = 20, Class = "Class A", EnrollmentDate = new DateTime(2021, 9, 1) },
            new Student { Name = "Hussein", Age = 22, Class = "Class B", EnrollmentDate = new DateTime(2022, 1, 15) },
            new Student { Name = "Ali", Age = 19, Class = "Class C", EnrollmentDate = new DateTime(2023, 5, 10) }
        };
    }
}
