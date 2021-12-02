using System;
using System.Collections.Generic;
using System.Timers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Добавил таймер для вывода каждые 4 секнды новых массивов

            Timer MyTimer = new Timer();
            MyTimer.Interval = 4000;
            MyTimer.Elapsed += MyTimer_Elapsed;
            MyTimer.Start();

            Console.ReadLine();

            MyTimer.Stop();

            Console.WriteLine();

        }


        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
            => WorkArray();


        //Метод, в котором будет осуществляться создание массива и поиск непарных элементов
        public static void WorkArray()
        {
            //Создание объекта класса и установление параметров для массива
            MyArray array = new MyArray(10, 0, 10);

            //Вывод элементов созданного изначально массива
            Console.WriteLine(OutMass(array.GetArray()));
            //Вывод не парных элементов массива
            Console.WriteLine(OutMass(array.SelectNoPar()));


            Console.ReadLine();
        }

        //Метод для вывода элементов массива в строку
        public static string OutMass(IEnumerable<int> array)
        {
            string stringarray = "";
            foreach (int x in array)
                stringarray = stringarray + x + " ";
            return stringarray;
        }
    }


}
