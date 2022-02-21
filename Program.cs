using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Co-ordinates value for the Length of Line");
            UC_1CalculateTheLength.LenghtBtwnTwoPoint();

            Console.WriteLine("Enter Co-ordinates value to Check Equality of two Lines");
            UC_2CheckEquality.CheckEqualityOfTwoLines();

            Console.WriteLine("Enter Co-ordinates value to Check Comparison of two Lines");
            UC_3CompareTwoLines.CompareTwoLineForGrtEqlLessThan();

        }
    }

}