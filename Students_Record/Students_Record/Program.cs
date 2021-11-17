using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_Record
{
    class Program
    {
        public static void Add(List<Student> students)
        {
            Console.Write("\nEnter Student Name=> ");
            string Name = Console.ReadLine();
            Console.Write("Enter Student Age=> ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Gender[1:girl / 2:boy]=> ");
            int gender = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Class[Integer]=> ");
            int Class = Convert.ToInt32(Console.ReadLine());

            students.Add(new Student(Name, Age, (Gender)gender, Class));
            Console.WriteLine("Student Data Sucessfully Added\n");
        }
        public static void Display(List<Student> students)
        {
            Dictionary<int, List<Student>> record = new Dictionary<int, List<Student>>()
            {
                {1 , students.Where(s => s.gender == Gender.girl).ToList()},
                {2 , students.Where(s => s.gender == Gender.boy).ToList()},
                {3 , students.OrderBy(s => s.Class).ToList()}
            };

            Console.WriteLine("\n1. Display Girls Record");
            Console.WriteLine("2. Display Boys Record");
            Console.WriteLine("3. Display Record Of Student in Sorted By Standard");

            Console.Write("Enter Your Choice => ");
            int choice = Convert.ToInt32(Console.ReadLine());

            foreach(var key in record)
            {
                if(key.Key==choice)
                {
                    Console.WriteLine("\n*********************************");
                    foreach (var student in key.Value)
                    {
                        Console.WriteLine(student.Name + " " + student.Age + " " + student.gender + " " + student.Class);
                    }
                    Console.WriteLine("*********************************\n");
                }
            }
        }
        static void Main(string[] args)
        {
            int choice;
            List<Student> students = new List<Student>();
            do
            {
                Console.WriteLine("1. Add Student Data");
                Console.WriteLine("2. Display Student Data");
                Console.WriteLine("0. Exit");

                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Add(students);
                        break;
                    case 2:
                        Display(students);
                        break;
                    case 0:
                        Console.WriteLine("Thank You..!!\n");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice\n");
                        break;
                }
            } while (choice != 0);
        }
    }
}
