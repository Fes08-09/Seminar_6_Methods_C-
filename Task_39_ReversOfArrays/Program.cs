// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


using System;
using static System.Console;

Clear();
Write("Введите элементы массива через пробел: ");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(",", array)}]");
WriteLine($"[{String.Join(", ", ReverseArray(array))}]");
ReverseArray1(array);
WriteLine($"[{String.Join(",",array)}]");

int[] GetArrayFromString(string arrayStr)
{
    string[] arS=arrayStr.Split(new char[]{' ',',','*'},StringSplitOptions.RemoveEmptyEntries); // вот этот пример!!!
    int[] result=new int[arS.Length];
    for(int i=0; i<arS.Length;i++)
        {
        result[i]=int.Parse(arS[i]);
        }
    return result;
}

// ===метод, который будет разворачивать массив
// ===1. разворачиваем и возвращаем новый массив массив 

int[] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i]=array[array.Length-i-1];
    }
    return result;
}

// === метод который будет разворачивать текущий массив

void ReverseArray1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int k = array[i];
        array[i] = array[array.Length-i-1];
        array[array.Length-i-1] = k;
    }
}