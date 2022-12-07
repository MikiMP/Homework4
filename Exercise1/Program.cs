using System;
using System.Collections;

namespace Exercise1
{
    internal class Program
    {
        //Задание 1
        //А.Объявить и проинициализировать массив int[] на 6 элементов.
        //Б.Ввести значения элементов массива из консоли.
        //В.Вывести введенные отсортированные по убыванию элементы массива на экран.
        static void decreasingSort(ref int[] array)
        {
            int sortTemp = 0;

            for (int sortI = 0; sortI < array.Length; sortI++)
            {
                for (int sortJ = 0; sortJ < array.Length - 1; sortJ++)
                {
                    if (array[sortJ] < array[sortJ + 1])
                    {
                        sortTemp = array[sortJ];
                        array[sortJ] = array[sortJ + 1];
                        array[sortJ + 1] = sortTemp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] intArray = new int[6];                                                    
            bool result = false;

            for(int arrayCounter = 0; arrayCounter < intArray.Length; arrayCounter ++)
            {
                Console.WriteLine("Type some integer number, array[{0}]: ", arrayCounter);
                result = int.TryParse(Console.ReadLine(), out intArray[arrayCounter]);      

                 if (!result)
                 {
                     Console.WriteLine("Typed not integer, try again!");
                     arrayCounter--;
                 }
            }

            decreasingSort(ref intArray);
            foreach (int Number in intArray)
                Console.Write(Number + " ");

            //Я хорошо помню, что в прошлый \nSomeText было как замечание. Но я не вижу инного выхода в этой ситуции,
            //так-как в 49 у нас Write, a 54 WriteLine без \n склеит в одну строку текс. Мне это не подходит.
            //Можно конечно добавить Console.WriteLine(); Лично для меня это хуже выглядит.
            Console.WriteLine("\nType any key to finish app");
            Console.ReadKey();
        }
    }
}
