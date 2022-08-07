using System;

namespace TaskForVowelLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your text here: ");
            string text = Console.ReadLine();
            Console.WriteLine(VowelLetter(ref text));
            
        }
        static int VowelLetter(ref string text) 
        {
            char[] vowel = { 'a', 'A', 'o', 'O', 'u', 'U', 'i', 'I', 'e', 'E', 'y', 'Y' };
            int count=0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < vowel.Length; j++)
                {
                    if (text[i]==vowel[j])
                    {
                        count++;
                    }
                }    
            }
            return count;
            // Alternative part searching
            //if (text[i] == 'a' || text[i] == 'A' || text[i] == 'o' || text[i] == 'O' || text[i] == 'u' || text[i] == 'U' || text[i] == 'e' || text[i] == 'E' || text[i] == 'y' || text[i] == 'Y' || text[i] == 'i' || text[i] == 'I')
            //{
            //    count++;
            //}
        }
    }
}

