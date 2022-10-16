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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}



int[] array = new int[10];    //создать новый массив в котором будет 10 элементов (по умолчанию будет заполнен нулями, чтобы заполнить другими числами нужно воспользоваться методом выше)

FillArray(array);
array[4]=4;   //искуственно добавили 4 в массив и ниже тоже
array[6]=4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,4);
Console.WriteLine(pos);
