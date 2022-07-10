// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



using System;
using static System.Console;

Clear();
WriteLine("Введите число: ");
int number10system = int.Parse(ReadLine());
int size =$"{number10system}".Length;
WriteLine(Convert10to2System(number10system));

string Convert10to2System(int number)
{
    string number_bin = "";
    while(number>0)
    {
        if (number % 2 == 0)
        {
            number_bin+="1";
        }
        else
        {
            number_bin+="0";
        }
        number/=2;
    }
    return number_bin;
}
