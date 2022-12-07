using System;

namespace Exercise2
{
    internal class Program
    {
        //Задание 2
        //А.Создать двумерный массив 3х3.Значения элементов массива инициализировать при объявлении массива.
        //Б.Вывести на экран значения максимального элемента каждого ряда.
        static void Main(string[] args)
        {
            int[,] intArray = new int[,] { {12356,432,5436 }, {12,425,46} };
              
            //[0 Row, 1 Column] 
            for (int intRow = 0; intRow < intArray.GetUpperBound(0) + 1; intRow++)
            {
                int maxNumberOfRow = 0; //специально тут обьявил переменную, что-бы автоматические сбрасывать при новой строке

                for (int intColumn = 0; intColumn < intArray.GetUpperBound(1) + 1; intColumn++)
                {
                    if (maxNumberOfRow < intArray[intRow, intColumn])
                    {
                        maxNumberOfRow = intArray[intRow, intColumn];
                    }
                    if (intColumn == intArray.GetUpperBound(1))
                        Console.WriteLine("Max number of row[{0}] = {1}", intRow, maxNumberOfRow);
                }
            }

            Console.WriteLine("Type any key to finish app");
            Console.ReadKey();
        }
    }
}
