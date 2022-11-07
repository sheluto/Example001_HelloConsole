// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = CountNums(num);

int CountNums(int number)
{
    int count = 0;
    while(number>0)
    {
        number=number/10;
        count++;
        Console.Write($"{number} ");
    }
    return count;
}
Console.WriteLine();
Console.WriteLine($"В числе {count} цифр.");
