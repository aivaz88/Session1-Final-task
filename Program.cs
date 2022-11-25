Console.Clear();

string[] x = {"hello", "2", "world", ":-)"};
Console.Write("Исходный массив: ");
PrintArray(x);
Console.Write("Преобразованный массив: ");
PrintArray(NewArray(x, SizeNewArray(x)));

int SizeNewArray(string[] firsArray)
{
    int size = 0;
    for (int i = 0; i < firsArray.GetLength(0); i++)
    {
        if (firsArray[i].Length <= 3) size++;
    }
    return size;
}

string[] NewArray(string[] firsArray, int size)
{
    string[] newArray = new string[size];
    int count = 0;
    for (int i = 0; i < firsArray.GetLength(0); i++)
    {
        if (firsArray[i].Length <= 3)
        {
            newArray[count] = firsArray[i];
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}