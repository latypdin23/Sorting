using Array.Array;
using Sorting.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void SomeSort(ISort<int> sorting, Array<int> array)
        {
            sorting.Sort(array);
        }
        static void ReadArray(Array<int> array)
        {
            Random r = new Random();
            for(int i=0;i<array.N;i++)
            {
                array[i] = r.Next(0,100);
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите размерность массива N=");
            int count = -1;
            if (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.WriteLine("Неверное значение для размерности");
            }
            
            Array<int> array = new Array<int>(count);
            ReadArray(array);
            Console.WriteLine("Первоначальный массив:");
            array.ShowArray();

            Console.WriteLine("Отсортированный массив:");
            SomeSort(new CocktailSort<int>(), array);

            array.ShowArray();
            Console.ReadKey();
        }
    }
}
