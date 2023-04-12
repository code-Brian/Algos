// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Array String Length Meme!");

string[] SortByLength(string[] array)
{
    List<string> SortingList = new List<string>();
    for(int i=0; i<array.Length; i++)
    {
        SortingList.Add(array[i]);
    }

    foreach(string str in SortingList)
    {
        Console.WriteLine($"{str} | Length: {str.Length}");
    }
    // for(int i = 0; i<array.Length; i++)
    // {
    //     Console.WriteLine($"Length of array[{i}]: {array[i].Length}");
    // }
    return array;
}

SortByLength(new string[]{"hello", "but", "big butt", "at", "I"});