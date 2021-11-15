using System;
using System.Collections.Generic;
using System.Text;

namespace Students_Record
{
    class Student
    {
        public string Name;
        public int Age;
        public Gender gender;
        public int Class;

        public Student(string Name , int Age , Gender gender , int Class)
        {
            this.Name = Name;
            this.Age = Age;
            this.gender = gender;
            this.Class = Class;
        }

    }
}
