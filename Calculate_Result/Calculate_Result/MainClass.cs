using System;
using System.Linq;
using System.Collections.Generic;

namespace Calculate_Result
{
    class MainClass
    {
        public static void AddStudent(List<Student> Students)
        {
            IResultInterface IObject;
            
            Console.Write("Enter Student Name => ");
            string name = Console.ReadLine();
            Console.Write("Enter Class Name from (SSC/NIIT/IIT) => ");
            string exam = Console.ReadLine();
            if (exam == "SSC")
            {
                IObject = new SscResult();
                double percentage = IObject.CalculateResult();
                Students.Add(new Student(name, exam, percentage));
            }
            else if (exam == "NIIT")
            {
                IObject = new NiitResult();
                double percentage = IObject.CalculateResult();
                Students.Add(new Student(name, exam, percentage));
            }
            else if (exam == "IIT")
            {
                IObject = new IitResult();
                double percentage = IObject.CalculateResult();
                Students.Add(new Student(name, exam, percentage));
            }
        }

        public static void DisplayStudent(List<Student> Students)
        {
            Dictionary<string, List<Student>> record = new Dictionary<string, List<Student>>()
                        {
                            { "SSC" ,Students.Where(s => s.exam == "SSC").ToList() },
                            { "NIIT" , Students.Where(s => s.exam == "NIIT").ToList() },
                            { "IIT" , Students.Where(s => s.exam == "IIT").ToList() }
                        };
            foreach (var Key in record)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine($"Result Of {Key.Key} Exam");
                foreach (var student in Key.Value)
                    Console.WriteLine(student.name + " " + student.exam + " " + student.percentage + "%");
            }
        }

        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();

            int choice = 0;
            do
            {
                Console.WriteLine("***********************");
                Console.WriteLine("1. Add Student Details");
                Console.WriteLine("2. Display Student Details");
                Console.WriteLine("0. Exit");

                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent(Students);
                        break;
                    case 2:
                        DisplayStudent(Students);
                        break;
                    case 0:
                        Console.WriteLine("Thank You");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 0);
            
        }
    }
}
