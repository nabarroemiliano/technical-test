using System;


namespace TechnicalTestCore
{
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int sum=0;
            for(int i = 1; i < maxNrAsInt + 1; i++)
            {
                sum = sum + i;

            }
            return sum;
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass

            long maxNrAsInt = Int32.Parse(maxNrAsString);

            long result = maxNrAsInt * (maxNrAsInt + 1) / 2;

            return result.ToString();

        }
    }
}
