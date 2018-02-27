using System;

namespace RollADie
{
    /// <summary>
    /// Class Two Sixes.
    /// </summary>
    class TwoSixes
    {
        /// <summary>
        /// Count.
        /// </summary>
        int count;

        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public TwoSixes()
        {
            count = 0;
        }

        /// <summary>
        /// Counting the number of two sixes in a row in sequence.
        /// </summary>
        /// <param name="toss"></param>
        public void TwoSixesInARow(int[] tosses)
        {
            for (int i = 0; i < tosses.Length - 1; ++i)
            {
                if (tosses[i] == 6 && tosses[i + 1] == 6)
                {
                    count++;
                }
            }
            Console.WriteLine("Two sixes in a row appear in this sequence " + count + " times.");
        }
    }
}
