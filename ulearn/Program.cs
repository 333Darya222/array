using System;
using System.Security.Cryptography;

namespace ulearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N=");
            int N = int.Parse(Console.ReadLine());
            int[] number = new int[N];
            FillArray(number);
            PrintArray(number);

            int[] degreeOfTwo= DegreeOfTwo(number);
            foreach(var degreeOftwo in degreeOfTwo)
            {
                if(degreeOftwo != 0)
                {
                    Console.WriteLine($"степени двойки:{degreeOftwo}");
                }
            }

            int[] PositiveOdd = PositiveOddNumbers(number);
            foreach (var PositiveOddNumbers in PositiveOdd)
            {
                if (PositiveOddNumbers != 0) 
                {
                    Console.WriteLine($"положительные нечетные числа из массива:{PositiveOddNumbers}");
                   
                }
            }
            

            int min = FirstMin(number);
            int max = LastMax(number);
            Console.WriteLine($"индекс  первого минимального числа: {min}, индекс последнего максимального числа:{max}");

            int ind = MinIndex(number);
            Console.WriteLine($"индекс минимального числа: {ind}");

        }

        static void PrintArray(int[] arr)//вывести массив
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+ " ");
            }
            Console.WriteLine();


        }
     
        static int[] FillArray(int[] number)  //заполнение массива
        {
          
            Random rnd = new Random();

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(-100, 100);

            }
            return number;
        }


        static int MinIndex(int[] array)
        {
            int min = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {

                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }

            return index;

        }
        static int MinElement(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }

            return min;
        }

        public static int FirstMin(int[] N)
        {
            
            int minIndex = 0;
            for (int i = 0; i < N.Length; i++)
            {

                if (N[i] < N[minIndex])
                {
                    minIndex = i;
                }
            
                

            }
            return minIndex;
           

        }
        public static int LastMax(int[] N)

        {
            int maxIndex = 0;
            for (int i = 0; i < N.Length; i++)
            {


                if (N[i] >= N[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static int[] PositiveOddNumbers(int[]N)
        {
            int[] positiveOddNumbers = new int[N.Length];
            
            for(int i=0; i<N.Length; i++)
            {
                
                if (N[i] > 0 && (N[i] %2!=0) )
                {
                    
                    positiveOddNumbers[i] = N[i];


                }
                
            }
           
                return positiveOddNumbers;
        }
        public static int[] DegreeOfTwo(int[] N)
        {
            int[] array = new int[N.Length];

            for (int i = 0; i < N.Length; i++)
            {
                array[i] = (int)Math.Pow(2, i+1);

            }

            return array;
        }
    }
}