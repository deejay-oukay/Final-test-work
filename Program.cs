// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

using System;

namespace MyNameSpace
{
    class Final
    {

        static string[] bigArray = {
            "hello", "2", "world", ":-)"
        };
        static string[] smallArray = new string[1];

        static public void Main()
        {
            for (int i = 0; i < bigArray.Length; i++)
                if (bigArray[i].Length <= 3)
                {
                    smallArray[smallArray.Length-1] = bigArray[i];
                    Array.Resize(ref smallArray, smallArray.Length+1);
                }
            if (smallArray.Length > 1)
            {
                Array.Resize(ref smallArray, smallArray.Length-1);
                System.Console.WriteLine("Строки, длина которых меньше либо равна 3 -> ["+String.Join(", ",smallArray)+"]");
            }
            else
                System.Console.WriteLine("Строки, длина которых меньше либо равна 3, не найдены -> []");
        }
    }
}