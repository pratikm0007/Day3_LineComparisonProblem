using System;

namespace LineComparisonProblem
{
    public class UC_3CompareTwoLines
    {
        public static void CompareTwoLineForGrtEqlLessThan()
        {
            UC_2CheckEquality.CheckEqualityOfTwoLines();

            if (UC_1CalculateTheLength.lengthOfLine1 > UC_2CheckEquality.lengthOfLine2)
            {
                Console.WriteLine($"Length of line1 {UC_1CalculateTheLength.lengthOfLine1} is greater than Length of line2 {UC_2CheckEquality.lengthOfLine2}");
            }
            else if (UC_1CalculateTheLength.lengthOfLine1 == UC_2CheckEquality.lengthOfLine2)
            {
                Console.WriteLine($"Length of line1 {UC_1CalculateTheLength.lengthOfLine1} is equal to Length of line2 {UC_2CheckEquality.lengthOfLine2}");
            }
            else
            {
                Console.WriteLine($"Length of line1 {UC_1CalculateTheLength.lengthOfLine1} is less than Length of line2 {UC_2CheckEquality.lengthOfLine2}");
            }
        }
    }
}
