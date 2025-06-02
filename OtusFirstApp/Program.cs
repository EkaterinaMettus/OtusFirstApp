using ClassLibrary;
using House;
using Application;
//using System;

namespace House
{
    class Window
    {
        int width;
        int length;
    }
}

namespace Application
{
    class Window
    {
        int top;
        int left;
    }
}


namespace OtusFirstApp
{
    /// <summary>
    /// Основной класс нашей программы
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Массив строк</param>
        static void Main(string[] args)
        {
            House.Window window = new House.Window();

            Class1.MethodFromLibrary();

            Method1();
            Method2();

            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Число</returns>
        static int Method1()
        {
            int x = 10;
            Console.WriteLine(x);

            x = 30;
            Console.WriteLine(x);

            return 0;
        }

        static void Method2()
        {
            int y = 20;
            Console.WriteLine(y);

            y = 50;
            Console.WriteLine(y);
        }
    }
}
