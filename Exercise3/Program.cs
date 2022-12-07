using System;
using System.Text;

namespace Exercise3
{
    internal class Program
    {
//        Задания*:
//1.Дан одномерный массив положительных вещественных чисел.Преобразовать этот массив следующим образом: сначала обнуляется минимальный элемент,
//затем максимальный из оставшихся, далее минимальный из оставшихся и т.д.до тех пор, пока не останется единственный элемент.
//В конце вывести на экран строку в формате “{ значение}-{индекс},...{значение}-{ индекс}” с данными по всем обнуленным элементам.
//Вывести последний элемент с индексом и значением. Используйте StringBuilder
//2. Написать универсальный метод сложения двух матриц, входные параметры: две матрицы в виде массивов, вернуть результат в виде массива, пример матрицы:
        static int GetMinNumber(ref int[] array)
        {
            int intIndex = 0;
            int intMinNumber = 0;

            for (int intInitialization = 0; intInitialization < array.Length; intInitialization++)
            {
                if (array[intInitialization] > 0)
                {
                    intMinNumber = array[intInitialization];
                    intIndex = intInitialization;
                    break;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] < intMinNumber) & (array[i] > 0))
                {
                    intMinNumber = array[i];
                    intIndex = i;
                }      
            }
            return intIndex;
        }
        static int GetMaxNumber(ref int[] array)
        {
            int intIndex = 0;
            int intMaxNumber = 0;

            for(int intInitialization = 0; intInitialization < array.Length; intInitialization++)
            {
                if (array[intInitialization] > 0)
                {
                    intMaxNumber = array[intInitialization];
                    intIndex = intInitialization;
                    break;
                }
            }

            for(int i = 0; i < array.Length; i++)
            {
                if ((array[i] > intMaxNumber) & (array[i] > 0))
                {
                    intMaxNumber = array[i];
                    intIndex = i;
                }     
            }
            return intIndex;
        }
        static bool oneValueLeft(ref int[] array)
        {
            int intNumberCounter = 0;
            bool result = false;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    intNumberCounter += 1;
            }
            result = intNumberCounter > 1 ? false : true;
            return result;
        }
        static void AddToStringBuilder(int value, int index, ref StringBuilder sb)
        {
            sb = sb.Append(value + "-" + index + ",");
        }
        static void Main(string[] args)
        {
            int[] intArray = new int[10];
            int intValue = 0;
            int intIndex = 0;
            Random rnd = new Random();
            StringBuilder stringResult = new StringBuilder();

            for(int arrayFiller = 0; arrayFiller < intArray.Length; arrayFiller++)
            {
                intArray[arrayFiller] = rnd.Next(1, 1000);
            }

            //“{ значение}-{индекс},...{значение}-{ индекс}” 
            while (oneValueLeft(ref intArray) == false)
            {
                if (oneValueLeft(ref intArray) == false)
                {
                    AddToStringBuilder(intArray[GetMinNumber(ref intArray)], GetMinNumber(ref intArray), ref stringResult);
                    intArray[GetMinNumber(ref intArray)] = 0;
                }

                if (oneValueLeft(ref intArray) == false)
                {
                    AddToStringBuilder(intArray[GetMaxNumber(ref intArray)], GetMaxNumber(ref intArray), ref stringResult);
                    intArray[GetMaxNumber(ref intArray)] = 0;
                }
            }
            stringResult = stringResult.Remove(stringResult.Length -1,1);
            stringResult = stringResult.Append(".");
            Console.WriteLine(stringResult.ToString());

            for(int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > 0)
                {
                    Console.WriteLine("Last number {0} - index {1}. ", intArray[i], i);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
