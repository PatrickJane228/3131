using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            byte n = byte.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)

            {//Цикл для заполнения с помощью метода SetValue
                Console.Write($"array [{i}] =");
                array.SetValue(int.Parse(Console.ReadLine()), i);
            }
            //Цикл вывода элементов ОМ( одномерный массив)   
            // for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"{array.GetValue(i)}");
            //}
            //Console.WriteLine();
            //Array.Reverse(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"{array.GetValue(i)}");
            //}
            ////Изменение порядка расположения элементов ОМ в обратном порядке.
            //Console.ReadKey();

            //Обнуление элементов в ОМ
            Console.WriteLine();
            Array.Reverse(array);



        }
    }
}
