Console.Clear();

string[] x = {"hello", "2", "world", ":-)"};


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