using System;
namespace FuncChange
{ // Диковицкий В.Б.
    class MyFunction
    {
        public void Table(fun1 F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public delegate double fun1(double a, double x);
        public double MyFunc1(double a, double x)
        {
            return a * x * x;
        }

        public double MyFunc2(double a, double x)

        {
            return a * Math.Sin(x);
             
    }
          
}
}















