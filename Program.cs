using System;

namespace Compare_to_and_Equals_to
{
    class Program
    {
        static void Main(string[] args)
        {
            int  val1, val2;
            Console.WriteLine("Enter the First number");
            val1 = int.Parse(Console.ReadLine());


                Console.WriteLine("Enter the second number");
            val2 = int.Parse(Console.ReadLine()); ;
            
            Console.WriteLine("Return value (comparison) = " + val1.CompareTo(val2));
            Console.WriteLine("Return value (Equals) = " + val1.Equals(val2));

        }
    }
}
