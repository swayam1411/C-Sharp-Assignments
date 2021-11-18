using System;
using System.IO;

namespace Assignment_4_Hospital_Management
{
    class Program
    {
        public static void AddPatient()
        {
            Console.WriteLine("\nEnter Patient's Full Name => ");
            string patientname = Console.ReadLine();
            Console.WriteLine("Enter Symptoms => ");
            string symptoms = Console.ReadLine();
            Console.WriteLine("Enter Treatment => ");
            string treatment = Console.ReadLine();
            Console.WriteLine("Enter Doctor Name => ");
            string doctor_name = Console.ReadLine();

            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string filepath = @"C:\Users\Computer\Desktop\GitHub\" + patientname + ".txt";
            if(!File.Exists(filepath))
            {
                using (StreamWriter insertinfile = File.CreateText(filepath))
                {
                    insertinfile.WriteLine(patientname + "\t" + symptoms + "\t" + treatment + "\t" + doctor_name + "\t" + date);
                    Console.WriteLine("Patient's record added Sucessfully..!!\n");
                }
            }
            else
            {
                using (StreamWriter insertinfile = File.AppendText(filepath))
                {
                    insertinfile.WriteLine(patientname + "\t" + symptoms + "\t" + treatment + "\t" + doctor_name + "\t" + date);
                    Console.WriteLine("Patient's another record is added Sucessfully..!!\n");
                }
            }
        }

        public static void DisplayPatient()
        {
            Console.WriteLine("\nEnter Patient's Full Name=> ");
            string patientname = Console.ReadLine();
            string filepath = @"C:\Users\Computer\Desktop\GitHub\" + patientname + ".txt";
            if (File.Exists(filepath))
            {
                Console.WriteLine("******************************************");
                foreach (string readfromfile in File.ReadLines(filepath))
                    Console.WriteLine(readfromfile);
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
                Console.WriteLine("\n1: Add Patient Details");
                Console.WriteLine("2: Display Patient Details");
                Console.WriteLine("0: Exit");

                Console.Write("Enter Your Choice => ");
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