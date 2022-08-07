using System;

namespace TaskForMinMaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {38,43,94,65,17,45,34,56,75 };
            ChangeMinMax(ref arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            
        }
        static void ChangeMinMax(ref int[] arr) 
        {
            int i = 0,max=arr[0], min = arr[0],indexofMin=0,indexofMax=0;
          
            
            for ( i = 0; i < arr.Length; i++)
            {
                if (min>arr[i])
                {
                    min = arr[i];
                    indexofMin = i;
                    
                }
                else if(max<arr[i])
                {
                    max = arr[i];
                    indexofMax = i;
                    
                }
            }
            arr[indexofMax] = min;
            arr[indexofMin] = max;

           
            
        }

    }
}
