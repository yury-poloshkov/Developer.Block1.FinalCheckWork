// Developer.Block1.FinalCheckWork

// Task: Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше, либо равна 3 символа.


string[] InitialazeStringArray()
{
    //string[] stringArray = {"hello", "2", "world", "-)"};
    
    Console.Write("Введите количество элементов массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] stringArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        stringArray[i] = Console.ReadLine();
    }
    Console.WriteLine();

    return stringArray;
}

void PrintStringArray(string[] stringArray)
{
    Console.Write("['" + stringArray[0]);
    for (int i = 1; i < stringArray.Length; i++)
        Console.Write("', '" + stringArray[i]);
    
    Console.WriteLine("']");
}

int CountShortStrings(string[] stringArray, int shortStringLength)
{
    int counter = 0;

    for (int i = 0; i < stringArray.Length; i++)
        if (stringArray[i].Length <= shortStringLength) counter++;

    return counter;
}

string[] FilterShortStrings(string[] stringArray, int shortStringLength, int shortStringCount)
{
    string[] shortStringArray = new string[shortStringCount];
    int counter =0;

    for (int i = 0; i < stringArray.Length; i++)
        if (stringArray[i].Length <= shortStringLength) 
        {
            shortStringArray[counter] = stringArray[i];        
            counter++;
        }
    return shortStringArray;
}

Console.Clear();
string[] testStringArray = InitialazeStringArray();

int shortStringLength = 3; // magic number from task
/* alternatively:
Console.Write("Введите предельную длинну короткой строки: ");
int shortStringLength = Convert.ToInt32(Console.ReadLine());
*/
int countShortStrings = CountShortStrings(testStringArray, shortStringLength);
if (countShortStrings != 0)
{
    string[] shortStringArray = FilterShortStrings(testStringArray, shortStringLength, countShortStrings);
    Console.Write("В массиве: ");
    PrintStringArray(testStringArray);
    Console.Write($"Следующие строки не длиннее {shortStringLength} символов: ");
    PrintStringArray(shortStringArray);
}
else Console.WriteLine($"Введенный массив не содержит элементов длинной менее {shortStringLength} символов.");
        