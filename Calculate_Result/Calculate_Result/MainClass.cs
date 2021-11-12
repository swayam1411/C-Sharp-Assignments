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
            string Name = Console.ReadLine();
            Console.Write("Enter Class Name from (SSC/NIIT/IIT) => ");
            string Exam = Console.ReadLine();
            if (Exam == "SSC")
            {
                IObject = new SSCResult();
                double PERCENTAGE = IObject.CalculateResult();
                Students.Add(new Student(Name, Exam, PERCENTAGE));
            }
            else if (Exam == "NIIT")
            {
                IObject = new NIITResult();
                double PERCENTAGE = IObject.CalculateResult();
                Students.Add(new Student(Name, Exam, PERCENTAGE));
            }
            else if (Exam == "IIT")
            {
                IObject = new IITResult();
                double PERCENTAGE = IObject.CalculateResult();
                Students.Add(new Student(Name, Exam, PERCENTAGE));
            }
        }

        public static void DisplayStudent(List<Student> Students)
        {
            Dictionary<string, List<Student>> Record = new Dictionary<string, List<Student>>()
                        {
                            { "SSC" ,Students.Where(s => s.Exam == "SSC").ToList() },
                            { "NIIT" , Students.Where(s => s.Exam == "NIIT").ToList() },
                            { "IIT" , Students.Where(s => s.Exam == "IIT").ToList() }
                        };
            foreach (var Key in Record)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine($"Result Of {Key.Key} Exam");
                foreach (var student in Key.Value)
                    Console.WriteLine(student.Name + " " + student.Exam + " " + student.PERCENTAGE + "%");
            }
        }

        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();

            int Choice = 0;
            do
            {
                Console.WriteLine("***********************");
                Console.WriteLine("1. Add Student Details");
                Console.WriteLine("2. Display Student Details");
                Console.WriteLine("0. Exit");

                Console.Write("Enter Your Choice: ");
                Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        AddStudent(Students);
                        break;
                    case 2:
                        DisplayStudent(Students);
                        break;
                    case 0:
                        Console.WriteLine("Thank You...!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }
            } while (Choice != 0);
        }
    }
}