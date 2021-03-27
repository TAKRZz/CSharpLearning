using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //用“埃氏筛法”求2~100以内的素数。2~100以内的数，
            //    先去掉2的倍数，再去掉3的倍数，再去掉4的倍数，
            //    以此类推...最后剩下的就是素数。
            int[] arr = new int[101];
            for(int i = 0; i < 101; i++)
            {
                arr[i] = i;
            }
            //将去掉的数置为 0
            arr[1] = 0;
            for(int i = 2; i <= 100; i++)
            {
                for (int n = i + 1; n <= 100; n++) 
                {
                    if(arr[n] % i == 0)
                    {
                        arr[n] = 0;
                    }
                }
            }
            //输出
            for(int i =0;i<101;i++)
            {
                if(arr[i] != 0)
                {
                    Console.Write(arr[i] +"  ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
