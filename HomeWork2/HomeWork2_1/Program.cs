using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个正整数 ：");
            string str = Console.ReadLine();
            int num = 0;
            for(int i = 0; i < str.Length; i++)
            {
                num *= 10;
                num += (int)str[i] - '0'; 
            }
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    for (int n = 2; n < i; n++)
                    {
                        if (i % n == 0)
                        {
                            goto Flag1;
                        }
                    }
                    Console.Write(i + " ");
                }
            Flag1:
                continue;
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
