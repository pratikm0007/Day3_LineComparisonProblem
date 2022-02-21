using System;

namespace LineComparisonProblem
{
    public class UC_2CheckEquality
    {
        public static double lengthOfLine2;
        public static void CheckEqualityOfTwoLines()
        {
            UC_1CalculateTheLength.LenghtBtwnTwoPoint();

            Console.WriteLine("Enter value for 2nd Line point1 isX11 ");
            double isX11 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 2nd Line point1 isY11 ");
            double isY11 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 2nd Line point2 isX22 ");
            double isX22 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for 2nd Line point2 isY22 ");
            double isY22 = Convert.ToDouble(Console.ReadLine());

            lengthOfLine2 = Math.Sqrt((Math.Pow((isX22 - isX11), 2)) + (Math.Pow((isY22 - isY11), 2)));
            Console.WriteLine($"Length of line2 is : {lengthOfLine2}");

            Console.WriteLine("Result Of Equality Check");
            Console.WriteLine(UC_1CalculateTheLength.lengthOfLine1.Equals(lengthOfLine2));
        }
        
    }
}
