using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;                     //русский язык
            Console.WriteLine("Дарова!");                                           //текст
            Console.WriteLine("Я расчитываю формулу y=7x2+3x+6. так что гони x");   //текст
            Console.Write("X = ");                                                  //текст
            int x = Convert.ToInt32(Console.ReadLine());                            //ввод
            Console.WriteLine($"y=7*{x}*2+3*{x}+6 = {(7*x)*2+(3*x)+6}");            //текст и расчёт формулы

            Console.WriteLine("\nНажмите любую клавишу для выхода.");               //чтобы приложение не закрывалось
            Console.ReadKey();
        }
    }
}
