using System;

namespace RollADie
{
    /// <summary>
    /// Class Sum Is Greater.
    /// </summary>
    class SumIsGreater
    {
        /// <summary>
        /// Count.
        /// </summary>
        int count;
        
        /// <summary>
        /// Parameterless constructor. 
        /// </summary>
        public SumIsGreater()
        {
            count = 0;
        }

        /// <summary>
        /// Couning sum of elements in array from start to end. 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="toss"></param>
        /// <returns></returns>
        private int Sum(int start, int end, int[] tosses)
        {
            int s = 0;
            for (int i = start; i < end; ++i)
            {
                s += tosses[i];
            }
            return s;
        }

        /// <summary>
        /// Counting the number of subsequences which sum is greater or equal to 20.
        /// </summary>
        /// <param name="toss"></param>
        public void SumIsGreater20(int[] tosses)
        {
            int j = 5;
            for (int i = 0; i < tosses.Length && j <= tosses.Length; ++i)
            {
                if (Sum(i, j, tosses) >= 20)
                {
                    count++;
                }
                j++;
            }
            Console.WriteLine("In the consequent 5 tosses the sum of all numbers greater or equal to 20 is: " + count);
        }
    }
}
