//Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
using System;

int[] InputArrayElements()
{
    Console.WriteLine("Введи элементы массива через пробел");
    string elements = Console.ReadLine()!;
    string[] elementsSplited = elements.Split(' ');
    int[] array = new int[elementsSplited.Length];

    for (int i = 0; i < elementsSplited.Length; i++)
    {
        array[i] = int.Parse(elementsSplited[i]);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Ваш массив : ");
    foreach (int n in array)
    {
        Console.Write($"{n} ");
    }
}

PrintArray(InputArrayElements());