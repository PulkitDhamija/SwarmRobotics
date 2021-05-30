using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
                                       // For two concentric circles
    class Vector
    {
        public double x;
        public double y;
        public Vector() { }
        public Vector(double a, double b)
        {
            x = a;
            y = b;
        }
    }
    class circle : Vector
    {
        public double r;

        public circle(double c, double d, double radius)
        {
            x = c;
            y = d;
            r = radius;
        }

    }
    class op
    {
        public static double dot(double q)
        {
            return q * q;
        }
    }
    class check
    {
        public static int cheg(Vector V, circle C)
        {
            if ((Math.Sqrt(op.dot(V.x - C.x) + op.dot(V.y - C.y))) <= C.r)
                return 1;
            else return 0;
        }
    }
    class Translate
    {
        public static circle shift(Vector V, circle C)
        {
            C.x = C.x + V.x;
            C.y = C.y + V.y;
            return C;
        }
    }
    class Rotate
    {
        public static circle rotate(double theta, circle C)
        {
            C.x = C.x * Math.Cos(theta) - C.y * Math.Sin(theta);
            C.y = C.y * Math.Cos(theta) + C.x * Math.Sin(theta);
            return C;
        }
    }
    class Region
    {
        public static void checkRegion(Vector V, circle C1, circle C2)
        {
            int cond1 = check.cheg(V, C1);
            int cond2 = check.cheg(V, C2);
            if (cond1 == 0 && cond2 == 1)
            { Console.WriteLine("True"); }
            else
            { Console.WriteLine("False"); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            circle C1 = new circle(0f, 0f, 3f);
            circle C2 = new circle(0f, 0f, 6f);
            Vector V = new Vector(5f, 0f);
            Vector V1 = new Vector(4f, 0f);
            Region.checkRegion(V, C1, C2);
            C1 = Rotate.rotate(90f, C1);
            C2 = Rotate.rotate(90f, C2);
            Region.checkRegion(V, C1, C2);
            C1 = Translate.shift(V1, C1);
            C2 = Translate.shift(V1, C2);
            Region.checkRegion(V, C1, C2);

            return;
        }
    }
}