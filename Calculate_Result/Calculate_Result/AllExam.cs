using System;
using System.Linq;

namespace Calculate_Result
{
    public class SSCResult : IResultInterface
    {
        public double CalculateResult()
        {
            int[] SubjectArr = new int[5];

            for (int i = 0; i < SubjectArr.Length; i++)
            {
                Console.Write($"Enter Marks Of {i + 1} Subject outof(100) => ");
                SubjectArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Total = SubjectArr.Sum();
            double PERCENTAGE = Total / 5;
            return PERCENTAGE;
        }
    }

    public class NIITResult : IResultInterface
    {
        public double CalculateResult()
        {
            Console.Write("Enter CGPA Of NIIT outof(10) => ");
            double CGPA = Convert.ToDouble(Console.ReadLine());
            double PERCENTAGE = CGPA * 9.5;
            return PERCENTAGE;
        }
    }

    public class IITResult : IResultInterface
    {
        public double CalculateResult()
        {
            Console.Write("Enter CGPA Of IIT outof(10) => ");
            double CGPA = Convert.ToDouble(Console.ReadLine());
            double PERCENTAGE = CGPA * 10;
            return PERCENTAGE;
        }
    }

}
