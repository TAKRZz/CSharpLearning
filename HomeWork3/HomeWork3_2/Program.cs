using System;
using System.Windows;

namespace HomeWork3_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int x1, x2, x3, y1, y2;
            System.Console.Write("输入当前的小时数: ");
            string a = Console.ReadLine();
            x1 = int.Parse(a);
            System.Console.Write("输入当前的分钟数: ");
            a = Console.ReadLine();
            x2 = int.Parse(a);
            System.Console.Write("输入当前的秒数: ");
            a = Console.ReadLine();
            x3 = int.Parse(a);
            System.Console.Write("输入闹钟的小时数: ");
            a = Console.ReadLine();
            y1 = int.Parse(a);
            System.Console.Write("输入闹钟的分钟数: ");
            a = Console.ReadLine();
            y2 = int.Parse(a);
            System.Console.Clear();
            Clock c1 = new Clock(x1, x2, x3, y1, y2);
            c1.ClockRun();
            System.Console.Read();
        }
    }

    public class Clock
    {
        int hour, minute, second;
        int al_hour, al_minute;

        public Clock(int hour, int minute, int second, int al_hour, int al_minute)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.al_hour = al_hour;
            this.al_minute = al_minute;
        }
        public void Alarm()
        {
            if (hour == al_hour && minute == al_minute && second == 0) 
            {
                MessageBox.Show("Alarm!");
                //while (true)
                //{
                //    System.Console.Write("");
                //}
            }
        }
        public void ClockRun()
        {
            while (true)
            {
                System.Console.WriteLine("Time : " + hour + " : " + minute + " : " + second);
                System.Threading.Thread.Sleep(1000); //休眠一秒
                if (second < 59)
                {
                    second += 1;
                }
                else
                {
                    second = 0;
                    if (minute < 59)
                    {
                        minute++;
                    }
                    else
                    {
                        minute = 0;
                        if (hour < 23)
                        {
                            hour++;
                        }
                        else
                        {
                            hour = 0;
                        }
                    }
                }
                Alarm();
                System.Console.Clear();
            }
        }

    }
}
