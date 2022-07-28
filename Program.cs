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

//Второй вариант

int CountLeightArray(string[] array, int N)
{
    int count = 0;

    foreach (string element in array)
    {
        if (element.Length >= N) count++;
    }
    return count;
}

string[] WriteToArrayVar2(string[] oldArray, int N, int sizeArray)
{
    int i = 0;
    string[] newArray = new string[sizeArray];
    foreach (string element in oldArray)
    {
        if (element.Length <= N)
        {
            newArray[i] = element;
            i++;
        }
    }
    return newArray;
}

string[] array = { "ggg", "hhhh", "124", "3", "6666666" };
Console.WriteLine("Первоначальный массив");
PrintArray(array);
string[] arraySmall = WriteToArray(array, 3);
Console.WriteLine("Первый вариант");
PrintArray(arraySmall);
Console.WriteLine("Второй вариант");
int count = CountLeightArray(array, 3);
string[] resault = WriteToArrayVar2(array, 3, count);
PrintArray(resault);
