using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array.Array;

namespace Sorting.Sorting
{
    /// <summary>
    /// Этот алгоритм является одним из самых простейших алгоритмов сортировки массива. Его смысл заключается в том, чтобы, чтобы идти по массиву, например слева направо, каждый раз искать минимальный элемент массива и обменивать его с первым элементом неотсортированной части массива. Шаги алгоритма можно представить следующим образом:
    ///     1. Находим минимальный элемент в массиве.
    ///     2. Меняем местами минимальный и первый элемент местами.
    ///     3. Ищем минимальный элемент в неотсортированной части массива, т.е., начиная уже со второго элемента массива.
    ///     4. Меняем местами второй элемент массива и найденный минимальный.
    ///     5. Ищем минимальный элемент в массиве, начиная с третьего, меняем местами третий и минимальный элементы.
    ///     6. Продолжаем алгоритм до тех пор пока не дойдем то конца массива.
    /// </summary>
    class SelectionSort<T> : ISort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Сортировка выбором одномерного массива
        /// </summary>
        /// <param name="array"></param>
        public void Sort(Array<T> array)
        {
            int indx; 
            for (int i = 0; i < array.N; i++) 
            {
                indx = i; 
                for (int j = i; j < array.N; j++) 
                {
                    if(array.Compare(indx,j))
                    {
                        indx = j; 
                    }
                }
                if (array[indx].Equals(array[i]))
                {
                    continue;
                }
                array.Swap(i, indx);
            }
        }
    }
}
