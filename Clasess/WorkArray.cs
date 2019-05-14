using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Fibonachi.Clasess
{
   public class WorkArray
   {

        int[] array = new int[100];
        //Функция выводит числа в случайном порядки(от 0 до 100)
        public int[] RondomArrayList()
        {
            Random rendom = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rendom.Next(0, 1000);
                
            }
            return array;
        }


        //Вычисление среднеарефмитического 





        // Максимальное значение

        public int MaxValueIntegerToListInt(IList list)
        {
            IList<int> listInt = list.Cast<int>().
                Select(r => Convert.ToInt32(r)).ToList();

            return listInt.Max();
        }

        // Максимальное значение
        public int MinValueIntegerToListInt(IList list)
        {
            IList<int> listInt = list.Cast<int>().
                Select(r => Convert.ToInt32(r)).ToList();

            return listInt.Min();
        }


    }
}
