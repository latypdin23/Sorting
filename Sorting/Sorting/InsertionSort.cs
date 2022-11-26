using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array.Array;

namespace Sorting.Sorting
{
    /// <summary>
    /// Внешний цикл начинает работу со второго элемента массива. 
    /// Запоминаем значение второго элемента массива. Во внутреннем цикле сравниваем каждый предыдущий элемент массива с текущим и, при необходимости, меняем их местами до тех пор, пока не дойдем до начала цикла или пока не встретится элемент менее текущего. 
    /// В результате массив отсортируется по возрастанию.
    /// </summary>
    class InsertionSort<T>: ISort<T> where T:IComparable<T>
    {
        /// <summary>
        /// Сортировка вставками одномерного массива
        /// </summary>
        /// <param name="array"></param>
        public void Sort(Array<T> array)
        {
            T x; 
            int j;
            for (int i = 1; i < array.N; i++)
            {
                x = array[i];
                j = i;
                while (j > 0 && array.Compare(j-1,x))
                {
                    array.Swap(j, j - 1);
                    j -= 1;
                }
                array[j] = x;
            }
        }
    }
}
