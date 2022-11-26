using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Array
{
    class Array<T> where T: IComparable<T>
    {
        public int N { get; set; }
        public T[] InArray { get; set; }
        public T this[int index]
        {
            get
            {
                if (index <= N && index >= 0)
                {
                    return InArray[index];
                }
                else
                {
                    throw new Exception("Обращение к несуществующему элементу массива");
                }
            }
            set
            {
                InArray[index] = value;
            }
        }
        /// <summary>
        /// Инициализирует массив чисел
        /// </summary>
        /// <param name="N"></param>
        public Array(int N)
        {
            this.N = N;
            InArray = new T[N];
        }
        /// <summary>
        /// Отображает массив на экране
        /// </summary>
        public void ShowArray()
        {
            for(int i=0;i<InArray.Length;i++)
            {
                Console.Write(InArray[i] + "\t");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Меняет в массиве два элемента местами
        /// </summary>
        /// <param name="array"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public void Swap(int i, int j)
        {
            T temp = InArray[i];
            InArray[i] = InArray[j];
            InArray[j] = temp;
        }
        /// <summary>
        /// Сравнивает элемент массива на i-ой позиции с элементом на j-ой позиции. Если i-ый больше, возвращает true.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public bool Compare(int i, int j)
        {
            if (InArray[i].CompareTo(InArray[j])>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Сравнивает элемент массива на i-ой позиции с элементом item. Если i-ый больше, возвращает true.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Compare(int i, T item)
        {
            if (InArray[i].CompareTo(item) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
