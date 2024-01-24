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

    for(int i=0; i<SortedByLast.Count; i++)
    {
        // Assume the first value of each iteration is the smallest to start
        int Min = (int)SortedByLast[i].Last<char>();
        Console.WriteLine($"Min starting as: {Min}");
        for(int j=i; j<SortedByLast.Count; j++)
        {
            // If a new Min ascii value is found, step into the sorting logic
            if(SortedByLast[j].Last<char>() < Min)
            {
                // Set Min to the newly found ascii value
                Min = SortedByLast[j].Last<char>();
                // Insert it at the beginning of the iteration
                SortedByLast.Insert(i,SortedByLast[j]);
                // Once inserted, remove it at an index of +1, since in the previous line, we've added on more value
                // This means that our index reference is incorrect, so we have to adjust by adding 1.
                SortedByLast.RemoveAt(j+1);
                Console.WriteLine($"New min found! Setting Min to: {Min}");
            }
        }
    }
    return SortedByLast.ToArray();
}
string[] test = Last("abc cba cab");

Console.WriteLine("\nEND RESULT ********************************************************************");
Console.WriteLine(test[0]);
Console.WriteLine(test[1]);
Console.WriteLine(test[2]);