using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array.Array;

namespace Sorting.Sorting
{
    /// <summary>
    ///     1. Необходимо выбрать опорный элемент массива, им может быть любой элемент, от этого не зависит правильность работы алгоритма;
    ///     2. Разделить массив на три части, в первую должны войти элементы меньше опорного, во вторую - равные опорному и в третью - все элементы больше опорного;
    ///     3. Рекурсивно выполняются предыдущие шаги, для подмассивов с меньшими и большими значениями, до тех пор, пока в них содержится больше одного элемента.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class QuickSort<T> : ISort<T> where T : IComparable<T>
    {
        /// <summary>
        /// метод возвращающий индекс опорного элемента
        /// </summary>
        /// <param name="array"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <returns></returns>
        private int Partition(Array<T> array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if(array.Compare(maxIndex,i))
                {
                    pivot++;
                    array.Swap(pivot, i);
                }
            }

            pivot++;
            array.Swap(pivot, maxIndex);
            return pivot;
        }

        //быстрая сортировка
        private Array<T> QuickSorting(Array<T> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSorting(array, minIndex, pivotIndex - 1);
            QuickSorting(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public void Sort(Array<T> array)
        {
            QuickSorting(array, 0, array.N - 1);
        }
    }
}
