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

