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
        int max = 0;
        string tempString = "";
        for(int j=0; j<SortedByLast.Count; j++)
        {
            Console.WriteLine($"Current Value of j: {j}");
            Console.WriteLine($"Last Char: {SortedByLast[j].Last<char>()}");
            Console.WriteLine($"Last Char to ascii: {(int)SortedByLast[j].Last<char>()}");
            if(j==0)
            {
                max = (int)SortedByLast[j].Last<char>();
                Console.WriteLine($"Initial Max set to: {max}");
            }
            else if((int)SortedByLast[j].Last<char>() < max)
            {
                max = (int)SortedByLast[j].Last<char>();
                tempString = SortedByLast[0];
                SortedByLast.Insert(0, SortedByLast[j]);
                SortedByLast.RemoveAt(j);
                SortedByLast.Insert(j, tempString);
            }
        }
    }
    return SortedByLast.ToArray();
}
string[] test = Last("abc cba cab");

Console.WriteLine(test[0]);
Console.WriteLine(test[1]);
Console.WriteLine(test[2]);