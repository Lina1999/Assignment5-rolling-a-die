using System;

namespace RollADie
{
    /// <summary>
    /// Class Rolling a die.
    /// </summary>
    public class RollingADie
    {
        /// <summary>
        /// Array of tosses.
        /// </summary>
        public int[] tosses;

        /// <summary>
        /// Declaring a delegate.
        /// </summary>
        /// <param name="tosses"></param>
        public delegate void CounterDelegate(int[] tosses);

        /// <summary>
        /// Instantiating delegate CounterDelegate.
        /// </summary>
        public CounterDelegate Counter;

        /// <summary>
        /// Parameterless constructor.
        /// </summary>
        public RollingADie()
        {
        }

        /// <summary>
        /// Simulation of a rolling die.
        /// </summary>
        /// <param name="amount of tosses"></param>

        public void Roll(int n)
        {
            tosses = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; ++i)
            {
                tosses[i] = random.Next(1, 7);
            }
        }

        /// <summary>
        /// Triggering events. 
        /// </summary>
        public void Trigger()
        {
            Counter(tosses);
        }

        /// <summary>
        /// Reading sequence.
        /// </summary>
        public void Read()
        {
            for (int i = 0; i < tosses.Length; ++i)
            {
                Console.Write(tosses[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
