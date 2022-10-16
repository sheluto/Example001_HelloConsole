void FillArray(int[] collection)    //метод заполнения массива
{
    int length = collection.Length; //получаем длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10); //Кладем туда числа 
        index++;
    }
}


void PrintArray(int[] col)     //метод печати массива на экран
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int[] array = new int[10];    //создать новый массив в котором будет 10 элементов (по умолчанию будет заполнен нулями, чтобы заполнить другими числами нужно воспользоваться методом выше)

FillArray(array);
PrintArray(array);
