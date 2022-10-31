// Вид 1 (Ничего не возвращают и ничего не принимают)
//void Method1() //нет никаких аргументов
//{
    //Console.WriteLine("Автор...") //например, указывать авторство в конце каждой программы
//}
//Method1(); //вызываем метод (идентификатор метода и круглые скобки)


//Вид 2 - ничего не возвращают, но могут принимать какие-то аргументы
//void Method2(string msg)
//{
    //Console.WriteLine(msg);
//}
//Method2("Текст сообщения");

//void Method21(string msg, int count)
//{
    //int i = 0;
    //while (i < count)
    //{
        //Console.WriteLine(msg);
        //i++;
    //}
//}
//Method21(msg: "Текст", count: 4);

//Вид 3 - что-то возвращают, но ничего не принимают

//int Method3()     //int - указываем тип данных который мы ожидаем
//{
    //return DateTime.Now.Year;     //обязательно используем оператор return
//}
//int year = Method3();  // кладем результат метода в переменную через оператор присваивания
//Console.WriteLine(year);   //выводим результат на экран

//Вид 4  - что-то принимают и что-то возвращают
// string Method4(int count, string Text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + Text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "asdf"); //10 раз выведет нашу строку
// Console.WriteLine(res);

//Цикл for:
// string Method4(int count, string Text)
//  {
//      string result = String.Empty;
//      for (int i = 0; i < count; i++)
//      {
//          result = result + Text;
//      }
//      return result;
//  }

//  string res = Method4(10, "asdf"); 
//  Console.WriteLine(res);

 //Цикл в цикле (вывод таблицы умножения на экран)

//  for (int i = 2; i <= 10; i++)
//  {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j}={i*j}");    //интерполяция строк

//     }
//         Console.WriteLine();  //для того чтобы сделать промежуток перед умножением на новое число
//  }

//Задача1 Дан текст - все пробелы заменить черточками, маленькие буквы к заменить большими К а большие С заменить маленькими с

// string text = "Мой первый друг, мой друг бесценный!"
//             + "И я судьбу благословил,"
//             + "Когда мой двор уединенный,"
//             + "Печальным снегом занесенный,"
//             + "Твой колокольчик огласил.";

// //string s = "qwerty"
// //            012345    Если требуется обратиться к конкретному символу строки
// //s[3]  r   Чтобы обратиться к конкретному символу строки вводим идентификатор строки s и номер символа в квадратных скобках

// //4й метод (принимает строку, возвращает строку)

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;     //инициализация пустой строки

//     int length = text.Length;   //получить длину нашей строки
//     for (int i = 0; i<length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text,' ','|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText,'к','К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText,'С','с');
// Console.WriteLine(newText);
// Console.WriteLine();

//сортировка массива методом выбора

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)   //выводим данный массив на экран
{
    int count = array.Length;   //получаем кол-во элементов

    for (int i = 0; i<count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();

}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;


    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
