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
            Console.WriteLine($"Whitespace detected at index: {i}");
            SortedByLast.Add(TempString);
            TempString="";
        }
        else if(i == x.Length-1)
        {
            Console.WriteLine("End of list detected");
            TempString = TempString + x[i];
            SortedByLast.Add(TempString);
        }
        else
        {
            TempString = TempString + x[i];
        }
        
    }
    return SortedByLast.ToArray();
}
string[] test = Last("abc cba cab");

Console.WriteLine(test[0]);
Console.WriteLine(test[1]);
Console.WriteLine(test[2]);