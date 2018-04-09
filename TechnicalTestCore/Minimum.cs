namespace TechnicalTestCore
{
    using System.Collections.Generic;

    internal class Minimum
    {
        public static int MinimumElementIn(List<int> intlist)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int min=9999;
            int currentValue;
            
            for (int i=0;i < intlist.Count;i++)
            {
                currentValue = intlist[i];

                if (currentValue < min)
                    min = currentValue;

            }
            return min;
        }
    }
}
