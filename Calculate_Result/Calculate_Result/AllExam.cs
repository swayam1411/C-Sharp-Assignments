using System;
using System.Linq;

namespace Calculate_Result
{
    public class SSCResult : IResultInterface
    {
        public double CalculateResult()
        {
            int[] subjectArr = new int[5];

            for (int i = 0; i < subjectArr.Length; i++)
            {
                Console.Write($"Enter Marks Of {i + 1} Subject outof(100) => ");
                subjectArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return subjectArr.Sum() / 5;
        }
    }

    public class NIITResult : IResultInterface
    {
        public double CalculateResult()
        {
            Console.Write("Enter CGPA Of NIIT outof(10) => ");
            double cgpa = Convert.ToDouble(Console.ReadLine());
            return cgpa * 9.5;
        }
    }

    public class IITResult : IResultInterface
    {
        public double CalculateResult()
        {
            Console.Write("Enter CGPA Of IIT outof(10) => ");
            double cgpa = Convert.ToDouble(Console.ReadLine());
            return cgpa * 10;
        }
    }

}
