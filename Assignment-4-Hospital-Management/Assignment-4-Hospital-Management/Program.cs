using System;
using System.IO;
namespace HospitalManagement
{
    class Program
    {
        public static void AddPatient()
        {
            Console.WriteLine("\nEnter Patient's Full Name => ");
            string patientName = Console.ReadLine();
            Console.WriteLine("Enter Symptoms => ");
            string symptoms = Console.ReadLine();
            Console.WriteLine("Enter Treatment => ");
            string treatment = Console.ReadLine();
            Console.WriteLine("Enter Doctor Name => ");
            string doctorName = Console.ReadLine();
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string filePath = @"C:\Users\Computer\Desktop\GitHub\" + patientName + ".txt";
            if(!File.Exists(filePath))
            {
                using (StreamWriter insertInFile = File.CreateText(filePath))
                {
                    insertInFile.WriteLine(patientName + "\t" + symptoms + "\t" + treatment + "\t" + doctorName + "\t" + date);
                    Console.WriteLine("Patient's record added Sucessfully..!!\n");
                }
            }
            else
            {
                using (StreamWriter insertInFile = File.AppendText(filePath))
                {
                    insertInFile.WriteLine(patientName + "\t" + symptoms + "\t" + treatment + "\t" + doctorName + "\t" + date);
                    Console.WriteLine("Patient's another record is added Sucessfully..!!\n");
                }
            }
        }
        public static void DisplayPatient()
        {
            Console.WriteLine("\nEnter Patient's Full Name=>");
            string patientName = Console.ReadLine();
            string filePath = @"C:\Users\Computer\Desktop\GitHub\" + patientName + ".txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("******************************************");
                foreach (string readFromFile in File.ReadLines(filePath))
                    Console.WriteLine(readFromFile);
                Console.WriteLine("******************************************");
            }
            else
                Console.WriteLine($"Their is no Record For {patientname} Patient\n");
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n1:Add Patient Details");
                Console.WriteLine("2:Display Patient Details");
                Console.WriteLine("0:Exit");
                Console.Write("Enter Your Choice =>");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddPatient();
                        break;
                    case 2:
                        DisplayPatient();
                        break;
                    case 0:
                        Console.WriteLine("Thank You..!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 0);
        }
    }
}
