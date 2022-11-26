using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array.Array;


namespace Sorting.Sorting
{
    /// <summary>
    /// Алгоритм сортировки Шелла базируется на двух идеях:
    ///     1. Сортировка вставками показывает лучшие результаты на практически упорядоченных массивах данных;
    ///     2. Сортировка вставками неэффективна для смешанных данных, потому что за одну итерацию элементы смещаются только на одну позицию.
    /// Для устранения недостатков алгоритма Insertion Sort, в сортировке Шелла осуществляется несколько сортировок вставками. 
    /// При этом в каждой итерации сравниваются элементы, которые размещены на разных расстояниях один от другого, начиная с наиболее отдаленных (d = 1⁄2 длины массива) до сравнения соседних элементов(d = 1).
    /// </summary>
    class ShellSort<T> : ISort<T> where T : IComparable<T>
    {      
        /// <summary>
        /// Сортировка Шелла одномерного массива
        /// </summary>
        /// <param name="array"></param>
        public void Sort(Array<T> array)
        {
            //расстояние между элементами, которые сравниваются
            int d = array.N / 2;
            while (d >= 1)
            {
                for (int i = d; i < array.N; i++)
                {
                    var j = i;
                    while ((j >= d) && array.Compare(j-d,j))
                    {
                        array.Swap(j, j - d);
                        j = j - d;
                    }
                }

                d = d / 2;
            }
        }       
    }
}
