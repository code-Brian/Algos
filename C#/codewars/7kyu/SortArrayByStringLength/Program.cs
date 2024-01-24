using System.Data;
using System.Linq;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Array String Length Meme!");
string[] SortByLength(string[] array)
{
    List<string> SortingList = array.ToList();
    string ShortestStr=SortingList[0];

    for(int i=0; i<SortingList.Count; i++)
    {
        ShortestStr = SortingList[i];
        int ListStart = i;
        for(int j=i; j<SortingList.Count; j++)
        {
            if(SortingList[j].Length < ShortestStr.Length)
            {
                Console.WriteLine("Shorter value found!");
                ShortestStr=SortingList[j];
                SortingList.Insert(ListStart,SortingList[j]);
                SortingList.RemoveAt(j+1);
            }
        }
    }

    string[] SortedArray = SortingList.ToArray();
    for(int i=0; i<SortedArray.Length; i++)
    {
        Console.WriteLine($"SortedArray[{i}]: {SortedArray[i]}");
    }
    return SortedArray;
}

SortByLength(new string[]{"Beg", "Life", "I", "To"});

// string[] test = new string[]{"Hello", "World", "Nice", "To", "Meet", "You"};
// for(int i=0; i<test.Length; i++)
// {
//     Console.WriteLine($"\ni is {i}");
//     for(int j=i; j<test.Length; j++)
//     {
//         Console.WriteLine(test[j]);
//     }
// }