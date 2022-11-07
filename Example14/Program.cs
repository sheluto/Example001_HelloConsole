// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int comp = GetCompNums(num);

// int GetCompNums(int number)
// {
//     int comp = 1;
//     while(number>1)
//     {
//         comp = comp*number;
//         number--;
//     }
//     return comp;
// }
// Console.WriteLine($"Произведение равно: {comp}");



//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int[]array = new int[8];

int[] NewArray(int[]Ar)
{
for (int i = 0; i < Ar.Length; i++)
{
    Ar[i] = new Random().Next(0,2);
    Console.Write($"{Ar[i]} ");
}
return Ar;
}

NewArray(array);
