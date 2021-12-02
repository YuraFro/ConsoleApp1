using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Класс для создания и работы с массивом
    public class MyArray
    {
        //Создаваемый рандомный массив
        private int[] array1;
        //Список со значениями без пары
        private List<int> listNoPar;
        //Список с парными значениями
        private List<int> listPar;

        //Конструктор с входными параметрами для настройки массива
        public MyArray (int n, int min, int max)
        {
            //Создание объекта
            array1 = new int[n];
            Random r = new Random();

            //Заполнение массива ранломными значениями в установленном диапозоне и размером
            for (int i = 0; i < n; i++)
            {
                array1[i] = r.Next(min, max);
            }
        }

        //Возращение массива
        public IEnumerable<int> GetArray ()
        {
            return array1;
        }

        //Выборка не парных элементов массива
        public IEnumerable<int> SelectNoPar ()
        {
            //Создание объектов
            listPar = new List<int> ();
            listNoPar = new List<int> ();

            //Сравнение элемента массива со всеми идущими после него
            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int j = i+1; j <= array1.Length - 1; j++)
                {
                    //Если значение элемента массива совпадает с последующим, то он заносится в отдельный список
                    if (array1[i] == array1[j])
                        listPar.Add(array1[i]);
                }
            }

            //Перебор элементов массива
            foreach (int number1 in array1)
            {
                //Если элемент массива не содержится в списке с парными элементами, то он заносится в отдельный список
                if (!listPar.Contains(number1))
                    listNoPar.Add(number1);
            }

            return listNoPar;

        }
    }
}
