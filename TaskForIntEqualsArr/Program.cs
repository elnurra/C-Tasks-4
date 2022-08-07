using System;

namespace TaskForIntEqualsArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 16, 43, 55, 32, 14, 17, 52, 45, 66, 32 };
            Console.WriteLine("Input your number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(SearchingNumber(ref number, ref arr)); 
        }
        static bool SearchingNumber(ref int num ,ref int[] arr)
        {
            
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==num)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
