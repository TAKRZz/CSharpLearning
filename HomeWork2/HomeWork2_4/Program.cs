using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HomeWork2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangle r1 = new rectangle(4, 5);
            Console.WriteLine("长方形是否存在： " + r1.Islegal());
            Console.WriteLine("长方形的面积： " + r1.AreaSize());

            triangle t1 = new triangle(3, 5, 4);
            Console.WriteLine("三角形是否存在： " + t1.Islegal());
            Console.WriteLine("三角形的面积： " + t1.AreaSize());

            squre s1 = new squre(9);
            Console.WriteLine("正方形是否存在： " + s1.Islegal());
            Console.WriteLine("正方形的面积： " + s1.AreaSize());


            Console.ReadLine();
        }
    }
}
//编写面向对象程序实现长方形、正方形、三角形等形状的类。
//每个形状类都能计算面积、判断形状是否合法。请尝试合理使用接口/抽象类、属性来实现。
interface shape
{
    double AreaSize();
    bool Islegal();
}

class triangle : shape
{
    double x1, x2, x3;

    public triangle(double x1, double x2, double x3)
    {
        this.x1 = x1;
        this.x2 = x2;
        this.x3 = x3;
    }

    public double AreaSize()
    {
        if (this.Islegal())
        {
            double p = (x1 + x2 + x3) / 2;
            double S = System.Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3));
            return S;
        }
        return -1;
        throw new NotImplementedException();
    }

    public bool Islegal()
    {
        if((x1 + x2) > x3 && (x1 + x3) > x2 && (x2 + x3) > x1)
        {
            if (x1 > 0 && x2 > 0 && x3 > 0)
            {
                return true;
            }
        }
        return false;
        throw new NotImplementedException();
    }
}

class rectangle : shape
{
    double x1, x2;

    public rectangle(double x1, double x2)
    {
        this.x1 = x1;
        this.x2 = x2;
    }

    public double AreaSize()
    {
        if (this.Islegal())
        {
            return x1 * x2;
        }
        return -1;
        throw new NotImplementedException();
    }

    public bool Islegal()
    {
        if (x1 > 0 && x2 > 0)
        {
            return true;
        }
        return false;
        throw new NotImplementedException();
    }

}

class squre : shape
{
    double x1;

    public squre(double x1)
    {
        this.x1 = x1;
    }

    public double AreaSize()
    {
        if (this.Islegal())
        {
            return x1 * x1;
        }
        return -1;
        throw new NotImplementedException();
    }

    public bool Islegal()
    {
        if (x1 > 0)
        {
            return true;
        }
        return false;
        throw new NotImplementedException();
    }
}
