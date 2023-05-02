using System.Text.Json;
//r See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] Last(string x)
{
    List<string> SortedByLast = new List<string>();
    string TempString="";
    for(int i=0; i<x.Length; i++)
    {
        if(x[i] == char.Parse(" "))
        {
            // Console.WriteLine($"Whitespace detected at index: {i}");
            SortedByLast.Add(TempString);
            TempString="";
        }
        else if(i == x.Length-1)
        {
            // Console.WriteLine("End of list detected");
            TempString = TempString + x[i];
            SortedByLast.Add(TempString);
        }
        else
        {
            TempString = TempString + x[i];
        }
    }

    int Min = (int)SortedByLast[0].Last<char>();
    Console.WriteLine($"Min starting as: {Min}");
    for(int i=0; i<SortedByLast.Count; i++)
    {
        int Cursor = i;
        for(int j=i; j<SortedByLast.Count; j++)
        {
            if((int)SortedByLast[j].Last<char>() < Min)
            {
                Min = SortedByLast[j].Last<char>();
                Console.WriteLine($"Min set to: {Min}");
                SortedByLast.Insert(Cursor, SortedByLast[j]);
                SortedByLast.RemoveAt(j+1);
            }
            Console.WriteLine($"ASCII value at {j} : {(int)SortedByLast[j].Last<char>()}");
            Console.WriteLine($"SortedByLast[{j}] = {SortedByLast[j]}");
        }
    }

    return SortedByLast.ToArray();
}
string[] test = Last("abc cba cab");

Console.WriteLine(test[0]);
Console.WriteLine(test[1]);
Console.WriteLine(test[2]);