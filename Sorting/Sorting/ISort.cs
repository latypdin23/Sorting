using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array.Array;

namespace Sorting.Sorting
{
    interface ISort<T> where T : IComparable<T>
    {

        /// <summary>
        /// Сортировка одномерного массива
        /// </summary>
        /// <param name="array"></param>
        void Sort(Array<T> array);

    }
}
