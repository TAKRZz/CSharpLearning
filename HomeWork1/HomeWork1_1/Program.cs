using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("请输入整数表达式： （形如 1231+3213 ");
            string arr = System.Console.ReadLine();
            int sign = 0;//sign 标识操作符 1+ 2- 3* 4/
            int ind = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '+')
                {
                    sign = 1;
                    ind = i;
                    break;
                }
                else if (arr[i] == '-')
                {
                    sign = 2;
                    ind = i;
                    break;

                }
                else if (arr[i] == '*')
                {
                    sign = 3;
                    ind = i;
                    break;

                }
                else if (arr[i] == '/')
                {
                    sign = 4;
                    ind = i;
                    break;
                }
                //else
                //{
                //    System.Console.WriteLine("输入有误！ ");
                //    return;
                //}
            }
            if(sign == 0)
            {
                Console.WriteLine("输入有误！ ");
                Console.ReadLine();
                return;
            }
            int num1 = 0, num2 = 0;
            for(int i = 0; i < ind; i++)
            {
                num1 *= 10;
                num1 += (int)arr[i] - (int)'0';
            }
            for (int i = ind + 1; i < arr.Length; i++)
            {
                num2 *= 10;
                num2 += (int)arr[i] - (int)'0';
            }
            if(sign == 1)
            {
                System.Console.WriteLine(num1 + num2);
            }
            else if(sign == 2){
                System.Console.WriteLine(num1 - num2);
            }
            else if (sign == 3)
            {
                System.Console.WriteLine(num1 * num2);
            }
            else if (sign == 4)
            {
                if(num2 == 0)
                {
                    System.Console.WriteLine("输入有误！ ");
                    Console.ReadLine();
                    return;
                }
                System.Console.WriteLine((double)num1 / (double)num2);
            }

            Console.ReadLine();



        }
    }
}
