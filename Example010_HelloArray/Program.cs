int[] array = {18,32,36,47,18,62,74,18};

int n = array.Length;   //позволяет получить длину(кол-во элементов) массива
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //оператор прерывания
    }
    //index = index + 1;
    index++;
}