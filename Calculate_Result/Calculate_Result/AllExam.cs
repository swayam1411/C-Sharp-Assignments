using System;
using System.Linq;

namespace Calculate_Result
{
    public class SscResult : IResultInterface
    {
        public double CalculateResult()
        {
            int[] subjectArr = new int[5];

            for (int i = 0; i < subjectArr.Length; i++)
            {
                Console.Write($"Enter Marks Of {i + 1} Subject outof(100) => ");
                subjectArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = subjectArr.Sum();
            double percentage = otal / 5;
            return percentage;
        }
    }

    public class NiitResult : IResultInterface
    {
        public double CalculateResult()
        {
            Console.Write("Enter CGPA Of NIIT outof(10) => ");
            double cgpa = Convert.ToDouble(Console.ReadLine());
            double percentage = cgpa * 9.5;
            return percentage;
        }
    }

    public class IitResult : IResultInterface
    {
        public double CalculateResult()
        {
            Console.Write("Enter CGPA Of IIT outof(10) => ");
            double cgpa = Convert.ToDouble(Console.ReadLine());
            double percentage = cgpa * 10;
            return percentage;
        }
    }

}
