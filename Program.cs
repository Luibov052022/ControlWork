// Программа из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам

// Первый вариант

string[] WriteToArray(string[] array, int N)
{

    string[] arraySmall = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= N) arraySmall[i] = array[i];
    }
    return arraySmall;
}

void PrintArray(string[] array)
{
    foreach (string element in array)
    {
        if (element != null)
            Console.Write(element + " ");
    }
    Console.WriteLine("");
}

string[] array = { "ggg", "hhhh", "124", "3", "6666666" };
Console.WriteLine("Первоначальный массив");
PrintArray(array);
string[] arraySmall = WriteToArray(array, 3);
Console.WriteLine("Первый вариант");
PrintArray(arraySmall);
