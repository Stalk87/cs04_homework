//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int GetResult(int number)
{
    int result = 0;
    int num = number;
    while (num > 0)
    {
        result = result + (num % 10);
        num = num / 10;
    }
    return result;
}

Console.WriteLine($"Сумма всех чисел числа {number} = {GetResult(number)}");