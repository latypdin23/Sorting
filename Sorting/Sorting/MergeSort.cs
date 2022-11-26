using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array.Array;

namespace Sorting.Sorting
{
    /// <summary>
    /// 1. Входной массив разбивается на две части одинакового размера;
    /// 2. Каждый из подмассивов сортируется отдельно, по этому же принципу, тоесть производится повторное разбитие до тех пор, пока длина подмассива не достигнет единицы.В таком случае каждый единичный массив считается отсортированным;
    /// 3. После этого осуществляется слияние всех подмассивов в один, в результате чего получаем отсортированные данные.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MergeSort<T> : ISort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Слияние массив
        /// </summary>
        /// <param name="array"></param>
        /// <param name="lowIndex"></param>
        /// <param name="middleIndex"></param>
        /// <param name="highIndex"></param>
        private void Merge(Array<T> array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            Array<T> tempArray = new Array<T>(highIndex - lowIndex + 1);
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if(!array.Compare(left,right))
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.N; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
        private Array<T> MergeSorting(Array<T> array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSorting(array, lowIndex, middleIndex);
                MergeSorting(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }
        /// <summary>
        /// Сортировка слиянием одномерного массива
        /// </summary>
        /// <param name="array"></param>
        public void Sort(Array<T> array)
        {
            MergeSorting(array, 0, array.N - 1);
        }

    }
}
