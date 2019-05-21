using System;
using System.Linq;

namespace QuestionIsOverlapProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x1,x2 by separating the input with a comma");
            var input1 = Console.ReadLine();
            Console.WriteLine("Enter the value of x3,x4 by separating the input with a comma");
            var input2 = Console.ReadLine();
            var firstcoordinate = InputToArray(input1);
            var secondcoordinate = InputToArray(input2);
           if(firstcoordinate !=null && secondcoordinate != null)
            {
                if (RightIsLessThanLeft(secondcoordinate[1], firstcoordinate[0]) || RightIsGreaterThanLeft(secondcoordinate[0], firstcoordinate[1]))
                {
                    Console.WriteLine("LINES DOES NOT OVERLAP");
                }
                else
                {
                    Console.WriteLine("LINES DOES OVERLAP");
                }
            }
            
        }
        static int[] InputToArray(string input)
        {
            var a = input.Split(',').Select(c=>int.Parse(c)).ToArray();
            if(a.Length > 1 && a.Length < 3)
            {
                return a;
            }
            return null;
        }
        static bool RightIsLessThanLeft(int x4,int x1)
        {
            return x4 < x1;
        }
        static bool RightIsGreaterThanLeft(int x3, int x2)
        {
            return x3 > x2;
        }
    }
}
