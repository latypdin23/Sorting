using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array;
using Array.Array;

namespace Sorting.Sorting
{
    /// <summary>
    /// 1. Каждый элемент массива сравнивается с последующим и если элемент[i] > элемент[i+1] происходит замена.
    /// 2. Шаг 1 повторяется n-1 раз, где n — количество элементов в массиве.
    /// </summary>
    class BubbleSort<T>: ISort<T> where T:IComparable<T>
    {
        /// <summary>
        /// Сортировка пузырьком одномерного массива с вещественными числами
        /// </summary>
        /// <param name="array"></param>
        public void Sort(Array<T> array)
        {
            for (int i = 0; i < array.N; i++)
            {
                for (int j = i+1; j < array.N; j++)
                {
                    if(array.Compare(i,j))
                    {
                        array.Swap(i, j);
                    }
                }
            }           
        }
    }
}
