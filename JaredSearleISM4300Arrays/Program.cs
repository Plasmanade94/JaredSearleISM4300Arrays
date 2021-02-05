using System;

namespace JaredSearleISM4300Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25};
            foreach (int val in numbers)
            {
                Console.WriteLine("Element value =" + val.ToString());
            }
            Console.ReadKey(true);

        }






        
    }
}

