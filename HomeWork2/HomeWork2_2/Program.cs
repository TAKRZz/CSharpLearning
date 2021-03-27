using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_2
{

    public class Method
    {
        public static int ArrMin(int[] arr, int size)
        {
            if (size == 1)
            {
                return arr[0];
            }
            int num = arr[0];
            for (int i = 0; i < size; i++)
            {
                num = num < arr[i] ? num : arr[i];
            }
            return num;
        }
        public static int ArrMax(int []arr,int size)
        {
            if (size == 1)
            {
                return arr[0];
            }
            int num = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                num = num > arr[i] ? num : arr[i];
            }
            return num;
        }

        public static double ArrMean(int []arr, int size)
        {
            if(size == 1)
            {
                return arr[0];
            }
            double num = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                num += arr[i];
            }
            num /= arr.Length;
            return num;
        }

        public static int ArrSum(int []arr, int size)
        {
            if(size == 1)
            {
                return arr[0];
            }
            int num = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                num += arr[i];
            }
            return num;
        }
    }
    class Program
    {

       
        static void Main(string[] args)
        {
            int []arr = { 2, 321, 43, 7, 4, 8, 567, 63, 856, 32, 546, 
                385, 85, 423, 74, 53, 13, 47, 85, 4273, 524 };
            
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
            Console.WriteLine("Min : " + Method.ArrMin(arr, arr.Length));
            Console.WriteLine("Max : " + Method.ArrMax(arr, arr.Length));
            Console.WriteLine("Mean : " + Method.ArrMean(arr, arr.Length));
            Console.WriteLine("Sum : " + Method.ArrSum(arr, arr.Length));
            Console.ReadLine();


        }




    }

}
