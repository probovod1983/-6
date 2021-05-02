using System;
using System.Collections.Generic;
using System.IO;
namespace FuncChange
{ // Диковицкий В.Б.
  //Изменить программу вывода таблицы функции так, чтобы можно было передавать 
  //функции типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

    class Program {
       
        public static void Main()
        {
            MyFunction function = new MyFunction();
                     
            Console.WriteLine("Таблица функции MyFunc1:");
            function.Table(new MyFunction.fun1(function.MyFunc1), -2, 2);
            Console.WriteLine("Таблица функции MyFunc2:");
            function.Table(new MyFunction.fun1(function.MyFunc2), -2, 2);
            Console.ReadLine();
        }
        
       
    }
}















