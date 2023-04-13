using System.Data;
using System.Linq;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Array String Length Meme!");
string[] SortByLength(string[] array)
{
    List<string> SortingList = array.ToList();
    string PreviousStr=SortingList[0];
    string ShortestStr=SortingList[0];

    for(int i=0; i<SortingList.Count; i++)
    {
        for(int j=0; j<SortingList.Count; j++)
        {
            if(SortingList[i].Length < ShortestStr.Length)
            {
                Console.WriteLine("Shorter value found!");
                ShortestStr=SortingList[i];
                SortingList.Insert(0,SortingList[i]);
                SortingList.RemoveAt(i+1);
            }
        }

        PreviousStr=SortingList[i];
    }
    string[] SortedArray = SortingList.ToArray();
    for(int i=0; i<SortedArray.Length; i++)
    {
        Console.WriteLine($"SortedArray[{i}]: {SortedArray[i]}");
    }
    return SortedArray;
}

SortByLength(new string[]{"Beg", "Life", "I", "To"});