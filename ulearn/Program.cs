using System;

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
            int min = FirstMin(number);
            int max = FirstMin(number);
            Console.WriteLine($"индекс  первого минимального числа: {min}, индекс последнего максимального числа:{max}");
            //Console.WriteLine("N=");
            //int N = int.Parse(Console.ReadLine());
            //int[] number = new int[N];
            //    FillArray(number);

            //    PrintArray(number);
            //    int ind = MinIndex(number);
            //    Console.WriteLine($"индекс минимального числа: {ind}");

        }
        static void PrintArray(int[] arr)//вывести массив
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+ " ");
            }
            Console.WriteLine();


        }
     
        static int[] FillArray(int size)  //заполнение массива
        {
            int[] number = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(1, 5);

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
            int maxIndex = 0;
            int minIndex = 0;
            for (int i = 0; i < N.Length; i++)
            {

                if (N[i] < N[minIndex])
                {
                    minIndex = i;
                }
                if(N[i] < N[maxIndex])
                {
                    maxIndex = i;
                }
                

            }
            return minIndex;
            return maxIndex;

        }
        //public static int LastMax(int[] N)

        //{
        //    int maxIndex = 0;
        //    for (int i = 0; i < N.Length; i++)
        //    {


        //        if (N[i] >= N[maxIndex])
        //        {
        //            maxIndex = i;
        //        }
        //    }
        //    return maxIndex;
        //}
    }
}