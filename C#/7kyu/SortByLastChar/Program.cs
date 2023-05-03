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

    // Setting the min value to value of the first index in the list
    int Min = (int)SortedByLast[0].Last<char>();
    Console.WriteLine($"Min starting as: {Min}");
    for(int i=0; i<SortedByLast.Count; i++)
    {
        // For tomorrow: 
        // We need to find the actual lowest value first
        // Then we can iterate over the other values in the list to find the next new lowest value
        for(int j=i; j<SortedByLast.Count; j++)
        {
            Console.WriteLine($"j starting at value: {j}");
            // If a new min value is found, we step into this for block.
            if((int)SortedByLast[j].Last<char>() < Min)
            {
                // Min is set to the ascii value of the current index.
                Min = SortedByLast[j].Last<char>();
                Console.WriteLine($"Min set to: {Min}");
                Console.WriteLine($"Inserting {SortedByLast[j]} at index {j}\n");
                // Insert the new min value into the list at the index of the Cursor.
                SortedByLast.Insert(j, SortedByLast[j]);
                // Remove the now extra value from the list at the index of j - 1.
                // Since we are inserting something into the list, the index is being offset by 1.
                // This is why we do j-1 instead of just j. 
                // The index value of j will no longer be removing the correct string if we do not adjust for this.
                Console.WriteLine($"Value of j {j} | Value of j - 1 {j -1 }");
                Console.WriteLine($"String at j {SortedByLast[j]} String at j - 1 {SortedByLast[j]}\n");
                Console.WriteLine($"Removing {SortedByLast[j]}");
                SortedByLast.RemoveAt(j);
                // Here is where we'll likely need to set the new value of mins at the Cursor so that we are assuming
                // The new beginning of the list is the smallest value at the 'new' beginning of the list.
                // We will also need to check that we don't throw the cursor out of bounds if we've reached the end of the list.
            }
            Console.WriteLine($"ASCII value at {j} : {(int)SortedByLast[j].Last<char>()}");
            Console.WriteLine($"SortedByLast[{j}] = {SortedByLast[j]}\n");
        }
    }

    return SortedByLast.ToArray();
}
string[] test = Last("abc cba cab");

Console.WriteLine(test[0]);
Console.WriteLine(test[1]);
Console.WriteLine(test[2]);