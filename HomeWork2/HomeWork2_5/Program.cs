using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            shape s1 = Factory.Creatshape(1);
            shape s2 = Factory.Creatshape(3);
            shape s3 = Factory.Creatshape(2);
            shape s4 = Factory.Creatshape(1);
            shape s5 = Factory.Creatshape(2);
            shape s6 = Factory.Creatshape(3);
            shape s7 = Factory.Creatshape(1);
            shape s8 = Factory.Creatshape(2);
            shape s9 = Factory.Creatshape(3);
            shape s0 = Factory.Creatshape(1);
            double sum = s1.AreaSize() + s0.AreaSize() +
                s2.AreaSize() + s6.AreaSize() +
                s3.AreaSize() + s7.AreaSize() +
                s4.AreaSize() + s8.AreaSize() +
                s5.AreaSize() + s9.AreaSize();
            Console.WriteLine("总面积为 ：" + sum);
            Console.ReadLine();


        }
    }
}
interface shape
{
    double AreaSize();
    bool Islegal();
}

class triangle : shape
{
    double x1, x2, x3;


    public triangle(double x1 = 1, double x2 = 1, double x3 = 1)
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
        if ((x1 + x2) > x3 && (x1 + x3) > x2 && (x2 + x3) > x1)
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

    public rectangle(double x1 = 1, double x2 = 1)
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

    public squre(double x1 = 1)
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

class Factory
{
    public static shape Creatshape(int condition)
    {
        shape s = null;
        if(condition == 1)
        {
            s = new triangle(); 
        }
        else if(condition == 2)
        {
            s = new rectangle();
        }
        else if(condition == 3)
        {
            s = new squre();
        }

        return s;
    }


}
