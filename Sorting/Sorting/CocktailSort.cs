using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array.Array;

namespace Sorting.Sorting
{
    /// <summary>
    /// Алгоритм сортировки перемешиванием такой же, что и у пузырьковой сортировки и при этом добавляется цикл пробега по массиву сверху-вниз.
    /// Основное отличие заключается в том, что в классической сортировке пузырьком происходит однонаправленное движение элементов (снизу — вверх), в то время, как сортировке перемешиванием мы сначала проходим снизу-вверху, а затем сверху-вниз.
    /// </summary>
    class CocktailSort<T> : ISort<T> where T : IComparable<T>
    {      
        /// <summary>
        /// Шейкерная сортировка одномерного массива
        /// </summary>
        /// <param name="array"></param>
        public void Sort(Array<T> array)
        {
            int left = 0, right = array.N - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if(array.Compare(i, i+1))
                    {
                        array.Swap(i, i + 1);
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (array.Compare(i-1, i))
                    {
                        array.Swap(i-1, i);
                    }
                }
                left++;
            }
        }
    }
}
