using System;

namespace RollADie
{
    class Program
    {
        static void Main(string[] args)
        {
            var roll = new RollingADie();
            roll.Roll(50);
            Console.WriteLine("Here is the sequence: ");
            roll.Read();
            Console.WriteLine();
            var isGreater = new SumIsGreater();
            var twoSixes = new TwoSixes();
            roll.Counter += isGreater.SumIsGreater20;
            roll.Counter += twoSixes.TwoSixesInARow;
            roll.Trigger();
        }
    }
}
