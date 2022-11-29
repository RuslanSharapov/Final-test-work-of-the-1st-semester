/* 
 Написать программу,которая из имеющегося массива строк формирует:
 массив строк у которых длинна меньше или равна 3 символа.
 Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями,лучше обойтись
 исключительно массивами.

Примеры:    ["hello", "2", "world", ":-)"]    -> ["2", ":-)"]
            ["1234", "1567", "-2", "computer science"]   -> ["-2"]
            ["Russia", "Denmark", "Kazan"]   -> []
*/

// Первый способ выполнения:

string[] notStrongProger = {"Всем", "Привет!", "Я", "Мамкин", "Прогер!", "Pro", "100", "Нуб"};

for (int i = 0; i < notStrongProger.Length; i++)
{
    if (notStrongProger[i].Length <= 3)
    {
        Console.Write($"{notStrongProger[i]} ");
    }  
}

// Второй способ выполнения: количество и сами строки задаются пользователем.

/* void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "0");

string[] firstArray = new string[rows];
for (int i = 0; i < rows; i++)
{
    Console.Write("Введите текст: ");
    string text = Console.ReadLine() ?? "0";
    firstArray[i] = text;
}

string[] secondArray = new string[rows];

for (int j = 0; j < rows; j++)
{
    if (firstArray[j].Length <= 3)
    {
        secondArray[j] = firstArray[j];
    }
}
Console.WriteLine();
Console.WriteLine("Вывод введенного вами массива строк: ");
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine("Вывод массива строк,длинна которых меньше или равна,трем символам: ");
PrintArray(secondArray); */

