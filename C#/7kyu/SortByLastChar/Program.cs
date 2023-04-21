using System.Text.Json;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] Last(string x)
{
    List<string> SortedByLast = new List<string>();
    string TempString="";
    for(int i=0; i<x.Length; i++)
    {
        // put each character of the string into a List
        TempString = TempString + x[i];
        Console.WriteLine(x[i]);
        if(x[i].Equals(" "))
        {
            Console.WriteLine(TempString);
            // Know that you're at the end of a string because of whitespace
            // Do not add this character. 
            // Add TempString to your list and continue iterating.
            SortedByLast.Add(TempString);
            TempString="";
        }
    }
    return SortedByLast.ToArray();
}

Console.WriteLine(JsonSerializer.Serialize(Last("abc cba cab")));
