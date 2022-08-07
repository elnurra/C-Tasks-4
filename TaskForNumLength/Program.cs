using System;

namespace TaskForNumLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your number:");
            int number;        
            Console.WriteLine(NumLength(out number));
        }
        static int NumLength(out int number) 
        {
            int count=0;
            number = int.Parse(Console.ReadLine());
            if (number==0)
            {
                count++;
            }
            else
            {
                while (number > 0 || number < 0)
                {
                    number /= 10;
                    count++;
                }
                
            }
            return count;
        }
    }
}
